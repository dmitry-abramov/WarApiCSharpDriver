namespace WarApi.CodeGenerator.Models.Api
{
    public class RequestParameter
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public bool IsRequired { get; set; }
    }
}