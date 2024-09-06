using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec10
{
    public partial class frm35347_Lista01_Exec10 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec10()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Celsius para Fahrenheit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtCelsius.Clear();
            txtFah.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Celsius = 0;
            double Fah = 0;

            try
            {
                Celsius = double.Parse(txtCelsius.Text);
            }
            catch
            {
                MessageBox.Show("Digite somente números com \nou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Fah = ((Celsius * 9) / 5) + 32;

            txtFah.Text = Fah.ToString("#0.0");
            lblResp.Text = Fah.ToString("#0.0") + " ºF";
        }
        #endregion

        #region txtCelsius
        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            txtFah.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
