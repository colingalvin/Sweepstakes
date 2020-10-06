using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        // member variables (HAS A)
        Stack<Sweepstakes> stack;

        // constructor (SPAWN)
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        // member methods (CAN DO)
        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
