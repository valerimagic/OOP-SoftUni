using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        protected Dictionary<string, IRobot> robots;
        protected int capacity = 10;
        
        public Garage()
        {
            this.robots=new Dictionary<string, IRobot>();
        }

        public int Capacity
        {
            get => this.capacity;
            set
            {
                this.capacity = value;
            }
        }
        public IReadOnlyDictionary<string, IRobot> Robots => this.robots;

        public void Manufacture(IRobot robot)
        {
            if (this.robots.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            if (robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot, robot.Name));
                //throw new ArgumentException(ExceptionMessages.ExistingRobot, robot.Name);
            }

            robots.Add(robot.Name, robot);

        }

        public void Sell(string robotName, string ownerName)
        {
            if (!robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = this.Robots.FirstOrDefault(r => r.Key == robotName).Value;
            robots[robotName].Owner = ownerName;
            robots[robotName].IsBought = true;
            robots.Remove(robot.Name);

        }
    }
}
