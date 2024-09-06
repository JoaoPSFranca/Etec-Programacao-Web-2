using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace prj35347_BDSeries
{
    public partial class Series : System.Web.UI.Page
    {
        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            string teste ="";

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

            #region linhaConexao
            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=prjSerie";
            MySqlConnection conexao = new MySqlConnection(linhaConexao);
            #endregion

            #region TryCatch
            try
            {
                conexao.Open();

                #region If !IsPostBack
                if (!IsPostBack)
                {
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
                            #region ifSerie
                            if (Codigo == i)
                            {
                                #region ComandoSelect
                                comando = "select ";
                                comando += "    s.cd_serie as Codigo, ";
                                comando += "    s.nm_serie as Nome, ";
                                comando += "     s.nm_original as Original, ";
                                comando += "    aa_ano_lancamento as Ano, ";
                                comando += "    s.nm_link_img as Foto, ";
                                comando += "    s.ds_sinopse_serie as Sinopse, ";
                                comando += "    group_concat(c.nm_categoria) as Categorias ";
                                comando += "from serie s  ";
                                comando += "join categoria_serie cs on (s.cd_serie = cs.cd_serie)  ";
                                comando += "join categoria c on (c.cd_categoria = cs.cd_categoria) ";
                                comando += "where s.cd_serie = " + i.ToString() + " ";
                                comando += "group by s.cd_serie;";
                                teste = comando;
                                #endregion

                                #region ExecutarComando
                                conexao.Close();
                                conexao.Open();
                                cSQL = new MySqlCommand(comando, conexao);
                                dados = cSQL.ExecuteReader();
                                #endregion

                                #region ifReadGeral
                                if (dados.Read())
                                {
                                    #region Variáveis
                                    string Image = dados["Foto"].ToString();
                                    string Categorias = dados["Categorias"].ToString();
                                    #endregion

                                    #region ComandoEpsTemps
                                    comando = "select max(cd_temporada) as Temporadas, count(cd_episodio) as Episodios from episodio where cd_serie = " + i.ToString() + ";";
                                    teste = comando;
                                    #endregion

                                    #region Executar
                                    conexao.Close();
                                    conexao.Open();
                                    cSQL = new MySqlCommand(comando, conexao);
                                    dados = cSQL.ExecuteReader();
                                    #endregion

                                    #region ifReadEpsTemps
                                    if (dados.Read())
                                    {
                                        #region VariaveisEpsTemps
                                        string Episodios = dados["Episodios"].ToString();
                                        string Temporadas = dados["Temporadas"].ToString();
                                        #endregion

                                        #region Mostrar
                                        ltlImage.Text = "<img src='../../Images/" + Image + "' class='Images'/>";
                                        ltlEps.Text = Episodios;
                                        ltlTemp.Text = Temporadas;
                                        ltlCategorias.Text = Categorias;
                                        #endregion

                                        #region dpdTemps
                                        int Temps = int.Parse(Temporadas);

                                        for (int j = 1; j <= Temps; j++)
                                        {
                                            dpdTemps.Items.Add(new ListItem(j.ToString() + "º Temporada", j.ToString()));
                                        }
                                        #endregion
                                    }
                                    #endregion
                                }
                                #endregion
                            }
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region If IsPostBack
                try
                {
                    conexao.Close();
                    conexao.Open();

                    #region Comando
                    string comando = "";
                    comando = "select max(cd_serie) as codigo from serie;";
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
                            #region ifSerie
                            if (Codigo == i)
                            {
                                #region ComandoSelect
                                comando = "select ";
                                comando += "    nm_serie as Nome, ";
                                comando += "    nm_original as Original, ";
                                comando += "    aa_ano_lancamento as Ano, ";
                                comando += "    ds_sinopse_serie as Sinopse ";
                                comando += "from serie s  ";
                                comando += "where s.cd_serie = " + i.ToString() + "; ";
                                #endregion

                                #region ExecutarComando
                                conexao.Close();
                                conexao.Open();
                                cSQL = new MySqlCommand(comando, conexao);
                                dados = cSQL.ExecuteReader();
                                #endregion

                                #region ifReadGeral
                                if (dados.Read())
                                {
                                    #region Variáveis
                                    string Nome = dados["Nome"].ToString();
                                    string Ano = dados["Ano"].ToString();
                                    string Original = dados["Original"].ToString();
                                    string Sinopse = dados["Sinopse"].ToString();
                                    #endregion

                                    #region Mostrar
                                    ltlNome.Text = Nome;
                                    ltlAno.Text = Ano;
                                    ltlOriginal.Text = Original;
                                    ltlSinopse.Text = Sinopse;
                                    #endregion
                                }
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
                    txtSinopse.InnerText = ex.Message;
                }
                #endregion

                #region ltlTempSelect
                ltlTempSelect.Text = dpdTemps.SelectedValue.ToString();
                #endregion

                #region Pegar o número
                string Numero = dpdTemps.SelectedValue.ToString();
                #endregion

                #region Limpar ltl
                ltlEp.Text = "";
                #endregion

                #region Comando3
                string comando3 = "";
                comando3 = "select max(cd_serie) as codigo from serie;";
                teste = comando3;
                #endregion

                #region ExecutarComando3
                conexao.Close();
                conexao.Open();
                MySqlCommand cSQL3 = new MySqlCommand(comando3, conexao);
                MySqlDataReader dados3 = cSQL3.ExecuteReader();
                #endregion

                #region IfGeralDados3
                if (dados3.Read())
                {
                    #region pegarMaxCd
                    string cdSla = dados3["codigo"].ToString();
                    int cdMaximo = int.Parse(cdSla);
                    #endregion

                    #region ForSerie
                    for (int i = 1; i < cdMaximo + 1; i++)
                    {
                        #region ifSerie
                        if (Codigo == i)
                        {
                            #region ComandoEpsTemps
                            comando3 = "select max(cd_temporada) as Temporadas, count(cd_episodio) as Episodios from episodio where cd_serie = " + i.ToString() + ";";
                            teste = comando3;
                            #endregion

                            #region ExecutarComando
                            conexao.Close();
                            conexao.Open();
                            cSQL3 = new MySqlCommand(comando3, conexao);
                            dados3 = cSQL3.ExecuteReader();
                            #endregion

                            #region IfReadTemporada
                            if (dados3.Read())
                            {
                                #region VariaveisEpsTemps
                                string Episodios = dados3["Episodios"].ToString();
                                string Temporadas = dados3["Temporadas"].ToString();
                                #endregion

                                #region ForTemporada
                                for (int j = 1; j < int.Parse(Temporadas) + 1; j++)
                                {
                                    #region IfTemporada
                                    if (j == int.Parse(Numero))
                                    {
                                        #region Comando
                                        comando3 = "select max(cd_episodio) as maxEpisodios from episodio where cd_temporada = " + j.ToString() + " and cd_serie = " + i.ToString() + ";";
                                        teste = comando3;
                                        #endregion

                                        #region ExecutarComando
                                        conexao.Close();
                                        conexao.Open();
                                        cSQL3 = new MySqlCommand(comando3, conexao);
                                        dados3 = cSQL3.ExecuteReader();
                                        #endregion

                                        #region ifMaxEps
                                        if (dados3.Read())
                                        {
                                            #region Variáveis
                                            string maxEpisodios = dados3["maxEpisodios"].ToString();
                                            int Z = 0;
                                            #endregion

                                            #region Mostrar na Tela Eps
                                            for (int n = 1; n < int.Parse(maxEpisodios) + 1; n++)
                                            {
                                                #region Comando
                                                comando3 = "select ";
                                                comando3 += "	cd_episodio as EpNumero, ";
                                                comando3 += "	nm_episodio as EpNome, ";
                                                comando3 += "	nm_original as EpOriginal, ";
                                                comando3 += "	date_format(dt_lancamento, '%d/%m/%Y') as EpData, ";
                                                comando3 += "	qt_duracao as EpTempo, ";
                                                comando3 += "	ds_sinopse_episodio as EpSinopse, ";
                                                comando3 += "	ds_observacao as EpObs ";
                                                comando3 += "from episodio ";
                                                comando3 += "where cd_temporada = " + j.ToString() + " and cd_serie = " + i.ToString() + " and cd_episodio = " + n.ToString() + ";";
                                                teste = comando3;
                                                #endregion

                                                #region ExecutarComando
                                                conexao.Close();
                                                conexao.Open();
                                                cSQL3 = new MySqlCommand(comando3, conexao);
                                                dados3 = cSQL3.ExecuteReader();
                                                #endregion

                                                #region IfSelectEps
                                                if (dados3.Read())
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
                                                    ltlEp.Text += " <h3> " + dados3["EpNumero"].ToString() + " - " + dados3["EpNome"].ToString() + " </h3>";
                                                    ltlEp.Text += " <h5>";
                                                    ltlEp.Text += "     <i> " + dados3["EpOriginal"].ToString() + " - Exibição em: " + dados3["EpData"].ToString() + " - " + dados3["EpTempo"].ToString() + "min </i>";
                                                    ltlEp.Text += " </h5>";
                                                    ltlEp.Text += " <br/>";
                                                    ltlEp.Text += " <p>";
                                                    ltlEp.Text += "     " + dados3["EpSinopse"].ToString();
                                                    ltlEp.Text += " </p>";
                                                    ltlEp.Text += " <br/>";
                                                    ltlEp.Text += " <h5> Observação: </h5>";
                                                    ltlEp.Text += " <p>";
                                                    #endregion

                                                    #region Verificar se tem Observação
                                                    if (dados3["EpObs"].ToString() == "")
                                                    {
                                                        ltlEp.Text += "     Nenhuma Observação Encontrada!";
                                                    }
                                                    else
                                                    {
                                                        ltlEp.Text += dados3["EpObs"].ToString();
                                                    }
                                                    #endregion

                                                    #region Terminar a estrutura
                                                    ltlEp.Text += " </p>";
                                                    ltlEp.Text += "</article>";
                                                    #endregion
                                                }
                                                #endregion
                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    #endregion
                                }
                                #endregion
                            }
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
                ltlSinopse.Text = ex.Message;
                ltlSinopse.Text += teste;
            }
            #endregion

        }
        #endregion

        #region btnEditar
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            #region AdicionarClasse
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

            #region Pegar Codigo
            string codigo = Request["cd"].ToString();
            int Codigo = int.Parse(codigo);
            #endregion

            #region linhaConexao
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
                        #region ifSerie
                        if (Codigo == i)
                        {
                            #region ComandoSelect
                            comando = "select ";
                            comando += "    nm_serie as Nome, ";
                            comando += "    nm_original as Original, ";
                            comando += "    aa_ano_lancamento as Ano, ";
                            comando += "    ds_sinopse_serie as Sinopse ";
                            comando += "from serie s  ";
                            comando += "where s.cd_serie = " + i.ToString() + "; ";
                            #endregion

                            #region ExecutarComando
                            conexao.Close();
                            conexao.Open();
                            cSQL = new MySqlCommand(comando, conexao);
                            dados = cSQL.ExecuteReader();
                            #endregion

                            #region ifReadGeral
                            if (dados.Read())
                            {
                                #region Variáveis
                                string Nome = dados["Nome"].ToString();
                                string Ano = dados["Ano"].ToString();
                                string Original = dados["Original"].ToString();
                                string Sinopse = dados["Sinopse"].ToString();
                                #endregion

                                #region Mostrar
                                txtNome.Text = Nome;
                                txtData.Text = Ano;
                                txtOriginal.Text = Original;
                                txtSinopse.InnerText = Sinopse;
                                #endregion
                            }
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
                txtSinopse.InnerText = ex.Message;
            }
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

        #region btnSalvar
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Pegar Codigo
            string codigo = Request["cd"].ToString();
            int Codigo = int.Parse(codigo);
            #endregion

            #region linhaConexao
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
                        #region ifSerie
                        if (Codigo == i)
                        {
                            #region ComandoSelect
                            comando = "update serie set ";
                            comando += "	nm_serie = '" + txtNome.Text + "', ";
                            comando += "	nm_original = '" + txtOriginal.Text + "', ";
                            comando += "	aa_ano_lancamento = " + txtData.Text + ", ";
                            comando += "	ds_sinopse_serie = '" + txtSinopse.InnerText + "' ";
                            comando += "where cd_serie = " + i.ToString() + "; ";
                            #endregion

                            #region ExecutarComando
                            conexao.Close();
                            conexao.Open();
                            cSQL = new MySqlCommand(comando, conexao);
                            cSQL.ExecuteNonQuery();
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
                txtSinopse.InnerText = ex.Message;
            }
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

        #region btnLixo
        protected void btnLixo_Click(object sender, EventArgs e)
        {
            #region Pegar Codigo
            string codigo = Request["cd"].ToString();
            #endregion

            #region linhaConexao
            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=prjSerie";
            MySqlConnection conexao = new MySqlConnection(linhaConexao);
            #endregion

            #region TryCatch
            try
            {
                conexao.Open();

                #region Delete Categoria_serie

                #region Comando
                string comando = "delete from categoria_serie where cd_serie = " + codigo + "; ";
                #endregion

                #region Executar
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();
                #endregion

                #endregion

                #region Delete episodio

                #region Comando
                comando = "delete from episodio where cd_serie = " + codigo + "; ";
                #endregion

                #region Executar
                conexao.Close();
                conexao.Open();
                cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();
                #endregion

                #endregion

                #region Delete serie

                #region Comando
                comando = "delete from serie where cd_serie = " + codigo + "; ";
                #endregion

                #region Executar
                conexao.Close();
                conexao.Open();
                cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();
                #endregion

                #endregion
            }
            catch (Exception ex)
            {
                txtSinopse.InnerText = ex.Message;
                return;
            }

            Response.Redirect("Index.aspx");
            #endregion
        }
        #endregion
    }
}