using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Sweepstakes
    {
        // member variables (HAS A)
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get => name;
        }

        // constructor (SPAWN)
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        // member methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {

        }
        
        //public Contestant PickWinner()
        //{

        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
