using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Account
{
    /// <summary>
    /// Method returns partial list of players. 
    /// The list is filtered by initial characters of user name and sorted alphabetically
    /// </summary>
    public class PlayersListRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "list";
            }
        }

        [RequestParameter("search", true)]
        public string Search { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }

        public PlayersListRequest()
        {
            Limit = 100;
        }
    }
}
