using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {

        protected Procedure()
        {
            this.Robots = new List<IRobot>();
        }
        protected IList<IRobot> Robots { get; }

        
        public abstract void DoService(IRobot robot, int procedureTime);

        public virtual string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");

            foreach (var item in this.Robots)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
