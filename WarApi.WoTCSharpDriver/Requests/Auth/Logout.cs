namespace WarApi.Requests.Auth
{
    /// <summary>
    /// Method deletes user's access_token
    /// </summary>
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
