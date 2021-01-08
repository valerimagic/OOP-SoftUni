using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        //private CarRepository cars;
        //private RaceRepository races;


        private List<IPlayer> players;
        private List<IPlayer> halfOne;
        private List<IPlayer> halfTwo;
        private List<IPlayer> winPlayers;
        private List<IPlayer> lossPlayers;
        private IPlayer firstPlayer;
        private IPlayer secondPlayer;

        public ChampionshipController()
        {

            players = new List<IPlayer>();
            halfOne = new List<IPlayer>();
            halfTwo = new List<IPlayer>();
            winPlayers = new List<IPlayer>();
            lossPlayers = new List<IPlayer>();

        }

        public string StartTournament(string tournamentName)
        {
            while (true)
            {
                Random random = new Random();
                int lucky = random.Next(1, 3);

                if (lucky == 1)
                {
                    if (halfOne.Count == 1 && winPlayers.Count == 0)
                    {
                        firstPlayer = halfOne[0];
                        secondPlayer = halfTwo[0];
                    }
                    halfOne[0].Win++;
                    winPlayers.Add(halfOne[0]);
                    halfTwo[0].Loss++;
                    lossPlayers.Add(halfTwo[0]);
                }
                else if (lucky == 2)
                {
                    if (halfTwo.Count == 1 && winPlayers.Count == 0)
                    {
                        firstPlayer = halfTwo[0];
                        secondPlayer = halfOne[0];
                    }
                    halfTwo[0].Win++;
                    winPlayers.Add(halfTwo[0]);
                    halfOne[0].Loss++;
                    lossPlayers.Add(halfOne[0]);

                }
                halfOne.RemoveAt(0);
                halfTwo.RemoveAt(0);
                if (halfOne.Count == 0 && winPlayers.Count == 1)
                {
                    break;
                }
                else if (halfOne.Count == 0 && winPlayers.Count > 1)
                {
                    int num = winPlayers.Count;
                    for (int i = 0; i < num; i++)
                    {
                        players.Add(winPlayers[i]);
                    }

                    for (int i = 0; i < num; i++)
                    {
                        winPlayers.RemoveAt(0);
                    }

                    int count = 0;
                    for (int i = 0; i < players.Count / 2; i++)
                    {
                        halfOne.Add(players[i]);
                        count++;
                    }

                    for (int i = count; i < players.Count; i++)
                    {
                        halfTwo.Add(players[i]);
                    }

                    int number = players.Count;
                    for (int i = 0; i < number; i++)
                    {
                        players.RemoveAt(0);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Winner is {firstPlayer.Name} from {firstPlayer.Country}.");
            sb.AppendLine($"Second is {secondPlayer.Name} from {secondPlayer.Country}.");

            return sb.ToString().TrimEnd();

        }

        public string CreatePlayer(string name, int age, string country, string city, int numberOfPlayedMatchs, int win, int loss)
        {

            IPlayer player = new Player(name, age, country, city, numberOfPlayedMatchs, win, loss);

            this.players.Add(player);

            return string.Format(OutputMessages.PlayerCount, players.Count);

        }

        public string CreateTournament(string name, int maxCountPlayer)
        {
            if (players.Count % 2 == 0 && players.Count <= maxCountPlayer)
            {
                foreach (var player in players)
                {
                    player.CanParticipate = true;
                }
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidCountPlayers, maxCountPlayer));
            }

            int count = 0;
            for (int i = 0; i < players.Count / 2; i++)
            {
                halfOne.Add(players[i]);
                count++;
            }

            for (int i = count; i < players.Count; i++)
            {
                halfTwo.Add(players[i]);
            }

            int countForRemove = players.Count;
            for (int i = 0; i < countForRemove; i++)
            {
                players.RemoveAt(0);
            }

            return string.Format(OutputMessages.TournamentCreated, name);

        }








        // НЕНУЖНИ
        public string CreateDriver(string driverName)
        {
            throw new NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            throw new NotImplementedException();
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            throw new NotImplementedException();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            throw new NotImplementedException();
        }

    }
}
