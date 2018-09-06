<%@ Page Title="Proceso de Corte" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="frmCorte.aspx.cs" Inherits="Prod.UI.Web.Pages.WebForm1" %>
<%@ Register Src="~/UserControls/ucPageTitle.ascx" TagName="ucTitulo" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<uc1:ucTitulo ID = "ucTitulo1" runat="server"></uc1:ucTitulo>
    
    <%-- Espacio para ingresar las librerias --%>
    <script src="frmCorte.js" type="text/javascript"></script>
    <%-- -------------------------------------*-------------------------------------- --%>

    <div class="page-content">
        <div class="panel panel-body">
                <div class="panel-heading" style="">
                    Cortes del periodo Agosto - 2018
                </div>
                 &nbsp; <button type="button" id="btnNuevo" class="btn">
                                                    <i class="fa fa-plus"></i>&nbsp;Nuevo pedido de corte</button>
                <div id="divDatos" class="form-body pal tbFondo" style="font-size:20px;">
                    <table id="tbDetails" class="table table-hover table-bordered  tablesorter dataTable no-footer" 
                            style="width: 100%;">
                                <thead>
                                    <tr>
                                        <th  style="border:1px solid black; text-align:center;">Correlativo</th>
                                        <th  style="border:1px solid black; text-align:center;">Fecha</th>
                                        <th style="border:1px solid black; text-align:center;">Bloque</th>
                                        <th  style="border:1px solid black; text-align:center;">Operario</th>
                                        <th  style="border:1px solid black; text-align:center;">OT</th>
                                        <th style="border:1px solid black; text-align:center;">Acciones</th>
                                    </tr>
                                </thead>
                                <tbody id="xtbody" >
                                <tr >
                                <td>001</td>
                                <td>14/08/2018</td>
                                <td>3456</td>
                                <td>Casas</td>
                                <td>72</td>
                                <td style="text-align:center;">
                                <button type="button" title="Eliminar" class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-trash fa-lg"></i>&nbsp;</button>
                                <button type="button" title="Editar"  class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-edit fa-lg" ></i>&nbsp;</button>
                                </td>
                                </tr>
                                <tr>
                                <td>002</td>
                                <td>14/08/2018</td>
                                <td>5378</td>
                                <td>Medrano</td>
                                <td>7255</td>
                                <td style="text-align:center;">
                                <button type="button" title="Eliminar" class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-trash fa-lg"></i>&nbsp;</button>
                                <button type="button" title="Editar"  class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-edit fa-lg" ></i>&nbsp;</button>
                                </td>
                                </tr>

                                <tr>
                                <td>003</td>
                                <td>14/08/2018</td>
                                <td>234</td>
                                <td>Palomino</td>
                                <td>7255</td>
                                <td style="text-align:center;">
                                <button type="button" title="Eliminar" class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-trash fa-lg"></i>&nbsp;</button>
                                <button type="button" title="Editar"  class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-edit fa-lg" ></i>&nbsp;</button>
                                </td>
                                </tr>

                                <tr>
                                <td>004</td>
                                <td>14/08/2018</td>
                                <td>543</td>
                                <td>Chavez</td>
                                <td>7258</td>
                                <td style="text-align:center;">
                                <button type="button" title="Eliminar" class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-trash fa-lg"></i>&nbsp;</button>
                                <button type="button" title="Editar"  class="btn btn-blue btn-lg" onclick="">
                                    <i class="fa fa-edit fa-lg" ></i>&nbsp;</button>
                                </td>
                                </tr>

                                </tbody>
                                <tfoot>
                                   <tr>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                   </tr>
                                </tfoot>
                            </table>
                </div>
        </div>

    </div>
    
</asp:Content>

<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>

