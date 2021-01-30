using RolandGarros.Core.Contracts;
using System;
using RolandGarros.IO.Contracts;

namespace RolandGarros.Core.Entities
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
                        resultMessage = this.controller.CreatePlayer(args[1], int.Parse(args[2]), args[3], args[4], int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]));
                    }
                    else if (cmdType == "StartTournament")
                    {
                        resultMessage = this.controller.StartTournament(args[1]);
                    }
                    else if (cmdType == "CreateTournament")
                    {
                        resultMessage = this.controller.CreateTournament(args[1], int.Parse(args[2]));
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
