﻿namespace PlayersAndMonsters
{
    public class MuseElf : Elf
    {
        public MuseElf(string username, int level) 
            : base(username, level)
        {
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
