namespace Football
{
    using Football.Core.Contracts;
    using Football.Core.Entities;
    using Football.IO;
    using Football.IO.Contracts;
    using Football.Models.Players.Contracts;
    using Football.Models.Players.Entities;

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
        }
    }
}
