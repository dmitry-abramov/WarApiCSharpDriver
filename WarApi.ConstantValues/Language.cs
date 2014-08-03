using System;
namespace WarApi.ConstantVlaues
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

        public static Language Korean { get { return new Language("ko"); } }

        public Language(string abbreviation)
        {
            Abbreviation = abbreviation;
        }

        public override string ToString()
        {
            return Abbreviation;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var language = obj as Language;

            if (language != null)
            {
                return string.Compare(this.Abbreviation, language.Abbreviation, StringComparison.InvariantCultureIgnoreCase) == 0;
            }

            return false;
        }
    }
}