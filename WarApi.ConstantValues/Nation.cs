using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarApiCSharpDriver
{
    public class Nation
    {
        public string Name { get; private set; }

        public static Nation USSR { get { return new Nation("ussr"); } }

        public static Nation Germany { get { return new Nation("germany"); } }

        public static Nation USA { get { return new Nation("usa"); } }

        public static Nation France { get { return new Nation("france"); } }

        public static Nation GreatBritain { get { return new Nation("uk"); } }

        public static Nation China { get { return new Nation("china"); } }

        public static Nation Japan { get { return new Nation("japan"); } }

        protected Nation(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
