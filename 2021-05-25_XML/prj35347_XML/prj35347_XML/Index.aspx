<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prj35347_XML.Index" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    
    <link href="Estilo/Style.css" rel="stylesheet" type="text/css" />

    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title> SériesFlix TV </title>

</head>
<body>
    <form id="Form" runat="server">
        <div>

            <header>
                
                <img src="../../Images/Logo.png" width="180px" class="logo"/>
                <asp:Button ID="btnBusc" runat="server" Text="Buscar"> </asp:Button>
                <asp:TextBox ID="TxtSB" runat="server" placeholder="Procurar por séries, episódios, personagens, etc."></asp:TextBox>

            </header>

            <hr/> 

            <br/>

            <div class="Conteudo">

                <asp:Literal ID="litTable" runat="server"></asp:Literal>

            </div>

        </div>
    </form>
</body>
</html>