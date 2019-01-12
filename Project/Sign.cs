using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Sign
    {
        public int x;
        public int y;
        public string msg;
        public Image[] signImage = { Properties.Resources.sign, 
                                   Properties.Resources.trainerDown};
        public int imageNumber;

        public Sign()
        {
        }

        public Sign(int _x, int _y, string _msg, Image[] _signImage, int _imageNumber)
        {
            x = _x;
            y = _y;
            msg = _msg;
            signImage = _signImage;
            imageNumber = _imageNumber;
        }
    }
}
