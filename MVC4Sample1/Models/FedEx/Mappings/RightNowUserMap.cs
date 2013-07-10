using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace MVC4Sample1.Models.FedEx.Mappings
{
    public class RightNowUserMap : ClassMap<RightNowUser>
    {
        public RightNowUserMap()
        {
            Id(x => x.Id);
            Map(x => x.RnUsername);
            Map(x => x.RnPassword);
        }
    }
}