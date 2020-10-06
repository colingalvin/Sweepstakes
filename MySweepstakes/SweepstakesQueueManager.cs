using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables (HAS A)
        private Queue<Sweepstakes> queue;

        // constructor (SPAWN)
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
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
