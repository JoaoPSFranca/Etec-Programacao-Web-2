using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec04
{
    public partial class frm35347_Lista01_Exec04 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec04()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Área do Triângulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtBase.Clear();
            txtAltura.Clear();
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Area = 0;
            double Base = 0;
            double Altura = 0;
            double Multi = 0;

            try
            {
                Altura = double.Parse(txtAltura.Text);
                Base = double.Parse(txtBase.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com\n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Multi = Altura * Base;
            Area = Multi / 2;

            txtArea.Text = Area.ToString("#0.00");
            lblResp.Text = Area.ToString("#0.0") + " m²";
        }
        #endregion

        #region txtBase
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region txtAltura
        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
