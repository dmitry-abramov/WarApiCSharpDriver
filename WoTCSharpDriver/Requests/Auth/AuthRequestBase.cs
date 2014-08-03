namespace WarApi.Requests.Auth
{
    public class AuthRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "auth";
            }
        }
    }
}
