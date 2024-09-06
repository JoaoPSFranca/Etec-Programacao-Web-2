<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prj35347_Pre_Licao.Index" %>

<!DOCTYPE html>

<html>
<head runat="server">
    
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

                <section class="Series">
                    <img src="../../Images/TheFlash.jpg" class="Images"/>
                    <h3> <strong> Flash </strong> </h3>
                    <h6> The Flash - 2014 - Ação, Drama, Ficção Científica  </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/Arrow.jpg" class="Images"/>
                    <h3> <strong> Arqueiro </strong> </h3>
                    <h6> Arrow - 2012 - Ação, Aventura, Mistério </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/Legends_of_Tomorrow.png" class="Images"/>
                    <h3> <strong> Lendas do Amanhã da DC </strong> </h3>
                    <h6> DC's Legends of Tomorrow - 2016 - Aventura, Comédia, Ficção Científica </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/WandaVision.png" class="Images"/>
                    <h3> <strong> Wanda e Visão </strong> </h3>
                    <h6> WandaVision - 2021 - Ação, Comédia, Sitcom </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/FalcaoSoldado.jpg" class="Images"/>
                    <h3> <strong> Falcão e o Soldado Invernal </strong> </h3>
                    <h6> The Falcon and The Winter Soldier - 2021 - Ação, Aventura, Fantasia </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/Inhumans.jpg" class="Images"/>
                    <h3> <strong> Inumanos </strong> </h3>
                    <h6> Marvel's Inhumans - 2017 - Ação, Drama, Ficção Científica </h6>
                </section>

                <section class="Series">
                    <img src="../../Images/Mandalorian.jpg" class="Images"/>
                    <h3> <strong> O Mandaloriano </strong> </h3>
                    <h6> The Mandalorian - 2019 - Drama, Ficção Científica, Western espacial </h6>
                </section>

            </div>

        </div>
    </form>
</body>
</html>
