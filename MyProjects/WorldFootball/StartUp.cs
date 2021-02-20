//using Core.Contracts;
using Football.IO;
using Football.IO.Contracts;
using Football.Core.Entities;
using Football.Core.Contracts;

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
        }

    }
}
