namespace PlayersAndMonsters
{
    public class Wizard : Hero
    {
        public Wizard(string username, int level) 
            : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
