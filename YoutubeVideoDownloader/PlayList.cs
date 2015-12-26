using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideoDownloader
{
    class PlayList
    {
        public String kind { get; set; }
        public String etag { get; set; }
        public string nextPageToken { get; set; }
        public PageInfo pageInfo { get; set; }        
        public List<PlayListItems> items { get; set; }
    }
}
