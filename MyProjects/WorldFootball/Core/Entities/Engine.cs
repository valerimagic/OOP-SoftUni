using Football.Core.Contracts;
using System;
using System.Collections.Generic;
using Football.IO.Contracts;
using Football.Models.Players.Entities;

namespace Football.Core.Entities
{
    public class Engine
    {
        private readonly IChampionshipController controller;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IChampionshipController championshipController, IReader reader, IWriter writer)
        {
            this.controller = championshipController;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command = this.reader.ReadLine();

            while (command != "End")
            {
                try
                {
                    var args = command.Split();
                    var cmdType = args[0];
                    string resultMessage = string.Empty;

                    if (cmdType == "CreatePlayer")
                    {
                        resultMessage =
                            this.controller.CreatePlayer(args[1], int.Parse(args[2]), args[3],
                                args[4], int.Parse(args[5]));
                    }

                    if (cmdType == "RemovePlayer")
                    {
                        resultMessage = this.controller.RemovePlayer(new Player(args[1], int.Parse(args[2]), args[3],
                            args[4]));
                    }

                    if (cmdType == "CreateTeam")
                    {
                        resultMessage =
                            this.controller
                                .CreateTeam(args[1]);
                    }
                    

                    this.writer.WriteLine(resultMessage);
                }
                catch (Exception e)
                {
                    this.writer.WriteLine(e.Message);
                }

                command = this.reader.ReadLine();
            }
        }

    }
}
