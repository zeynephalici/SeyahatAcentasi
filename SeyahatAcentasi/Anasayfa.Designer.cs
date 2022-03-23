namespace SeyahatAcentasi
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.msSeyahatAcentesi = new System.Windows.Forms.MenuStrip();
            this.tsmiNesneIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSefer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBilet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeferRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOturum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOturumuSonlandir = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsmiBiletRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.msSeyahatAcentesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // msSeyahatAcentesi
            // 
            this.msSeyahatAcentesi.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.msSeyahatAcentesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNesneIslemleri,
            this.tsmiRapor,
            this.tsmiOturum});
            this.msSeyahatAcentesi.Location = new System.Drawing.Point(0, 0);
            this.msSeyahatAcentesi.Name = "msSeyahatAcentesi";
            this.msSeyahatAcentesi.Size = new System.Drawing.Size(801, 28);
            this.msSeyahatAcentesi.TabIndex = 0;
            this.msSeyahatAcentesi.Text = "MenuStrip";
            // 
            // tsmiNesneIslemleri
            // 
            this.tsmiNesneIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSefer,
            this.tsmiBilet,
            this.tsmiKullanici});
            this.tsmiNesneIslemleri.Name = "tsmiNesneIslemleri";
            this.tsmiNesneIslemleri.Size = new System.Drawing.Size(124, 24);
            this.tsmiNesneIslemleri.Text = "&Nesne İşlemleri";
            // 
            // tsmiSefer
            // 
            this.tsmiSefer.Name = "tsmiSefer";
            this.tsmiSefer.Size = new System.Drawing.Size(148, 26);
            this.tsmiSefer.Text = "&Sefer";
            this.tsmiSefer.Click += new System.EventHandler(this.tsmiSefer_Click);
            // 
            // tsmiBilet
            // 
            this.tsmiBilet.Name = "tsmiBilet";
            this.tsmiBilet.Size = new System.Drawing.Size(148, 26);
            this.tsmiBilet.Text = "&Bilet";
            this.tsmiBilet.Click += new System.EventHandler(this.tsmiBilet_Click);
            // 
            // tsmiKullanici
            // 
            this.tsmiKullanici.Name = "tsmiKullanici";
            this.tsmiKullanici.Size = new System.Drawing.Size(148, 26);
            this.tsmiKullanici.Text = "&Kullanıcı";
            this.tsmiKullanici.Click += new System.EventHandler(this.tsmiKullanici_Click);
            // 
            // tsmiRapor
            // 
            this.tsmiRapor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeferRapor,
            this.tsmiBiletRapor});
            this.tsmiRapor.Name = "tsmiRapor";
            this.tsmiRapor.Size = new System.Drawing.Size(63, 24);
            this.tsmiRapor.Text = "&Rapor";
            // 
            // tsmiSeferRapor
            // 
            this.tsmiSeferRapor.Name = "tsmiSeferRapor";
            this.tsmiSeferRapor.Size = new System.Drawing.Size(224, 26);
            this.tsmiSeferRapor.Text = "Sefer Raporu";
            this.tsmiSeferRapor.Click += new System.EventHandler(this.tsmiSeferRapor_Click);
            // 
            // tsmiOturum
            // 
            this.tsmiOturum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSifreDegistir,
            this.tsmiOturumuSonlandir});
            this.tsmiOturum.Name = "tsmiOturum";
            this.tsmiOturum.Size = new System.Drawing.Size(73, 24);
            this.tsmiOturum.Text = "Oturum";
            // 
            // tsmiSifreDegistir
            // 
            this.tsmiSifreDegistir.Name = "tsmiSifreDegistir";
            this.tsmiSifreDegistir.Size = new System.Drawing.Size(217, 26);
            this.tsmiSifreDegistir.Text = "Şifre Değiştir";
            this.tsmiSifreDegistir.Click += new System.EventHandler(this.tsmiSifreDegistir_Click);
            // 
            // tsmiOturumuSonlandir
            // 
            this.tsmiOturumuSonlandir.Name = "tsmiOturumuSonlandir";
            this.tsmiOturumuSonlandir.Size = new System.Drawing.Size(217, 26);
            this.tsmiOturumuSonlandir.Text = "Oturumu Sonlandır";
            this.tsmiOturumuSonlandir.Click += new System.EventHandler(this.tsmiOturumuSonlandir_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip.Location = new System.Drawing.Point(0, 377);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // tsmiBiletRapor
            // 
            this.tsmiBiletRapor.Name = "tsmiBiletRapor";
            this.tsmiBiletRapor.Size = new System.Drawing.Size(224, 26);
            this.tsmiBiletRapor.Text = "Bilet Raporu";
            this.tsmiBiletRapor.Click += new System.EventHandler(this.tsmiBiletRapor_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 399);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msSeyahatAcentesi);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msSeyahatAcentesi;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msSeyahatAcentesi.ResumeLayout(false);
            this.msSeyahatAcentesi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip msSeyahatAcentesi;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiNesneIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmiSefer;
        private System.Windows.Forms.ToolStripMenuItem tsmiBilet;
        private System.Windows.Forms.ToolStripMenuItem tsmiKullanici;
        private System.Windows.Forms.ToolStripMenuItem tsmiRapor;
        private System.Windows.Forms.ToolStripMenuItem tsmiOturum;
        private System.Windows.Forms.ToolStripMenuItem tsmiSifreDegistir;
        private System.Windows.Forms.ToolStripMenuItem tsmiOturumuSonlandir;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeferRapor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBiletRapor;
    }
}



