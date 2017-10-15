using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lttpspoiler {
    public partial class MainFrame : Form {
        public MainFrame() {
            InitializeComponent();
            mapControl.mapChanged += mapControl_mapChanged;
            mapControl.mapAdded += mapControl_mapAdded;
            loadButton.Click += loadButton_Click;
            mapControl.drawItems = itemsCheck.Checked;
            mapControl.drawEnemies = enemiesCheck.Checked;
            mapControl.drawObjectives = objectivesCheck.Checked;
            fixButton("hammer", find1);
            fixButton("hookshot", find2);
            fixButton("moon pearl", find3);
            fixButton("magic mirror", find4);
            fixButton("progressive glove", find5);
        }

        private void fixButton(string v, Button button) {
            Bitmap b = (Bitmap)Image.FromFile("Assets/" + v + ".png");
            b.MakeTransparent(Color.Fuchsia);
            button.Image = b;
        }

        private void loadButton_Click(object sender, EventArgs e) {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK) {
                mapControl.seed.load(d.FileName);
            }
            
        }

        private void mapControl_mapAdded(object sender, MapAddedEventArgs e) {
            mapSelector.Items.Add(e.map);            
        }

        private void mapControl_mapChanged(object sender, EventArgs e) {
            if (mapControl.selectedMapIndex != -1) {
                mapSelector.SelectedIndex = mapControl.selectedMapIndex;
            }
        }


        private void MainFrame_Load(object sender, EventArgs e) {
            DirectoryInfo files = new DirectoryInfo("Assets/maps");
            FileInfo[] f = files.GetFiles("*.map");
            foreach (FileInfo s in f) {
                mapControl.addMap(s.FullName);
                Debug.WriteLine("MainFrame_Load " + s.FullName);
            }
            mapSelector.SelectedIndex = 0;
            if (Location.X > SystemInformation.VirtualScreen.Width
                || Location.Y > SystemInformation.VirtualScreen.Height) {
                SetBounds(0, 0, 100, 100);
            }
            SetBounds(100, 100, 500, 400);
        }

        private void LayerState_Changed(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            string tag = ((string)cb.Tag).ToLower();
            if (tag.Equals("items")) {
                mapControl.drawItems = !mapControl.drawItems;
            }
            else if(tag.Equals("enemies")) {
                mapControl.drawEnemies = !mapControl.drawEnemies;
            }
            else if(tag.Equals("objectives")) {
                mapControl.drawObjectives = !mapControl.drawObjectives;
            }
            mapControl.Invalidate();
        }

        private void mapSelector_SelectedIndexChanged(object sender, EventArgs e) {
            if (mapSelector.SelectedIndex < 0) return;
             mapControl.selectedMapIndex = mapSelector.SelectedIndex;
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void MainFrame_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //only the first one
            if (files.Length > 0) {
                mapControl.seed.load(files[0]);
            }
        }

        private void MainFrame_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void about_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(mapControl.seed.difficulty)) {
                About a = new About();
                a.diff.Text = mapControl.seed.difficulty;
                a.logic.Text = mapControl.seed.logic;
                a.seed.Text = mapControl.seed.seed;
                a.goal.Text = mapControl.seed.goal;
                a.build.Text = mapControl.seed.build.ToShortDateString();
                a.mode.Text = mapControl.seed.mode;
                a.ShowDialog();
            }
            else {
                About a = new About();
                a.ShowDialog();
            }
        }

        private void find_Click(object sender, EventArgs e) {
            Button b = sender as Button;
        }
    }
}
