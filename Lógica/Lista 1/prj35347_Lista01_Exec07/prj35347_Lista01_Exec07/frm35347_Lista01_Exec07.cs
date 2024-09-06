using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec07
{
    public partial class frm35347_Lista01_Exec07 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec07()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Média Geométrica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
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
            txtV1.Clear();
            txtV2.Clear();
            txtMedia.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calculadora
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double V1 = 0;
            double V2 = 0;
            double Media = 0;

            try
            {
                V1 = double.Parse(txtV1.Text);
                V2 = double.Parse(txtV2.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com \nou sem decimal", "Erro na Digitação");
                Limpar();
                return;
            }

            Media = Math.Sqrt((V1 * V2));

            txtMedia.Text = Media.ToString("#0.0");
            lblResp.Text = Media.ToString("#0.0");
        }
        #endregion

        #region txtV1
        private void txtV1_TextChanged(object sender, EventArgs e)
        {
            txtMedia.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region txtV2
        private void txtV2_TextChanged(object sender, EventArgs e)
        {
            txtMedia.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
