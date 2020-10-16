using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IGun> guns;
        private readonly IRepository<IPlayer> players;
        private readonly IMap map;

        public Controller()
        {
            this.guns = new GunRepository();
            this.players = new PlayerRepository();
            this.map = new Map();
        }


        public string AddGun(string type, string name, int bulletsCount)
        {
            Gun gun;

            if(type == "Pistol")
            {
                gun = new Pistol(name, bulletsCount);
            }

            else if(type == "Rifle")
            {
                gun = new Rifle(name, bulletsCount);
            }
            else
            {    
                //TODO: . OR ! v imeto na messages-a
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            this.guns.Add(guns);
            //TODO return $"Successfully added gun {gun.Name}.";
            return string.Format(OutputMessages.SuccessfullyAddedGun, gun.Name );





        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            var gun = guns.FindByName(gunName);

            IPlayer player;

            if(type == "Terrorist")
            {
                player = new Terrorist(username, health, armor, gun);
            }
            else if(type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, gun);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            players.Add(player);

            return $"Successfully added player {player.Username}.";
        }


        public string StartGame()
        {
            var playersAlive = this.players.Models.Where(x => x.IsAlive).ToList();

            var result = map.Start(playersAlive);

            return result;
            
        }
        public string Report()
        {
            var player = this.players.Models
                             .OrderBy(t => t.GetType().Name)
                             .ThenByDescending(h => h.Health)
                             .ThenByDescending(u => u.Username)
                             .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in player)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }



    }
}
