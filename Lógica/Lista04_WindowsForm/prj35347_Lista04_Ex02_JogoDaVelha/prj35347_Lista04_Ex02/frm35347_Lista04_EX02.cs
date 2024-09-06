using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista04_Ex02
{
    public partial class frm35347_Lista04_EX02 : Form
    {
        #region Inicializar
        public frm35347_Lista04_EX02()
        {
            InitializeComponent();
        }
        #endregion

        #region Resetar
        private void btnResetar_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        #region Método
        private void Resetar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            x = 1;
        }
        #endregion
        #endregion

        #region btns
            #region Variáveis Globais
            int x = 1;
            string Btn1 = "";
            string Btn2 = "";
            string Btn3 = "";
            string Btn4 = "";
            string Btn5 = "";
            string Btn6 = "";
            string Btn7 = "";
            string Btn8 = "";
            string Btn9 = "";
            #endregion
            
            #region btn1
            private void btn1_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn1.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn1.Text = "O";
                    x = x - 1;
                }

                Btn1 = btn1.Text;

                btn1.Enabled = false;

                #region if
                if (String.Equals(Btn1, Btn2) & String.Equals(Btn2, Btn3))
                {
                    lblResp.Text = "O Jogador " + Btn1 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn1, Btn4) & String.Equals(Btn4, Btn7))
                    {
                        lblResp.Text = "O Jogador " + Btn1 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        if (String.Equals(Btn1, Btn5) & String.Equals(Btn5, Btn9))
                        {
                            lblResp.Text = "O Jogador " + Btn1 + " venceu";
                            Resetar();
                        }
                        else
                        {
                            lblResp.Text = "";
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region btn2
            private void btn2_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn2.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn2.Text = "O";
                    x = x - 1;
                }

                Btn2 = btn2.Text;

                btn2.Enabled = false;

                #region if
                if (String.Equals(Btn1, Btn2) & String.Equals(Btn2, Btn3))
                {
                    lblResp.Text = "O Jogador " + Btn1 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn2, Btn5) & String.Equals(Btn5, Btn8))
                    {
                        lblResp.Text = "O Jogador " + Btn2 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        lblResp.Text = "";
                    }
                }
                #endregion
            }
            #endregion

            #region btn3
            private void btn3_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn3.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn3.Text = "O";
                    x = x - 1;
                }

                Btn3 = btn3.Text;

                btn3.Enabled = false;

                #region if
                if (String.Equals(Btn1, Btn2) & String.Equals(Btn2, Btn3))
                {
                    lblResp.Text = "O Jogador " + Btn1 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn3, Btn6) & String.Equals(Btn6, Btn9))
                    {
                        lblResp.Text = "O Jogador " + Btn3 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        if (String.Equals(Btn3, Btn5) & String.Equals(Btn5, Btn7))
                        {
                            lblResp.Text = "O Jogador " + Btn7 + " venceu";
                            Resetar();
                        }
                        else
                        {
                            lblResp.Text = "";
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region btn4
            private void btn4_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn4.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn4.Text = "O";
                    x = x - 1;
                }

                Btn4 = btn4.Text;

                btn4.Enabled = false;

                #region if
                if (String.Equals(Btn4, Btn5) & String.Equals(Btn4, Btn6))
                {
                    lblResp.Text = "O Jogador " + Btn4 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn1, Btn4) & String.Equals(Btn4, Btn7))
                    {
                        lblResp.Text = "O Jogador " + Btn1 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        lblResp.Text = "";
                    }
                }
                #endregion
            }
            #endregion

            #region btn5
            private void btn5_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn5.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn5.Text = "O";
                    x = x - 1;
                }

                Btn5 = btn5.Text;

                btn5.Enabled = false;

                #region if
                if (String.Equals(Btn4, Btn5) & String.Equals(Btn4, Btn6))
                {
                    lblResp.Text = "O Jogador " + Btn4 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn2, Btn5) & String.Equals(Btn5, Btn8))
                    {
                        lblResp.Text = "O Jogador " + Btn2 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        if (String.Equals(Btn1, Btn5) & String.Equals(Btn5, Btn9))
                        {
                            lblResp.Text = "O Jogador " + Btn1 + " venceu";
                            Resetar();
                        }
                        else
                        {
                            if (String.Equals(Btn3, Btn5) & String.Equals(Btn5, Btn7))
                            {
                                lblResp.Text = "O Jogador " + Btn7 + " venceu";
                                Resetar();
                            }
                            else
                            {
                                lblResp.Text = "";
                            }
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region btn6
            private void btn6_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn6.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn6.Text = "O";
                    x = x - 1;
                }

                Btn6 = btn6.Text;

                btn6.Enabled = false;

                #region if
                if (String.Equals(Btn4, Btn5) & String.Equals(Btn4, Btn6))
                {
                    lblResp.Text = "O Jogador " + Btn4 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn3, Btn6) & String.Equals(Btn6, Btn9))
                    {
                        lblResp.Text = "O Jogador " + Btn3 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        lblResp.Text = "";
                    }
                }
                #endregion
            }
            #endregion

            #region btn7
            private void btn7_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn7.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn7.Text = "O";
                    x = x - 1;
                }

                Btn7 = btn7.Text;

                btn7.Enabled = false;

                #region if
                if (String.Equals(Btn7, Btn8) & String.Equals(Btn7, Btn9))
                {
                    lblResp.Text = "O Jogador " + Btn7 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn1, Btn4) & String.Equals(Btn4, Btn7))
                    {
                        lblResp.Text = "O Jogador " + Btn1 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        if (String.Equals(Btn3, Btn5) & String.Equals(Btn5, Btn7))
                        {
                            lblResp.Text = "O Jogador " + Btn7 + " venceu";
                            Resetar();
                        }
                        else
                        {
                            lblResp.Text = "";
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region btn8
            private void btn8_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn8.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn8.Text = "O";
                    x = x - 1;
                }

                Btn8 = btn8.Text;

                btn8.Enabled = false;

                #region if
                if (String.Equals(Btn7, Btn8) & String.Equals(Btn7, Btn9))
                {
                    lblResp.Text = "O Jogador " + Btn7 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn2, Btn5) & String.Equals(Btn5, Btn8))
                    {
                        lblResp.Text = "O Jogador " + Btn2 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        lblResp.Text = "";
                    }
                }
                #endregion
            }
            #endregion

            #region btn9
            private void btn9_Click(object sender, EventArgs e)
            {
                if (x == 1)
                {
                    btn9.Text = "X";
                    x = x + 1;
                }
                else
                {
                    btn9.Text = "O";
                    x = x - 1;
                }

                Btn9 = btn9.Text;

                btn9.Enabled = false;

                #region if
                if (String.Equals(Btn7, Btn8) & String.Equals(Btn7, Btn9))
                {
                    lblResp.Text = "O Jogador " + Btn7 + " venceu";
                    Resetar();
                }
                else
                {
                    if (String.Equals(Btn3, Btn6) & String.Equals(Btn6, Btn9))
                    {
                        lblResp.Text = "O Jogador " + Btn3 + " venceu";
                        Resetar();
                    }
                    else
                    {
                        if (String.Equals(Btn1, Btn5) & String.Equals(Btn5, Btn9))
                        {
                            lblResp.Text = "O Jogador " + Btn1 + " venceu";
                            Resetar();
                        }
                        else
                        {
                            lblResp.Text = "";
                        }
                    }
                }
                #endregion
            }
            #endregion
        #endregion
    }
}
