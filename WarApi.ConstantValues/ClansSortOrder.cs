using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarApi.ConstantVlaues
{
    public class ClansSortOrder
    {
        public string OrderBy { get; private set; }

        public static ClansSortOrder ByName { get { return new ClansSortOrder("name"); } }

        public static ClansSortOrder ByNameDesc { get { return new ClansSortOrder("-name"); } }

        public static ClansSortOrder ByMembersCount { get { return new ClansSortOrder("members_count"); } }

        public static ClansSortOrder ByMembersCountDesc { get { return new ClansSortOrder("-members_count"); } }

        public static ClansSortOrder ByCreationDate { get { return new ClansSortOrder("created_at"); } }

        public static ClansSortOrder ByCreationDateDesc { get { return new ClansSortOrder("-created_at"); } }

        public static ClansSortOrder ByAbbreviation { get { return new ClansSortOrder("abbreviation"); } }

        public static ClansSortOrder ByAbbreviationDesc { get { return new ClansSortOrder("-abbreviation"); } }

        public ClansSortOrder(string orderBy)
        {
            OrderBy = orderBy;
        }

        public override string ToString()
        {
            return OrderBy;
        }
    }
}
