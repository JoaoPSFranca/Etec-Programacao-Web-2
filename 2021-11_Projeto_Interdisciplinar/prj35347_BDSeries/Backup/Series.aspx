<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="prj35347_BDSeries.Series" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href='Estilo/Style.css' rel='stylesheet' type='text/css' />

    <meta name='viewport' content='width=device-width, initial-scale=1.0' />

    <title> SériesFlix TV </title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>  
            <a href='../../Index.aspx'> 
                <img src='../../Images/Logo.png' width='180px' class='logo'/> 
            </a>
            <input id='btnBusc' type='button' value='Buscar' />
            <input id='TxtSB' type='text' placeholder='Procurar por séries, episódios, personagens, etc.' />
        </header>

        <hr/> 

        <br/>

        <div class='a'>

            <section class='b'>

                <article>
                    <asp:Literal ID="ltlImage" runat="server"></asp:Literal>
                </article>

                <article class='d'>

                    <h1 class='e'> <asp:Literal ID="ltlNome" runat="server"></asp:Literal> </h1>

                    <h5 class='f h'> <strong> Título Original: </strong> <asp:Literal ID="ltlOriginal" runat="server"></asp:Literal> </h5>

                    <br/>

                    <h5 class='f'> <strong> Ano de Estreia: </strong> <asp:Literal ID="ltlAno" runat="server"></asp:Literal> </h5>

                    <br/>

                    <h5 class='f'> <strong> Categorias: </strong> <asp:Literal ID="ltlCategorias" runat="server"></asp:Literal> </h5>

                    <br/>

                    <h5 class='f'> <strong> Temporadas: </strong> <asp:Literal ID="ltlTemp" runat="server"></asp:Literal> | <strong> Episódios: </strong> <asp:Literal ID="ltlEps" runat="server"></asp:Literal> </h5>

                </article>

            </section>

            <nav>
                <ul>
                    <li><a href='#Sinopse'> Sinopse </a></li>
                    <li><a href='#Episodios'> Temporadas e Episódios </a></li>
                    <asp:Button ID="btnLixo" runat="server" Text="" type="button" 
                            onclick="btnLixo_Click" />
                    <article class="i"> 
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" type='button' onclick="btnEditar_Click"></asp:Button> 
                    </article>
                </ul>
            </nav>

            <br/>

            <main>
            
                <h1 id='Sinopse' class='Titulo'> Sinopse </h1>

                <br/>

                <p> <asp:Literal ID="ltlSinopse" runat="server"></asp:Literal> </p>

                <br/>

                <br/>

                <h1 id='Episodios' class='Titulo'> Temporadas e Episódios </h1>

                <div class='g'>
                    <p> Selecione: 
                        <asp:DropDownList ID="dpdTemps" runat="server" class="Select" AutoPostBack="true"></asp:DropDownList>
                    </p>

                    <br/>

                    <br/>

                    <h2 class='Titulo'> <asp:Literal ID="ltlTempSelect" runat="server"></asp:Literal>ª Temporada </h2>

                    <br/>

                    <section class='temp'>
                        
                        <asp:Literal ID="ltlEp" runat="server"></asp:Literal>

                    </section>

                </div>

            </main>

            <div id="bloqueio" class="bloqueio escondido" runat="server"></div>

            <div id="pnlNovo" class="CaixaFlutuante escondido" runat="server">
                <form id="frmNovo">
                    <h1 style="color:white"> Editar Série </h1>

                    <p>
                        <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" type="text" name="txtNome"></asp:TextBox>
                    </p>

                    <br />

                    <p>
                        <asp:Label ID="lblOriginal" runat="server" Text="Nome Original:"></asp:Label>
                        <asp:TextBox ID="txtOriginal" runat="server" type="text" name="txtOriginal"></asp:TextBox>
                    </p>

                    <br />

                    <p>
                        <asp:Label ID="lblData" runat="server" Text="Ano de Lançamento:"></asp:Label>
                        <asp:TextBox ID="txtData" runat="server" type="number" minlength="4" MaxLength="4" name="txtData"></asp:TextBox>
                    </p>

                    <p>
                        <asp:Label ID="lblSinopse" runat="server" Text="Sinopse da Série:"></asp:Label>
                        <textarea id="txtSinopse" type="text" name="txtSinopse" cols="30" rows="10" runat="server"></textarea>
                    </p>

                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" onclick="btnSalvar_Click"/>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" type='button' onclick="btnCancelar_Click"/>
                
                    <br />
                
                    <span id="msg" runat="server" style="color:Red"></span>
                </form>
            </div>

        </div>
    </div>
    </form>
</body>
</html>
