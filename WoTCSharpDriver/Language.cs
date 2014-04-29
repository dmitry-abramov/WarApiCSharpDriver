using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver
{
    public class Language
    {
        public string Abbreviation { get; private set; }

        public static Language English { get { return new Language("en"); } }

        public static Language Russian { get { return new Language("ru"); } }

        public static Language Polish { get { return new Language("pl"); } }

        public static Language German { get { return new Language("de"); } }

        public static Language Spanish { get { return new Language("es"); } }

        public static Language French { get { return new Language("fr"); } }

        public static Language Chinese { get { return new Language("zh-cn"); } }

        public static Language Turkish { get { return new Language("tr"); } }

        public static Language Czech { get { return new Language("cs"); } }

        public static Language Thailand { get { return new Language("th"); } }

        public static Language Vietnamese { get { return new Language("vi"); } }

        public Language Korean { get { return new Language("ko"); } }

        protected Language(string abbreviation)
        {
            Abbreviation = abbreviation;
        }

        public override string ToString()
        {
            return Abbreviation;
        }
    }
}