
namespace VeriTabaniOtelOtomasyonu
{
    partial class Odalar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OdaIdtxt = new System.Windows.Forms.TextBox();
            this.OdaNotxt = new System.Windows.Forms.TextBox();
            this.OdaBilgiGridview = new System.Windows.Forms.DataGridView();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BosRbtn = new System.Windows.Forms.RadioButton();
            this.DoluRbtn = new System.Windows.Forms.RadioButton();
            this.Duzenlebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdaBilgiGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oda No";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oda ID";
            // 
            // OdaIdtxt
            // 
            this.OdaIdtxt.Location = new System.Drawing.Point(153, 80);
            this.OdaIdtxt.Name = "OdaIdtxt";
            this.OdaIdtxt.Size = new System.Drawing.Size(153, 22);
            this.OdaIdtxt.TabIndex = 7;
            // 
            // OdaNotxt
            // 
            this.OdaNotxt.Location = new System.Drawing.Point(153, 154);
            this.OdaNotxt.Name = "OdaNotxt";
            this.OdaNotxt.Size = new System.Drawing.Size(153, 22);
            this.OdaNotxt.TabIndex = 10;
            this.OdaNotxt.Visible = false;
            // 
            // OdaBilgiGridview
            // 
            this.OdaBilgiGridview.AllowUserToAddRows = false;
            this.OdaBilgiGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OdaBilgiGridview.BackgroundColor = System.Drawing.Color.White;
            this.OdaBilgiGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OdaBilgiGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OdaBilgiGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OdaBilgiGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaBilgiGridview.EnableHeadersVisualStyles = false;
            this.OdaBilgiGridview.Location = new System.Drawing.Point(477, 53);
            this.OdaBilgiGridview.Name = "OdaBilgiGridview";
            this.OdaBilgiGridview.ReadOnly = true;
            this.OdaBilgiGridview.RowHeadersWidth = 51;
            this.OdaBilgiGridview.RowTemplate.Height = 24;
            this.OdaBilgiGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdaBilgiGridview.Size = new System.Drawing.Size(434, 350);
            this.OdaBilgiGridview.TabIndex = 12;
            this.OdaBilgiGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdaBilgiGridview_CellContentClick);
            // 
            // Silbtn
            // 
            this.Silbtn.ForeColor = System.Drawing.Color.Black;
            this.Silbtn.Location = new System.Drawing.Point(287, 328);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(104, 36);
            this.Silbtn.TabIndex = 14;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.ForeColor = System.Drawing.Color.Black;
            this.Eklebtn.Location = new System.Drawing.Point(22, 328);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(97, 36);
            this.Eklebtn.TabIndex = 13;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "BOŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "DOLU";
            // 
            // BosRbtn
            // 
            this.BosRbtn.AutoSize = true;
            this.BosRbtn.Location = new System.Drawing.Point(81, 220);
            this.BosRbtn.Name = "BosRbtn";
            this.BosRbtn.Size = new System.Drawing.Size(17, 16);
            this.BosRbtn.TabIndex = 17;
            this.BosRbtn.TabStop = true;
            this.BosRbtn.UseVisualStyleBackColor = true;
            // 
            // DoluRbtn
            // 
            this.DoluRbtn.AutoSize = true;
            this.DoluRbtn.Location = new System.Drawing.Point(277, 222);
            this.DoluRbtn.Name = "DoluRbtn";
            this.DoluRbtn.Size = new System.Drawing.Size(17, 16);
            this.DoluRbtn.TabIndex = 18;
            this.DoluRbtn.TabStop = true;
            this.DoluRbtn.UseVisualStyleBackColor = true;
            // 
            // Duzenlebtn
            // 
            this.Duzenlebtn.ForeColor = System.Drawing.Color.Black;
            this.Duzenlebtn.Location = new System.Drawing.Point(149, 328);
            this.Duzenlebtn.Name = "Duzenlebtn";
            this.Duzenlebtn.Size = new System.Drawing.Size(97, 36);
            this.Duzenlebtn.TabIndex = 19;
            this.Duzenlebtn.Text = "DÜZENLE";
            this.Duzenlebtn.UseVisualStyleBackColor = true;
            this.Duzenlebtn.Click += new System.EventHandler(this.Duzenlebtn_Click);
            // 
            // Odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(923, 460);
            this.Controls.Add(this.Duzenlebtn);
            this.Controls.Add(this.DoluRbtn);
            this.Controls.Add(this.BosRbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.OdaBilgiGridview);
            this.Controls.Add(this.OdaNotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdaIdtxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Odalar";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Odalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdaBilgiGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OdaIdtxt;
        private System.Windows.Forms.TextBox OdaNotxt;
        private System.Windows.Forms.DataGridView OdaBilgiGridview;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton BosRbtn;
        private System.Windows.Forms.RadioButton DoluRbtn;
        private System.Windows.Forms.Button Duzenlebtn;
    }
}