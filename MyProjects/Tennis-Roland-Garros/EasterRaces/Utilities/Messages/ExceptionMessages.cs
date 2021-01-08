namespace EasterRaces.Utilities.Messages
{
    public static class ExceptionMessages
    {
        public const string InvalidCountPlayers = "Players cannot be odd and no more than {1} players.";//ok
     
        public const string InvalidName = "Name {0} cannot be less than {1} symbols or more than {2} symbols.";//ok
  
        public const string InvalidAge = "Age must be between {0} and {1} years."; //ok
    
        public const string InvalidNumberOfMatch = "Number of played matches must be greater than or equal to 0."; //ok

        public const string InvalidNumberOfGoals = "Number of goals must be greater than or equal to 0."; //ok
        
        public const string InvalidNumberOfYellowCards = "Number of yellow cards must be greater than or equal to 0."; //ok

        public const string PlayerExists = "Player {0} is already exist."; //ok
        
        public const string DriverAlreadyAdded = "Driver {0} is already added in {1} race.";
               
        public const string DriverNotFound = "Driver {0} could not be found.";
               
        public const string DriverNotParticipate = "Driver {0} could not participate in race.";
            
        public const string DriverInvalid = "Driver cannot be null.";
           
        public const string CarExists = "Car {0} is already create.";
       
        public const string CarInvalid = "Car cannot be null.";
     
        public const string CarNotFound = "Car {0} could not be found.";
         
        public const string RaceNotFound = "Race {0} could not be found.";
      
        public const string RaceExists = "Race {0} is already created.";
    
        public const string RaceInvalid = "Race {0} cannot start with less than {1} participants.";
    }
}
