namespace SeyahatAcentasi
{
    partial class Sefer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sefer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKalkisYeri = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tsAracCubugu = new System.Windows.Forms.ToolStrip();
            this.tsbYeni = new System.Windows.Forms.ToolStripButton();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbYenile = new System.Windows.Forms.ToolStripButton();
            this.tsTxtAra = new System.Windows.Forms.ToolStripTextBox();
            this.tsbAra = new System.Windows.Forms.ToolStripButton();
            this.tsbSil = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVarisYeri = new System.Windows.Forms.TextBox();
            this.dtpKalkisTarihSaati = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsAracCubugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 533);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kalkış Yeri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(204, 127);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(277, 29);
            this.txtAciklama.TabIndex = 4;
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.Location = new System.Drawing.Point(204, 170);
            this.txtKalkisYeri.Margin = new System.Windows.Forms.Padding(2);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.Size = new System.Drawing.Size(275, 29);
            this.txtKalkisYeri.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(131, 88);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 25);
            this.lblId.TabIndex = 6;
            // 
            // tsAracCubugu
            // 
            this.tsAracCubugu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.tsAracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbYeni,
            this.tsbKaydet,
            this.tsbYenile,
            this.tsTxtAra,
            this.tsbAra,
            this.tsbSil});
            this.tsAracCubugu.Location = new System.Drawing.Point(0, 0);
            this.tsAracCubugu.Name = "tsAracCubugu";
            this.tsAracCubugu.Size = new System.Drawing.Size(913, 38);
            this.tsAracCubugu.TabIndex = 7;
            // 
            // tsbYeni
            // 
            this.tsbYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbYeni.Image")));
            this.tsbYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYeni.Name = "tsbYeni";
            this.tsbYeni.Size = new System.Drawing.Size(40, 32);
            this.tsbYeni.Text = "Yeni";
            this.tsbYeni.Click += new System.EventHandler(this.tsbYeni_Click);
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbKaydet.Image")));
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Size = new System.Drawing.Size(40, 32);
            this.tsbKaydet.Text = "Kaydet";
            this.tsbKaydet.Click += new System.EventHandler(this.tsbKaydet_Click);
            // 
            // tsbYenile
            // 
            this.tsbYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYenile.Image = ((System.Drawing.Image)(resources.GetObject("tsbYenile.Image")));
            this.tsbYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYenile.Name = "tsbYenile";
            this.tsbYenile.Size = new System.Drawing.Size(40, 32);
            this.tsbYenile.Text = "Yenile";
            this.tsbYenile.Click += new System.EventHandler(this.tsbYenile_Click);
            // 
            // tsTxtAra
            // 
            this.tsTxtAra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtAra.Name = "tsTxtAra";
            this.tsTxtAra.Size = new System.Drawing.Size(200, 38);
            // 
            // tsbAra
            // 
            this.tsbAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAra.Image = ((System.Drawing.Image)(resources.GetObject("tsbAra.Image")));
            this.tsbAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAra.Name = "tsbAra";
            this.tsbAra.Size = new System.Drawing.Size(40, 32);
            this.tsbAra.Text = "Ara";
            this.tsbAra.Click += new System.EventHandler(this.tsbAra_Click);
            // 
            // tsbSil
            // 
            this.tsbSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbSil.Image")));
            this.tsbSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSil.Name = "tsbSil";
            this.tsbSil.Size = new System.Drawing.Size(40, 32);
            this.tsbSil.Text = "Sil";
            this.tsbSil.Click += new System.EventHandler(this.tsbSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Varış Yeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kalkış Tarih Saati";
            // 
            // txtVarisYeri
            // 
            this.txtVarisYeri.Location = new System.Drawing.Point(204, 218);
            this.txtVarisYeri.Name = "txtVarisYeri";
            this.txtVarisYeri.Size = new System.Drawing.Size(277, 29);
            this.txtVarisYeri.TabIndex = 10;
            // 
            // dtpKalkisTarihSaati
            // 
            this.dtpKalkisTarihSaati.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpKalkisTarihSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKalkisTarihSaati.Location = new System.Drawing.Point(206, 268);
            this.dtpKalkisTarihSaati.Name = "dtpKalkisTarihSaati";
            this.dtpKalkisTarihSaati.Size = new System.Drawing.Size(274, 29);
            this.dtpKalkisTarihSaati.TabIndex = 11;
            // 
            // Sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 879);
            this.Controls.Add(this.dtpKalkisTarihSaati);
            this.Controls.Add(this.txtVarisYeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsAracCubugu);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtKalkisYeri);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sefer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsAracCubugu.ResumeLayout(false);
            this.tsAracCubugu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKalkisYeri;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ToolStrip tsAracCubugu;
        private System.Windows.Forms.ToolStripButton tsbYeni;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripButton tsbYenile;
        private System.Windows.Forms.ToolStripButton tsbAra;
        private System.Windows.Forms.ToolStripButton tsbSil;
        private System.Windows.Forms.ToolStripTextBox tsTxtAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVarisYeri;
        private System.Windows.Forms.DateTimePicker dtpKalkisTarihSaati;
    }
}