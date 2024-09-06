using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec_06
{
    public partial class frm35347_Lista01_Exec06 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec06()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Média Aritimética", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Método Limpar
        private void Limpar()
        {
            lblResp.Text = "";
            txtMedia.Clear();
            txtV1.Clear();
            txtV2.Clear();
            txtV3.Clear();
            txtV4.Clear();
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double V1 = 0;
            double V2 = 0;
            double V3 = 0;
            double V4 = 0;
            double Media = 0;

            try
            {
                V1 = double.Parse(txtV1.Text);
                V2 = double.Parse(txtV2.Text);
                V3 = double.Parse(txtV3.Text);
                V4 = double.Parse(txtV4.Text);
            }
            catch 
            {
                MessageBox.Show("Digite apenas números com \nou sem decimal", "Erro na Digitação");
                Limpar();
                return;
            }

            Media = (V1 + V2 + V3 + V4) / 4;

            txtMedia.Text = Media.ToString("#0.0");
            lblResp.Text = Media.ToString("#0.0"); 
        }
        #endregion

        #region txtV1
        private void txtV1_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtMedia.Clear();
        }
        #endregion

        #region txtV2
        private void txtV2_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtMedia.Clear();
        }
        #endregion

        #region txtV3
        private void txtV3_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtMedia.Clear();
        }
        #endregion

        #region txtV4
        private void txtV4_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtMedia.Clear();
        }
        #endregion
    }
}
