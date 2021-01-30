using System;
using RolandGarros.Models.Players.Contracts;
using RolandGarros.Utilities.Messages;

namespace RolandGarros.Models.Players.Entities
{
    public class Player : IPlayer
    {
        private string name;
        private int age;
        private string country;
        private string city;
        private int numberOfPlayedMatchs;
        private int win;
        private int loss;

        public Player(string name, int age, string country, string city, int numberOfPlayedMatchs, int win, int loss)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.City = city;
            this.NumberOfPlayedMatchs = numberOfPlayedMatchs;
            this.Win = win;
            this.Loss = loss;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 2, 30));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < 14 || value > 50)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidAge, 14, 50));
                }

                this.age = value;
            }
        }

        public string Country
        {
            get => this.country;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 2, 30));
                }

                this.country = value;
            }
        }
        public string City
        {
            get => this.city;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 2, 30));
                }

                this.city = value;
            }
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
                    throw new ArgumentException((ExceptionMessages.InvalidNumberOfGoals));
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
                    throw new ArgumentException((ExceptionMessages.InvalidNumberOfYellowCards));
                }

                this.loss = value;
            }
        }

        public bool CanParticipate
        {
            get;
            set;
        }
        
    }
}
