namespace prj35347_Lista01_Exec01
{
    partial class frm35347_Lista01_Exec01
    {
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
            this.lblBase = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(12, 83);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(70, 20);
            this.txtV1.TabIndex = 0;
            this.txtV1.TextChanged += new System.EventHandler(this.txtV1_TextChanged);
            // 
            // lblBase
            // 
            this.lblBase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(12, 48);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(70, 32);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base (m)";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(100, 83);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(70, 20);
            this.txtV2.TabIndex = 1;
            this.txtV2.TextChanged += new System.EventHandler(this.txtV2_TextChanged);
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(188, 83);
            this.txtResp.Name = "txtResp";
            this.txtResp.ReadOnly = true;
            this.txtResp.Size = new System.Drawing.Size(70, 20);
            this.txtResp.TabIndex = 2;
            this.txtResp.TabStop = false;
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(96, 48);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(82, 32);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura (m)";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(188, 48);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(70, 32);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área (m²)";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(11, 182);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(246, 77);
            this.lblResp.TabIndex = 1;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 129);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(70, 33);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(100, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 33);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(188, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 33);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frm35347_Lista01_Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 268);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista01_Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de Quadriláteros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

