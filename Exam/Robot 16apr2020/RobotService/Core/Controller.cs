using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IGarage garage;

        private Chip chip;
        private Rest rest;
        private TechCheck techCheck;
        private Work work;
        private Charge charge;
        private Polish polish;

        public Controller()
        {
            this.garage = new Garage();
            this.chip = new Chip();
            this.rest = new Rest();
            this.techCheck = new TechCheck();
            this.work = new Work();
            this.charge = new Charge();
            this.polish = new Polish();

        }


        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            if (robotType == "PetRobot")
            {
                IRobot robot = new PetRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "HouseholdRobot")
            {
                IRobot robot = new HouseholdRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "WalkerRobot")
            {
                IRobot robot = new WalkerRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }

            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            }

            string message = string.Format(OutputMessages.RobotManufactured, name);
            return message;

        }

        public string Chip(string robotName, int procedureTime)
        {

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            if (robot == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            this.chip.DoService(robot, procedureTime);

            return ($"{string.Format(OutputMessages.ChipProcedure, robotName)}");

        }

        public string TechCheck(string robotName, int procedureTime)
        {
            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            this.techCheck.DoService(robot, procedureTime);

            string message = string.Format(OutputMessages.TechCheckProcedure, robotName);
            return message;

        }

        public string Rest(string robotName, int procedureTime)
        {

            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            this.rest.DoService(robot, procedureTime);

            string message = string.Format(OutputMessages.RestProcedure, robotName);
            return message;

        }

        public string Work(string robotName, int procedureTime)
        {

            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            this.work.DoService(robot, procedureTime);

            string message = string.Format(OutputMessages.WorkProcedure, robotName, procedureTime);
            return message;

        }

        public string Charge(string robotName, int procedureTime)
        {

            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            this.charge.DoService(robot, procedureTime);

            string message = string.Format(OutputMessages.ChargeProcedure, robotName);
            return message;

        }

        public string Polish(string robotName, int procedureTime)
        {

            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;
            this.polish.DoService(robot, procedureTime);

            string message = string.Format(OutputMessages.PolishProcedure, robotName);
            return message;

        }

        public string Sell(string robotName, string ownerName)
        {

            if (garage.Robots.FirstOrDefault(x => x.Key == robotName).Value == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot robot = garage.Robots.FirstOrDefault(x => x.Key == robotName).Value;

            if (robot.IsChipped == true)
            {
                garage.Sell(robotName, ownerName);
                string message = string.Format(OutputMessages.SellChippedRobot, ownerName);
                return message;
            }
            else
            {
                string message = string.Format(OutputMessages.SellNotChippedRobot, ownerName);
                return message;
            }

        }

        public string History(string procedureType)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{procedureType}");

            if (procedureType == "Charge")
            {
                foreach (IRobot robot in this.charge.Robots)
                {
                    sb.AppendLine(robot.ToString());
                }

            }

            else if (procedureType == "Chip")
            {
                foreach (IRobot robot in this.chip.Robots)
                {

                    sb.AppendLine(robot.ToString());
                }
            }

            else if (procedureType == "Polish")
            {
                foreach (IRobot robot in this.polish.Robots)
                {

                    sb.AppendLine(robot.ToString());
                }
            }

            else if (procedureType == "Rest")
            {

                foreach (IRobot robot in this.rest.Robots)
                {

                    sb.AppendLine(robot.ToString());
                }
            }

            else if (procedureType == "TechCheck")
            {
                foreach (IRobot robot in this.techCheck.Robots)
                {
                    sb.AppendLine(robot.ToString());

                }

            }

            else if (procedureType == "Work")
            {

                foreach (IRobot robot in this.work.Robots)
                {
                    sb.AppendLine(robot.ToString());
                }
            }

            return sb.ToString().TrimEnd();

        }
    }
}
