using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC4Sample1.Models.FedEx;
using FluentNHibernate.Mapping;

namespace MVC4Sample1.Models.FedEx.Mappings
{
    public class ScheduleMap : ClassMap<Schedule>
    {
        public ScheduleMap()
        {
            Id(x => x.Id);
            Map(x => x.IntervalInMinutes);
            Map(x => x.NextRunTime);
        }
    }
}