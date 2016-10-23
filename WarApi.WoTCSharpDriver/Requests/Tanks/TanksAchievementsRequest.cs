namespace WarApi.Requests.Tanks
{
    /// <summary>
    /// Method returns list of achievements on all vehicles
    /// </summary>
    public class TanksAchievementsRequest : TanksRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "achievements";
            }
        }
    }
}
