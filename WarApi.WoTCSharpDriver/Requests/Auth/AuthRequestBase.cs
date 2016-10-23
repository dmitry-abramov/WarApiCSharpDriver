namespace WarApi.Requests.Auth
{
    /// <summary>
    /// Base class for Authentification methods
    /// </summary>
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
