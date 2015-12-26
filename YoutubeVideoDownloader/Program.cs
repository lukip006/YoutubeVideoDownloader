using System;
using System.IO;
//using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Web.Script.Serialization;
namespace YoutubeVideoDownloader
{
    class Program
    {
        static readonly String playlistID = "PL6n9fhu94yhWKHkcL7RJmmXyxkuFB3KSl";
        static readonly String apiKey = "AIzaSyAHZw_drnm_Rw58YdLWif1mKfWMeK48PzQ";        
        static readonly String partialUrl = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId={0}&key={1}&nextPageToken={2}";
        List<PlayList> playlist = null;
        static void Main(string[] args)
        {
            playlist = new List<PlayList>(); 
        }
        static String formURL(String partialURL,String playListID,String apiKey,String nextPageToken="")
        {
            return String.Format(partialURL, playListID, apiKey, nextPageToken);
        }
        static String GetResponseFromURL(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string s = reader.ReadToEnd();
            return s;
        }
        static List<PlayList> GetPlayListInfo(String nextPageToken = "")
        {
            String fullUrl = formURL(partialUrl, playlistID, apiKey, nextPageToken);
            String response=GetResponseFromURL(fullUrl);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            
            pl = serializer.Deserialize<PlayList>(response);
            //check if this has a next info.
            if (!String.IsNullOrEmpty(pl.nextPageToken))
            {
                GetResponseFromURL(pl.nextPageToken);
            }
            return pl;
        }

        
    }
}
