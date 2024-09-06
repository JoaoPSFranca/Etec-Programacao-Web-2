using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj35347_Lista01_ASPNet
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
        #endregion

        #region método limpar
        private void Limpar()
        {
            txtResp.Text = "";
            txtV1.Text = "";
            txtV2.Text = "";
            lblResp.Text = "";
            txtV1.Focus();
        }
        #endregion

        #region Calcular
        protected void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            double Area = 0;
            double Altura = 0;
            double Base = 0;
            #endregion

            #region TryBase
            try
            {
                Base = double.Parse(txtV2.Text);
            }
            catch
            {
                lblResp.Text = "Digite apenas números na caixa de textos da Base";
                txtV1.Text = "";
                txtV1.Focus();
                return;
            }
            #endregion

            #region TryAltura
            try
            {
                Altura = double.Parse(txtV1.Text);
            }
            catch
            {
                lblResp.Text = "Digite apenas números na caixa de textos da  Altura";
                txtV2.Text = "";
                txtV2.Focus();
                return;
            }
            #endregion

            #region Calculo
            Area = Base * Altura;
            #endregion

            #region mostrar
            txtResp.Text = Area.ToString("#0.00");
            lblResp.Text = Area.ToString("#0.0") + " m²";
            #endregion
        }
        #endregion

        #region txtV1
        protected void txtV1_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtResp.Text = "";
        }
        #endregion

        #region txtV2
        protected void txtV2_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtResp.Text = "";
        }
        #endregion
        #endregion

        #region EX2

        #region Limpar2
        protected void btnLimpar2_Click(object sender, EventArgs e)
        {
            Limpar2();
        }
        #endregion

        #region Método Limpar2
        private void Limpar2()
        {
            txtAresta2.Text = "";
            txtArea2.Text = "";
            lblResp2.Text = "";
        }
        #endregion

        #region Calcular2
        protected void btnCalc2_Click(object sender, EventArgs e)
        {
            #region Variáveis 2
            double aresta2 = 0;
            double area2 = 0;
            #endregion

            #region TryAresta 2
            try
            {
                aresta2 = double.Parse(txtAresta2.Text);
            }
            catch
            {
                lblResp2.Text = "Digite apenas números na caixa de textos da Aresta";
                txtAresta2.Text = "";
                txtAresta2.Focus();
                return;
            }
            #endregion

            #region Cálculo 2
            area2 = aresta2 * aresta2;
            #endregion

            #region Mostrar 2
            txtArea2.Text = area2.ToString("#0.00");
            lblResp2.Text = area2.ToString("#0.0") + " m²";
            #endregion
        }
        #endregion

        #region txtAresta2
        protected void txtAresta2_TextChanged(object sender, EventArgs e)
        {
            txtArea2.Text = "";
            lblResp2.Text = "";
        }
        #endregion

        #endregion

        #region EX3

        #region Limpar 3
        protected void btnLimpar3_Click(object sender, EventArgs e)
        {
            Limpar3();
        }
        #endregion

        #region Método Limpar 3
        private void Limpar3()
        {
            txtDiagonal3.Text = "";
            txtArea3.Text = "";
            lblResp3.Text = "";
        }
        #endregion

        #region Calcular 3
        protected void btnCalc3_Click(object sender, EventArgs e)
        {
            #region Variáveis 3
            double Diagonal3 = 0;
            double Multi3 = 0;
            double Area3 = 0;
            #endregion

            #region TryDiagonal 3
            try
            {
                Diagonal3 = double.Parse(txtDiagonal3.Text);
            }
            catch
            {
                lblResp3.Text = "Digite apenas números na caixa de textos da Diagonal";
                txtDiagonal3.Text = "";
                txtDiagonal3.Focus();
                return;
            }
            #endregion

            #region Cálculo 3
            Multi3 = Diagonal3 * Diagonal3;
            Area3 = Multi3 / 2;
            #endregion

            #region Mostrar 3 
            txtArea3.Text = Area3.ToString("#0.00");
            lblResp3.Text = Area3.ToString("#0.0") + " m²";
            #endregion
        }
        #endregion

        #region txtDiagonal 3
        protected void txtDiagonal3_TextChanged(object sender, EventArgs e)
        {
            txtArea3.Text = "";
            lblResp3.Text = "";
        }
        #endregion

        #endregion

        #region EX4

        #region Limpar 4
        protected void btnLimpar4_Click(object sender, EventArgs e)
        {
            Limpar4();
        }
        #endregion

        #region Método Limpar 4
        private void Limpar4()
        {
            txtBase4.Text = "";
            txtAltura4.Text = "";
            txtArea4.Text = "";
            lblResp4.Text = "";
        }
        #endregion

        #region Calcular 4
        protected void btnCalc4_Click(object sender, EventArgs e)
        {
            #region Variáveis 4
            double Area4 = 0;
            double Base4 = 0;
            double Altura4 = 0;
            double Multi4 = 0;
            #endregion

            #region TryBase 4
            try
            {
                Base4 = double.Parse(txtBase4.Text);
            }
            catch
            {
                lblResp4.Text = "Digite apenas números na caixa de textos da Base";
                txtBase4.Text = "";
                txtBase4.Focus();
                return;
            }
            #endregion

            #region TryAltura 4
            try
            {
                Altura4 = double.Parse(txtAltura4.Text);
            }
            catch
            {
                lblResp4.Text = "Digite apenas números na caixa de textos da  Altura";
                txtAltura4.Text = "";
                txtAltura4.Focus();
                return;
            }
            #endregion

            #region Cálculo 4
            Multi4 = Altura4 * Base4;
            Area4 = Multi4 / 2;
            #endregion

            #region Mostrar 4
            txtArea4.Text = Area4.ToString("#0.00");
            lblResp4.Text = Area4.ToString("#0.0") + " m²";
            #endregion
        }
        #endregion

        #region txtBase 4
        protected void txtBase4_TextChanged(object sender, EventArgs e)
        {
            txtArea4.Text = "";
            lblResp4.Text = "";
        }
        #endregion

        #region txtAltura 4
        protected void txtAltura4_TextChanged(object sender, EventArgs e)
        {
            txtArea4.Text = "";
            lblResp4.Text = "";
        }
        #endregion

        #endregion

        #region EX5

        #region Limpar 5
        protected void btnLimpar5_Click(object sender, EventArgs e)
        {
            Limpar5();
        }
        #endregion

        #region Método Limpar 5
        private void Limpar5()
        {
            txtDiametro5.Text = "";
            txtVolume5.Text = "";
            lblResp5.Text = "";
        }
        #endregion

        #region Calcular 5
        protected void btnCalc5_Click(object sender, EventArgs e)
        {
            #region Variáveis
            double Diametro5 = 0;
            double Volume5 = 0;
            #endregion

            #region TryDiametro 5
            try
            {
                Diametro5 = double.Parse(txtDiametro5.Text);
            }
            catch
            {
                lblResp5.Text = "Digite apenas números na caixa de texto do Diâmetro";
                txtDiametro5.Text = "";
                txtDiametro5.Focus();
                return;
            }
            #endregion

            #region Cálculo 5
            Volume5 = (Math.Pow((Diametro5/2), 3) * (4 * 3.1415)) / 3;
            #endregion 

            #region Mostrar 5
            txtVolume5.Text = Volume5.ToString("#0.00");
            lblResp5.Text = Volume5.ToString("#0.00") + " m³";
            #endregion
        }
        #endregion

        #region txtDiametro 5
        protected void txtDiametro5_TextChanged(object sender, EventArgs e)
        {
            txtVolume5.Text = "";
            lblResp5.Text = "";
        }
        #endregion

        #endregion

        #region EX6

        #region Limpar 6
        protected void btnLimpar6_Click(object sender, EventArgs e)
        {
            Limpar6();
        }

        #endregion 

        #region Método Limpar 6
        private void Limpar6()
        {
            lblResp6.Text = "";
            txtMedia6.Text = "";
            txtV16.Text = "";
            txtV26.Text = "";
            txtV36.Text = "";
            txtV46.Text = "";
        }
        #endregion

        #region Calcular 6
        protected void btnCalc6_Click(object sender, EventArgs e)
        {
            #region variáveis 6
            double V16 = 0;
            double V26 = 0;
            double V36 = 0;
            double V46 = 0;
            double Media6 = 0;
            #endregion

            #region TryV1 6
            try
            {
                V16 = double.Parse(txtV16.Text);
            }
            catch
            {
                lblResp6.Text = "Digite apenas números na caixa de texto do Valor 1";
                txtV16.Text = "";
                txtV16.Focus();
                return;
            }
            #endregion

            #region TryV2 6
            try
            {
                V26 = double.Parse(txtV26.Text);
            }
            catch
            {
                lblResp6.Text = "Digite apenas números na caixa de texto do Valor 2";
                txtV26.Text = "";
                txtV26.Focus();
                return;
            }
            #endregion

            #region TryV3 6
            try
            {
                V36 = double.Parse(txtV36.Text);
            }
            catch
            {
                lblResp6.Text = "Digite apenas números na caixa de texto do Valor 3";
                txtV36.Text = "";
                txtV36.Focus();
                return;
            }
            #endregion

            #region TryV4 6
            try
            {
                V46 = double.Parse(txtV46.Text);
            }
            catch
            {
                lblResp6.Text = "Digite apenas números na caixa de texto do Valor 4";
                txtV46.Text = "";
                txtV46.Focus();
                return;
            }
            #endregion

            #region Cálculo 6
            Media6 = (V16 + V26 + V36 + V46) / 4;
            #endregion

            #region Mostrar
            txtMedia6.Text = Media6.ToString("#0.0");
            lblResp6.Text = Media6.ToString("#0.0"); 
            #endregion
        }
        #endregion

        #region txtV1 6
        protected void txtV16_TextChanged(object sender, EventArgs e)
        {
            lblResp6.Text = "";
            txtMedia6.Text = "";
        }
        #endregion 

        #region txtV2 6
        protected void txtV26_TextChanged(object sender, EventArgs e)
        {
            lblResp6.Text = "";
            txtMedia6.Text = "";
        }
        #endregion

        #region txtV3 6
        protected void txtV36_TextChanged(object sender, EventArgs e)
        {
            lblResp6.Text = "";
            txtMedia6.Text = "";
        }
        #endregion

        #region txtV4 6
        protected void txtV46_TextChanged(object sender, EventArgs e)
        {
            lblResp6.Text = "";
            txtMedia6.Text = "";
        }
        #endregion

        #endregion

        #region EX7

        #region Limpar
        protected void btnLimpar7_Click(object sender, EventArgs e)
        {
            Limpar7();
        }

        #region Método Limpar 7
        private void Limpar7()
        {
            txtV17.Text = "";
            txtV27.Text = "";
            txtMedia7.Text = "";
            lblResp7.Text = "";
        }
        #endregion

        #endregion

        #region Calcular7
        protected void btnCalc7_Click(object sender, EventArgs e)
        {
            #region Variáveis 7
            double V17 = 0;
            double V27 = 0;
            double Media7 = 0;
            #endregion

            #region TryV1 7
            try
            {
                V17 = double.Parse(txtV17.Text);
            }
            catch
            {
                lblResp7.Text = "Digite apenas números na caixa de texto do Valor 1";
                txtV17.Text = "";
                txtV17.Focus();
                return;
            }
            #endregion

            #region TryV2 7
            try
            {
                V27 = double.Parse(txtV27.Text);
            }
            catch
            {
                lblResp7.Text = "Digite apenas números na caixa de texto do Valor 2";
                txtV27.Text = "";
                txtV27.Focus();
                return;
            }
            #endregion

            #region Cálculo
            Media7 = Math.Sqrt((V17 * V27));
            #endregion

            #region Mostrar
            txtMedia7.Text = Media7.ToString("#0.0");
            lblResp7.Text = Media7.ToString("#0.0");
            #endregion
        }
        #endregion

        #region txtV1 7
        protected void txtV17_TextChanged(object sender, EventArgs e)
        {
            txtMedia7.Text = "";
            lblResp7.Text = "";
        }
        #endregion

        #region txtV2 7
        protected void txtV27_TextChanged(object sender, EventArgs e)
        {
            txtMedia7.Text = "";
            lblResp7.Text = "";
        }
        #endregion

        #endregion

        #region EX8

        #region Limpar 8

        protected void btnLimpar8_Click(object sender, EventArgs e)
        {
            Limpar8();
        }

            #region Método Limpar 8
            private void Limpar8()
            {
                txtMilhas8.Text = "";
                txtKm8.Text = "";
                lblResp8.Text = "";
            }
            #endregion

        #endregion

        #region Calcular 8

        protected void btnCalc8_Click(object sender, EventArgs e)
        {
            #region Variáveis 8

            double Km8 = 0;
            double Milhas8 = 0;

            #endregion

            #region TryMilhas 8
            try
            {
                Milhas8 = double.Parse(txtMilhas8.Text);
            }
            catch
            {
                lblResp8.Text = "Digite somente números na caixa de texto de Milhas";
                txtMilhas8.Text = "";
                txtMilhas8.Focus();
                return;
            }
            #endregion

            #region Cálculo 8
            Km8 = Milhas8 * 1.852;
            #endregion

            #region Mostrar
            txtKm8.Text = Km8.ToString("#0.000");
            lblResp8.Text = Km8.ToString("#0.0") + " Km";
            #endregion
        }
       
        #endregion

        #region txtMilhas 8

        #endregion

        #endregion

        #region EX9

            #region Limpar9
                protected void btnLimpar9_Click(object sender, EventArgs e)
                {
                    Limpar9();
                }

                #region Método Limpar 9
                    private void Limpar9()
                    {
                        txtCorrente9.Text = "";
                        txtRes9.Text = "";
                        txtTensao9.Text = "";
                        lblTensao9.Text = "";
                    }
                #endregion

            #endregion

            #region Calcular 9
                protected void btnCalc9_Click(object sender, EventArgs e)
                {
                    #region Variáveis 9
                        double Res9 = 0;
                        double Corrente9 = 0;
                        double Tensao9 = 0;
                    #endregion

                    #region TryResistência 9
                        try
                        {
                            Res9 = double.Parse(txtRes9.Text);
                        }
                        catch
                        {
                            lblResp9.Text = "Digite somente números na caixa de texto da Resistência";
                            txtRes9.Text = "";
                            txtRes9.Focus();
                            return;
                        }
                    #endregion

                    #region TryCorrente 9
                        try
                        {
                            Corrente9 = double.Parse(txtCorrente9.Text);
                        }
                        catch
                        {
                            lblResp9.Text = "Digite somente números na caixa de texto da Corrente";
                            txtCorrente9.Text = "";
                            txtCorrente9.Focus();
                            return;
                        }
                    #endregion

                    #region Cálculo 9
                        Tensao9 = Res9 * Corrente9;
                    #endregion

                    #region Mostrar 9
                        txtTensao9.Text = Tensao9.ToString("#0.00");
                        lblResp9.Text = Tensao9.ToString("#0.0") + " Ohms";
                    #endregion
                }

            #endregion

            #region txtRes 9
                protected void txtRes9_TextChanged(object sender, EventArgs e)
                {
                    lblResp9.Text = "";
                    txtTensao9.Text = "";
                }
            #endregion

            #region txtCorrente 9
                protected void txtCorrente9_TextChanged(object sender, EventArgs e)
                {
                    lblResp9.Text = "";
                    txtTensao9.Text = "";
                }
            #endregion

        #endregion

        #region EX10

            #region Limpar10

                protected void btnLimpar10_Click(object sender, EventArgs e)
                {
                    Limpar10();
                }

                #region Método Limpar 10
                    private void Limpar10()
                    {
                        txtCelsius10.Text = "";
                        txtFah10.Text = "";
                        lblResp10.Text = "";
                    }
                #endregion

            #endregion

            #region Calcular 10
                protected void btnCalc10_Click(object sender, EventArgs e)
                    {
                        #region Variáveis 10
                            double Celsius10 = 0;
                            double Fah10 = 0;
                        #endregion

                        #region TryResistência 10
                            try
                            {
                                Celsius10 = double.Parse(txtCelsius10.Text);
                            }
                            catch
                            {
                                lblResp10.Text = "Digite somente números na caixa de texto dos Celsius";
                                txtCelsius10.Text = "";
                                txtCelsius10.Focus();
                                return;
                            }
                        #endregion

                        #region Cálculo 10
                            Fah10 = ((Celsius10 * 9) / 5) + 32;
                        #endregion

                        #region Mostrar 10
                            txtFah10.Text = Fah10.ToString("#0.0");
                            lblResp10.Text = Fah10.ToString("#0.0") + " ºF";
                        #endregion
                    }

            #endregion

            #region txtCelsius 10
                protected void txtCelsius10_TextChanged(object sender, EventArgs e)
                {
                    txtFah10.Text = "";
                    lblResp10.Text = "";
                }
            #endregion

        #endregion
    }
}