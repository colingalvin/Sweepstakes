﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySweepstakes
{
    public class Contestant : Participant
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("Please enter your first name: ");
            lastName = UserInterface.GetUserInputFor("Please enter your last name: ");
            emailAddress = UserInterface.GetUserInputFor("Please enter your email address: ");
        }


        // member methods (CAN DO)
        public override void Notify(string sweepstakesName, Winner winner)
        {
            Console.WriteLine($"Dear {firstName}, we are sorry to inform you that you were not chosen as the winner of our {sweepstakesName} sweepstakes. " +
                $"Please join us in congratulating our winner, {winner.firstName} {winner.lastName}!");
        }
    }
}
