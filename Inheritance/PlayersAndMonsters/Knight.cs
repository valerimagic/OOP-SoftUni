using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string username, int level) : base(username, level)
        {
            //this.Username = username;
        }
        public string Username { get; set; }
        public int Level { get; set; }

    }


}
