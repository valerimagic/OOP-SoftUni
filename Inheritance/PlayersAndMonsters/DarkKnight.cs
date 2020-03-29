using System;
using System.Collections.Generic;
using System.Text;

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
