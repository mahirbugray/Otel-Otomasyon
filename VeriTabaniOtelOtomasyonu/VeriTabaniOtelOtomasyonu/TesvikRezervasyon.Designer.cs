
namespace VeriTabaniOtelOtomasyonu
{
    partial class TesvikRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.RezerTipitxt = new System.Windows.Forms.TextBox();
            this.GirisGunu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CikisGunu = new System.Windows.Forms.DateTimePicker();
            this.RezervasyonBilgiGridview = new System.Windows.Forms.DataGridView();
            this.Duzenlebtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.OdaNoCmbox = new System.Windows.Forms.ComboBox();
            this.MusteriIdCmbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RezerNotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MusteriKartNotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonBilgiGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rezervasyon Tipi";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RezerTipitxt
            // 
            this.RezerTipitxt.Location = new System.Drawing.Point(177, 38);
            this.RezerTipitxt.Name = "RezerTipitxt";
            this.RezerTipitxt.Size = new System.Drawing.Size(153, 22);
            this.RezerTipitxt.TabIndex = 11;
            this.RezerTipitxt.Visible = false;
            // 
            // GirisGunu
            // 
            this.GirisGunu.Location = new System.Drawing.Point(130, 344);
            this.GirisGunu.Name = "GirisGunu";
            this.GirisGunu.Size = new System.Drawing.Size(200, 22);
            this.GirisGunu.TabIndex = 17;
            this.GirisGunu.ValueChanged += new System.EventHandler(this.GirisGunu_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giriş Günü";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Çıkış Günü";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CikisGunu
            // 
            this.CikisGunu.Location = new System.Drawing.Point(130, 406);
            this.CikisGunu.Name = "CikisGunu";
            this.CikisGunu.Size = new System.Drawing.Size(200, 22);
            this.CikisGunu.TabIndex = 20;
            this.CikisGunu.ValueChanged += new System.EventHandler(this.CikisGunu_ValueChanged);
            // 
            // RezervasyonBilgiGridview
            // 
            this.RezervasyonBilgiGridview.AllowUserToAddRows = false;
            this.RezervasyonBilgiGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RezervasyonBilgiGridview.BackgroundColor = System.Drawing.Color.White;
            this.RezervasyonBilgiGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RezervasyonBilgiGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RezervasyonBilgiGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RezervasyonBilgiGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyonBilgiGridview.EnableHeadersVisualStyles = false;
            this.RezervasyonBilgiGridview.Location = new System.Drawing.Point(441, 38);
            this.RezervasyonBilgiGridview.Name = "RezervasyonBilgiGridview";
            this.RezervasyonBilgiGridview.ReadOnly = true;
            this.RezervasyonBilgiGridview.RowHeadersWidth = 51;
            this.RezervasyonBilgiGridview.RowTemplate.Height = 24;
            this.RezervasyonBilgiGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RezervasyonBilgiGridview.Size = new System.Drawing.Size(718, 350);
            this.RezervasyonBilgiGridview.TabIndex = 21;
            this.RezervasyonBilgiGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezervasyonBilgiGridview_CellContentClick);
            // 
            // Duzenlebtn
            // 
            this.Duzenlebtn.Location = new System.Drawing.Point(140, 469);
            this.Duzenlebtn.Name = "Duzenlebtn";
            this.Duzenlebtn.Size = new System.Drawing.Size(97, 36);
            this.Duzenlebtn.TabIndex = 24;
            this.Duzenlebtn.Text = "DÜZENLE";
            this.Duzenlebtn.UseVisualStyleBackColor = true;
            this.Duzenlebtn.Click += new System.EventHandler(this.Duzenlebtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Location = new System.Drawing.Point(278, 469);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(104, 36);
            this.Silbtn.TabIndex = 23;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Location = new System.Drawing.Point(13, 469);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(97, 36);
            this.Eklebtn.TabIndex = 22;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // OdaNoCmbox
            // 
            this.OdaNoCmbox.FormattingEnabled = true;
            this.OdaNoCmbox.Location = new System.Drawing.Point(177, 182);
            this.OdaNoCmbox.Name = "OdaNoCmbox";
            this.OdaNoCmbox.Size = new System.Drawing.Size(153, 24);
            this.OdaNoCmbox.TabIndex = 25;
            this.OdaNoCmbox.Text = "Oda NO";
            // 
            // MusteriIdCmbox
            // 
            this.MusteriIdCmbox.FormattingEnabled = true;
            this.MusteriIdCmbox.Location = new System.Drawing.Point(177, 125);
            this.MusteriIdCmbox.Name = "MusteriIdCmbox";
            this.MusteriIdCmbox.Size = new System.Drawing.Size(153, 24);
            this.MusteriIdCmbox.TabIndex = 26;
            this.MusteriIdCmbox.Text = "MusteriId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rezervasyon No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RezerNotxt
            // 
            this.RezerNotxt.Location = new System.Drawing.Point(177, 84);
            this.RezerNotxt.Name = "RezerNotxt";
            this.RezerNotxt.Size = new System.Drawing.Size(153, 22);
            this.RezerNotxt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Müşteri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Oda No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MusteriKartNotxt
            // 
            this.MusteriKartNotxt.Location = new System.Drawing.Point(177, 235);
            this.MusteriKartNotxt.Name = "MusteriKartNotxt";
            this.MusteriKartNotxt.Size = new System.Drawing.Size(166, 22);
            this.MusteriKartNotxt.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(42, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Kart No";
            // 
            // TesvikRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1193, 539);
            this.Controls.Add(this.MusteriKartNotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RezerNotxt);
            this.Controls.Add(this.MusteriIdCmbox);
            this.Controls.Add(this.OdaNoCmbox);
            this.Controls.Add(this.Duzenlebtn);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.RezervasyonBilgiGridview);
            this.Controls.Add(this.CikisGunu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GirisGunu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RezerTipitxt);
            this.Name = "TesvikRezervasyon";
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonBilgiGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RezerTipitxt;
        private System.Windows.Forms.DateTimePicker GirisGunu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker CikisGunu;
        private System.Windows.Forms.DataGridView RezervasyonBilgiGridview;
        private System.Windows.Forms.Button Duzenlebtn;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.ComboBox OdaNoCmbox;
        private System.Windows.Forms.ComboBox MusteriIdCmbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RezerNotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MusteriKartNotxt;
        private System.Windows.Forms.Label label7;
    }
}