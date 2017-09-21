using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public static class DataSource
    {

        public static Constraints Get(string name)
        {
            return GetInformation().SingleOrDefault(x => x.Name.Equals(name));
        }
        public static List<Constraints> GetInformation()
        {
            Constraints data1 = new Constraints(456, "Mayfair", "Hotels");
            Constraints data2 = new Constraints(456, "Indigo", "Flights");
            Constraints data3 = new Constraints(456, "i20", "Cars");
            return (new List<Constraints>() { data1, data2, data3 });
        }
    }
}
