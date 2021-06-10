namespace PlayersAndMonsters
{
    public class BladeKnight : DarkKnight
    {
        public BladeKnight(string username, int level) 
            : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
