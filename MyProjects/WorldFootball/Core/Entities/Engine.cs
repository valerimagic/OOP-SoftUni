﻿namespace Football.Core.Entities
{
    using System;
    using Football.Core.Contracts;
    using Football.IO.Contracts;
    using Football.Models.Players.Entities;

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
                            this.controller.CreatePlayer(args[1], int.Parse(args[2]), args[3], args[4], int.Parse(args[5]));
                    }

                    if (cmdType == "RemovePlayer")
                    {
                        resultMessage = this.controller.RemovePlayer(new Player(args[1], int.Parse(args[2]), args[3], args[4]));
                    }

                    if (cmdType == "CreateTeam")
                    {
                        resultMessage =
                            this.controller.CreateTeam(args[1]);
                    }

                    if (cmdType == "CreateStatistic")
                    {
                        resultMessage = this.controller.AddStatistic(int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5]));
                    }

                    if (cmdType == "Save")
                    {
                        this.controller.Save();
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
