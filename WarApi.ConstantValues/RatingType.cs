using System;

namespace WarApi.ConstantValues
{
    public class RatingType
    {
        public string Name { get; private set; }

        public static RatingType All { get { return new RatingType("all"); } }

        public static RatingType Type1 { get { return new RatingType("1"); } }

        public static RatingType Type7 { get { return new RatingType("7"); } }

        public static RatingType Type28 { get { return new RatingType("28"); } }

        public RatingType(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var ratingType = obj as RatingType;

            if (ratingType != null)
            {
                return string.Compare(this.Name, ratingType.Name, StringComparison.InvariantCultureIgnoreCase) == 0;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.ToLowerInvariant().GetHashCode();
        }

        // this implicit cast was created to use RatingType as dictionary key 
        public static implicit operator RatingType(string ratingType)
        {
            return new RatingType(ratingType);
        }
    }
}
