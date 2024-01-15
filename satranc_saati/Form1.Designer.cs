namespace satranc_saati
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
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.tmBeyaz = new System.Windows.Forms.Timer(this.components);
            this.tmSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblSiyah = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(22, 81);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(135, 61);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyaz.Location = new System.Drawing.Point(22, 160);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(135, 61);
            this.btnBeyaz.TabIndex = 1;
            this.btnBeyaz.Text = "Beyaz";
            this.btnBeyaz.UseVisualStyleBackColor = false;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.Location = new System.Drawing.Point(22, 244);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(135, 61);
            this.btnSiyah.TabIndex = 2;
            this.btnSiyah.Text = "Siyah";
            this.btnSiyah.UseVisualStyleBackColor = false;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(181, 182);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(115, 39);
            this.lblBeyaz.TabIndex = 3;
            this.lblBeyaz.Text = "label1";
            // 
            // tmBeyaz
            // 
            this.tmBeyaz.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmSiyah
            // 
            this.tmSiyah.Tick += new System.EventHandler(this.tmSiyah_Tick);
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(181, 266);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(115, 39);
            this.lblSiyah.TabIndex = 4;
            this.lblSiyah.Text = "label2";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(181, 103);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(115, 39);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 377);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnBeyaz);
            this.Controls.Add(this.btnBasla);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBeyaz;
        private System.Windows.Forms.Button btnSiyah;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Timer tmBeyaz;
        private System.Windows.Forms.Timer tmSiyah;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Label lblMesaj;
    }
}

