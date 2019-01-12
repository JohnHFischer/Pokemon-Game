using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public class Item
    {
        public string name;      
        public string description;
        public Image[] itemImage = { Properties.Resources.boatImage, 
                                   Properties.Resources.exitImage, 
                                   Properties.Resources.healthPotion};
        public int x, y;
        public int imageNumber;
        public int price;
    
        public Item()
        {
        }

        public Item(string _name, string _description, Image[] _itemImage, int _imageNumber, int _x, int _y, int _price)
        {
            name = _name;          
            description = _description;
            itemImage = _itemImage;
            imageNumber = _imageNumber;
            x = _x;
            y = _y;
            price = _price;           
        }
    }
}
