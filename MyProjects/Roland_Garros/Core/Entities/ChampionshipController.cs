﻿using System;
using System.Collections.Generic;
using System.Text;
using RolandGarros.Core.Contracts;
using RolandGarros.Models.Players.Contracts;
using RolandGarros.Models.Players.Entities;
using RolandGarros.Utilities.Messages;

namespace RolandGarros.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        
        private readonly List<IPlayer> players;
        private readonly List<IPlayer> halfOne;
        private readonly List<IPlayer> halfTwo;
        private readonly List<IPlayer> winPlayers;
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
                CheckForWinnerAfterEachRound();


                if (MenageListWithPlayersDuringTheTournament())
                {
                    break;
                }
            }

            return PrintFinalResult(firstPlayer, secondPlayer);

        }


        public string CreatePlayer(string name, int age, string country, string city, int numberOfPlayedMatchs, int win, int loss)
        {

            IPlayer player = new Player(name, age, country, city, numberOfPlayedMatchs, win, loss);

            this.players.Add(player);

            return string.Format(OutputMessages.PlayerCount, players.Count);

        }

        public string CreateTournament(string name, int maxCountPlayer)
        {
            CheckBeforeCreateTournament(maxCountPlayer);

            FillingTournamentAandBhalves();

            return string.Format(OutputMessages.TournamentCreated, name);

        }

        private void FillingTournamentAandBhalves()
        {
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
        }

        private void CheckBeforeCreateTournament(int maxCountPlayer)
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
        }
        
        private bool MenageListWithPlayersDuringTheTournament()
        {
            if (halfOne.Count == 0 && winPlayers.Count == 1)
            {
                return true;
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

            return false;
        }

        private string PrintFinalResult(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Winner is {firstPlayer.Name} from {firstPlayer.Country}.");
            sb.AppendLine($"Second is {secondPlayer.Name} from {secondPlayer.Country}.");

            return sb.ToString().TrimEnd();
        }
        
        private void CheckForWinnerAfterEachRound()
        {
            Random random = new Random();
            int winner = random.Next(1, 3);

            if (winner == 1)
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

            else if(winner == 2)
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
        }


    }
}
