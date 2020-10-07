using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Contestant
    {
        // member variables (HAS A)
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        // constructor (SPAWN)
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("Please enter your first name: ");
            lastName = UserInterface.GetUserInputFor("Please enter your last name: ");
            emailAddress = UserInterface.GetUserInputFor("Please enter your email address: ");
        }

        // member methods (CAN DO)
    }
}
