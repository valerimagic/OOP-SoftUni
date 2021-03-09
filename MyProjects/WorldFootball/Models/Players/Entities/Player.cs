namespace Football.Models.Players.Entities
{
    using System;
    using Football.Models.Players.Contracts;
    using Football.Utilities.Messages;

    public class Player : IPlayer
    {
        private string name;
        private int age;
        private string country;
        private string city;

        public Player()
        {
        }

        public Player(string name, int age, string country, string city) : this()
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.City = city;
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

        public int NumberOfPlayedMatchs { get; }

        public int Win { get; set; }

        public int Loss { get; set; }

        public bool CanParticipate { get; set; }
    }
}
