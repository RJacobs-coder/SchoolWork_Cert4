using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT1._2Programming2_DroneStorage
{
    class Drone
    {
        // Private values to enable the need for setters and getters.
        private string engineConfiguation;
        private string range;
        private string accessories;
        private string price;
        
        // Getters and setters to allow use of values above.
        public string gsEngine
        {
           
            get { return engineConfiguation;}
            set { engineConfiguation = value; }

        }

        public string gsRange
        {
            get { return range; }
            set { range = value; }

        }
        public string gsAccessories
        {
            get { return accessories; }
            set { accessories = value; }

        }
        public string gsPrice
        {
            get { return price; }
            set { price = value; }

        }

        // Method to combine all values into a single string for main method to call.
        public string combinestring ()
        {
           string value = "Engine config - " + gsEngine + " Range - " + gsRange + " Accessories - "+ gsAccessories + " Price - " + gsPrice;
            return value; 
        }
        
    }
}
