<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMenu.aspx.cs" Inherits="Prod.UI.Web.frmMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>Nombre de usuario</label>
    <input type="text" id="txtUsuario" />
    <label>Clave de usuario:</label>
    <input type="password" id="txtClaver" />
    <input type="button" value="Ingresar" id="btnIngresar" />
    <input type="button" value="Cancelar" id="Button1" />
    <input type="checkbox" value="0" />Mantener sesion iniciar
    </div>
    </form>
</body>
</html>
