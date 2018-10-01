using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class Videos
    {
        int iD;
        private string name;

        public string Name { get { return name; } set => name = value; }

        public string UrlVideo { get { return urlVideo; } set => urlVideo = value; }

        public int ID { get => iD; set => iD = value; }

        private string urlVideo;

    }
}