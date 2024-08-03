using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tube
{
    public class Station
    {
        //Declare variables
        private string name;
        private string id;
        private int zone;


        //Get and Set Methods       
        public Station(string a, string b, int c)
        {
            name = a;
            id = b;
            zone = c;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Zone
        {
            get { return zone; }
            set { zone = value; }
        }


        //ToString method
        public override string ToString()
        {

            string station = "name = " + name + ",id = " + id + ",zone = " + zone;

            return station;
        }

    }

}
