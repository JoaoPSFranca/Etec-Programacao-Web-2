<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="prj35347_XML_Series1.Series" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
                </ul>
            </nav>

            <br/>

            <main>
            
                <h1 id='Sinopse' class='Titulo'> Sinopse </h1>

                <br/>

                <p> <asp:Literal ID="ltlSinopse" runat="server"></asp:Literal> </p>

                <br/>

                <h1 id='Episodios' class='Titulo'> Temporadas e Episódios </h1>

                <br/>

                <div class='g'>
                    <p> Selecione: 
                        <asp:DropDownList ID="dpdTemps" runat="server" class="Select" AutoPostBack="true"></asp:DropDownList>
                    </p>

                    <br/>

                    <h2 class='Titulo'> <asp:Literal ID="ltlTempSelect" runat="server"></asp:Literal>ª Temporada </h2>

                    <br/>

                    <section class='temp'>
                        
                        <asp:Literal ID="ltlEp" runat="server"></asp:Literal>

                    </section>

                </div>

            </main>

        </div>
    </div>
    </form>
</body>
</html>
