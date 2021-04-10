using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private IList<IRobot> robots;
        protected Procedure()
        {
            this.robots = new List<IRobot>();
        }

        public virtual IList<IRobot> Robots => this.robots;

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}");

            foreach (var VARIABLE in this.robots)
            {
                sb.AppendLine(VARIABLE.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if (robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }

            robot.ProcedureTime -= procedureTime;

        }

    }
}
