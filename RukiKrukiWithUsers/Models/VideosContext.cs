using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class VideosContext:DbContext
    {
        public VideosContext() : base("VideosDB")
        {

        }

        public virtual DbSet<Videos> AllVideos { get; set; }
    }
}