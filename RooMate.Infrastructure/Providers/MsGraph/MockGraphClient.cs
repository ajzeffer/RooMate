using System;
using System.Collections.Generic;
using RooMate.Core.Contracts.Graph;
using RooMate.Infrastructure.Providers.MsGraph.Models;

namespace RooMate.Infrastructure.Providers.MsGraph
{
    public class MockGraphClient : IGraphClient
    {
        public IGraphRoomSchedules GetRoomSchedules()
        {
            return new GraphRoomSchedules
            {
                value = new List<IGraphSchedule>
                {
                    new GraphSchedule
                    {
                        scheduleId = "Room-Pi3.14159265@drivetime.com",
                        scheduleItems = new List<IGraphScheduleItem>
                        {
                            new GraphScheduleItem
                            {
                                start = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(1).ToString("G")
                                },
                                end = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(2).ToString("G")
                                }
                            },  new GraphScheduleItem
                            {
                            start = new GraphScheduleTime
                            {
                            datetime = DateTime.Now.AddHours(4).ToString("G")
                        },
                        end = new GraphScheduleTime
                        {
                            datetime = DateTime.Now.AddHours(5).ToString("G")
                        }
                    }
                        }
                    },
                    new GraphSchedule
                    {
                        scheduleId = "Room-Chaos@drivetime.com",
                        scheduleItems = new List<IGraphScheduleItem>
                        {
                            new GraphScheduleItem
                            {
                                start = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(1).ToString("G")
                                },
                                end = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(2).ToString("G")
                                }
                            },  new GraphScheduleItem
                            {
                                start = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(4).ToString("G")
                                },
                                end = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(5).ToString("G")
                                }
                            }
                        }
                    },
                    new GraphSchedule
                    {
                        scheduleId = "Room-Revolution@drivetime.com",
                        scheduleItems = new List<IGraphScheduleItem>
                        {
                            new GraphScheduleItem
                            {
                                start = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(1).ToString("G")
                                },
                                end = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(2).ToString("G")
                                }
                            },  new GraphScheduleItem
                            {
                                start = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(4).ToString("G")
                                },
                                end = new GraphScheduleTime
                                {
                                    datetime = DateTime.Now.AddHours(5).ToString("G")
                                }
                            }
                        }
                    },
                    
                }
            };
        }

        public IGraphSchedule GetRoomSchedule(string roomid)
        {
            return new GraphSchedule
            {
                scheduleId = "Room-Pi3.14159265@drivetime.com",
                scheduleItems = new List<IGraphScheduleItem>
                {
                    new GraphScheduleItem
                    {
                        start = new GraphScheduleTime
                        {
                            datetime = DateTime.Now.AddHours(1).ToString("G")
                        },
                        end = new GraphScheduleTime
                        {
                            datetime = DateTime.Now.AddHours(2).ToString("G")
                        }
                    },
                    new GraphScheduleItem
                    {
                        start = new GraphScheduleTime
                        {
                            datetime = DateTime.Now.AddHours(4).ToString("G")
                        },
                        end = new GraphScheduleTime
                        {
                            datetime = DateTime.Now.AddHours(5).ToString("G")
                        }
                    }
                }
            };
        }
    }
}