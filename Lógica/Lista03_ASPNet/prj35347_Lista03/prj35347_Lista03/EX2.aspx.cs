using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj35347_Lista03
{
    public partial class EX2 : System.Web.UI.Page
    {
        #region Inicializar
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Limpar
        protected void btnLimpar2_Click(object sender, EventArgs e)
        {
            ltbNum.Items.Clear();
        }
        #endregion

        #region Gerar
        protected void btnGerar_Click(object sender, EventArgs e)
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
    }
}