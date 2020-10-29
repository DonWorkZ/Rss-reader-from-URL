namespace pod.projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnNy = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.btnNy2 = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblAvsnitt2 = new System.Windows.Forms.Label();
            this.lblBeskrivning = new System.Windows.Forms.Label();
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.chAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 12;
            this.lbAvsnitt.Location = new System.Drawing.Point(9, 312);
            this.lbAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(402, 136);
            this.lbAvsnitt.TabIndex = 0;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(9, 297);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(149, 12);
            this.lblAvsnitt.TabIndex = 1;
            this.lblAvsnitt.Text = "Podcast #nr: Avsnitt #nr";
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbUpdate.Location = new System.Drawing.Point(171, 229);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(118, 20);
            this.cbUpdate.TabIndex = 2;
            this.cbUpdate.Text = "Var x minut";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(292, 229);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(118, 20);
            this.cbKategori.TabIndex = 3;
            this.cbKategori.Text = "Kategori";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(169, 214);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(131, 12);
            this.lblUpdate.TabIndex = 4;
            this.lblUpdate.Text = "Uppdateringsfrekvens:";
            this.lblUpdate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(290, 214);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(59, 12);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(11, 229);
            this.tbURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(154, 21);
            this.tbURL.TabIndex = 6;
            this.tbURL.Text = "http://...";
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(9, 214);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 12);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL:";
            // 
            // btnNy
            // 
            this.btnNy.Location = new System.Drawing.Point(166, 263);
            this.btnNy.Margin = new System.Windows.Forms.Padding(2);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(78, 18);
            this.btnNy.TabIndex = 8;
            this.btnNy.Text = "Ny...";
            this.btnNy.UseVisualStyleBackColor = true;
            this.btnNy.Click += new System.EventHandler(this.btnNy_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(249, 263);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(78, 18);
            this.btnSpara.TabIndex = 9;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(332, 263);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(78, 18);
            this.btnTaBort.TabIndex = 10;
            this.btnTaBort.Text = "Ta bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(628, 228);
            this.btnTaBort2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(78, 18);
            this.btnTaBort2.TabIndex = 13;
            this.btnTaBort2.Text = "Ta bort...";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            this.btnTaBort2.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(545, 228);
            this.btnSpara2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(78, 18);
            this.btnSpara2.TabIndex = 12;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            this.btnSpara2.Click += new System.EventHandler(this.btnSpara2_Click);
            // 
            // btnNy2
            // 
            this.btnNy2.Location = new System.Drawing.Point(463, 228);
            this.btnNy2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNy2.Name = "btnNy2";
            this.btnNy2.Size = new System.Drawing.Size(78, 18);
            this.btnNy2.TabIndex = 11;
            this.btnNy2.Text = "Ny...";
            this.btnNy2.UseVisualStyleBackColor = true;
            this.btnNy2.Click += new System.EventHandler(this.btnNy2_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(463, 200);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(242, 21);
            this.tbKategori.TabIndex = 14;
            this.tbKategori.Text = "Kategori";
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 12;
            this.lbKategori.Location = new System.Drawing.Point(463, 30);
            this.lbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(242, 160);
            this.lbKategori.TabIndex = 15;
            this.lbKategori.SelectedIndexChanged += new System.EventHandler(this.lbKategori_SelectedIndexChanged);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Location = new System.Drawing.Point(463, 11);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(71, 12);
            this.lblKategorier.TabIndex = 16;
            this.lblKategorier.Text = "Kategorier:";
            this.lblKategorier.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAvsnitt2
            // 
            this.lblAvsnitt2.AutoSize = true;
            this.lblAvsnitt2.Location = new System.Drawing.Point(463, 285);
            this.lblAvsnitt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnitt2.Name = "lblAvsnitt2";
            this.lblAvsnitt2.Size = new System.Drawing.Size(149, 12);
            this.lblAvsnitt2.TabIndex = 17;
            this.lblAvsnitt2.Text = "Podcast #nr: Avsnitt #nr";
            // 
            // lblBeskrivning
            // 
            this.lblBeskrivning.AutoSize = true;
            this.lblBeskrivning.Location = new System.Drawing.Point(463, 312);
            this.lblBeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(167, 12);
            this.lblBeskrivning.TabIndex = 18;
            this.lblBeskrivning.Text = "Beskrivning av avsnittet...";
            this.lblBeskrivning.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAvsnitt,
            this.chFrekvens,
            this.chNamn,
            this.chKategori});
            this.lvPodcasts.GridLines = true;
            this.lvPodcasts.HideSelection = false;
            this.lvPodcasts.Location = new System.Drawing.Point(11, 11);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(399, 179);
            this.lvPodcasts.TabIndex = 19;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            this.lvPodcasts.View = System.Windows.Forms.View.Details;
            this.lvPodcasts.SelectedIndexChanged += new System.EventHandler(this.lvCart_SelectedIndexChanged);
            // 
            // chAvsnitt
            // 
            this.chAvsnitt.Text = "Avsnitt";
            this.chAvsnitt.Width = 70;
            // 
            // chFrekvens
            // 
            this.chFrekvens.DisplayIndex = 2;
            this.chFrekvens.Text = "Frekvens";
            this.chFrekvens.Width = 182;
            // 
            // chNamn
            // 
            this.chNamn.DisplayIndex = 1;
            this.chNamn.Text = "Namn";
            this.chNamn.Width = 173;
            // 
            // chKategori
            // 
            this.chKategori.Text = "Kategori";
            this.chKategori.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 458);
            this.Controls.Add(this.lvPodcasts);
            this.Controls.Add(this.lblBeskrivning);
            this.Controls.Add(this.lblAvsnitt2);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.btnTaBort2);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnNy2);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnNy);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lbAvsnitt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ComboBox cbUpdate;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.Button btnNy2;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.ListBox lbKategori;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblAvsnitt2;
        private System.Windows.Forms.Label lblBeskrivning;
        private System.Windows.Forms.ListView lvPodcasts;
        private System.Windows.Forms.ColumnHeader chAvsnitt;
        private System.Windows.Forms.ColumnHeader chFrekvens;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.ColumnHeader chKategori;
    }
}

