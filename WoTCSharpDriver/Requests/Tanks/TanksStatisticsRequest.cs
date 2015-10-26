namespace WarApi.Requests.Tanks
{
    /// <summary>
    /// Method returns overall statistics, Tank Company statistics, 
    /// and clan statistics per each vehicle for each user
    /// </summary>
    public class TanksStatisticsRequest : TanksRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "stats";
            }
        }
    }
}
