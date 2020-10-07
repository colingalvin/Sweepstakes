using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class MarketingFirm
    {
        // member variables (HAS A)
        private ISweepstakesManager manager;

        // constructor (SPAWN)

        /*
        
        This application has the ability to utilize different organizational structures
        in its implimentation. Both stack or queue data structures will allow the same
        overall functionality while giving the user the option to choose the structure
        which best serves their individual needs.

        */

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        // member methods (CAN DO)
        public void CreateSweepstakes()
        {
            string userInput = UserInterface.GetUserInputFor("Enter the name of the new sweepstakes: ");
            Sweepstakes sweepstakes = new Sweepstakes(userInput);
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
