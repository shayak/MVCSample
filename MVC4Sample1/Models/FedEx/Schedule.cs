using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4Sample1.Models.FedEx
{
    public class Schedule
    {
        public virtual int Id { get; protected set; }
        public virtual int IntervalInMinutes { get; set; }
        public virtual DateTime NextRunTime { get; set; }
    }
}