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
        private Stack<Sweepstakes> stack;

        // constructor (SPAWN)
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        // member methods (CAN DO)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }
    }
}
