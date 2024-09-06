using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj35347_Lista02
{
    public partial class Index : System.Web.UI.Page
    {
        #region Inicializar
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region EX1

        #region Limpar
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();    
        }

            #region método limpar
            private void Limpar()
            {
                txtBinario.Text = "";
                txtDecimal.Text = "";
                lblResp.Text = "";
                txtDecimal.Focus();
            }
            #endregion

        #endregion

        #region Calcular
        protected void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            int Decimal = 0;
            int Resto = 0;
            #endregion

            #region TryDecimal
            try
            {
                Decimal = int.Parse(txtDecimal.Text);
            }
            catch
            {
                txtDecimal.Text = "";
                txtDecimal.Focus();
                lblResp.Text = "Digite somente números na caixa de textos 'Decimal'";
                return;
            }
            #endregion

            #region If 199 > D < 2
            if (Decimal > 199)
            {
                txtDecimal.Text = "";
                txtDecimal.Focus();
                lblResp.Text = "Digite somente números entre 1 e 200 na caixa de textos Decimal";
                return;
            }
            else
            {
                if (Decimal < 2)
                {
                    txtDecimal.Text = "";
                    txtDecimal.Focus();
                    lblResp.Text = "Digite somente números entre 1 e 200 na caixa de textos Decimal";
                    return;
                }
            }
            #endregion

            #region Cálculo
            while (Decimal > 1)
            {
                Resto = Decimal % 2;
                txtBinario.Text = Resto.ToString() + lblResp.Text;
                lblResp.Text = Resto.ToString() + lblResp.Text;
                Decimal = Decimal / 2;
            }
            #endregion

            #region Mostrar
            txtBinario.Text = Decimal.ToString() + lblResp.Text;
            lblResp.Text = Decimal.ToString() + lblResp.Text;
            #endregion

            #region if textlenght
            if (txtBinario.Text.Length < 8)
            {
                while (txtBinario.Text.Length < 8)
                {
                    txtBinario.Text = 0 + txtBinario.Text;
                    lblResp.Text = 0 + lblResp.Text;
                }
            }
            #endregion
        }
        #endregion

        #region txtDecimal
        protected void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            txtBinario.Text = "";
            lblResp.Text = "";
        }
        #endregion

        #endregion

        #region EX2

        #region Limpar
        protected void btnLimpar2_Click(object sender, EventArgs e)
        {
            Limpar2();
        }

            #region Método Limpar2
            private void Limpar2()
            {
                txtBinario2.Text = "";
                txtDecimal2.Text = "";
                lblResp2.Text = "";
                txtBinario2.Focus();
            }
            #endregion

        #endregion

        #region Calcular
        protected void btnCalc2_Click(object sender, EventArgs e)
        {
            #region Variáveis
            int Binario = 0;
            int j = 0;
            double Decimal = 0;
            int k = 7;
            #endregion

            #region TryBinário
            try
            {
                Binario = int.Parse(txtBinario2.Text);
            }
            catch
            {
                txtBinario2.Text = "";
                txtBinario2.Focus();
                lblResp2.Text = "Digite somente números na caixa de textos 'Binário'";
                return;
            }
            #endregion

            #region txtlength < 8
            txtDecimal2.Text = txtBinario2.Text;
            while (txtDecimal2.Text.Length < 8)
            {
                txtDecimal2.Text = 0 + txtDecimal2.Text;
            }
            #endregion

            #region Substring
            for (int i = 1; i < 9; i++)
            {
                j = int.Parse(txtDecimal2.Text.Substring(i - 1, 1));
                if (j == 0)
                {

                }
                else
                {
                    if (j == 1)
                    {
                        Decimal = Decimal + Math.Pow(2, k);
                    }
                    else
                    {
                        txtDecimal2.Text = "";
                        txtBinario2.Text = "";
                        txtBinario2.Focus();
                        lblResp2.Text = "Digite somente números binários na caixa de textos 'Binário:'";
                        return;
                    }
                }
                k--;
            }
            #endregion

            #region Mostrar
            txtDecimal2.Text = Decimal.ToString();
            lblResp2.Text = Decimal.ToString();
            #endregion
        }
        #endregion

        #region txtBinario
        protected void txtBinario2_TextChanged(object sender, EventArgs e)
        {
            txtDecimal2.Text = "";
            lblResp2.Text = "";
        }
        #endregion

        #endregion

        
    }


}