
namespace VeriTabaniOtelOtomasyonu
{
    partial class RezervasyonTipi
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
            this.btnOnOdemeli = new System.Windows.Forms.Button();
            this.btnOnceden = new System.Windows.Forms.Button();
            this.btnStandart = new System.Windows.Forms.Button();
            this.btnTesvik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(294, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Tipi Seçiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOnOdemeli
            // 
            this.btnOnOdemeli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOnOdemeli.Location = new System.Drawing.Point(74, 136);
            this.btnOnOdemeli.Name = "btnOnOdemeli";
            this.btnOnOdemeli.Size = new System.Drawing.Size(123, 61);
            this.btnOnOdemeli.TabIndex = 1;
            this.btnOnOdemeli.Text = "Ön Ödemeli Rezervasyon";
            this.btnOnOdemeli.UseVisualStyleBackColor = false;
            this.btnOnOdemeli.Click += new System.EventHandler(this.btnOnOdemeli_Click);
            // 
            // btnOnceden
            // 
            this.btnOnceden.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOnceden.Location = new System.Drawing.Point(258, 136);
            this.btnOnceden.Name = "btnOnceden";
            this.btnOnceden.Size = new System.Drawing.Size(123, 61);
            this.btnOnceden.TabIndex = 2;
            this.btnOnceden.Text = "60 Gün Önceden Rezervasyon";
            this.btnOnceden.UseVisualStyleBackColor = false;
            this.btnOnceden.Click += new System.EventHandler(this.btnOnceden_Click);
            // 
            // btnStandart
            // 
            this.btnStandart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStandart.Location = new System.Drawing.Point(423, 136);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(123, 61);
            this.btnStandart.TabIndex = 3;
            this.btnStandart.Text = "Standart Rezervasyon";
            this.btnStandart.UseVisualStyleBackColor = false;
            this.btnStandart.Click += new System.EventHandler(this.btnStandart_Click);
            // 
            // btnTesvik
            // 
            this.btnTesvik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTesvik.Location = new System.Drawing.Point(593, 136);
            this.btnTesvik.Name = "btnTesvik";
            this.btnTesvik.Size = new System.Drawing.Size(123, 61);
            this.btnTesvik.TabIndex = 4;
            this.btnTesvik.Text = "Teşvik Rezervasyonları";
            this.btnTesvik.UseVisualStyleBackColor = false;
            this.btnTesvik.Click += new System.EventHandler(this.btnTesvik_Click);
            // 
            // RezervasyonTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 231);
            this.Controls.Add(this.btnTesvik);
            this.Controls.Add(this.btnStandart);
            this.Controls.Add(this.btnOnceden);
            this.Controls.Add(this.btnOnOdemeli);
            this.Controls.Add(this.label1);
            this.Name = "RezervasyonTipi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnOdemeli;
        private System.Windows.Forms.Button btnOnceden;
        private System.Windows.Forms.Button btnStandart;
        private System.Windows.Forms.Button btnTesvik;
    }
}

