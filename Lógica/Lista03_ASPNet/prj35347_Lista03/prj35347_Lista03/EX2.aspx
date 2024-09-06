<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX2.aspx.cs" Inherits="prj35347_Lista03.EX2" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <link href="Estilo/Style.css" rel="stylesheet" type="text/css" />

    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title> Exercício 2 </title>

</head>
<body>

    <header class="h o">

        <a href="Index.html">
            <figure>
                <img src="Images/logo.png" alt="Minha Logo" class="d"/>
            </figure>
        </a>

        <div class="g j">
            <a href="EX1.aspx">
                <h1 class="k"> Combinações </h1>
            </a>
            <a href="#">
                <h1 id="i"> Randomização </h1>
            </a>
        </div>

    </header>

    <form id="EX2" runat="server">
    <div class="l n">
        <h2> Gerador de Números Aleatórios </h2>

        <br/>

        <div class="b">
            <asp:ListBox ID="ltbNum" runat="server"></asp:ListBox>
        </div>
        <br/>

        <section class="m r">
            <asp:Button ID="btnGerar" class="btn" runat="server" Text="Gerar" 
            onclick="btnGerar_Click"/>
            <asp:Button ID="btnLimpar2" class="btn" runat="server" Text="Limpar" 
            onclick="btnLimpar2_Click" />
        </section>
    </div>
    </form>
</body>
</html>