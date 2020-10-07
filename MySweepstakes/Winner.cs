using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Winner : Participant, IContestant
    {
        // member variables

        // constructor
        public Winner(Participant chosenWinner)
        {
            firstName = chosenWinner.firstName;
            lastName = chosenWinner.lastName;
            emailAddress = chosenWinner.emailAddress;
            registrationNumber = chosenWinner.registrationNumber;
        }

        // member methods
        public override void Notify(Winner winner)
        {
            Console.WriteLine($"Congratulations {winner.firstName}, you have been chosen as our winner!");
        }
    }
}
