namespace vizekutuphane
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.KitapGrid = new System.Windows.Forms.DataGridView();
            this.KitapeEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BasimYili = new System.Windows.Forms.TextBox();
            this.YayinEvi = new System.Windows.Forms.TextBox();
            this.YazarAdi = new System.Windows.Forms.TextBox();
            this.KitapAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.KitapGrid);
            this.tabPage1.Controls.Add(this.KitapeEkle);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BasimYili);
            this.tabPage1.Controls.Add(this.YayinEvi);
            this.tabPage1.Controls.Add(this.YazarAdi);
            this.tabPage1.Controls.Add(this.KitapAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Kitap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // KitapGrid
            // 
            this.KitapGrid.AllowUserToAddRows = false;
            this.KitapGrid.AllowUserToDeleteRows = false;
            this.KitapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapGrid.Location = new System.Drawing.Point(30, 94);
            this.KitapGrid.Name = "KitapGrid";
            this.KitapGrid.ReadOnly = true;
            this.KitapGrid.Size = new System.Drawing.Size(584, 272);
            this.KitapGrid.TabIndex = 9;
            // 
            // KitapeEkle
            // 
            this.KitapeEkle.Location = new System.Drawing.Point(554, 34);
            this.KitapeEkle.Name = "KitapeEkle";
            this.KitapeEkle.Size = new System.Drawing.Size(75, 23);
            this.KitapeEkle.TabIndex = 8;
            this.KitapeEkle.Text = "Kitap ekle";
            this.KitapeEkle.UseVisualStyleBackColor = true;
            this.KitapeEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Basım Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yayın Evi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazır Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // BasimYili
            // 
            this.BasimYili.Location = new System.Drawing.Point(427, 37);
            this.BasimYili.Name = "BasimYili";
            this.BasimYili.Size = new System.Drawing.Size(100, 20);
            this.BasimYili.TabIndex = 3;
            // 
            // YayinEvi
            // 
            this.YayinEvi.Location = new System.Drawing.Point(304, 36);
            this.YayinEvi.Name = "YayinEvi";
            this.YayinEvi.Size = new System.Drawing.Size(100, 20);
            this.YayinEvi.TabIndex = 2;
            // 
            // YazarAdi
            // 
            this.YazarAdi.Location = new System.Drawing.Point(164, 36);
            this.YazarAdi.Name = "YazarAdi";
            this.YazarAdi.Size = new System.Drawing.Size(100, 20);
            this.YazarAdi.TabIndex = 1;
            // 
            // KitapAdi
            // 
            this.KitapAdi.Location = new System.Drawing.Point(18, 36);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(100, 20);
            this.KitapAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raf";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(648, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Üye";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasimYili;
        private System.Windows.Forms.TextBox YayinEvi;
        private System.Windows.Forms.TextBox YazarAdi;
        private System.Windows.Forms.TextBox KitapAdi;
        private System.Windows.Forms.DataGridView KitapGrid;
        private System.Windows.Forms.Button KitapeEkle;
    }
}

