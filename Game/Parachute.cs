using System;
using System.Collections.Generic;
namespace Unit03.Game
{
    // The parachute class keeps track of a parachute and it's cargo (person in this instance).
    // The parachachute can be destroyed one line at a time, and the cargo(person) can die.
    public class Parachute
    {
        private List<string> parachute = new List<string>();
        private List<string> person = new List<string>();

        // IConstructs a new instance of parachute.
        // Adds the lines of the parachute and adds the lines of the person.
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

        // Get rid of the first row of the parachute.
        public void takeRowOffParachute()
        {
            parachute.RemoveAt(0);
        }
        
        // When the parachute is gone, set the person to x rather than an o.
        public void setDeath()
        {
            person[0] = "    x    ";
        }

        public List<string> getParachute()
        {
            return parachute;
        }

        public List<string> getPerson()
        {
            return person;
        }
    }
}

