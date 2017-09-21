using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Constraints
    {
        private int _uniqueIdentity;

        public int UniqueID
        {
            get { return _uniqueIdentity; }
            set { _uniqueIdentity = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Constraints(int id, string name, string type)
        {
            _uniqueIdentity = id;
            _name = name;
            _type = type;
        }
    }
}
