﻿using System;

namespace _6.FootballTeamGenerator
{
    public class Player
    {
		private string name;
		private int endurance;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shootin)
		{
			this.Name = name;
			this.Endurance = endurance;
			this.Sprint = sprint;
			this.Dribble = dribble;
			this.Passing = passing;
			this.Shootin = shootin;
		}

		public string Name
		{
			get { return name; }
			set 
			{
				if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("A name should not be empty.");
				}
				name = value; 
			}
		}


		public int Endurance
		{
			get { return endurance; }
			private set 
			{
				if(value < 0 || value > 100)
				{
					throw new ArgumentException("Endurance should be between 0 and 100.");
				}
				endurance = value; 
			}
		}


		public int Sprint
		{
			get { return sprint; }
			private set 
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Sprint should be between 0 and 100.");
				}
				sprint = value; 
			}
		}


		public int Dribble
		{
			get { return dribble; }
			private set 
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Dribble should be between 0 and 100.");
				}
				dribble = value; 
			}
		}


		public int Passing
		{
			get { return passing; }
			private set 
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Passing should be between 0 and 100.");
				}
				passing = value; 
			}
		}


		public int Shootin
		{
			get { return shooting; }
			private set 
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Shooting should be between 0 and 100.");
				}
				shooting = value; 
			}
		}

		public int AverageCalculated()
		{
			var average = (endurance + sprint + dribble + passing + shooting) == 0 
				? 
				0 : (int)Math.Round((this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5.0);
			return average;
		}

	}
}
