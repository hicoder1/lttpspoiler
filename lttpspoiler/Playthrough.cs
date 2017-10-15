using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lttpspoiler {
    public class Playthrough {

        public List<Item> objectives;
        public int current;

        public event EventHandler objectiveChanged;

        public Playthrough() {
            objectives = new List<Item>();
            current = 0;
        }

        public void addObjective(string position, string item) {
            Item i = new Item();
            i.positionName = position;
            i.name = item;
            objectives.Add(i);
        }

        public Item getNextObjective() {
            //needs error checking
            return objectives[current++];
        }

        public Item getPreviousObjective() {
            //needs error checking and to subtract first? not sure 
            //the first time it is clicked, nothing will appear to happen
            return objectives[current--];
        }
    }
}
