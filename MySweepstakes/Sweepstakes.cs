using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Sweepstakes
    {
        // member variables (HAS A)
        private Dictionary<int, Participant> contestants;
        private int key;
        private string name;
        public string Name
        {
            get => name;
        }

        // constructor (SPAWN)
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Participant> ();
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

        public Winner PickWinner()
        {
            Participant chosenWinner;
            Random random = new Random();
            contestants.TryGetValue(random.Next(1, contestants.Count + 1), out chosenWinner);
            Winner winner = new Winner(chosenWinner);
            ReassignWinner(chosenWinner, winner);
            NotifyParticipants(winner);
            return winner;
        }

        private void ReassignWinner(Participant chosenWinner, Winner winner)
        {
            contestants.Remove(chosenWinner.registrationNumber);
            contestants.Add(winner.registrationNumber, winner);
        }

        private void NotifyParticipants(Winner winner)
        {
            foreach(KeyValuePair<int, Participant> contestant in contestants)
            {
                contestant.Value.Notify(winner);
            }
        }

        public void PrintContestantInfo(Participant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.firstName} {contestant.lastName}");
            Console.WriteLine($"Email address: {contestant.emailAddress}");
            Console.WriteLine($"Registration number: {contestant.registrationNumber}");
        }
    }
}
