using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj35347_Lista03
{
    public partial class index : System.Web.UI.Page
    {
        #region Inicializar
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region txtEspAmos
        protected void txtEspAmos_TextChanged(object sender, EventArgs e)
        {
            txtResp.Text = "";
            txtQuan.Text = "";
        }
        #endregion

        #region txtTamAmos
        protected void txtTamAmos_TextChanged(object sender, EventArgs e)
        {
            txtResp.Text = "";
            txtQuan.Text = "";
        }
        #endregion

        #region Limpar
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEspAmos.Text = "";
            txtTamAmos.Text = "";
            txtQuan.Text = "";
            txtResp.Text = "";
            txtEspAmos.Focus();
        }
        #endregion

        #region Calcular
        protected void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            int I = 0;
            int C = 0;
            int N = 0;
            int N2 = 0;
            int P = 0;
            int P2 = 0;
            int A = 0;
            int A2 = 0;
            #endregion

            #region TryCat N

            try
            {
                N = int.Parse(txtEspAmos.Text);
            }
            catch
            {
                txtEspAmos.Text = "";
                txtEspAmos.Focus();
                txtResp.Text = " Informe apenas números no Espaço Amostral! ";
                return;
            }

            #endregion

            #region TryCat P

            try
            {
                P = int.Parse(txtTamAmos.Text);
            }
            catch
            {
                txtTamAmos.Text = "";
                txtTamAmos.Focus();
                txtResp.Text = " Informe apenas números no Tamanho da Amostra! ";
                return;
            }

            #endregion

            #region Pré-Cálculo

            #region For A
            A = N - P;
            A2 = A;
            for (I = A2 - 1; I >= 1; I--)
            {
                A = A * I;
            }
            #endregion

            #region For N
            N2 = N;
            for (I = N2 - 1; I >= 1; I--)
            {
                N = N * I;
            }
            #endregion

            #region For P
            P2 = P;
            for (I = P2 - 1; I >= 1; I--)
            {
                P = P * I;
            }
            #endregion

            #endregion

            #region Cálculo
            C = N / (P * A);
            #endregion

            #region Mostrar
            txtQuan.Text = C.ToString();
            #endregion
        }
        #endregion
    }
}