using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Mart
    {
        public int x;
        public int y;
        public Image martImage = Properties.Resources.mart;

        public Mart()
        {
        }

        public Mart(int _x, int _y, Image _martImage)
        {
            x = _x;
            y = _y;
            martImage = _martImage;
        }
    }
}
