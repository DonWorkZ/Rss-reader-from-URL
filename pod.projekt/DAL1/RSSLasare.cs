using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL1
{
    public  class RSSLasare
    {
        public static async Task<int> hamtaRss(string url)
        {

            using (XmlReader xReader = XmlReader.Create(url))
            {
                int i = 0;
                SyndicationFeed feed = SyndicationFeed.Load(xReader);
                foreach (SyndicationItem item in feed.Items)
                {
                    i++;
                }
                return i;
            }
        }
        
        public static async Task<int> hamtaURL(string url, int frekvens, string kategori)
        {
            using (XmlReader xReader = XmlReader.Create(url))
            {
                int i = 0; int count = 0;
                SyndicationFeed feed = SyndicationFeed.Load(xReader);

                foreach(SyndicationItem item in feed.Items)
                {
                    count++;
                    List<String> categoryarray = new List<String>();
                    foreach(SyndicationCategory itemcategory in item.Categories)
                    {
                        categoryarray.Add(itemcategory.Name);
                    }

                    if(kategori.Equals("") || categoryarray.IndexOf(kategori) > -1)
                    {
                        i++;
                    }
                }

                Podcast podcast = new Podcast(url, i, feed.Title.Text, frekvens, kategori);

                ListaPodcasts.laggTillPodd(podcast);
                XMLdal.savepodcast();

                return 0;
            }
        }
        
        public static async Task<List<String>> getitems(String url, string kategori)
        {
            List<String> items = new List<String>();

            using (XmlReader xReader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(xReader);

                foreach (SyndicationItem item in feed.Items)
                {
                    List<String> categoryarray = new List<String>();
                    foreach (SyndicationCategory itemcategory in item.Categories)
                    {
                        categoryarray.Add(itemcategory.Name);
                    }

                    if (kategori.Equals("") || categoryarray.IndexOf(kategori) > -1)
                    {
                        items.Add(item.Title.Text);
                    }
                }
                return items;
            }
            
        }
    }
}
