using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace prj35347_BDSeries
{
    public partial class Index : System.Web.UI.Page
    {
        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            litTeste.Text = "";

            string teste = "";

            #region LinhaConexao
            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=prjSerie";
            MySqlConnection conexao = new MySqlConnection(linhaConexao);
            #endregion

            #region tryCatch
            try
            {
                conexao.Open();

                #region Comando
                string comando = "";
                comando = "select max(cd_serie) as codigo from serie;";
                teste = comando;
                #endregion

                #region Executar
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();
                #endregion

                #region ifReadMaxCd
                if (dados.Read())
                {
                    #region pegarMaxCd
                    string cdSla = dados["codigo"].ToString();
                    int cdMaximo = int.Parse(cdSla);
                    #endregion

                    #region For
                    for (int i = 1; i < cdMaximo + 1; i++)
                    {
                        #region Comando
                        comando = " select ";
	                    comando += "    s.cd_serie as Codigo, ";
                        comando += "    s.nm_serie as Nome, ";
                        comando += "    s.nm_original as Original, ";
                        comando += "    aa_ano_lancamento as Lançamento, ";
                        comando += "    s.nm_link_img as Imagem, ";
	                    comando += "    group_concat(c.nm_categoria) as Categorias ";
                        comando += "from serie s ";
                        comando += "join categoria_serie cs on (s.cd_serie = cs.cd_serie) ";
                        comando += "join categoria c on (c.cd_categoria = cs.cd_categoria) ";
                        comando += "where s.cd_serie = " + i.ToString() + " ";
                        comando += "group by s.cd_serie ";
                        comando += "order by s.nm_serie ";
                        teste = comando;
                        #endregion

                        #region Executar
                        conexao.Close();
                        conexao.Open();
                        cSQL = new MySqlCommand(comando, conexao);
                        dados = cSQL.ExecuteReader();
                        #endregion

                        #region If Read Criar Estrutura
                        if (dados.Read())
                        {
                            #region Variáveis
                            string Codigo = dados["Codigo"].ToString();
                            string Foto = dados["Imagem"].ToString();
                            string Nome = dados["Nome"].ToString();
                            string Original = dados["Original"].ToString();
                            string Lancamento = dados["Lançamento"].ToString();
                            string Categorias = dados["Categorias"].ToString();
                            #endregion

                            #region Criar Estrutura
                            litTeste.Text += "<a href='../../Series.aspx?cd=" + Codigo + "'";
                            litTeste.Text += "  <section class='Series'>";
                            litTeste.Text += "      <img src='../../Images/" + Foto + "' class='Images1'/>";
                            litTeste.Text += "      <h3> <strong> " + Nome + " </strong> </h3>";
                            litTeste.Text += "      <h6> " + Original + " - ";
                            litTeste.Text += Lancamento + " - ";
                            litTeste.Text += Categorias + "</h6>";
                            litTeste.Text += "  </section>";
                            litTeste.Text += "</a>";
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion

                conexao.Close();
            }
            catch (Exception ex)
            {
                litTeste.Text = ex.Message;
                litTeste.Text += " <br> " + teste;
            }
            #endregion
        }
        #endregion

        #region btnAdd
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            #region RemoverClasse
            bloqueio.Attributes.Add("class", String.Join(" ", bloqueio
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .ToArray()
            ));

            pnlNovo.Attributes.Add("class", String.Join(" ", pnlNovo
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .ToArray()
            ));
            #endregion
        }
        #endregion

        #region btnCancelar 
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            #region Limpar
            txtNome.Text = "";
            txtOriginal.Text = "";
            txtData.Text = "";
            txtSinopse.InnerText = "";
            #endregion

            #region Retirar Classes
            bloqueio.Attributes.Add("class", String.Join(" ", bloqueio
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .Concat(new string[] { "escondido" })
               .ToArray()
            ));

            pnlNovo.Attributes.Add("class", String.Join(" ", pnlNovo
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .Concat(new string[] { "escondido" })
               .ToArray()
            ));
            #endregion
        }
        #endregion

        #region btnAdicionar
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            #region Validações
            if (txtNome.Text == "")
            {
                msg.InnerText = "Nome Inválido";
                return;
            }

            if (txtOriginal.Text == "")
            {
                msg.InnerText = "Nome Original Inválido";
                return;
            }

            if (txtData.Text == "")
            {
                msg.InnerText = "Data Inválida";
                return;
            }

            if (txtSinopse.InnerText == "")
            {
                msg.InnerText = "Sinopse Inválida";
                return;
            }
            #endregion

            #region LinhaConexao
            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=prjSerie";
            MySqlConnection conexao = new MySqlConnection(linhaConexao);
            #endregion

            #region TryCatch
            try
            {
                conexao.Open();

                #region Comando
                string comando = "";
                comando = "select max(cd_serie) as codigo from serie;";
                #endregion

                #region Executar
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();
                #endregion

                if (dados.Read())
                {
                    #region pegarMaxCd
                    string cdSla = dados["codigo"].ToString();
                    int cdMaximo = (int.Parse(cdSla)) + 1;
                    #endregion

                    #region Variáveis
                    string nome = txtNome.Text;
                    string nomeOriginal = txtOriginal.Text;
                    string data = txtData.Text;
                    string sinopse = txtSinopse.InnerText;
                    #endregion

                    comando = "insert into serie values (" + cdMaximo.ToString() + ", '" + nome + "', '" + nomeOriginal + "', " + data + ", 'interroga.png','" + sinopse + "'); insert into categoria_serie values(" + cdMaximo.ToString() + ", 10);";

                    conexao.Close();
                    conexao.Open();

                    #region Executar
                    cSQL = new MySqlCommand(comando, conexao);
                    cSQL.ExecuteNonQuery();
                    #endregion
                
                }

                conexao.Close();
            }
            catch
            {

            }
            #endregion

            #region Limpar
            txtNome.Text = "";
            txtOriginal.Text = "";
            txtData.Text = "";
            txtSinopse.InnerText = "";
            #endregion

            #region Retirar Classes
            bloqueio.Attributes.Add("class", String.Join(" ", bloqueio
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .Concat(new string[] { "escondido" })
               .ToArray()
            ));

            pnlNovo.Attributes.Add("class", String.Join(" ", pnlNovo
               .Attributes["class"]
               .Split(' ')
               .Except(new string[] { "", "escondido" })
               .Concat(new string[] { "escondido" })
               .ToArray()
            ));
            #endregion

            Response.Redirect(Request.RawUrl);
        }
        #endregion
    }
}