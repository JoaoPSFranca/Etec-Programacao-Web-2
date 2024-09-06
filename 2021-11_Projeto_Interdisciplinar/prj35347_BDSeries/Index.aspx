<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prj35347_BDSeries.Index" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <link href="Estilo/Style.css" rel="stylesheet" type="text/css" />

    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title> SériesFlix TV </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>
            <a href='#'> 
                <img src="../../Images/Logo.png" width="180px" class="logo"/>
            </a>
            <asp:Button ID="btnBusc" runat="server" Text="Buscar"> </asp:Button>
            <asp:TextBox ID="TxtSB" runat="server" placeholder="Procurar por séries, episódios, personagens, etc."></asp:TextBox>
        </header>

        <hr/>
             
        <br/>

        <div class="Conteudo">
            <asp:Literal ID="litTeste" runat="server"></asp:Literal>
            
            <asp:Button ID="btnAdd" runat="server" Text="+" class="Series" 
                onclick="btnAdd_Click" />
        </div>

        <div id="bloqueio" class="bloqueio escondido" runat="server"></div>

        <div id="pnlNovo" class="CaixaFlutuante escondido" runat="server">
            <form id="frmNovo">
                <h1 style="color:white"> Adicionar Série </h1>

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
                    <asp:TextBox ID="txtData" runat="server" type="number" name="txtData"></asp:TextBox>
                </p>

                <p>
                    <asp:Label ID="lblSinopse" runat="server" Text="Sinopse da Série:"></asp:Label>
                    <textarea id="txtSinopse" type="text" name="txtSinopse" cols="30" rows="10" runat="server"></textarea>
                </p>

                <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" 
                    onclick="btnAdicionar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" />
                
                <br />
                
                <span id="msg" runat="server" style="color:Red"></span>
            </form>
        </div>
    </div>
    </form>
</body>
</html>
