namespace PlayersAndMonsters
{
    public class Elf : Hero
    {
        public Elf(string username, int level) : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
