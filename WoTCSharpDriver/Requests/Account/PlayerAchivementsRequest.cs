﻿using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Account
{
    public class PlayerAchivementsRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "achivements";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }
    }
}
