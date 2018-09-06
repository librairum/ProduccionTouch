<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="frmDetalleCorte.aspx.cs" Inherits="Prod.UI.Web.Pages.frmDetalleCorte" %>
<%@ Register Src="~/UserControls/ucPageTitle.ascx" TagName="ucTitulo" TagPrefix="uc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:ucTitulo ID = "ucTitulo1" runat="server"></uc1:ucTitulo>
<script type="text/javascript" src="Utilitario.js"></script>
<script type= "text/javascript" src="frmDetalleCorte.js"></script>
<script type="text/javascript" src="../js/isotope.pkgd.js"></script>

<!-- <script type="text/javascript" src="../js/paging.js"></script> -->
<!-- <link type="text/css"  rel="stylesheet" href="../css/paging.css" -->
<link type="text/css" rel="stylesheet" href="../css/ToggleButton.css" />
<style type="text/css">
    .element-item
    {    
    position: relative;
  float: left;
  width: 120px;
  height: 100px;
  margin: 5px;
  padding: 10px;
  background: #888;
  color: #262524;
  cursor:pointer;
    }
    .maquina
    {
    
    background-color:red;
    padding:10px;
    color:White;
    
    }
    .color
    {
        font-size:10px;
        text-align:center;
        }
    h5.etiqueta
    {
    width:100px;
    height:50px;
    }
    h5.texto
    {
        height:50px;
        }
    h5
    {
    font-size:40px;
    text-align:center;
                
    }
    .nroDeOrden
    {
    background-color:Green;
    color:White;
    padding:10px;
    }
    .is-checked
    {
    background-color:#0099cc;
    color:White;
    }
             
    /* Style the tab */
.tab {
    overflow: hidden;
    
    border-bottom: 1px solid #2980B9;
    /*background-color: #f1f1f1;*/
    
    
}

/* Style the buttons that are used to open the tab content */
.tab a {
    background-color: #2980B9;
    
    float: left;
    border: 1px solid #e0ecfc;
    outline: none;
    cursor: pointer;
    /*padding: 14px 16px;*/
    padding:14px 6px;
    transition: 0.3s;
    text-decoration:none;
    color:White;
    
    font-size:14px;
    text-transform:uppercase;
    font-weight:normal;
    border-radius:20px 20px 0 0;
}

/* Change background color of buttons on hover */
.tab a:hover {
    /*background-color: #ddd;*/
    background-color:#e0ecfc;
    color:Black;
}

/* Create an active/current tablink class */
.tab a.active {
    /*background-color: #ccc;*/
    background-color:#e0ecfc;
    border-top:1px groove #2980B9;
    border-left:1px groove #2980B9;
    border-right:1px groove #2980B9;
    color:Black;
}   

/* Style the tab content */
.tabcontent, .tabcontent_Basico {
    display: none;
    padding: 6px 12px;
    border: 1px solid #ccc;
    border-top: none;
}
table   tr  > th >  label, table tr > th 
{
  font-size:12px;
  font-weight:normal;
}



.form-seperated .form-group > div{
 padding: 0;
}

/*Remover boton Spin UpDown de caja de tipo numerico por HTML5*/
input::-webkit-outer-spin-button,
input::-webkit-inner-spin-button {
    /* display: none; <- Crashes Chrome on hover */
    -webkit-appearance: none;
    margin: 0; /* <-- Apparently some margin are still there even though it's hidden */
}

/* Ventana modal JQUERY UI-DIALOG*/
.ui-dialog .ui-dialog-titlebar
{
    background:#007399;
    padding:.8em 1em;
    }
/*Titulo de la ventan de dialogo */

/*Boton de cerrar ventana de dialogo*/
.ui-dialog-titlebar-close
{
    position: absolute;
    right: .3em;
    top: 40%;
    width: 30px;
    margin: -10px 0 0 0;
    padding: 1px;
    height: 30px
    }
            
            /* Boton Toggle */

</style>
<div class="page-content">
    <div class="panel panel-body">
        <%--<div class="panel-heading" style="font-size:18px;">
            Detalle de pedido de corte
        </div>--%>
        <div class="form-body pam">
            <div id="divDetalles" style="width: 99%; margin-left:25px; font-size:20px;">
            <div class="form-horizontal form-seperated">
                <div class="form-body form-inline">
                
                    <!-- cabecera de documento -->
                    <div class="form-group" style="width:100%;">
                            <label>Codigo de documento:</label>
                            <input type="text" class="form-text" id="txtCodigoDocumento" style="width:100px;" readonly  />
                            <label for="txtCodigoMaquina" class="control-label" style="font-size:10px; font-weight:normal;">Maquina</label>

                            <!-- Maquina -->
                            <input type="text" id="txtCodigoMaquina" style="width: 100px;" class="form-text require" />
                            <button type="button" id="btnAyudaMaquina" class="btn"><i class="fa fa-search fa-2x"></i></button>
                            <label class="control-label" id="txtmaquina" style="font-size:10px; font-weight:normal; color:Blue;" >Descripcion</label>
                            
                        
                            <!--Turno -->
                            <label for="txtturno" class="control-label" style="font-size:10px; font-weight:normal; margin-left:10px;">Turno</label>
                            <input type="text" id="txtCodigoTurno" style="width: 250px;" class="form-text require" />

                            <button type="button"  id="btnAyudaTurno" class="btn"><i class="fa fa-search fa-2x"></i></button> 
                            <label class="control-label" id="txtturno" style="font-size:10px; font-weight:normal; color:Blue;" >Descripcion</label>
                            <button type="button" id="btnCancelar" class="btn" style="float:right; margin-left:5px;">
                                <i class="fa fa-undo fa-2x"></i>&nbsp;Cancelar
                            </button>
                            <button type="button" id="btnGuardar" class="btn" style="float:right"><i class="fa fa-save fa-2x"></i>&nbsp;Guardar</button>

                    </div>

                    <br />
                    <br />
                    <!-- Grilla de operacion-->
                    <div class="form-group" style="margin-top:10px;  width:100%;">
                        <div class="tab">
                            <a class="tablinks_Basico active" onclick="NavegarTabControl(event, 'divOrdenDeTrabajo')">Order de trabajo</a>
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event, 'divMateriaPrima')">Materia Prima</a> 
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event,'divMedidas')" >Medidas de bloque</a>
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event,'divCepillado')">Cepillado</a>
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event, 'divBajada')">Bajada</a> 
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event, 'divCostra')">Costra</a>
                            <a class="tablinks_Basico" onclick="NavegarTabControl(event, 'divSaldo')">Saldo</a>

                        </div>
                         <!-- Orden de trabajo -->
                         <div id="divOrdenDeTrabajo" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray;  display:block;">
                            <table border="1">
                            <tr>
                                <th><label class="control-label"  >Numero</label></th>
                                <th><label class="control-label"  >Tipo</label></th>
                                <th><label class="control-label" >Color</label></th>
                                <th><label class="control-label" >Ancho</label></th>
                                <th><label class="control-label" >Largo</label></th>
                                <th><label class="control-label" >Alto</label></th>
                                <th><label class="control-label" >Acciones</label></th>
                            </tr>
                            <tr>
                                <td style="width:5%;">
                                    <input type="number" class="form-text" style="width: 100%;" id="txtNumeroOT" /></td>

                                <!-- Ayuda -->
                                <td style="width:14%;"><input type="text" class="form-text" style="width: 60%;" id="txtTipoOT" />
                                    <button type="button" id="btnAyudaTipo" class="btn"><i class="fa fa-search fa-2x"></i></button>
                                </td>
                                
                                <!-- Ayuda -->
                                <td style="width:14%;">
                                    <input type="text" class="form-text" style="width: 60%;" id="txtColorOT" /><input type="text" id="txtColorId" style="display:none;" />
                                    <button type="button" id="btnAyudaColor" class="btn" style="width:auto;"> <i class="fa fa-search fa-2x"></i></button>
                                </td>

                                <td style="width:14%;"><input type="number" class="form-text" style="width: 100%;" id="txtAnchoOT" /></td>
                                <td style="width:14%;"><input type="number" class="form-text" style="width: 100%;" id="txtLargoOT" /></td>
                                <td style="width:14%;"><input type="number" class="form-text" style="width: 100%;" id="txtAltoOt" /></td>
                                <td style="width:13%;">
                                    <button type="button" id="Button5" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                    <button type="button" id="Button6" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                </td>
                            </tr>
                        </table>
                        </div>
                        <!-- Materia prima -->
                        <div  id="divMateriaPrima" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                            <table border="1">
                                <tr>
                                    <th><label class="control-label">Bloque</label></th>
                                    <th><label class="control-label">Descripcion</label></th>
                                    <th><label class="control-label">Ancho</label></th>
                                    <th><label class="control-label">Largo</label></th>
                                    <th><label class="control-label">Alto</label></th>
                                    <th><label class="control-label">Volumen</label></th>
                                    <th><label class="control-label">Cantera</label></th>
                                    <th><label class="control-label">Acciones</label></th>
                                </tr>
                                <tr>
                                    <td style="width:10%;"><input type="text" class="form-text" style="width: 100%;" id="txtBloque" /></td>
                                    <td style="width:50%;"><input type="text" class="form-text" style="width: 100%;" id="txtDescripcion" readonly="true" /></td>
                                    <td style="width:5%;"><input type="text" class="form-text" style="width: 100%;" id="txtAnchoMP" readonly="true" /></td>
                                    <td style="width:5%;"><input type="text" class="form-text" style="width: 100%;" id="txtLargoMP" readonly="true" /></td>
                                    <td style="width:5%;"><input type="text" class="form-text" style="width: 100%;" id="txtAltoMP" readonly="true" /></td>
                                    <td style="width:5%;"><input type="text" class="form-text" style="width: 100%;" id="txtVolumen" readonly="true" /></td>
                                    <td style="width:5%;"><input type="text" class="form-text" style="width: 100%;" id="txtCantera" readonly="true" /></td>
                                    <td style="width:18%;">
                                        <button type="button" id="Button17" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                        <button type="button" id="Button18" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <!-- Medidas -->
                        <div id="divMedidas" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                            <table border="1">
                                <tr><th><label class="control-label">Ancho</label></th>
                                    <th><label class="control-label">Largo</label></th>
                                    <th><label class="control-label">Alto</label></th>
                                    <th><label class="control-label">Acciones</label></th>
                                </tr>
                                <tr>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" id="txtAncho" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" id="txtLargo" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" id="txtAlto" />
                                    </td>
                                    <td>
                                        <button type="button" id="Button1" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                        <button type="button" id="Button2" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <!-- Cepillado -->
                        <div id="divCepillado" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                            <table border="1">
                                <tr>
                                    <th>
                                        <label class="control-label">
                                            Hora inicio:</label>
                                    </th>
                                    <th>
                                        <label class="control-label">
                                            Hora fin:</label>
                                    </th>
                                    <th>
                                        <label class="control-label">
                                            Superior</label>
                                    </th>
                                    <th>
                                        <label class="control-label">
                                            Lado 1</label>
                                    </th>
                                    <th>
                                        <label class="control-label">
                                            Lado 2</label>
                                    </th>
                                    <th>
                                        Acciones
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        <input type="text" class="form-text" id="txtHoraInicio" maxlength="5" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" id="txtFin" maxlength="5" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" id="txtSuperior"  style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" id="txtLado1"  style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" id="txtLado2" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <button type="button" id="btnGuardarCepillado" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                        <button type="button" id="btnCancelarCepillado" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                    </td>
                                </tr>
                            </table>
                            
                        </div>
                        <!-- Bajada -->
                        <div id="divBajada" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                            <table border="1">
                                <tbody><tr>
                                    <th colspan="2">
                                        Hora
                                    </th>
                                    <th colspan="3">
                                        Medidas
                                    </th>
                                    <th colspan="2">
                                        Piezas buenas
                                    </th>
                                    <th colspan="3">
                                        Piezas malas
                                    </th>
                                    <th colspan="3">
                                        Canastilla salida
                                    </th>
                                </tr>
                                <tr>
                                    <th><label>Inicio</label></th>
                                    <th><label>Fin</label></th>

                                    <th><label>Ancho</label></th>
                                    <th><label>Largo</label></th>
                                    <th><label>Alto</label></th>

                                    <th>Cant.</th>
                                    <th>Canastilla</th>

                                    <th>Cant.</th>
                                    <th>Canastilla</th>
                                    <th>Motivo</th>

                                    <th>Esta Llena</th>
                                    <th>Hora salida</th>
                                    <th>Acciones</th>
                                </tr>
                                <tr>
                                    <td>
                                        <input class="form-text" type="text" style="width: 60px;" id="txtHoraInicioBajada">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 60px;" id="txtHoraFinBajada">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 55px;" id="txtAnchoBajada">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 55px;" id="txtLargoBajada">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 55px;" id="txtAltoBajada">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 40px;" id="txtCantPzasBuenas">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 70px;" id="txtCanastillaPzasBuenas">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 40px;" id="txtCantPzasMalas">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 100px;" id="xtCanastillaPzasMalas">
                                    </td>
                                    <td>
                                        <input class="form-text" type="text" style="width: 120px;" id="txtMotivo">
                                    </td>
                                    <td style="width:20px;">
                                        <label class="switch">
                                        <input type="checkbox" id="chkCanastillaLlena">
                                        <span class="slider round"></span>
                                        </label>
                                        <!-- <input type="checkbox" name="chkCanastillaLlena" /> -->
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 70px;" id="txtHoraSalida">
                                    </td>
                                    <td>
                                        <button type="button" id="btnGuardarBajada" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                        <button type="button" id="btnCancelarBajada" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                    </td>
                                </tr>
                            </tbody></table>
                            
                        </div>
                        <!-- Costras -->
                        <div id="divCostra" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                        <table border="1">
                            <tr>
                                <th>Ancho</th>
                                <th>Largo</th>
                                <th>Alto</th>
                                <th>Observacion</th>
                                <th>Acciones</th>
                            </tr>
                            <tr>
                                <td><input type="text" class="form-text" style="width:100px;" id="txtAnchoCostra" /></td>
                                <td><input type="text" class="form-text" style="width:100px;" id="txtLargoCostra" /></td>
                                <td><input type="text" class="form-text" style="width:100px;" id="txtAltoCostra" /></td>
                                <td><input type="text" class="form-text" style="width:100px;" id="txtObservacionCostra" /></td>
                                <td>
                                    <button type="button" id="btnGuardarCostra" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                    <button type="button" id="btnCancelarCostra" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                </td>
                            </tr>
                        </table>
                        </div>
                        <!-- Saldo -->
                         <div id="divSaldo" class="tabcontent_Basico" style="border-left: 1px solid gray; border-right: 1px solid gray;
                            border-bottom: 1px solid gray; ">
                            <table border="1">
                                <tr>
                                    <th>
                                        Bloque
                                    </th>
                                    <th>
                                        Ancho
                                    </th>
                                    <th>
                                        Largo
                                    </th>
                                    <th>
                                        Alto
                                    </th>
                                    <th>
                                        Observacion
                                    </th>
                                    <th>
                                        Acciones
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <input type="text" class="form-text" style="width: 100px;" />
                                    </td>
                                    <td>
                                        <button type="button" id="Button9" class="btn"><i class="fa fa-save fa-2x"></i></button>
                                        <button type="button" id="Button10" class="btn"><i class="fa fa-undo fa-2x"></i></button>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <br />
                   <br />
                    <!-- Grilla detalle del documento-->
                    <div class="form-group" style="margin-top: 10px; width:100%; border:1px solid purple;">
                        <table border="1" id="tblDetalleCorte" style="width:inherit" >
                            <tr style="font-size: 12px;">
                                <th>Operario</th>
                                <th>H.Inicio</th>
                                <th>H.Fin</th>
                                <th>Cant.</th>
                                <th>Almacen</th>
                                <th>Producto</th>
                                <th>UM</th>
                                <th>Largo</th>
                                <th>Ancho</th>
                                <th>Espesor</th>
                                <th>MT2</th>
                                <th>MT3</th>
                                <th>Canastilla</th>
                                <th>H.Salida</th>
                                <th>Motivo</th>
                                <th>Acciones</th>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>
                                    PALOMINO VELIZ JOEL
                                </td>
                                <td>
                                    06:35
                                </td>
                                <td>
                                    05:00
                                </td>
                                <td>
                                    30
                                </td>
                                <td>
                                    CORTE ALMACEN
                                </td>
                                <td>
                                    FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL
                                </td>
                                <td>
                                    pza
                                </td>
                                <td>
                                    1.3
                                </td>
                                <td>
                                    13
                                </td>
                                <td>
                                    50
                                </td>
                                <td>
                                    12.8778
                                </td>
                                <td>
                                    0.64389
                                </td>
                                <td>
                                    3456
                                </td>
                                <td>
                                    00:00
                                </td>
                                <td>
                                    Motivo
                                </td>
                                <td>
                                    <button type="button" id="Button11" class="btn" onclick="return EliminarDetalleCorte(1)"><i class="fa fa-trash fa-2x"></i></button>
                                </td>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>
                                    PALOMINO VELIZ JOEL
                                </td>
                                <td>
                                    06:35
                                </td>
                                <td>
                                    05:00
                                </td>
                                <td>
                                    30
                                </td>
                                <td>
                                    CORTE ALMACEN
                                </td>
                                <td>
                                    FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL
                                </td>
                                <td>
                                    pza
                                </td>
                                <td>
                                    1.3
                                </td>
                                <td>
                                    13
                                </td>
                                <td>
                                    50
                                </td>
                                <td>
                                    12.8778
                                </td>
                                <td>
                                    0.64389
                                </td>
                                <td>
                                    3456
                                </td>
                                <td>
                                    00:00
                                </td>
                                <td>
                                    Motivo
                                </td>
                                <td>
                                    <button type="button" id="Button12" class="btn" onclick="return EliminarDetalleCorte(1)"><i class="fa fa-trash fa-2x"></i></button>
                                </td>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>
                                    PALOMINO VELIZ JOEL
                                </td>
                                <td>
                                    06:35
                                </td>
                                <td>
                                    05:00
                                </td>
                                <td>
                                    30
                                </td>
                                <td>
                                    CORTE ALMACEN
                                </td>
                                <td>
                                    FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL
                                </td>
                                <td>
                                    pza
                                </td>
                                <td>
                                    1.3
                                </td>
                                <td>
                                    13
                                </td>
                                <td>
                                    50
                                </td>
                                <td>
                                    12.8778
                                </td>
                                <td>
                                    0.64389
                                </td>
                                <td>
                                    3456
                                </td>
                                <td>
                                    00:00
                                </td>
                                <td>
                                    Motivo
                                </td>
                                <td>
                                    <button type="button" id="Button13" class="btn" onclick="return EliminarDetalleCorte(1)">
                                        <i class="fa fa-trash fa-2x"></i>
                                    </button>
                                </td>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>
                                    PALOMINO VELIZ JOEL
                                </td>
                                <td>
                                    06:35
                                </td>
                                <td>
                                    05:00
                                </td>
                                <td>
                                    30
                                </td>
                                <td>
                                    CORTE ALMACEN
                                </td>
                                <td>
                                    FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL
                                </td>
                                <td>
                                    pza
                                </td>
                                <td>
                                    1.3
                                </td>
                                <td>
                                    13
                                </td>
                                <td>
                                    50
                                </td>
                                <td>
                                    12.8778
                                </td>
                                <td>
                                    0.64389
                                </td>
                                <td>
                                    3456
                                </td>
                                <td>
                                    00:00
                                </td>
                                <td>
                                    Motivo
                                </td>
                                <td>
                                    <button type="button" id="Button14" class="btn" onclick="return EliminarDetalleCorte(1)">
                                        <i class="fa fa-trash fa-2x"></i>
                                    </button>
                                </td>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>
                                    PALOMINO VELIZ JOEL
                                </td>
                                <td>
                                    06:35
                                </td>
                                <td>
                                    05:00
                                </td>
                                <td>
                                    30
                                </td>
                                <td>
                                    CORTE ALMACEN
                                </td>
                                <td>
                                    FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL
                                </td>
                                <td>
                                    pza
                                </td>
                                <td>
                                    1.3
                                </td>
                                <td>
                                    13
                                </td>
                                <td>
                                    50
                                </td>
                                <td>
                                    12.8778
                                </td>
                                <td>
                                    0.64389
                                </td>
                                <td>
                                    3456
                                </td>
                                <td>
                                    00:00
                                </td>
                                <td>
                                    Motivo
                                </td>
                                <td>
                                    <button type="button" id="Button15" class="btn" onclick="return EliminarDetalleCorte(1)">
                                        <i class="fa fa-trash fa-2x"></i>
                                    </button>
                                </td>
                            </tr>
                            <tr style="font-size: 12px;">
                                <td>PALOMINO VELIZ JOEL</td><td>06:35</td><td>05:00</td><td>30</td><td>CORTE ALMACEN</td><td>FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL</td>
                                <td>pza</td>
                                <td>1.3</td><td>13</td><td>50</td>
                                <td>12.8778</td><td>0.64389</td>
                                <td>3456</td>
                                <td>00:00</td><td>Motivo</td>
                                <td>
                                    <button type="button" id="Button16" class="btn" onclick="return EliminarDetalleCorte(1)"><i class="fa fa-trash fa-2x"></i></button>
                                </td>
                            </tr>
                            
                            <tfoot>
                            <tr style="font-size:12px;">
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th>300</th>
                                <th>200</th>
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
            </div>
        </div>
        
    </div>

    <!--  Ventana de ayuda de maquinas -->
    <div title = "Seleccionar maquina" id="DivAyudaMaquina">
                
                    
                    <div  id="filters" class="button-group">
                        <button class="button is-checked" 
                            data-filter="numberFilterByGroup1" value="1"  >maquina 1 - 10</button>
                        <button class="button" 
                        data-filter="numberFilterByGroup2" value="2" >maquina 11 - 20</button>

                    </div>
                    <div id="divMaquinas" style="width:99%" class="grid">
                        <!-- LA AYUDA NO DEBE TENER MAS DE 10 ITEMS-->
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                        <h1 class="codigoMaquina" style="display:none;">001</h1>
                            <h5 class="etiqueta number" style="display:none;">1</h5>
                            <h5 class="etiqueta texto" style="font-size:20px; text-align:center;">Cortadora 1</h5>
                        </div>
                        <div class="element-item maquina" data-category ="1" onclick="SeleccionarMaquina(this)" >
                        
                            <h1 class="codigoMaquina"  style="display:none;">002</h1>
                            <h5 class="etiqueta number" style="display:none;">2</h5>
                            <h5 class="etiqueta texto" style="font-size:20px; text-align:center;">Cortadora 2</h5>
                            
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">003</h1>
                            <h5 class="etiqueta number" style="display:none;">3</h5>
                            <h5 class="etiqueta texto" style="font-size:20px; text-align:center;">Cortadora 3</h5>
                        </div>
                      <%--  <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">004</h1>
                            <h5 class="etiqueta number">4</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">005</h1>
                            <h5 class="etiqueta number">5</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">006</h1>
                            <h5 class="etiqueta number">6</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">007</h1>
                            <h5  class="etiqueta number">7</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">008</h1>
                            <h5 class="etiqueta number">8</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">009</h1>
                            <h5 class="etiqueta number">9</h5>
                        </div>
                        <div class="element-item maquina" data-category = "1" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">010</h1>
                            <h5 class="etiqueta number">10</h5>
                        </div>
                        <!--  del 11 - 20 -->
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">011</h1>
                            <h5 class="etiqueta number">11</h5>
                        </div>
                        <div class="element-item maquina" data-category ="2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">012</h1>
                            <h5 class="etiqueta number">12</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">013</h1>
                            <h5 class="etiqueta number">13</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">014</h1>
                            <h5 class="etiqueta number">14</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">015</h1>
                            <h5 class="etiqueta number">15</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">016</h1>
                            <h5 class="etiqueta number">16</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">017</h1>
                            <h5 class="etiqueta number">17</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">018</h1>
                            <h5 class="etiqueta number">18</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">019</h1>
                            <h5 class="etiqueta number">19</h5>
                        </div>
                        <div class="element-item maquina" data-category = "2" onclick="SeleccionarMaquina(this)">
                            <h1 class="codigoMaquina"  style="display:none;">020</h1>
                            <h5 class="etiqueta number">20</h5>
                        </div>--%>
                    </div>
                    

                </div>
    <!-- Ventana de ayuda de turno -->
    
    <div title="Seleccionar turno" id="divAyudaTurno">
        <div id="divTurnos" style="width: 99%" class="grid">
            <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                <span class="codigoDeOrden" style="display: none;">1</span>
                <h1 class="codigoHorario" style="display: none;">
                    01</h1>
                <h5 class="etiqueta number" style="font-size: 18px;">
                    DIA de 07:00 a 19:00</h5>
            </div>
            <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                <span class="codigoDeOrden" style="display: none;">2</span>
                <h1 class="codigoHorario" style="display: none;">
                    02</h1>
                <h5 class="etiqueta number" style="font-size: 18px;">
                    NOCHE de 19:00 a 07:00</h5>
            </div>
            <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                <span class="codigoDeOrden" style="display: none;">3</span>
                <h1 class="codigoHorario" style="display: none;">
                    03</h1>
                <h5 class="etiqueta number" style="font-size: 18px;">
                    DIA de 07:00 a 17:00</h5>
            </div>
            <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                <span class="codigoDeOrden" style="display: none;">4</span>
                <h1 class="codigoHorario" style="display: none;">
                    04</h1>
                <h5 class="etiqueta number" style="font-size: 18px;">
                    NOCHE de 19:00 a 05:00</h5>
            </div>
            <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                <span class="codigoDeOrden" style="display: none;">5</span>
                <h1 class="codigoHorario" style="display: none;">
                    05</h1>
                <h5 class="etiqueta number" style="font-size: 18px;">
                    SABADO DIA de 07:00 a 15:00</h5>
            </div>
        </div>
    </div>
    
    <!-- Ventana de ayuda de color -->
    
    <div title="Seleccionar color" id="divAyudaColor">
    <div id="filtersByValue"class="button-group">
        <button class="button is-checked" data-filter="numberFilterByValue" value="1">Pagina 1</button>
        <button class="button" data-filter="numberFilterByValue" value="2">Pagina 2</button>
        <button class="button" data-filter="numberFilterByValue" value="3">Pagina 3</button>
        <button class="button" data-filter="numberFilterByValue" value="4">Pagina 4</button>
    </div>
            <div id="resultadodebusqueda" style="width: 99%" class="grid">
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">1</span><span class="codigoDeColor"
                        style="display: none;">AB</span><h5 class="texto" style="font-size: 18px;">
                            Albertino</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">2</span><span class="codigoDeColor"
                        style="display: none;">03</span><h5 class="texto" style="font-size: 18px;">
                            ALBERTINO B</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">3</span><span class="codigoDeColor"
                        style="display: none;">AL</span><h5 class="texto" style="font-size: 18px;">
                            Alpaquita</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">4</span><span class="codigoDeColor"
                        style="display: none;">AM</span><h5 class="texto" style="font-size: 18px;">
                            Andean Mahogany</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">5</span><span class="codigoDeColor"
                        style="display: none;">AG</span><h5 class="texto" style="font-size: 18px;">
                            Andes Gold</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">6</span><span class="codigoDeColor"
                        style="display: none;">AN</span><h5 class="texto" style="font-size: 18px;">
                            Andes Noce</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">7</span><span class="codigoDeColor"
                        style="display: none;">BA</span><h5 class="texto" style="font-size: 18px;">
                            Basalto</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">8</span><span class="codigoDeColor"
                        style="display: none;">BR</span><h5 class="texto" style="font-size: 18px;">
                            Brecia</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">9</span><span class="codigoDeColor"
                        style="display: none;">BG</span><h5 class="texto" style="font-size: 18px;">
                            Brecia Gold</h5>
                </div>
                <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">10</span><span class="codigoDeColor"
                        style="display: none;">CD</span><h5 class="texto" style="font-size: 18px;">
                            Café Dorado</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">11</span><span class="codigoDeColor"
                        style="display: none;">DV</span><h5 class="texto" style="font-size: 18px;">
                            Cafe Dorado Veta</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">12</span><span class="codigoDeColor"
                        style="display: none;">CA</span><h5 class="texto" style="font-size: 18px;">
                            Cappuccino</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">13</span><span class="codigoDeColor"
                        style="display: none;">CH</span><h5 class="texto" style="font-size: 18px;">
                            Chala</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">14</span><span class="codigoDeColor"
                        style="display: none;">CE</span><h5 class="texto" style="font-size: 18px;">
                            Chocolate</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">15</span><span class="codigoDeColor"
                        style="display: none;">MS</span><h5 class="texto" style="font-size: 18px;">
                            Colonia a la Veta</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">16</span><span class="codigoDeColor"
                        style="display: none;">Co</span><h5 class="texto" style="font-size: 18px;">
                            Colonio</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">17</span><span class="codigoDeColor"
                        style="display: none;">CR</span><h5 class="texto" style="font-size: 18px;">
                            Cream</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">18</span><span class="codigoDeColor"
                        style="display: none;">CV</span><h5 class="texto" style="font-size: 18px;">
                            Crema Viejo</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">19</span><span class="codigoDeColor"
                        style="display: none;">Da</span><h5 class="texto" style="font-size: 18px;">
                            Dalilac</h5>
                </div>
                <div class="element-item maquina" data-category="2" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">20</span><span class="codigoDeColor"
                        style="display: none;">DB</span><h5 class="texto" style="font-size: 18px;">
                            Dark Brown</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">21</span><span class="codigoDeColor"
                        style="display: none;">DO</span><h5 class="texto" style="font-size: 18px;">
                            Dorado</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">22</span><span class="codigoDeColor"
                        style="display: none;">Du</span><h5 class="texto" style="font-size: 18px;">
                            Dune</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">23</span><span class="codigoDeColor"
                        style="display: none;">DR</span><h5 class="texto" style="font-size: 18px;">
                            Dusky Red</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">24</span><span class="codigoDeColor"
                        style="display: none;">Ew</span><h5 class="texto" style="font-size: 18px;">
                            English Walnut</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">25</span><span class="codigoDeColor"
                        style="display: none;">Ex</span><h5 class="texto" style="font-size: 18px;">
                            Expreso</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">26</span><span class="codigoDeColor"
                        style="display: none;">FA</span><h5 class="texto" style="font-size: 18px;">
                            Faraon</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">27</span><span class="codigoDeColor"
                        style="display: none;">FI</span><h5 class="texto" style="font-size: 18px;">
                            Fiorito</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">28</span><span class="codigoDeColor"
                        style="display: none;">FO</span><h5 class="texto" style="font-size: 18px;">
                            Fossil</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">29</span><span class="codigoDeColor"
                        style="display: none;">GO</span><h5 class="texto" style="font-size: 18px;">
                            Golden</h5>
                </div>
                <div class="element-item maquina" data-category="3" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">30</span><span class="codigoDeColor"
                        style="display: none;">GR</span><h5 class="texto" style="font-size: 18px;">
                            Gray</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">31</span><span class="codigoDeColor"
                        style="display: none;">Hi</span><h5 class="texto" style="font-size: 18px;">
                            Hickory</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">32</span><span class="codigoDeColor"
                        style="display: none;">IB</span><h5 class="texto" style="font-size: 18px;">
                            Inca Blend</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">33</span><span class="codigoDeColor"
                        style="display: none;">Ky</span><h5 class="texto" style="font-size: 18px;">
                            Kyra</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">34</span><span class="codigoDeColor"
                        style="display: none;">LA</span><h5 class="texto" style="font-size: 18px;">
                            Laguna</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">35</span><span class="codigoDeColor"
                        style="display: none;">lag l</span><h5 class="texto" style="font-size: 18px;">
                            laguna light</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">36</span><span class="codigoDeColor"
                        style="display: none;">ON</span><h5 class="texto" style="font-size: 18px;">
                            Laguna Ondas</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">37</span><span class="codigoDeColor"
                        style="display: none;">LEY</span><h5 class="texto" style="font-size: 18px;">
                            LEYVA</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">38</span><span class="codigoDeColor"
                        style="display: none;">LB</span><h5 class="texto" style="font-size: 18px;">
                            Light Brown</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">39</span><span class="codigoDeColor"
                        style="display: none;">LI</span><h5 class="texto" style="font-size: 18px;">
                            Lilac</h5>
                </div>
                <div class="element-item maquina" data-category="4" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">40</span><span class="codigoDeColor"
                        style="display: none;">MP</span><h5 class="texto" style="font-size: 18px;">
                            Machu Picchu</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">41</span><span class="codigoDeColor"
                        style="display: none;">02</span><h5 class="texto" style="font-size: 18px;">
                            Madeira</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">42</span><span class="codigoDeColor"
                        style="display: none;">MR</span><h5 class="texto" style="font-size: 18px;">
                            Marron</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">43</span><span class="codigoDeColor"
                        style="display: none;">ma</span><h5 class="texto" style="font-size: 18px;">
                            Marron Gris</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">44</span><span class="codigoDeColor"
                        style="display: none;">MX</span><h5 class="texto" style="font-size: 18px;">
                            Mix</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">45</span><span class="codigoDeColor"
                        style="display: none;">VC</span><h5 class="texto" style="font-size: 18px;">
                            Mix Crema Veta</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">46</span><span class="codigoDeColor"
                        style="display: none;">MC</span><h5 class="texto" style="font-size: 18px;">
                            Mix Cremas</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">47</span><span class="codigoDeColor"
                        style="display: none;">MG</span><h5 class="texto" style="font-size: 18px;">
                            Mix Gold</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">48</span><span class="codigoDeColor"
                        style="display: none;">MI</span><h5 class="texto" style="font-size: 18px;">
                            Mix Gris</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">49</span><span class="codigoDeColor"
                        style="display: none;">MM</span><h5 class="texto" style="font-size: 18px;">
                            Mix Marron</h5>
                </div>
                <div class="element-item maquina" data-category="5" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">50</span><span class="codigoDeColor"
                        style="display: none;">MV</span><h5 class="texto" style="font-size: 18px;">
                            Mix Veta</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">51</span><span class="codigoDeColor"
                        style="display: none;">Nu</span><h5 class="texto" style="font-size: 18px;">
                            Nuvolato</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">52</span><span class="codigoDeColor"
                        style="display: none;">OX</span><h5 class="texto" style="font-size: 18px;">
                            Onix
                        </h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">53</span><span class="codigoDeColor"
                        style="display: none;">XV</span><h5 class="texto" style="font-size: 18px;">
                            Onix a la Veta</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">54</span><span class="codigoDeColor"
                        style="display: none;">PA</span><h5 class="texto" style="font-size: 18px;">
                            Paracas</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">55</span><span class="codigoDeColor"
                        style="display: none;">RE</span><h5 class="texto" style="font-size: 18px;">
                            REVISAR</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">56</span><span class="codigoDeColor"
                        style="display: none;">RO</span><h5 class="texto" style="font-size: 18px;">
                            Rococho</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">57</span><span class="codigoDeColor"
                        style="display: none;">RS</span><h5 class="texto" style="font-size: 18px;">
                            Rojo Spondylus</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">58</span><span class="codigoDeColor"
                        style="display: none;">SL</span><h5 class="texto" style="font-size: 18px;">
                            Silver</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">59</span><span class="codigoDeColor"
                        style="display: none;">TM</span><h5 class="texto" style="font-size: 18px;">
                            Tormento</h5>
                </div>
                <div class="element-item maquina" data-category="6" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">60</span><span class="codigoDeColor"
                        style="display: none;">TO</span><h5 class="texto" style="font-size: 18px;">
                            Tornado</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">61</span><span class="codigoDeColor"
                        style="display: none;">TN</span><h5 class="texto" style="font-size: 18px;">
                            Tornado Ondas</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">62</span><span class="codigoDeColor"
                        style="display: none;">TV</span><h5 class="texto" style="font-size: 18px;">
                            Tornado Veta</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">63</span><span class="codigoDeColor"
                        style="display: none;">VA</span><h5 class="texto" style="font-size: 18px;">
                            Vanilla</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">64</span><span class="codigoDeColor"
                        style="display: none;">VL</span><h5 class="texto" style="font-size: 18px;">
                            Volcano</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">65</span><span class="codigoDeColor"
                        style="display: none;">04</span><h5 class="texto" style="font-size: 18px;">
                            VOLCANO B</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">66</span><span class="codigoDeColor"
                        style="display: none;">WP</span><h5 class="texto" style="font-size: 18px;">
                            Wayna Picchu</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">67</span><span class="codigoDeColor"
                        style="display: none;">WC</span><h5 class="texto" style="font-size: 18px;">
                            White Cedar</h5>
                </div>
                <div class="element-item maquina" data-category="7" onclick="SeleccionarMaquina(this)">
                    <span class="codigoDeOrden" style="display: none;">68</span><span class="codigoDeColor"
                        style="display: none;">YU</span><h5 class="texto" style="font-size: 18px;">
                            Yurac</h5>
                </div>
            </div>
    </div>
    
    
    <!-- Ventana de ayuda de tipo -->
    <div title="Seleccioanr tipo" id="divAyudaTipo">
        
        <div  style="width: 99%" class="grid">
        <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
            <span class="codigoDeOrden" style="display: none;">1</span>
            <span class="codigoDeTipo"style="display: none;">BA</span>
            <h5 class="texto" style="font-size: 18px;">Baldosa</h5>
         </div>
       <%--  <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
            <span class="codigoDeOrden" style="display: none;">2</span>
            <span class="codigoDeTipo"style="display: none;">BL</span>
            <h5 class="texto" style="font-size: 18px;">BLOQUE TRAVERTINO</h5>
         </div>
         <div class="element-item maquina" data-category="1" onclick="SeleccionarMaquina(this)">
            <span class="codigoDeOrden" style="display: none;">3</span>
            <span class="codigoDeTipo"style="display: none;">FI</span>
            <h5 class="texto" style="font-size: 18px;">FILAÑA</h5>
         </div>--%>

           <%-- <div class="element-item maquina">
                <span style="display: none" class="codigoTipo" >BA</span><h5 class="etiqueta number">
                    Baldosa</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">MD</span><h5 class="etiqueta number">
                    Moldura</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">MS</span><h5 class="etiqueta number">
                    Mosaico</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">OV</span><h5 class="etiqueta number">
                    Ovalín</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">PL</span><h5 class="etiqueta number">
                    Plancha</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">BL</span><h5 class="etiqueta number">
                    BLOQUE TRAVERTINO</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">FI</span><h5 class="etiqueta number">
                    FILAÑA</h5>
            </div>
            <!--
            <div class="element-item maquina">
                <span style="display: none">MR</span><h5 class="etiqueta number">
                    MATERIAL DE RECUPERACION</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">FP</span><h5 class="etiqueta number">
                    FILAÑA PLANCHA</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">SP</span><h5 class="etiqueta number">
                    Mosaico Spacatto</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">CO</span><h5 class="etiqueta number">
                    COSTRA</h5>
            </div>
            <div class="element-item maquina">
                <span style="display: none">CC</span><h5 class="etiqueta number">
                    COSTRA X CEPILLADO</h5>
            </div>--%>
        </div>
    </div>
    
    <!---------------------------------------------------------------------------------------------------------------- -->
    <!------------------------------------------ Ventana visor de listview ---------------------------------------------->
    <!---------------------------------------------------------------------------------------------------------------- -->
    
<%-- espacio para crear el codigo de ayuda--%>

</asp:Content>
