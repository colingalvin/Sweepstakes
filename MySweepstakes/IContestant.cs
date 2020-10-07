using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public interface IContestant
    {
        void Notify(Winner winner);
    }
}
