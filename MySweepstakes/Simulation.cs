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
        public ISweepstakesManager CreateMarketingFirmWithManager()
        {
            string managerChoice = UserInterface.GetUserInputFor("Choose Stack or Queue organization structure: ");
            ISweepstakesManager manager = null;
            switch(managerChoice)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return CreateMarketingFirmWithManager();
            }
            return manager;
        }

        public void RunSimulation()
        {
            //ISweepstakesManager manager = CreateMarketingFirmWithManager();
            //marketingFirm = new MarketingFirm(manager);

            //Sweepstakes sweepstakes = new Sweepstakes("sweepstakes");
            //Contestant colin = new Contestant();
            //Contestant keith = new Contestant();
            //Contestant phil = new Contestant();
            //sweepstakes.RegisterContestant(colin);
            //sweepstakes.RegisterContestant(keith);
            //sweepstakes.RegisterContestant(phil);
            //sweepstakes.PickWinner();

            //Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            //Contestant colin = new Contestant();
            //sweepstakes.RegisterContestant(colin);
            //sweepstakes.PrintContestantInfo(colin);
        }
    }
}
