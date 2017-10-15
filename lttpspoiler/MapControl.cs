using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Boss = lttpspoiler.Position;

namespace lttpspoiler {
    public partial class MapControl : UserControl {

        private Bitmap itemLayer, objectiveLayer, bossLayer, entranceLayer;
        public bool drawItems, drawObjectives, drawEnemies, drawEntrances;
        public Seed seed;
        public List<Map> maps;

        public event EventHandler mapChanged;
        public event EventHandler<MapAddedEventArgs> mapAdded;

        private int selectedIndex;

        private static Pen border = new Pen(Brushes.Gold, 2.0f);
        private static Pen objectiveBorder = new Pen(Brushes.Red, 2.0f);

        public int selectedMapIndex {
            get {
                return selectedIndex;
            }
            set {
                selectedIndex = value;
                fireMapChanged();
            }
        }

        public Map selectedMap {
            get {
                if (maps != null && maps.Count > selectedIndex && selectedIndex > -1) {
                    return maps[selectedIndex];
                }
                return null;
            }
        }

        public int getMapIndex(string displayName) {
            for(int i =0; i < maps.Count; i++) {
                if (displayName.Equals(maps[i].displayName)) {
                    return i;
                }
            }
            return -1;
        }

        private void fireMapChanged() {
            if (selectedMapIndex > -1 && selectedMapIndex < maps.Count) {
                this.AutoScrollMinSize = selectedMap.image.Size;
                createItemLayer();
                createBossLayer();
                createObjectiveLayer();
            }

            if (mapChanged != null) {
                mapChanged(this, new EventArgs());
            }
            Invalidate();
        }

        private void createBossLayer() {
            if (bossLayer != null) bossLayer.Dispose();
            if (selectedMap != null) {
                bossLayer = new Bitmap(selectedMap.image.Width, selectedMap.image.Height);
                Graphics g = Graphics.FromImage(bossLayer);
                g.Clear(Color.Transparent);
                foreach (Boss b in selectedMap.bosses) {
                    g.DrawRectangle(border, b.x - 16, b.y - 16, 64, 64);
                    g.DrawImage(b.image, b.x - 16, b.y - 16, 64, 64);
                }
                g.Dispose();
            }
        }

        private void createObjectiveLayer() {
            if (objectiveLayer != null) objectiveLayer.Dispose();
            if (selectedMap != null) {
                objectiveLayer = new Bitmap(selectedMap.image.Width, selectedMap.image.Height);
                Graphics g = Graphics.FromImage(objectiveLayer);
                g.Clear(Color.Transparent);
                foreach (Item i in seed.playthrough.objectives) {
                    foreach (Position p in selectedMap.positions) {
                        if (i.positionName.ToUpper().Equals(p.name.ToUpper())) {
                            g.DrawRectangle(objectiveBorder, p.x - 16, p.y - 16, 32, 32);
                            if (p.cached) {
                                int w = p.image.Width;
                                int h = p.image.Height;
                                int offseth = (int)(w / 2);
                                int offsetv = (int)(h / 2);
                                g.DrawImage(p.image, p.x - offseth, p.y - offsetv, w, h);
                            }
                        }
                    }
                }
                g.Dispose();
            }
        }

        private void createItemLayer() {
            if (itemLayer != null) itemLayer.Dispose();
            if (selectedMap != null) {
                itemLayer = new Bitmap(selectedMap.image.Width, selectedMap.image.Height);
                Graphics g = Graphics.FromImage(itemLayer);
                g.Clear(Color.Transparent);
                foreach (Position p in selectedMap.positions) {
                    g.DrawRectangle(border, p.x - 16, p.y - 16, 32, 32);
                    if (!p.cached) {
                        foreach (Item i in seed.items) {
                            if (i.positionName.ToUpper().Equals(p.name.ToUpper())) {
                                p.cached = true;
                                p.image = i.image;
                                break;
                            }
                        }
                    }
                    if (p.cached) {
                        int w = p.image.Width;
                        int h = p.image.Height;
                        int offseth = (int)(w / 2);
                        int offsetv = (int)(h / 2);
                        g.DrawImage(p.image, p.x - offseth, p.y - offsetv, w, h);
                    }
                }
                g.Dispose();
            }
        }



        public MapControl() {
            InitializeComponent();
            maps = new List<Map>();
            drawItems = drawObjectives = drawEnemies = drawEntrances = false;
            seed = new Seed();
            seed.seedLoaded += seed_seedLoaded;
            selectedIndex = -1;
        }

        private void seed_seedLoaded(object sender, EventArgs e) {
            foreach (Map m in maps) {
                foreach (Position p in m.positions) {
                    if (p.image != null)
                        p.image.Dispose();
                    p.cached = false;
                }
            }
            createItemLayer();
            createObjectiveLayer();
            Invalidate();
        }

        private bool dragging = false;
        private Cursor originalCursor;
        private Point previous;
        protected override void OnMouseDown(MouseEventArgs e) {
            if (!dragging) {
                dragging = true;
                previous = e.Location;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            if(dragging) {
                //not sure what i was doing wrong here, but it was f'ed
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e) {
            if(dragging)
                dragging = false;
            base.OnMouseUp(e);
        }
        protected override void OnMouseEnter(EventArgs e) {
            base.OnMouseEnter(e);
            originalCursor = this.Cursor;
            this.Cursor = Cursors.Hand;
        }
        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            this.Cursor = originalCursor;
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (selectedMap == null) return;
            int ax = this.AutoScrollPosition.X; int aw = selectedMap.image.Width;
            int ay = this.AutoScrollPosition.Y; int ah = selectedMap.image.Height;

            e.Graphics.Clear(SystemColors.Control);
            e.Graphics.DrawImage(selectedMap.image, ax, ay, aw, ah);
            if (drawItems) {
                e.Graphics.DrawImage(itemLayer, ax, ay, aw, ah);
            }
            if (drawEnemies) {
                e.Graphics.DrawImage(bossLayer, ax, ay, aw, ah);
            }
            if (drawObjectives) {
                e.Graphics.DrawImage(objectiveLayer, ax, ay, aw, ah);
            }
        }

        public void addMap(string file) {
            try {
                Map m = new Map();
                maps.Add(m);
                Debug.WriteLine("MapControl.addMap - loading map");
                m.load(file);
                Debug.WriteLine("MapControl.addMap " + m.displayName + " - loaded");
                fireMapAdded(m.displayName);
            }
            catch (Exception e) {
                Debug.WriteLine("MapControl.addMap " + e.Message);
            } 
        }

        private void fireMapAdded(string displayName) {
            if (mapAdded != null) {
                MapAddedEventArgs e = new MapAddedEventArgs();
                int i = getMapIndex(displayName);
                Map m = maps[i];
                e.map = m.displayName;
                e.index = i;
                mapAdded(this, e);
            }
        }
    }
}
