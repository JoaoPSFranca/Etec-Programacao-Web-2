<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prj35347_Lista02.Index" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title> Lista 2 top </title>
    <link href="Estilo/Style.css" type="text/css" rel="Stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h1> Lista 02 </h1>
        </header>

        <main id="main">
            <div id="Ex1">
                <asp:Label ID="lblEX1" runat="server" Text="1 - Receba um número inteiro entre 1 e 200 e ao clique de um botão o exiba este número em binário com 8 dígitos. "></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtDecimal" runat="server" MaxLength="3" 
                    Placeholder="Em Decimal:" ontextchanged="txtDecimal_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txtBinario" runat="server" ReadOnly="true" Placeholder="Em Binário:"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblResp" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnCalc" runat="server" Text="Calcular" 
                    onclick="btnCalc_Click"/>
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" 
                    onclick="btnLimpar_Click"/>
            </div>

            <div id="Ex2">
                <asp:Label ID="lblEx2" runat="server" Text="2 - Receba um número binário de 8 dígitos e ao clique de um botão o exiba este número em decimal. "></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtBinario2" runat="server" MaxLength="8" 
                    Placeholder="Em Binário:" ontextchanged="txtBinario2_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txtDecimal2" runat="server" ReadOnly="true" Placeholder="Em Decimal:"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblResp2" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnCalc2" runat="server" Text="Calcular" 
                    onclick="btnCalc2_Click"/>
                <asp:Button ID="btnLimpar2" runat="server" Text="Limpar" 
                    onclick="btnLimpar2_Click"/>
            </div>
        </main>

    </form>
</body>
</html>
