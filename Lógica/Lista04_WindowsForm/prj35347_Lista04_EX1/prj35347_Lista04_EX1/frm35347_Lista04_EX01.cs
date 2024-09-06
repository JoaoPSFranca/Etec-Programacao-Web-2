using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista04_EX1
{
    public partial class frm35347_Lista04_EX01 : Form
    {
        #region Inicializar
        public frm35347_Lista04_EX01()
        {
            InitializeComponent();
        }
        #endregion

        #region Gerar
        private void btnGerar_Click(object sender, EventArgs e)
        {
            #region Limpar
            ltbNum.Items.Clear();
            #endregion

            #region Variáveis
            Random R = new Random();
            int NumeroSorteado = 0;
            int[] Verificar = new int[10];
            #endregion

            #region for
            for (int i = 0; i < 10; i++)
            {
                #region Sortear
                NumeroSorteado = R.Next(0, 21);
                #endregion

                #region Verificar Repetição
                for (int j = 0; j < 10; j++)
                {
                    while (Verificar[j] == NumeroSorteado)
                    {
                        NumeroSorteado = R.Next(0, 21);
                        j = 0;
                    }
                }
                #endregion

                #region Mostrar
                ltbNum.Items.Add(NumeroSorteado.ToString());
                #endregion

                #region Passar o Valor
                Verificar[i] = NumeroSorteado;
                #endregion
            }
            #endregion
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbNum.Items.Clear();
        }
        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Gerar Números Aleatórios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion
    }
}
