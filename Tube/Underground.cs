using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tube
{
    public class Underground
    {

        //Declaring Dictionary
        private Dictionary<string, Station> underground = new Dictionary<string, Station>();

        //Adds station to the dictionary
        public void AddStation(Station station)
        {
            underground[station.ID] = station;
        }

        //Returns station object based on the station id 
        public Station returnStation(string id)
        {
            if (underground.ContainsKey(id))
            {
                return underground[id];
            }
            return null;
        }


        //Find function, finds the station class and returns it based on the id
        public string find(string id)
        {
            if(underground.TryGetValue(id, out var station))
            {
                return station.ToString();
            }
            return ("Station not found");
        }

        //Underground ToString Method
        public override string ToString()
        {
            //Set blank string
            string stationValues = "";
            //Loop through underground
            foreach (var i in underground)
            {
                //Overwrite blank string with station ToString method.
                stationValues = stationValues + i.Value.ToString() + "\n";
            }

            //Return Station found
            return stationValues;
        }
    }
}
