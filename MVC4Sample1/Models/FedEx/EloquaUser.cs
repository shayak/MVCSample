using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4Sample1.Models.FedEx
{
    public class EloquaUser
    {
        public virtual int Id { get; protected set; }
        public virtual string ElqUrl { get; set; }
        public virtual string ElqUsername { get; set; }
        public virtual string ElqPassword { get; set; }
    }
}