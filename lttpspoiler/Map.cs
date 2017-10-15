using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

//just so it looks right
using Boss = lttpspoiler.Position;

namespace lttpspoiler {
    public class Map {

        public string name;
        public string displayName;

        public string filename;
        public string path;
        public string fullpath { get { return path + filename; } }

        public Image image;

        public List<Position> positions;
        public List<Boss> bosses;

        public event EventHandler mapLoaded;
        public event EventHandler mapSaved;

        public Map() {
            positions = new List<Position>();
            bosses = new List<Boss>();
        }

        public void load(string mapname) {
            using (StreamReader sr = new StreamReader(mapname)) {
                string ln = null;
                while ((ln = sr.ReadLine()) != null) {
                    ln = ln.Trim();
                    if (ln.StartsWith("#")) continue;

                    string[] tokens = ln.Split(',');
                    string t = tokens[0].ToUpper();
                    if (t.StartsWith("MAP")) {
                        FileInfo info = new FileInfo(mapname);
                        string tmp = info.FullName;
                        path = Path.GetDirectoryName(tmp) + @"\";
                        filename = Path.GetFileNameWithoutExtension(tmp) + ".png";
                        name = tokens[1].Trim();
                        displayName = tokens[2].Trim();
                        image = Image.FromFile(path + filename);
                    }
                    else if (t.StartsWith("POSITION")) {
                        //name, x, y
                        addPosition(tokens[1].Trim(), tokens[2].Trim(), tokens[3].Trim());
                    }
                    else if (t.StartsWith("BOSS")) {
                        //name, x, y
                        addBoss(tokens[1].Trim(), tokens[2].Trim(), tokens[3].Trim());
                    }
                    else if (t.StartsWith("ENTRANCE")) {
                        //name, x, y, mapName, entranceName
                        //addEntrance(tokens[1].Trim(), tokens[2].Trim(), tokens[3].Trim(), )
                    }
                }
            }
            fireMapLoaded();
        }

        private void addBoss(string bname, string px, string py) {
            Boss b = new Boss();
            b.name = bname;
            b.x = Convert.ToInt32(px);
            b.y = Convert.ToInt32(py);
            b.image = Image.FromFile("Assets/bosses/" + b.name + ".png");
            b.cached = true;
            bosses.Add(b);

        }

        private void addPosition(string pname, string px, string py) {
            Position p = new Position();
            p.name = pname.Replace("'", "");
            p.x = Convert.ToInt32(px);
            p.y = Convert.ToInt32(py);
            positions.Add(p);
        }

        private void fireMapLoaded() {
            if (mapLoaded != null) {
                mapLoaded(this, new EventArgs());
            }
        }

        public void save(string filename) {
            fireMapSaved();
        }

        private void fireMapSaved() {
            if (mapSaved != null) {
                mapSaved(this, new EventArgs());
            }
        }
    }
}
