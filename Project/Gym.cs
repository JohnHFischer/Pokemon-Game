using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Gym
    {
        public int x;
        public int y;
        Image[] gymImage = { Properties.Resources.gymOneImage, 
                                   Properties.Resources.gymTwoImage, 
                                   Properties.Resources.gymThreeImage, 
                                   Properties.Resources.gymFourImage, 
                                   Properties.Resources.gymFiveImage, 
                                   Properties.Resources.gymSixImage};
        public int gymNumber;
        public Gym()
        {
        }

        public Gym(int _x, int _y, Image [] _gymImage, int _gymNumber)
        {
            x = _x;
            y = _y;
            gymImage = _gymImage;
            gymNumber = _gymNumber;
        }
    }
}
