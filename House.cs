using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class House
    {
        public int x;
        public int y;
        Image[] houseImage = { Properties.Resources.houseSmall, 
                                   Properties.Resources.houseWide};

        public int houseNumber;
        public House()
        {
        }

        public House(int _x, int _y, Image[] _houseImage, int _houseNumber)
        {
            x = _x;
            y = _y;
            houseImage = _houseImage;
            houseNumber = _houseNumber;
        }
    }
}
