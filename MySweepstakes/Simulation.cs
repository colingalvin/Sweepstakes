using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Simulation
    {
        // member variables (HAS A)
        public MarketingFirm marketingFirm;

        // constructor (SPAWN)

        // member methods (CAN DO)
        public void CreateMarketingFirmWithManager()
        {
            string managerChoice = UserInterface.GetUserInputFor("Choose Stack or Queue organization structure: ");
            switch(managerChoice)
            {
                case "Stack":
                    SweepstakesStackManager stack = new SweepstakesStackManager();
                    marketingFirm = new MarketingFirm(stack);
                    break;
                case "Queue":
                    SweepstakesQueueManager queue = new SweepstakesQueueManager();
                    marketingFirm = new MarketingFirm(queue);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    CreateMarketingFirmWithManager();
                    break;
            }
        }
    }
}
