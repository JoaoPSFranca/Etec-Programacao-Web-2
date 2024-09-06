using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec03
{
    public partial class frm35347_Lista01_Exec03 : Form
    {
        #region Incializar
        public frm35347_Lista01_Exec03()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Área do Quadrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtDiagonal.Clear();
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Diagonal = 0;
            double Multi = 0;
            double Area = 0;

            try
            {
                Diagonal = double.Parse(txtDiagonal.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Multi = Diagonal * Diagonal;
            Area = Multi / 2;

            txtArea.Text = Area.ToString("#0.00");
            lblArea.Text = Area.ToString("#0.0") + " m²";
        }
        #endregion

        #region txtArea
        private void txtDiagonal_TextChanged(object sender, EventArgs e)
        {
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
