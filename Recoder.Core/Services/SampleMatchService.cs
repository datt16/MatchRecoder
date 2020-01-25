﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Recoder.Core.Models;

namespace Recoder.Core.Services {
    class SampleMatchService {
        private IEnumerable<MatchData> _allMatchDatas;
        //private IEnumerable<MatchData> AllMatches() {
        //    var Matches = AllMatches();
        //    return Matches.SelectMany()
        //}

        private static IEnumerable<MatchData> SampleMatch() {
            return new List<MatchData>()
            {

            new MatchData()
            {
                Title = "SampleData",
                TeamAName = "TeamA",
                TeamBName = "TeamB",
                GamesCount = 3,
                TeamAPlayers = new List<Player>()
                {
                    new Player()
                    {
                        Name = "PlayerA",
                        Age = 16,
                        Pos = "Volley"
                    },
                    new Player()
                    {
                        Name = "PlayerB",
                        Age = 16,
                        Pos = "Base"
                    }
                },
                TeamBPlayers = new List<Player>()
                {
                    new Player()
                    {
                        Name = "PlayerC",
                        Age = 16,
                        Pos = "Volley"
                    },
                    new Player()
                    {
                        Name = "PlayerD",
                        Age = 16,
                        Pos = "Base"
                    }
                },
                Points = new List<Point>()
                {
                    new Point()
                    {
                        id = 0,
                        getter = 's',
                        Tags = new List<Tag>
                        {
                            new Tag()
                            {
                                TagName = "Fault",
                                ShortTag = "F"
                            },
                            new Tag()
                            {
                                TagName = "ServiceAce",
                                ShortTag = "SA"
                            }
                        }
                    }
                }
            }
            };
        }
    }
}