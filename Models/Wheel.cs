using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slot_Machine.Models
{
    public class Wheel
    {
        public int WheelID { get; set; }
        public int Val1 { get; set; }
        public int Val2 { get; set; }
        public int Val3 { get; set; }
        public int Val4 { get; set; }

        public void SpinWheel(int wheel)
        {
            Random random = new Random();
            Val1 = Val2;
            Val2 = Val3;
            Val3 = Val4;
            Val4 = random.Next(1, 5);
        }
    }
}
