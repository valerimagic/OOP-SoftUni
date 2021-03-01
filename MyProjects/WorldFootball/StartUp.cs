//using Core.Contracts;

using System.Data;
using Dataaccess.Entity;
using Football.IO;
using Football.IO.Contracts;
using Football.Core.Entities;
using Football.Core.Contracts;
using Football.Models.Players.Contracts;
using Football.Models.Players.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Football
{
    public class StartUp
    {
        public static void Main()
        {
            IChampionshipController controller = new ChampionshipController();
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(controller, reader, writer);
            engine.Run();

            
            IPlayer player = new Player();

            
            //db.BaseClass.ToList();
            //var team = 

        }

    }
}
