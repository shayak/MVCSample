using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace MVC4Sample1.Models.FedEx.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            HasOne(x => x.RightNowId);
            HasOne(x => x.EloquaId);
        }
    }
}