namespace PlayersAndMonsters
{
    public class SoulMaster : DarkWizard
    {
        public SoulMaster(string username, int level) 
            : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
