<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practica.aspx.cs" Inherits="PruebaTFT.Practica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Práctica TFT</title>
</head>

<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

            <asp:Button ID="btnSaludar"
                runat="server"
                Text="Saludar"
                OnClick="btnSaludar_Click" />

            <br /><br />

            <asp:Label ID="lblMensaje" runat="server"></asp:Label>

            <br /><br />

            <asp:Button ID="btnVerPersonas"
                runat="server"
                Text="Ver personas"
                OnClick="btnVerPersonas_Click" />

            <br /><br />

            <asp:Label ID="lblPersonas" runat="server"></asp:Label>

            <br /><br />

            <asp:TextBox ID="txtNuevaPersona" runat="server"></asp:TextBox>

            <asp:Button ID="btnGuardarPersona"
                runat="server"
                Text="Guardar persona"
                OnClick="btnGuardarPersona_Click" />

            <br /><br />

            <asp:Label ID="lblGuardado" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>