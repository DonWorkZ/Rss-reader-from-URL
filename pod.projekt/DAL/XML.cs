using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using model;


namespace DAL
{
    public class XML
    {
        public void Serialize(List<Podcast> podcastList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
            using (FileStream outFile = new FileStream("podcast.xml", FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, podcastList);
            }
        }

        public List<Podcast> Deserialize()
        {
            List<Podcast> listOfPodcastToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream inFile = new FileStream("podcast.xml", FileMode.Open, FileAccess.Read))
            {
                listOfPodcastToBeReturned = (List<Podcast>)xmlSerializer.Deserialize(inFile);
            }
            return listOfPodcastToBeReturned;
        }
    }
}
}
