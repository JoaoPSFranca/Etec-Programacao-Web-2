namespace prj35347_Lista01_Exec07
{
    partial class frm35347_Lista01_Exec07
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
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.lblV1 = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.lblV2 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(12, 46);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(85, 20);
            this.txtV1.TabIndex = 0;
            this.txtV1.TextChanged += new System.EventHandler(this.txtV1_TextChanged);
            // 
            // lblV1
            // 
            this.lblV1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.Location = new System.Drawing.Point(12, 20);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(85, 23);
            this.lblV1.TabIndex = 1;
            this.lblV1.Text = "Valor 1:";
            this.lblV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(103, 46);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(86, 20);
            this.txtV2.TabIndex = 1;
            // 
            // lblV2
            // 
            this.lblV2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.Location = new System.Drawing.Point(103, 20);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(86, 23);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Valor 2:";
            this.lblV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(195, 46);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(86, 20);
            this.txtMedia.TabIndex = 0;
            this.txtMedia.TabStop = false;
            // 
            // lblMedia
            // 
            this.lblMedia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(195, 20);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(86, 23);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "Média:";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 198);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(85, 31);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(103, 198);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 31);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(195, 198);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(12, 69);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(269, 126);
            this.lblResp.TabIndex = 1;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_Lista01_Exec07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista01_Exec07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média Geométrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResp;
    }
}

