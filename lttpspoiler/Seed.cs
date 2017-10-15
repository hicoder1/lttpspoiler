using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lttpspoiler {

    public class Seed {

        public string difficulty;
        public string logic;
        public string seed;
        public string goal;
        public DateTime build;
        public string mode;
        public int longest_item_chain;
        public int regions_visited;
        public Playthrough playthrough;
        public List<Item> items;

        public event EventHandler seedLoaded;
        public event EventHandler seedSaved;

        public Seed() {
            items = new List<Item>();
            playthrough = new Playthrough();
        }

        private string[] getTokens(string ln) {
            ln = ln.Trim();
            ln = ln.Replace("\"", "");
            ln = ln.Replace(",", "");
            ln = ln.Replace("\t", "");
            return ln.Split(':');
        }

        public void load(string filename) {
            items = new List<Item>();
            playthrough = new Playthrough();
            using (StreamReader sr = new StreamReader(filename)) {
                string ln = null;
                while ((ln = sr.ReadLine()) != null) {
                    if(ln.Contains("entrances")) {
                        while((ln = sr.ReadLine()) != null) {
                            if (ln.Contains("]")) goto outer;
                            if (ln.Contains('{') || ln.Contains('}')) continue;
                            //read emtrances;
                        }
                    }
                    if (ln.Contains("playthrough")) {
                        while ((ln = sr.ReadLine()) != null) {
                            string[] t;
                            if (ln.Contains("meta")) break;
                            if( ln.Contains("Defeat Ganon") ||
                                ln.Contains("Agahnim")) {
                                continue;
                            }
                            if (ln.Contains("longest")) {
                                t = getTokens(ln);
                                this.longest_item_chain = Convert.ToInt32(t[1]);
                                ln = sr.ReadLine();
                                t = getTokens(ln);
                                this.regions_visited = Convert.ToInt32(t[1]);
                                goto outer;
                            }
                            if (ln.Contains('{') || ln.Contains('}')) continue;
                            t = getTokens(ln);
                            playthrough.addObjective(t[0].Trim().Replace("'", ""), t[1].Trim());
                        }
                    }
                    if(ln.Contains("meta")) {
                        while ((ln = sr.ReadLine()) != null) {
                            if (sr.Peek() == -1)
                                goto outer;
                            if (ln.Contains('{') || ln.Contains('}')) continue;

                            string[] t = getTokens(ln);
                            if (t[0].Equals("difficulty")) this.difficulty = t[1];
                            else if (t[0].Equals("logic")) this.logic = t[1];
                            else if (t[0].Equals("seed")) this.seed = t[1];
                            else if (t[0].Equals("goal")) this.goal = t[1];
                            else if (t[0].Equals("build")) this.build = DateTime.Parse(t[1]);
                            else if (t[0].Equals("mode")) this.mode = t[1];
                        }
                    }
                    if (ln.Contains('{') || ln.Contains('}')) continue;
                    if (ln.Contains("Agahnim")) continue;
                    string[] tokens = getTokens(ln);
                    addItem(tokens[0].Trim(), tokens[1].Trim());
                    outer:;
                }
            }
            fireSeedLoaded();
        }

        private void fireSeedLoaded() {
            if (seedLoaded != null) {
                seedLoaded(this, new EventArgs());
            }
        }

        //includes translation for the entrance randomizer
        //works with v25 and v26 item and entrance randomizers
        private void addItem(string p1, string p2) {
            Item i = new Item();
            if (p1.Contains("'"))
                p1 = p1.Replace("'", "");
            if (p1.Contains("Hera"))
                if (p1.Contains("Basement"))
                    p1 = "[dungeon-L3-1F] Tower of Hera - first floor";
            i.positionName = p1;
            i.name = p2;
            string file = p2;
            if (p2.Contains("Big"))
                p2 = "big key";
            else if (p2.Contains("Key"))
                p2 = "key";
            else if (p2.Contains("Compass"))
                p2 = "compass";
            else if (p2.Contains("Map"))
                p2 = "dungeon map";
            else if (p2.Contains("Blue Boomerang"))
                p2 = "boomerang";
            else if (p2.Contains("Red Boomerang"))
                p2 = "magical boomerang";
            else if (p2.Contains("Rupee (1)"))
                p2 = "one rupee";
            else if (p2.Contains("Rupees (5)"))
                p2 = "five rupees";
            else if (p2.Contains("Rupees (10)"))
                p2 = "ten rupees";
            else if (p2.Contains("Rupees (20)"))
                p2 = "twenty rupees";
            else if (p2.Contains("Rupees (50)"))
                p2 = "fifty rupees";
            else if (p2.Contains("Rupees (100)"))
                p2 = "one hundred rupees";
            else if (p2.Contains("Rupees (300)"))
                p2 = "three hundred rupees";
            else if (p2.Contains("Bombs (3)"))
                p2 = "three bombs";
            else if (p2.Contains("Single Arrow"))
                p2 = "arrow";
            else if (p2.Contains("Boss Heart"))
                p2 = "heart container";
            else if (p2.Contains("(1/2)"))
                p2 = "half magic";
            else if (p2.Contains("(1/4)"))
                p2 = "quarter magic";
            else if (p2.Contains("+"))
                p2 = p2.Replace("+", "");
            else if (p2.Contains("Silver Arrows"))
                p2 = "silver arrows upgrade";
            else if (p2.Contains("Arrows (10)"))
                p2 = "ten arrows";
            else if (p2.Contains("Arrows (5)"))
                p2 = "five arrows";
            else if (p2.Contains("Sanctuary Heart"))
                p2 = "heart container";
            else if (p2.Contains("Blue Pendant"))
                p2 = "pendant of power";
            else if (p2.Contains("Green Pendant"))
                p2 = "pendant of courage";
            else if (p2.Contains("Red Pendant"))
                p2 = "pendant of wisdom";
            else if (p2.Contains("Ocarina"))
                p2 = "flute";
            else if (p2.Contains("Cape"))
                p2 = "magic cape";

            Bitmap b = (Bitmap)Image.FromFile("Assets/" + p2 + ".png");
            b.MakeTransparent(Color.Fuchsia);
            i.image = b;
            items.Add(i);
        }

        public void save(string filename) {
        }
    }
}
