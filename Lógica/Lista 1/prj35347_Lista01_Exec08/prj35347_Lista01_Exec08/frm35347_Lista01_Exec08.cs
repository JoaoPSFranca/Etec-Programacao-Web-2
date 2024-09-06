using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec08
{
    public partial class frm35347_Lista01_Exec08 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec08()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Milhas para Quilômetros", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtMilhas.Clear();
            txtKm.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Km = 0;
            double Milhas = 0;

            try
            {
                Milhas = double.Parse(txtMilhas.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com \nou sem decimal", "Erro na Digitação");
                Limpar();
                return;
            }

            Km = Milhas * 1.852;

            txtKm.Text = Km.ToString("#0.000");
            lblResp.Text = Km.ToString("#0.0") + " Km";
        }
        #endregion

        #region txtMilhas
        private void txtMilhas_TextChanged(object sender, EventArgs e)
        {
            txtKm.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
