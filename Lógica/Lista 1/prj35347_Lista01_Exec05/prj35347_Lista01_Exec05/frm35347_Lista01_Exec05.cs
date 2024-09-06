using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_Exec05
{
    public partial class frm35347_Lista01_Exec05 : Form
    {
        #region Incializar
        public frm35347_Lista01_Exec05()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Área da Efera", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            txtDiâmetro.Clear();
            txtVolume.Clear();
            lblResp.Text = "";
        }
        #endregion

        #region Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Diâmetro = 0;
            double Volume = 0;
            double Raio = 0;
            double Pi = 3.1415;
            double Multi1 = 0;
            double Multi2 = 0;
            double Raio2 = 0;

            try
            {
                Diâmetro = double.Parse(txtDiâmetro.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com \nou sem decimal", "Erro na Digitação");
                Limpar();
                return;
            }

            Raio = Diâmetro / 2;
            Raio2 = Raio * Raio * Raio;
            Multi1 = 4 * Pi;
            Multi2 = Multi1 * Raio2;
            Volume = Multi2 / 3;

            txtVolume.Text = Volume.ToString("#0.00");
            lblResp.Text = Volume.ToString("#0.00") + " m³";
        }
        #endregion

        #region txtDiâmetro
        private void txtDiâmetro_TextChanged(object sender, EventArgs e)
        {
            txtVolume.Clear();
            lblResp.Text = "";
        }
        #endregion
    }
}
