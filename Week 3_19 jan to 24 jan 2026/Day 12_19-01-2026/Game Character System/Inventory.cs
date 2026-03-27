using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System
{
    internal class Inventory
    {
        public List<string> Items = new List<string>();

        public void AddItem(string item)
        {
            Items.Add(item);
        }
    }
}
