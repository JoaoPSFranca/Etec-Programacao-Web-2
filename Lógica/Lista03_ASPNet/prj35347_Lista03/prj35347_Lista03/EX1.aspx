<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX1.aspx.cs" Inherits="prj35347_Lista03.index" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <link href="Estilo/Style.css" rel="stylesheet" type="text/css" />

    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title> Exercício 1 </title>

</head>
<body>

    <header class="h o">

        <a href="Index.html">
            <figure>
                <img src="Images/logo.png" alt="Minha Logo" class="d"/>
            </figure>
        </a>

        <div class="g j">
            <a href="#">
                <h1 class="k"> Combinações </h1>
            </a>
            <a href="EX2.aspx">
                <h1 id="i"> Randomização </h1>
            </a>
        </div>

    </header>

    <form id="EX1" runat="server">
        <div class="l">
            <h2> Cálculo da Quantidade de Combinações </h2>

            <br/>
            
            <div class="p">
                <asp:TextBox ID="txtEspAmos" class="txt" runat="server" placeholder="Espaço Amostral" 
                    ontextchanged="txtEspAmos_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txtTamAmos" class="txt" runat="server" placeholder="Tamanho da Amostra" 
                    ontextchanged="txtTamAmos_TextChanged"></asp:TextBox>
            </div>

            <div class="q">
                <asp:TextBox ID="txtQuan" class="txt" runat="server" placeholder="Quant. Combinações" ReadOnly="true"></asp:TextBox>
            </div>

            <br/>

            <br/>

            <section class="m">
                <asp:Button ID="btnCalc" class="btn" runat="server" Text="Calcular" 
                onclick="btnCalc_Click"/>
                <asp:Button ID="btnLimpar" class="btn" runat="server" Text="Limpar" 
                onclick="btnLimpar_Click" />
            </section>

            <br/>

            <div class="s">
                <asp:Label ID="txtResp" runat="server" Text=""></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>