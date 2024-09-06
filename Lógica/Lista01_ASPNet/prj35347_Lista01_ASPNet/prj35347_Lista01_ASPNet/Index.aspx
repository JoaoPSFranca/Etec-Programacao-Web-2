<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prj35347_Lista01_ASPNet.Index" %>

<!DOCTYPE>

<html>
<head runat="server">
    
    <title> Lista 1 top </title>

    <link href="Style.css" type="text/css" rel="Stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="Ex1">
        <asp:Label ID="lblEX1" runat="server" Text="EX1"></asp:Label>
        <br />
        <asp:Label ID="lblBase" runat="server" Text="Base"></asp:Label>
        <asp:Label ID="lblAltura" runat="server" Text="Altura"></asp:Label>
        <asp:Label ID="lblArea" runat="server" Text="Área"></asp:Label>
        <br />
        <asp:TextBox ID="txtV1" runat="server" ontextchanged="txtV1_TextChanged" ></asp:TextBox>
        <asp:TextBox ID="txtV2" runat="server" ontextchanged="txtV2_TextChanged" ></asp:TextBox>
        <asp:TextBox ID="txtResp" runat="server"></asp:TextBox>
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
        <asp:Label ID="lblEX2" runat="server" Text="EX2"></asp:Label>
        <br />
        <asp:Label ID="lblAresta2" runat="server" Text="Aresta"></asp:Label>
        <asp:Label ID="lblArea2" runat="server" Text="Área"></asp:Label>
        <br />
        <asp:TextBox ID="txtAresta2" runat="server" 
            ontextchanged="txtAresta2_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtArea2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc2" runat="server" Text="Calcular" 
        onclick="btnCalc2_Click"/>
        <asp:Button ID="btnLimpar2" runat="server" Text="Limpar" 
        onclick="btnLimpar2_Click"/>
    </div>

    <div id="EX3">
        <asp:Label ID="lblEX3" runat="server" Text="EX3"></asp:Label>
        <br />
        <asp:Label ID="lblDiagonal3" runat="server" Text="Diagonal"></asp:Label>
        <asp:Label ID="lblArea3" runat="server" Text="Área"></asp:Label>
        <br />
        <asp:TextBox ID="txtDiagonal3" runat="server" 
            ontextchanged="txtDiagonal3_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtArea3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp3" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc3" runat="server" Text="Calcular" 
            onclick="btnCalc3_Click"/>
        <asp:Button ID="btnLimpar3" runat="server" Text="Limpar" 
            onclick="btnLimpar3_Click"/>
    </div>

    <div id="EX4">
        <asp:Label ID="lblEX4" runat="server" Text="EX4"></asp:Label>
        <br />
        <asp:Label ID="lblBase4" runat="server" Text="Base"></asp:Label>
        <asp:Label ID="lblAltura4" runat="server" Text="Altura"></asp:Label>
        <asp:Label ID="lblArea4" runat="server" Text="Área"></asp:Label>
        <br />
        <asp:TextBox ID="txtBase4" runat="server" ontextchanged="txtBase4_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtAltura4" runat="server" 
            ontextchanged="txtAltura4_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtArea4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp4" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc4" runat="server" Text="Calcular" 
            onclick="btnCalc4_Click"/>
        <asp:Button ID="btnLimpar4" runat="server" Text="Limpar" 
            onclick="btnLimpar4_Click"/>
    </div>

    <div id="EX5">
        <asp:Label ID="lblEX5" runat="server" Text="EX5"></asp:Label>
        <br />
        <asp:Label ID="lblDiametro5" runat="server" Text="Diâmetro"></asp:Label>
        <asp:Label ID="lblVolume5" runat="server" Text="Volume"></asp:Label>
        <br />
        <asp:TextBox ID="txtDiametro5" runat="server" 
            ontextchanged="txtDiametro5_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtVolume5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp5" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc5" runat="server" Text="Calcular" 
            onclick="btnCalc5_Click"/>
        <asp:Button ID="btnLimpar5" runat="server" Text="Limpar" 
            onclick="btnLimpar5_Click"/>
    </div>

    <div id="EX6">
        <asp:Label ID="lblEX6" runat="server" Text="EX6"></asp:Label>
        <br />
        <asp:Label ID="lblV16" runat="server" Text="Valor 1:"></asp:Label>
        <asp:TextBox ID="txtV16" runat="server" ontextchanged="txtV16_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblV26" runat="server" Text="Valor 2:"></asp:Label>
        <asp:TextBox ID="txtV26" runat="server" ontextchanged="txtV26_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblV36" runat="server" Text="Valor 3:"></asp:Label>
        <asp:TextBox ID="txtV36" runat="server" ontextchanged="txtV36_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblV46" runat="server" Text="Valor 4:"></asp:Label>
        <asp:TextBox ID="txtV46" runat="server" ontextchanged="txtV46_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMedia6" runat="server" Text="Média:"></asp:Label>
        <asp:TextBox ID="txtMedia6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblResp6" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc6" runat="server" Text="Calcular" 
            onclick="btnCalc6_Click"/>
        <asp:Button ID="btnLimpar6" runat="server" Text="Limpar" 
            onclick="btnLimpar6_Click"/>
    </div>

    <div id="EX7">
        <asp:Label ID="lblEX7" runat="server" Text="EX7"></asp:Label>
        <br />
        <asp:Label ID="lblV17" runat="server" Text="Valor 1:"></asp:Label>
        <asp:Label ID="lblV27" runat="server" Text="Valor 2:"></asp:Label>
        <asp:Label ID="lblMedia7" runat="server" Text="Média: "></asp:Label>
        <br />
        <asp:TextBox ID="txtV17" runat="server" ontextchanged="txtV17_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtV27" runat="server" ontextchanged="txtV27_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtMedia7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp7" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc7" runat="server" Text="Calcular" 
            onclick="btnCalc7_Click"/>
        <asp:Button ID="btnLimpar7" runat="server" Text="Limpar" 
            onclick="btnLimpar7_Click"/>
    </div>

    <div id="EX8">
        <asp:Label ID="lblEX8" runat="server" Text="EX8"></asp:Label>
        <br />
        <asp:Label ID="lblMilhas8" runat="server" Text="Valor em Milhas"></asp:Label>
        <asp:Label ID="lblKm8" runat="server" Text="Valor em Km"></asp:Label>
        <br />
        <asp:TextBox ID="txtMilhas8" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtKm8" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp8" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc8" runat="server" Text="Calcular" 
            onclick="btnCalc8_Click"/>
        <asp:Button ID="btnLimpar8" runat="server" Text="Limpar" 
            onclick="btnLimpar8_Click"/>
    </div>

    <div id="EX9">
        <asp:Label ID="lblEX9" runat="server" Text="EX9"></asp:Label>
        <br />
        <asp:Label ID="lblRes9" runat="server" Text="Resistência:"></asp:Label>
        <asp:Label ID="lblCorrente9" runat="server" Text="Corrente:"></asp:Label>
        <asp:Label ID="lblTensao9" runat="server" Text="Tensão:"></asp:Label>
        <br />
        <asp:TextBox ID="txtRes9" runat="server" ontextchanged="txtRes9_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtCorrente9" runat="server" 
            ontextchanged="txtCorrente9_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtTensao9" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp9" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc9" runat="server" Text="Calcular" 
            onclick="btnCalc9_Click"/>
        <asp:Button ID="btnLimpar9" runat="server" Text="Limpar" 
            onclick="btnLimpar9_Click"/>
    </div>

    <div id="EX10">
        <asp:Label ID="lblEX10" runat="server" Text="EX10"></asp:Label>
        <br />
        <asp:Label ID="lblCelsius10" runat="server" Text="Celsius (ºC):"></asp:Label>
        <asp:Label ID="lblFah10" runat="server" Text="Fahrenheit (ºF):"></asp:Label>
        <br />
        <asp:TextBox ID="txtCelsius10" runat="server" 
            ontextchanged="txtCelsius10_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtFah10" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblResp10" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnCalc10" runat="server" Text="Calcular" onclick="btnCalc10_Click"/>
        <asp:Button ID="btnLimpar10" runat="server" Text="Limpar" 
            onclick="btnLimpar10_Click"/>
    </div>

    </form>
</body>
</html>
