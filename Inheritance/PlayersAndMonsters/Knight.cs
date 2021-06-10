namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string username, int level) : base(username, level)
        {
        }

        public string Username { get; set; }
        public int Level { get; set; }
    }
}
