using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace lttpspoiler {
    public class Item {
        public string name;
        public string positionName;
        public Image image;

        public Item() {
            image = new Bitmap(1, 1);
        }
    }
}
