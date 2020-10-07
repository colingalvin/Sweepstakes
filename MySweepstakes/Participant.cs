using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public abstract class Participant : IContestant
    {
        // member variables (HAS A)
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public abstract void Notify(Winner winner);
    }
}
