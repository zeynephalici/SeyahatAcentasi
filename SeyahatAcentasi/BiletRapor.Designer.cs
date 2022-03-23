namespace SeyahatAcentasi
{
    partial class BiletRapor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbSefer = new System.Windows.Forms.ComboBox();
            this.lblSefer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbSefer
            // 
            this.cbSefer.FormattingEnabled = true;
            this.cbSefer.Location = new System.Drawing.Point(122, 41);
            this.cbSefer.Name = "cbSefer";
            this.cbSefer.Size = new System.Drawing.Size(190, 24);
            this.cbSefer.TabIndex = 1;
            this.cbSefer.SelectedIndexChanged += new System.EventHandler(this.cbSefer_SelectedIndexChanged);
            // 
            // lblSefer
            // 
            this.lblSefer.AutoSize = true;
            this.lblSefer.Location = new System.Drawing.Point(55, 49);
            this.lblSefer.Name = "lblSefer";
            this.lblSefer.Size = new System.Drawing.Size(45, 16);
            this.lblSefer.TabIndex = 2;
            this.lblSefer.Text = "Sefer :";
            // 
            // BiletRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSefer);
            this.Controls.Add(this.cbSefer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BiletRapor";
            this.Text = "BiletRapor";
            this.Load += new System.EventHandler(this.BiletRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSefer;
        private System.Windows.Forms.Label lblSefer;
    }
}