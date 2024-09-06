using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec02
{
    public partial class Frm35347_Lista01_Exec02 : Form
    {
        #region Inicializar
        public Frm35347_Lista01_Exec02()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Área do Quadrado", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtAresta.Clear();
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double aresta = 0;
            double area = 0;

            try
            {
                aresta = double.Parse(txtAresta.Text);
            }
            catch
            {
                MessageBox.Show("Coloque apenas números com \n ou sem decimal", "Erro na Digitação");
                Limpar();
                return;
            }

            area = aresta * aresta;

            txtArea.Text = area.ToString("#0.00");
            lblResp.Text = area.ToString("#0.0") + " m²";
        }
        #endregion

        #region txtAresta
        private void txtAresta_TextChanged(object sender, EventArgs e)
        {
            txtArea.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
