﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forums.Domain.Entities.User;
using static System.Collections.Specialized.BitVector32;

namespace Forums.BusinessLogic.DBModel
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=Forums")
        {
        }


        public virtual DbSet<Session> Sessions { get; set; }
    }
}
