using RolandGarros.Core.Contracts;
using RolandGarros.IO;
using RolandGarros.IO.Contracts;
using RolandGarros.Core.Entities;

namespace RolandGarros
{
    public class StartUp
    {
        public static void Main()
        {
            IChampionshipController controller = new ChampionshipController();
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine enigne = new Engine(controller, reader, writer);
            enigne.Run();
        }
    }
}
