using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Core
{
    public class Controller : IController
    {

        private IComputer computer;
        private IList<IComputer> computers;


        public Controller()
        {
            this.computers = new List<IComputer>();

        }


        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {

            var exist = computers.FirstOrDefault(x => x.Id == id);
            if (exist != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            else if (computerType == "DesktopComputer")
            {
                computer = new DesktopComputer(id, manufacturer, model, price);
                this.computers.Add(computer);
            }
            else if (computerType == "Laptop")
            {
                computer = new Laptop(id, manufacturer, model, price);
                this.computers.Add(computer);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            string msg = string.Format(SuccessMessages.AddedComputer, id);
            return msg;

        }


        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
            double overallPerformance, string connectionType)
        {

            IComputer computer = this.computers.FirstOrDefault(x => x.Id == computerId);
            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }


            if (computer.Peripherals.FirstOrDefault(x => x.Id == id) != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }


            IPeripheral peripheral;
            if (peripheralType == "Headset")
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Keyboard")
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Monitor")
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Mouse")
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }
            string msg = string.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);
            return msg;
        }


        public string RemovePeripheral(string peripheralType, int computerId)
        {

            IComputer searchComputerID = this.computers.FirstOrDefault(x => x.Id == computerId);
            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            var remove = computer.RemovePeripheral(peripheralType);
            string rezult = string.Format(SuccessMessages.RemovedPeripheral, peripheralType, remove.Id);
            return rezult;
        }


        public string RemoveComponent(string componentType, int computerId)
        {

            IComputer searchComputerID = computers.FirstOrDefault(x => x.Id == computerId);
            if (searchComputerID == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            var component = computer.RemoveComponent(componentType);
            return string.Format(SuccessMessages.RemovedComponent, componentType, component.Id);

        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {

            IComputer searchComputerID = computers.FirstOrDefault(x => x.Id == computerId);
            if (searchComputerID == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            if (computer.Components.FirstOrDefault(x => x.Id == id) != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }


            if (componentType == "CentralProcessingUnit")
            {
                var component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "Motherboard")
            {
                var component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "PowerSupply")
            {
                var component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "RandomAccessMemory")
            {
                var component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "SolidStateDrive")
            {
                var component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "VideoCard")
            {
                var component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }

            string msg = string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
            return msg;
        }


        public string BuyComputer(int id)
        {
            IComputer searchComputerID = computers.FirstOrDefault(x => x.Id == id);
            if (searchComputerID == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            this.computers.Remove(searchComputerID);
            return computer.ToString();

        }


        public string BuyBest(decimal budget)
        {
            this.computers = this.computers.OrderByDescending(x => x.OverallPerformance).ToList();
            var bestPriceComputer = computers.FirstOrDefault(x => x.Price <= budget);

            if (bestPriceComputer == null)
            {
                string msg = string.Format(ExceptionMessages.CanNotBuyComputer, budget);
                throw new ArgumentException(msg);
            }

            this.computers.Remove(bestPriceComputer);
            return computer.ToString();

        }

        public string GetComputerData(int id)
        {
            IComputer searchComputerID = computers.FirstOrDefault(x => x.Id == id);
            if (searchComputerID == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            return computer.ToString();

        }
    }
}
