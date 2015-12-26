using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideoDownloader
{
    class PlayListItems
    {
        public String kind { get; set; }
        public String etag { get; set; }
        public String id { get; set; }
        public ContentDetails contentDetails { get; set; }
    }
}
