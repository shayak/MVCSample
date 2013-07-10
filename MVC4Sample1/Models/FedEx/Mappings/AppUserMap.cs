using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MVC4Sample1.Models.FedEx.Users;

namespace MVC4Sample1.Models.FedEx.Mappings
{
    public class AppUserMap : ClassMap<AppUser>
    {
        public AppUserMap()
        {
            Id(x => x.Id);
            HasOne(x => x.RightNowId);
            HasOne(x => x.EloquaId);
        }
    }
}