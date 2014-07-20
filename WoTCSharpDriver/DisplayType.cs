namespace WarApiCSharpDriver
{
    public class DisplayType
    {
        public string TypeName { get; private set; }

        public static DisplayType Page { get { return new DisplayType("page"); } }

        public static DisplayType Popup { get { return new DisplayType("popup"); } }

        protected DisplayType(string typeName)
        {
            TypeName = typeName;
        }

        public override string ToString()
        {
            return TypeName;
        }
    }
}
