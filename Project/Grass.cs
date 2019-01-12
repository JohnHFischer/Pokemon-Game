using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Grass
    {
        public int x;
        public int y;
        public int level;


        public Image grassImage = Properties.Resources.grass;

        public Grass()
        {
        }

        public Grass(int _x, int _y, Image _grassImage, int _level)
        {
            x = _x;
            y = _y;
            grassImage = _grassImage;
            level = _level;
        }
    }
}
