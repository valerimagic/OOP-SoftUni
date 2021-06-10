namespace PlayersAndMonsters
{
    public class DarkKnight : Knight
    {
        public DarkKnight(string username, int level)
            : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
