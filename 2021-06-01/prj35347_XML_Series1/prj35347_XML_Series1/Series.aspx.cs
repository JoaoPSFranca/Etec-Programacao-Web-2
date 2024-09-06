using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace prj35347_XML_Series1
{
    public partial class Series : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Redirect
            if (Request["cd"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            #endregion

            #region Pegar Codigo
            string codigo = Request["cd"].ToString();
            int Codigo = int.Parse(codigo);
            #endregion

            #region !IsPostBack
            if (!IsPostBack)
            {
                #region arquivo
                XmlDocument arquivo = new XmlDocument();
                if (File.Exists(Request.PhysicalApplicationPath + @"\XML\Series.xml"))
                {
                    #region Criando a Lista
                    arquivo.Load(Request.PhysicalApplicationPath + @"\XML\Series.xml");

                    XmlNodeList ListaSeries = arquivo.GetElementsByTagName("SERIE");
                    #endregion

                    #region Verificando a lista
                    for (int i = 0; i < ListaSeries.Count; i++)
                    {
                        #region Formatação da Página CD
                        if (codigo == ListaSeries[i]["Codigo"].InnerText)
                        {
                            #region Variáveis
                            string Nome = ListaSeries[i]["Nome"].InnerText;
                            string Ano = ListaSeries[i]["Ano"].InnerText;
                            string Original = ListaSeries[i]["Original"].InnerText;
                            string Image = ListaSeries[i]["Foto"].InnerText;
                            string Sinopse = ListaSeries[i]["Sinopse"].InnerText;
                            string Episodios = ListaSeries[i]["Episodios"].InnerText;
                            string Temporadas = ListaSeries[i]["Temporadas"].InnerText;
                            #endregion

                            #region Mostrar
                            ltlNome.Text = Nome;
                            ltlAno.Text = Ano;
                            ltlOriginal.Text = Original;
                            ltlImage.Text = "<img src='../../Images/" + Image + "' class='Images'/>";
                            ltlSinopse.Text = Sinopse;
                            ltlEps.Text = Episodios;
                            ltlTemp.Text = Temporadas;
                            #endregion

                            #region dpdTemps
                            int Temps = int.Parse(Temporadas);

                            for (int j = 1; j <= Temps; j++)
                            {
                                dpdTemps.Items.Add(new ListItem(j.ToString() + "º Temporada", j.ToString()));
                            }
                            #endregion

                            #region ListaCategorias

                            #region Criar ListaCategorias
                            XmlNodeList ListaCategorias = ListaSeries[i]["Categorias"].GetElementsByTagName("Categoria");
                            #endregion

                            #region Criar Categorias
                            string Categorias = "";

                            for (int k = 0; k < ListaCategorias.Count; k++)
                            {
                                Categorias += ListaCategorias[k].InnerText + ", ";
                            }
                            #endregion

                            #region Mostrar
                            ltlCategorias.Text = Categorias.ToString().Substring(0, Categorias.Length - 2);
                            #endregion

                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            #region ltlTempSelect
            ltlTempSelect.Text = dpdTemps.SelectedValue.ToString();
            #endregion

            #region Mostrar Temporadas

            if (File.Exists(Request.PhysicalApplicationPath + @"\XML\Series.xml"))
            {
                #region Criando a ListaSerie
                XmlDocument arquivo2 = new XmlDocument();

                arquivo2.Load(Request.PhysicalApplicationPath + @"\XML\Series.xml");

                XmlNodeList ListaSeries = arquivo2.GetElementsByTagName("SERIE");
                #endregion

                #region Pegar o número
                string Numero = dpdTemps.SelectedValue.ToString();
                #endregion

                #region Limpar ltl
                ltlEp.Text = "";
                #endregion

                #region Mostrar na Tela

                #region For da ListaSeries
                for (int l = 0; l < ListaSeries.Count; l++)
                {
                    if (codigo == ListaSeries[l]["Codigo"].InnerText)
                    {
                        #region Criar a ListaTemps
                        XmlNodeList ListaTemps = ListaSeries[l]["Temps"].GetElementsByTagName("Temp");
                        #endregion

                        #region For ListaTemps
                        for (int m = 0; m < ListaTemps.Count; m++)
                        {
                            if (Numero == ListaTemps[m]["Numero"].InnerText)
                            {
                                #region Criar a ListaEps
                                XmlNodeList ListaEps = ListaTemps[m]["Eps"].GetElementsByTagName("Ep");
                                #endregion

                                #region Variável Z
                                int Z = 0;
                                #endregion

                                #region Mostrar na Tela Eps
                                for (int n = 0; n < ListaEps.Count; n++)
                                {
                                    #region Verificar X1 ou X2
                                    if (Z == 0)
                                    {
                                        ltlEp.Text += "<article class='art X1'>";
                                        Z = 1;
                                    }
                                    else
                                    {
                                        ltlEp.Text += "<article class='art X2'>";
                                        Z = 0;
                                    }
                                    #endregion

                                    #region Criar estrutura
                                    ltlEp.Text += " <h3> " + ListaEps[n]["EpNumero"].InnerText + " - " + ListaEps[n]["EpNome"].InnerText + " </h3>";
                                    ltlEp.Text += " <h5>";
                                    ltlEp.Text += "     <i> " + ListaEps[n]["EpOriginal"].InnerText + " - Exibição em: " + ListaEps[n]["EpData"].InnerText + " - " + ListaEps[n]["EpTempo"].InnerText + " </i>";
                                    ltlEp.Text += " </h5>";
                                    ltlEp.Text += " <br/>";
                                    ltlEp.Text += " <p>";
                                    ltlEp.Text += "     " + ListaEps[n]["EpSinopse"].InnerText;
                                    ltlEp.Text += " </p>";
                                    ltlEp.Text += " <br/>";
                                    ltlEp.Text += " <h5> Observação: </h5>";
                                    ltlEp.Text += " <p>";
                                    #endregion

                                    #region Verificar se tem Observação
                                    if (ListaEps[n]["EpObs"].InnerText == "")
                                    {
                                        ltlEp.Text += "     Nenhuma Observação Encontrada!";
                                    }
                                    else
                                    {
                                        ltlEp.Text += ListaEps[n]["EpObs"].InnerText;
                                    }
                                    #endregion

                                    #region Terminando a estrutura
                                    ltlEp.Text += " </p>";
                                    ltlEp.Text += "</article>";
                                    #endregion
                                }
                                #endregion
                            }
                        }
                        #endregion
                    }
                }

                
                #endregion

                #endregion
            }

            #endregion
        }
        #endregion
    }
} 