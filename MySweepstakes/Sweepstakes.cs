using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Sweepstakes
    {
        // member variables (HAS A)
        private Dictionary<int, Contestant> contestants;
        private int key;
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
            key = 1;
        }

        // member methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = key;
            contestants.Add(key, contestant);
            key++;
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            Contestant winner;
            contestants.TryGetValue(random.Next(1, contestants.Count + 1), out winner);
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.firstName} {contestant.lastName}");
            Console.WriteLine($"Email address: {contestant.emailAddress}");
            Console.WriteLine($"Registration number: {contestant.registrationNumber}");
        }
    }
}
