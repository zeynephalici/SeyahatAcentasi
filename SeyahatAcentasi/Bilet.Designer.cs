namespace SeyahatAcentasi
{
    partial class Bilet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tsAracCubugu = new System.Windows.Forms.ToolStrip();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbYenile = new System.Windows.Forms.ToolStripButton();
            this.tsTxtAra = new System.Windows.Forms.ToolStripTextBox();
            this.tsbAra = new System.Windows.Forms.ToolStripButton();
            this.tsbSil = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSeferGrid = new System.Windows.Forms.ComboBox();
            this.lblBiletSatisTarihSaati = new System.Windows.Forms.Label();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYolcuAdi = new System.Windows.Forms.TextBox();
            this.txtYolcuSoyadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSefer = new System.Windows.Forms.ComboBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsAracCubugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 283);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sefer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Koltuk No";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(111, 48);
            this.lblId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 6;
            // 
            // tsAracCubugu
            // 
            this.tsAracCubugu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.tsAracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbKaydet,
            this.tsbYenile,
            this.tsTxtAra,
            this.tsbAra,
            this.tsbSil});
            this.tsAracCubugu.Location = new System.Drawing.Point(0, 0);
            this.tsAracCubugu.Name = "tsAracCubugu";
            this.tsAracCubugu.Size = new System.Drawing.Size(498, 35);
            this.tsAracCubugu.TabIndex = 7;
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbKaydet.Image")));
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Size = new System.Drawing.Size(32, 32);
            this.tsbKaydet.Text = "Kaydet";
            this.tsbKaydet.Click += new System.EventHandler(this.tsbKaydet_Click);
            // 
            // tsbYenile
            // 
            this.tsbYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYenile.Image = ((System.Drawing.Image)(resources.GetObject("tsbYenile.Image")));
            this.tsbYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYenile.Name = "tsbYenile";
            this.tsbYenile.Size = new System.Drawing.Size(32, 32);
            this.tsbYenile.Text = "Yenile";
            this.tsbYenile.Click += new System.EventHandler(this.tsbYenile_Click);
            // 
            // tsTxtAra
            // 
            this.tsTxtAra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtAra.Name = "tsTxtAra";
            this.tsTxtAra.Size = new System.Drawing.Size(111, 35);
            // 
            // tsbAra
            // 
            this.tsbAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAra.Image = ((System.Drawing.Image)(resources.GetObject("tsbAra.Image")));
            this.tsbAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAra.Name = "tsbAra";
            this.tsbAra.Size = new System.Drawing.Size(32, 32);
            this.tsbAra.Text = "Ara";
            this.tsbAra.Click += new System.EventHandler(this.tsbAra_Click);
            // 
            // tsbSil
            // 
            this.tsbSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbSil.Image")));
            this.tsbSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSil.Name = "tsbSil";
            this.tsbSil.Size = new System.Drawing.Size(32, 32);
            this.tsbSil.Text = "Sil";
            this.tsbSil.Click += new System.EventHandler(this.tsbSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bilet Kesim Zamanı ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilet Seri No";
            // 
            // cbSeferGrid
            // 
            this.cbSeferGrid.FormattingEnabled = true;
            this.cbSeferGrid.Location = new System.Drawing.Point(334, 248);
            this.cbSeferGrid.Margin = new System.Windows.Forms.Padding(2);
            this.cbSeferGrid.Name = "cbSeferGrid";
            this.cbSeferGrid.Size = new System.Drawing.Size(153, 21);
            this.cbSeferGrid.TabIndex = 12;
            this.cbSeferGrid.SelectedIndexChanged += new System.EventHandler(this.cbSeferGrid_SelectedIndexChanged);
            // 
            // lblBiletSatisTarihSaati
            // 
            this.lblBiletSatisTarihSaati.AutoSize = true;
            this.lblBiletSatisTarihSaati.Location = new System.Drawing.Point(108, 120);
            this.lblBiletSatisTarihSaati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiletSatisTarihSaati.Name = "lblBiletSatisTarihSaati";
            this.lblBiletSatisTarihSaati.Size = new System.Drawing.Size(0, 13);
            this.lblBiletSatisTarihSaati.TabIndex = 14;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(111, 144);
            this.txtSeriNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(153, 20);
            this.txtSeriNo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yolcu Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yolcu Soyadı";
            // 
            // txtYolcuAdi
            // 
            this.txtYolcuAdi.Location = new System.Drawing.Point(111, 174);
            this.txtYolcuAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYolcuAdi.Name = "txtYolcuAdi";
            this.txtYolcuAdi.Size = new System.Drawing.Size(153, 20);
            this.txtYolcuAdi.TabIndex = 18;
            // 
            // txtYolcuSoyadi
            // 
            this.txtYolcuSoyadi.Location = new System.Drawing.Point(111, 202);
            this.txtYolcuSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYolcuSoyadi.Name = "txtYolcuSoyadi";
            this.txtYolcuSoyadi.Size = new System.Drawing.Size(153, 20);
            this.txtYolcuSoyadi.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sefer";
            // 
            // cbSefer
            // 
            this.cbSefer.FormattingEnabled = true;
            this.cbSefer.Location = new System.Drawing.Point(111, 70);
            this.cbSefer.Name = "cbSefer";
            this.cbSefer.Size = new System.Drawing.Size(153, 21);
            this.cbSefer.TabIndex = 21;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(111, 97);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(153, 20);
            this.txtKoltukNo.TabIndex = 22;
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 476);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.cbSefer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYolcuSoyadi);
            this.Controls.Add(this.txtYolcuAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.lblBiletSatisTarihSaati);
            this.Controls.Add(this.cbSeferGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsAracCubugu);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Bilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet";
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
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ToolStrip tsAracCubugu;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripButton tsbYenile;
        private System.Windows.Forms.ToolStripButton tsbAra;
        private System.Windows.Forms.ToolStripButton tsbSil;
        private System.Windows.Forms.ToolStripTextBox tsTxtAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSeferGrid;
        private System.Windows.Forms.Label lblBiletSatisTarihSaati;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYolcuAdi;
        private System.Windows.Forms.TextBox txtYolcuSoyadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSefer;
        private System.Windows.Forms.TextBox txtKoltukNo;
    }
}