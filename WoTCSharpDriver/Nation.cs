using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver
{
    public class Nation
    {
        public string Name { get; private set; }

        public Nation USSR { get { return new Nation("ussr"); } }

        public Nation Germany { get { return new Nation("germany"); } }

        public Nation USA { get { return new Nation("usa"); } }

        public Nation France { get { return new Nation("france"); } }

        public Nation GreatBritain { get { return new Nation("uk"); } }

        public Nation China { get { return new Nation("china"); } }

        public Nation Japan { get { return new Nation("japan"); } }

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
