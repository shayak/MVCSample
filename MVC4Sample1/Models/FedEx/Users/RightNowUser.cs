using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4Sample1.Models.FedEx.Users
{
    public class RightNowUser
    {
        public virtual int Id { get; protected set; }
        public virtual string RnUrl { get; set; }
        public virtual string RnUsername { get; set; }
        public virtual string RnPassword { get; set; }
    }
}