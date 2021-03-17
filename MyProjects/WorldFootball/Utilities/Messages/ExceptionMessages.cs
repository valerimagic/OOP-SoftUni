namespace Football.Utilities.Messages
{
    public static class ExceptionMessages
    {
        public const string PlayerNOTExists = "Player {0} do not exist.";
     
        public const string InvalidName = "Name {0} cannot be less than {1} symbols or more than {2} symbols.";
  
        public const string InvalidAge = "Age must be between {0} and {1} years.";
    
        public const string InvalidNumberOfMatch = "Number of played matches must be greater than or equal to 0.";

        public const string InvalidPoints = "Points must be more or equal than 0";

        public const string InvalidNumberOfGoals = "Number of goals must be greater than or equal to 0.";
        
        public const string InvalidNumberOfYellowCards = "Number of yellow cards must be greater than or equal to 0."; 

        public const string PlayerExists = "Player {0} is already exist.";
        
        public const string InvalidCountPlayers = "Players cannot be odd and no more than {1} players.";
    }
}
