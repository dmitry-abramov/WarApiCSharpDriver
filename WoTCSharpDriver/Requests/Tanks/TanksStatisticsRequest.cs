namespace WoTCSharpDriver.Requests.Tanks
{
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
