
namespace VeriTabaniOtelOtomasyonu
{
    partial class OnOdemeliRezervasyon
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
            this.MusteriKartNotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RezerNotxt = new System.Windows.Forms.TextBox();
            this.MusteriIdCmbox = new System.Windows.Forms.ComboBox();
            this.OdaNoCmbox = new System.Windows.Forms.ComboBox();
            this.Duzenlebtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.RezervasyonBilgiGridview = new System.Windows.Forms.DataGridView();
            this.CikisGunu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GirisGunu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RezerTipitxt = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonBilgiGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // MusteriKartNotxt
            // 
            this.MusteriKartNotxt.Location = new System.Drawing.Point(181, 259);
            this.MusteriKartNotxt.Name = "MusteriKartNotxt";
            this.MusteriKartNotxt.Size = new System.Drawing.Size(166, 22);
            this.MusteriKartNotxt.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(46, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Kart No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Oda No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Rezervasyon No";
            // 
            // RezerNotxt
            // 
            this.RezerNotxt.Location = new System.Drawing.Point(181, 110);
            this.RezerNotxt.Name = "RezerNotxt";
            this.RezerNotxt.Size = new System.Drawing.Size(166, 22);
            this.RezerNotxt.TabIndex = 62;
            // 
            // MusteriIdCmbox
            // 
            this.MusteriIdCmbox.FormattingEnabled = true;
            this.MusteriIdCmbox.Location = new System.Drawing.Point(181, 151);
            this.MusteriIdCmbox.Name = "MusteriIdCmbox";
            this.MusteriIdCmbox.Size = new System.Drawing.Size(166, 24);
            this.MusteriIdCmbox.TabIndex = 61;
            this.MusteriIdCmbox.Text = "MusteriId";
            // 
            // OdaNoCmbox
            // 
            this.OdaNoCmbox.FormattingEnabled = true;
            this.OdaNoCmbox.Location = new System.Drawing.Point(181, 208);
            this.OdaNoCmbox.Name = "OdaNoCmbox";
            this.OdaNoCmbox.Size = new System.Drawing.Size(166, 24);
            this.OdaNoCmbox.TabIndex = 60;
            this.OdaNoCmbox.Text = "Oda NO";
            // 
            // Duzenlebtn
            // 
            this.Duzenlebtn.Location = new System.Drawing.Point(148, 477);
            this.Duzenlebtn.Name = "Duzenlebtn";
            this.Duzenlebtn.Size = new System.Drawing.Size(110, 36);
            this.Duzenlebtn.TabIndex = 59;
            this.Duzenlebtn.Text = "DÜZENLE";
            this.Duzenlebtn.UseVisualStyleBackColor = true;
            this.Duzenlebtn.Click += new System.EventHandler(this.Duzenlebtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Location = new System.Drawing.Point(286, 477);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(117, 36);
            this.Silbtn.TabIndex = 58;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Location = new System.Drawing.Point(21, 477);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(110, 36);
            this.Eklebtn.TabIndex = 57;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
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
            this.RezervasyonBilgiGridview.Location = new System.Drawing.Point(535, 64);
            this.RezervasyonBilgiGridview.Name = "RezervasyonBilgiGridview";
            this.RezervasyonBilgiGridview.ReadOnly = true;
            this.RezervasyonBilgiGridview.RowHeadersWidth = 51;
            this.RezervasyonBilgiGridview.RowTemplate.Height = 24;
            this.RezervasyonBilgiGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RezervasyonBilgiGridview.Size = new System.Drawing.Size(731, 350);
            this.RezervasyonBilgiGridview.TabIndex = 56;
            this.RezervasyonBilgiGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezervasyonBilgiGridview_CellContentClick);
            // 
            // CikisGunu
            // 
            this.CikisGunu.Location = new System.Drawing.Point(134, 424);
            this.CikisGunu.Name = "CikisGunu";
            this.CikisGunu.Size = new System.Drawing.Size(213, 22);
            this.CikisGunu.TabIndex = 55;
            this.CikisGunu.ValueChanged += new System.EventHandler(this.CikisGunu_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Çıkış Günü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Giriş Günü";
            // 
            // GirisGunu
            // 
            this.GirisGunu.Location = new System.Drawing.Point(134, 362);
            this.GirisGunu.Name = "GirisGunu";
            this.GirisGunu.Size = new System.Drawing.Size(213, 22);
            this.GirisGunu.TabIndex = 52;
            this.GirisGunu.ValueChanged += new System.EventHandler(this.GirisGunu_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Rezervasyon Tipi";
            this.label1.Visible = false;
            // 
            // RezerTipitxt
            // 
            this.RezerTipitxt.Location = new System.Drawing.Point(181, 64);
            this.RezerTipitxt.Name = "RezerTipitxt";
            this.RezerTipitxt.Size = new System.Drawing.Size(166, 22);
            this.RezerTipitxt.TabIndex = 50;
            this.RezerTipitxt.Visible = false;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.ForeColor = System.Drawing.Color.White;
            this.datelbl.Location = new System.Drawing.Point(1148, 31);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(38, 17);
            this.datelbl.TabIndex = 49;
            this.datelbl.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OnOdemeliRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1302, 547);
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
            this.Controls.Add(this.datelbl);
            this.Name = "OnOdemeliRezervasyon";
            this.Text = "OnOdemeliRezervasyon";
            this.Load += new System.EventHandler(this.OnOdemeliRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonBilgiGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MusteriKartNotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RezerNotxt;
        private System.Windows.Forms.ComboBox MusteriIdCmbox;
        private System.Windows.Forms.ComboBox OdaNoCmbox;
        private System.Windows.Forms.Button Duzenlebtn;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.DataGridView RezervasyonBilgiGridview;
        private System.Windows.Forms.DateTimePicker CikisGunu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker GirisGunu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RezerTipitxt;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
    }
}