using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    public class ListaPodcasts
    {
        private static List<Podcast> podcastListor { get; set; }

        public ListaPodcasts()
        {
            podcastListor = XMLdal.getpodcast();
        }

        public static void laggTillPodd(Podcast podcast)
        {
            podcastListor.Add(podcast);
        }

        public static List<Podcast> returaPodcastLista()
        {
            return podcastListor;
        }


        public static void taBortPodcast(string podcastNamn)
        {
            podcastListor.RemoveAll(podcast => podcast.PodcastNamn.Equals(podcastNamn));
            XMLdal.savepodcast();
        }
    }
}
