FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000


FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS builder
ARG Configuration=Release
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY RooMate.Core/RooMate.Core.csproj  ./RooMate.Core/
COPY RooMate.Infrastructure/RooMate.Infrastructure.csproj ./RooMate.Infrastructure/
COPY RooMate.Core.Tests/RooMate.Core.Tests.csproj ./RooMate.Core.Tests/
COPY RooMate.WebApi/RooMate.WebApi.csproj ./RooMate.WebApi/

RUN dotnet restore
COPY . .
RUN dotnet test RooMate.Core.Tests/RooMate.Core.Tests.csproj
RUN dotnet build RooMate.WebApi/RooMate.WebApi.csproj  -c $Configuration -o /app

FROM builder AS publish
ARG Configuration=Release
RUN dotnet publish -c $Configuration -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
CMD ["dotnet","RooMate.WebApi.dll"]