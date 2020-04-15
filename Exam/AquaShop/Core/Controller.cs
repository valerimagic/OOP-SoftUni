using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IDecoration> decorations;
        private readonly ICollection<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            //  Adds an Aquarium.Valid types are: "FreshwaterAquarium" and "SaltwaterAquarium".
            //  If the Aquarium type is invalid, you have to throw an InvalidOperationException with the following message:
            //  • "Invalid aquarium type."
            //  If the Aquarium is added successfully, the method should return the following string:
            //  • "Successfully added {aquariumType}."

            IAquarium aquarium;
            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumType);
            }
            else if (aquariumName == nameof(SaltwaterAquarium))
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
            this.aquariums.Add(aquarium);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);



        }
        public string AddDecoration(string decorationType)
        {
            //            Parameters
            //•	type - string
            //Functionality
            //Creates a decoration of the given type and adds it to the DecorationRepository. Valid types are: "Ornament" and "Plant".
            //If the decoration type is invalid, throw an InvalidOperationException with message:
            //•	"Invalid decoration type."
            //The method should return the following string if the operation is successful:
            //•	"Successfully added {decorationType}."

            IDecoration decoration;

            if (decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }
            else if (decorationType == nameof(Plant))
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
            this.decorations.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);


        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            throw new NotImplementedException();
        }

        public string CalculateValue(string aquariumName)
        {
            throw new NotImplementedException();
        }

        public string FeedFish(string aquariumName)
        {
            throw new NotImplementedException();
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            //           Parameters
            //•	aquariumName - string
            //•	decorationType - string
            //Functionality
            //Adds the desired Decoration to the Aquarium with the given name. You have to remove the Decoration from the DecorationRepository if the insert is successful.
            //If there is no such decoration, you have to throw an InvalidOperationException with the following message:
            //•	"There isn't a decoration of type {decorationType}."
            //If no errors are thrown, return a string with the following message "Successfully added {decorationType} to {aquariumName}.".

            var decoration = this.decorations.FindByType(decorationType);
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if(decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            aquarium.AddDecoration(decoration);
            decorations.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            throw new NotImplementedException();
        }
    }
}
