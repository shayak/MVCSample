using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4Sample1.Models.FedEx
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual int EloquaId { get; set; }
        public virtual int RightNowId { get; set; }
    }
}