using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class ToolsContext : DbContext
    {
        public ToolsContext() : base("ToolsDB")
        {

        }

        public virtual DbSet<Tool> Tools { get; set; }
    }
}