using Football.Utilities.Messages;
using System;

namespace Football.Models.StatisticsTeam.Entities
{
    public class StatisticTeam
    {
        private int numberOfPlayedMatchs;
        private int win;
        private int loss;
        private int draw;


        public StatisticTeam()
        {
                
        }
        public StatisticTeam(int numberOfPlayedMatchs, int win, int loss, int draw)
        {
            this.NumberOfPlayedMatchs = numberOfPlayedMatchs;
            this.Win = win;
            this.Loss = loss;
            this.Draw = draw;
        }

        public int NumberOfPlayedMatchs
        {
            get => this.numberOfPlayedMatchs;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException((ExceptionMessages.InvalidNumberOfMatch));
                }

                this.numberOfPlayedMatchs = value;
            }
        }
        public int Win
        {
            get => this.win;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException((ExceptionMessages.InvalidPoints));
                }

                this.win = value;
            }
        }
        public int Loss
        {
            get => this.loss;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException((ExceptionMessages.InvalidPoints));
                }

                this.loss = value;
            }
        }

        public int Draw
        {
            get => this.draw;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException((ExceptionMessages.InvalidPoints));
                }

                this.draw = value;
            }
        }


    }
}
