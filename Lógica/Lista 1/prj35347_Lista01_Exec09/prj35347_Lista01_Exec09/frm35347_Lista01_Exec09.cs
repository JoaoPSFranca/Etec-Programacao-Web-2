using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec09
{
    public partial class frm35347_Lista01_Exec09 : Form
    {
        #region Inicializar
        public frm35347_Lista01_Exec09()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Lei de Ohm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtCorrente.Clear();
            txtResist.Clear();
            txtTensao.Clear();
            lblTensao.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Resis = 0;
            double Corrente = 0;
            double Tensao = 0;

            try
            {
                Resis = double.Parse(txtResist.Text);
                Corrente = double.Parse(txtCorrente.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com \nou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Tensao = Resis * Corrente;

            txtTensao.Text = Tensao.ToString("#0.00");
            lblResp.Text = Tensao.ToString("#0.0") + " Ohms";
        }
        #endregion

        #region txtResist
        private void txtResist_TextChanged(object sender, EventArgs e)
        {
            txtTensao.Clear();
            lblTensao.Text = "";
        }
        #endregion

        #region txtCorrente
        private void txtCorrente_TextChanged(object sender, EventArgs e)
        {
            txtTensao.Clear();
            lblTensao.Text = "";
        }
        #endregion
    }
}
