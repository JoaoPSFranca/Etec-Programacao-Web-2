namespace prj35347_Lista01_Exec09
{
    partial class frm35347_Lista01_Exec09
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
            this.lblResist = new System.Windows.Forms.Label();
            this.txtResist = new System.Windows.Forms.TextBox();
            this.lblCorrente = new System.Windows.Forms.Label();
            this.txtCorrente = new System.Windows.Forms.TextBox();
            this.lblTensao = new System.Windows.Forms.Label();
            this.txtTensao = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResist
            // 
            this.lblResist.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResist.Location = new System.Drawing.Point(12, 23);
            this.lblResist.Name = "lblResist";
            this.lblResist.Size = new System.Drawing.Size(71, 23);
            this.lblResist.TabIndex = 0;
            this.lblResist.Text = "Resistência:";
            this.lblResist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResist
            // 
            this.txtResist.Location = new System.Drawing.Point(12, 49);
            this.txtResist.Name = "txtResist";
            this.txtResist.Size = new System.Drawing.Size(71, 20);
            this.txtResist.TabIndex = 0;
            this.txtResist.TextChanged += new System.EventHandler(this.txtResist_TextChanged);
            // 
            // lblCorrente
            // 
            this.lblCorrente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrente.Location = new System.Drawing.Point(89, 23);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(73, 23);
            this.lblCorrente.TabIndex = 0;
            this.lblCorrente.Text = "Corrente:";
            this.lblCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorrente
            // 
            this.txtCorrente.Location = new System.Drawing.Point(89, 49);
            this.txtCorrente.Name = "txtCorrente";
            this.txtCorrente.Size = new System.Drawing.Size(73, 20);
            this.txtCorrente.TabIndex = 1;
            this.txtCorrente.TextChanged += new System.EventHandler(this.txtCorrente_TextChanged);
            // 
            // lblTensao
            // 
            this.lblTensao.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensao.Location = new System.Drawing.Point(168, 23);
            this.lblTensao.Name = "lblTensao";
            this.lblTensao.Size = new System.Drawing.Size(73, 23);
            this.lblTensao.TabIndex = 0;
            this.lblTensao.Text = "Tensão:";
            this.lblTensao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTensao
            // 
            this.txtTensao.Location = new System.Drawing.Point(168, 49);
            this.txtTensao.Name = "txtTensao";
            this.txtTensao.ReadOnly = true;
            this.txtTensao.Size = new System.Drawing.Size(73, 20);
            this.txtTensao.TabIndex = 2;
            this.txtTensao.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 183);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(71, 26);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(89, 183);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(73, 26);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(168, 183);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 26);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(12, 72);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(229, 108);
            this.lblResp.TabIndex = 0;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_Lista01_Exec09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 225);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTensao);
            this.Controls.Add(this.txtCorrente);
            this.Controls.Add(this.txtResist);
            this.Controls.Add(this.lblTensao);
            this.Controls.Add(this.lblCorrente);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblResist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista01_Exec09";
            this.Text = "Lei de Ohm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResist;
        private System.Windows.Forms.TextBox txtResist;
        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.TextBox txtCorrente;
        private System.Windows.Forms.Label lblTensao;
        private System.Windows.Forms.TextBox txtTensao;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResp;
    }
}

