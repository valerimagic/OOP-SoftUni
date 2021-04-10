using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => (IReadOnlyCollection<IComponent>)this.components;

        public IReadOnlyCollection<IPeripheral> Peripherals => (IReadOnlyCollection<IPeripheral>)this.peripherals;


        public void AddComponent(IComponent component)
        {

            var exist = this.components.FirstOrDefault(x => x.GetType().Name == component.GetType().Name);

            if (exist != null)
            {
                string msg = string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name,
                    base.Id);
                throw new ArgumentException(msg);
            }

            components.Add(component);

        }


        public IComponent RemoveComponent(string componentType)
        {
            var exist = this.components.FirstOrDefault(x => x.GetType().Name == componentType);

            if (exist == null)
            {
                    string msg = string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, base.Id);
                    throw new ArgumentException(msg);
            }

            this.components.Remove(exist);
            return exist;
        }


        public void AddPeripheral(IPeripheral peripheral)
        {
            var exist = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheral.GetType().Name);

            if (exist != null)
            {
                string msg = string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name,
                    base.Id);
                throw new ArgumentException(msg);
            }

            this.peripherals.Add(peripheral);
        }


        public IPeripheral RemovePeripheral(string peripheralType)
        {
            var exist = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if (exist == null)
            {
                string msg = string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, base.Id);
                throw new ArgumentException(msg);
            }

            this.peripherals.Remove(exist);
            return exist;
        }

        public override double OverallPerformance
        {
            get
            {
                if (this.Components.Count==0)
                {
                    return base.OverallPerformance;
                }
                return base.OverallPerformance + Components.Average(x => x.OverallPerformance);
            }
        }


        public override decimal Price
        {
            get
            {
                var computerPrice = this.components.Sum(x => x.Price);
                var peripherPrice = this.peripherals.Sum(x => x.Price);
                return computerPrice + peripherPrice + base.Price;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());


            sb.AppendLine($" Components ({this.Components.Count}):");
            foreach (IComponent component in this.Components)
            {
                sb.AppendLine($"  {component.ToString()}");
            }

            double average = 0;
            if (this.Peripherals.Count != 0)
            {
                average = this.Peripherals.Average(p => p.OverallPerformance);
            }
            sb.AppendLine($" Peripherals ({this.Peripherals.Count}); Average Overall Performance ({average:F2}):");
            foreach (IPeripheral peripheral in this.Peripherals)
            {
                sb.AppendLine($"  {peripheral.ToString()}");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
