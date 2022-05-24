using System;
using System.Collections.Generic;
namespace Unit03.Game
{
    public class Parachute
    {
        private List<string> parachute = new List<string>();
        private List<string> person = new List<string>();

        public Parachute()
        {
            parachute.Add("   ___   ");
            parachute.Add("  /   \\  ");
            parachute.Add("   ___   ");
            parachute.Add("  \\   /  ");
            parachute.Add("   \\ /   ");

            person.Add("    O    ");
            person.Add("   /|\\   ");
            person.Add("   / \\   ");
        }

        public takeRowOffParachute()
        {
            parachute.removeAt(0);
        }
        public getParachute()
        {
            return parachute;
        }
        public getPerson()
        {
            return person;
        }
    }
}