using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec01
{
    public partial class frm35347_Lista01_Exec01 : Form
    {
        #region Incializar
        public frm35347_Lista01_Exec01()
        {
            InitializeComponent();
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region método limpar
        private void Limpar()
        {
            txtResp.Clear();
            txtV1.Clear();
            txtV2.Clear();
            lblResp.Text = "";
            txtV1.Focus();
        }
        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?","Calculadora",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Area = 0;
            double Altura = 0;
            double Base = 0;

            try
            {
                Altura = double.Parse(txtV1.Text);
                Base = double.Parse(txtV2.Text);
            }
            catch
            {
                MessageBox.Show("Digite somente número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Area = Base * Altura;

            txtResp.Text = Area.ToString("#0.00");
            lblResp.Text = Area.ToString("#0.0") + " m²";
        }
        #endregion

        #region txtV1
        private void txtV1_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtResp.Clear();
        }
        #endregion

        #region txtV2
        private void txtV2_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtResp.Clear();
        }
        #endregion
    }
}
