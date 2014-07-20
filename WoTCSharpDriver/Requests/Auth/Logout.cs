namespace WarApiCSharpDriver.Requests.Auth
{
    public class Logout : AuthRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "logout";
            }
        }
    }
}
