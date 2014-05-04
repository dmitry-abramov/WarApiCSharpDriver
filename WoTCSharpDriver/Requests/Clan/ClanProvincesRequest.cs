﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClanProvincesRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "provinces";
            }
        }

        [RequestParameter("clan_id", true)]
        public string ClanId { get; set; }
    }
}