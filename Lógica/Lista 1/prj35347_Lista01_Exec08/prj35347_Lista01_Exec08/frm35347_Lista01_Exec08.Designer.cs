namespace prj35347_Lista01_Exec08
{
    partial class frm35347_Lista01_Exec08
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
            this.lblMilhas = new System.Windows.Forms.Label();
            this.txtMilhas = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMilhas
            // 
            this.lblMilhas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilhas.Location = new System.Drawing.Point(12, 30);
            this.lblMilhas.Name = "lblMilhas";
            this.lblMilhas.Size = new System.Drawing.Size(100, 23);
            this.lblMilhas.TabIndex = 0;
            this.lblMilhas.Text = "Valor em Milhas:";
            this.lblMilhas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMilhas
            // 
            this.txtMilhas.Location = new System.Drawing.Point(12, 56);
            this.txtMilhas.Name = "txtMilhas";
            this.txtMilhas.Size = new System.Drawing.Size(100, 20);
            this.txtMilhas.TabIndex = 0;
            this.txtMilhas.TextChanged += new System.EventHandler(this.txtMilhas_TextChanged);
            // 
            // lblKm
            // 
            this.lblKm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(132, 30);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(115, 23);
            this.lblKm.TabIndex = 0;
            this.lblKm.Text = "Valor em Quilômetros:";
            this.lblKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(132, 56);
            this.txtKm.Name = "txtKm";
            this.txtKm.ReadOnly = true;
            this.txtKm.Size = new System.Drawing.Size(115, 20);
            this.txtKm.TabIndex = 0;
            this.txtKm.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 190);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(172, 190);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(12, 79);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(235, 108);
            this.lblResp.TabIndex = 0;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_Lista01_Exec08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 227);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtMilhas);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblMilhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista01_Exec08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milhas para Quilômetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilhas;
        private System.Windows.Forms.TextBox txtMilhas;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResp;
    }
}

