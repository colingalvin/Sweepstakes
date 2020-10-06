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
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }

    }
}
