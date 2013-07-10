using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MVC4Sample1.Models.FedEx.Users;

namespace MVC4Sample1.Models.FedEx.Mappings
{
    public class EloquaUserMap : ClassMap<EloquaUser>
    {
        public EloquaUserMap()
        {
            Id(x => x.Id);
            Map(x => x.ElqUsername);
            Map(x => x.ElqPassword);
        }
    }
}