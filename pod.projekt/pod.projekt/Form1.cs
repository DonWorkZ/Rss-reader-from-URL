using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL1;

namespace pod.projekt
{
    public partial class Form1 : Form
    {
        private static readonly Regex regex = new Regex(@"^\d+$");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new ListaKategorier();
            new ListaPodcasts();

            UppdateraPodcastListView();
            UpdateListCategories();
        }

        public void UppdateraPodcastListView()
        {
            lvPodcasts.Items.Clear();
            List<Podcast> podcasts = ListaPodcasts.returaPodcastLista();
            foreach(Podcast podcast in podcasts)
            {
                String[] row = { podcast.Avsnitt.ToString(), podcast.frekvens.ToString(), podcast.namn,podcast.kategori };
                ListViewItem listitem = new ListViewItem(row);
                lvPodcasts.Items.Add(listitem);
            }
        }

        public void UpdateListCategories()
        {
            List<Kategori> categories = ListaKategorier.hamtaKategoriLista();
            List<String> lbltext = new List<String>();
            this.lbKategori.Items.Clear();
            this.cbKategori.Items.Clear();
            for (int i = 0; i < categories.Count; i++)
            {
                this.lbKategori.Items.Add(categories[i].kategorier);
                this.cbKategori.Items.Add(categories[i].kategorier);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private async void lvCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvPodcasts.SelectedItems.Count > 0)
            {
                update_episode_list();
            }
            
        }

        private async void update_episode_list()
        {
            int index = lvPodcasts.Items.IndexOf(lvPodcasts.SelectedItems[0]);
            lbAvsnitt.Items.Clear();

            if (index > -1)
            {
                Podcast podcast = ListaPodcasts.returaPodcastLista()[index];
                List<String> array = await RSSLasare.getitems(podcast.URLn, podcast.kategori);
               
                foreach (String item in array)
                {
                    lbAvsnitt.Items.Add(item);
                }
            }

            
        }

        private async void btnNy_Click(object sender, EventArgs e)
        {
            if (!this.tbURL.Text.Equals(""))
            {
                int index = cbKategori.SelectedIndex;

                String Kategori = "";
                if(index >= 0)
                {
                    Kategori = ListaKategorier.hamtaKategoriLista()[index].kategorier;
                }

                int frequency = 0;

                if(regex.IsMatch(cbUpdate.Items[cbUpdate.SelectedIndex].ToString()))
                {
                    frequency = Int32.Parse(cbUpdate.Items[cbUpdate.SelectedIndex].ToString());
                }
               
                try
                {
                    int i = await RSSLasare.hamtaURL(this.tbURL.Text, frequency, Kategori);
                    UppdateraPodcastListView();

                }
                catch(Exception error)
                {
                    
                }
            }


        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNy2_Click(object sender, EventArgs e)
        {
            if (!this.tbKategori.Text.Equals(""))
            {
                Kategori category = new Kategori(this.tbKategori.Text);
                ListaKategorier.laggTillKategori(category);
                UpdateListCategories();
            }
        }

        private void btnTaBort2_Click(object sender, EventArgs e)
        {
            int index = this.lbKategori.SelectedIndex;
            if (index >= 0)
            {
                ListaKategorier.remoteKategori(index);
                UpdateListCategories();
            }
        }

        private void btnSpara2_Click(object sender, EventArgs e)
        {
            XMLdal.sparaListaKategorier();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            XMLdal.savepodcast();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            int index = lvPodcasts.Items.IndexOf(lvPodcasts.SelectedItems[0]);
            if (index > -1)
            {
                Podcast podcast = ListaPodcasts.returaPodcastLista()[index];
                ListaPodcasts.taBortPodcast(podcast.namn);
                UppdateraPodcastListView();
                lbAvsnitt.Items.Clear();
            }
            
        }
    }
}