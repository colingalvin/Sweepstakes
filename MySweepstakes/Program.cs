using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            Contestant colin = new Contestant();
            Contestant keith = new Contestant();
            Contestant philip = new Contestant();
            sweepstakes.RegisterContestant(colin);
            sweepstakes.RegisterContestant(keith);
            sweepstakes.RegisterContestant(philip);
            sweepstakes.PickWinner();
        }
    }
}
