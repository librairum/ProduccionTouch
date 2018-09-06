//Constantes
var K_ACCION = "";
var K_NUEVO = "I";
var K_EDIT = "U";

$(function () {
    //alert("JQUERY cargador");
    $("#btnNuevo").click(function () {
        Nuevo();
    });
});
function Nuevo() {
            K_ACCION = K_NUEVO;
            $(location).attr('href', "frmDetalleCorte.aspx?id=0"); // valor de 0 cuando es nuevo registro
            return false;
}
var CargarDetalle = function () {
    var args = "01";
    if ($.fn.dataTable.isDataTable("#tbDetails")) {
        table = $("#tbDetails").DataTable();
        table.destroy();
    }

    $("#tbDetails tbody").empty();

    ListarCortesDePedido(args, function (output, context) {
        var result = (JSON.parse(output));
        var datos = result.data;

        for (var x = 0; x < datos.length; x++) {
            $("#tbDetails tbody").append(
        "<tr><td>" + datos[x].CodigoPedido +
        "</td><td>" + datos[x].FechaPedido +
        "</td><td>" + datos[x].NumeroBloque +
        "</td><td>" + datos[x].NombreOperario +
        "</td><td>" + datos[x].NumeroOrdenDeTrabajo + "</td>" +
        AgregarBloqueParaBotones("") + "</tr>");

            //        "</td><td style='text-align:center;'>" +
            //				"<button type='button' class='btn btn-info btn-outlined btn-xs' " +
            //				"onClick='return MostrarReporte(" + '"' + datos[i].Numero + '"' + ")'>" +
            //				"<i class= 'fa fa-print fa-lg'></i></button> " +
            //				"<button type='button' title='Seleccionar' class='btn btn-info btn-outlined btn-xs' onClick='return ver(" + '"'
            //				+ datos[i].Numero + '"' + ")'>" + "<i class='fa fa-file-text-o fa-lg'></i></button> " +
            //				"<button type='button' title='Editar' class='btn btn-blue btn-xs' onClick='return editar(" +
            //				'"' + datos[i].Numero + '"' + ");'><i class='fa fa-edit'></i>&nbsp;</button>&nbsp;<button type='button' title='Eliminar' class='btn btn-default btn-xs' onClick='return eliminar(" + '"' + datos[i].Numero + '"' + ")'><i class='fa fa-trash-o'></i>&nbsp;</button></td></tr>");
        }

    });
    function AgregarBloqueParaBotones(parBotones) {
        var htmlstring = "<td style='text-align:center;'>" + parBotones + "</td>";
        return htmlstring;
    }
    function AgregarBotonNuevo() {

    }
    function AgregarBotonEditar(parValordeRegistro) {
        //        var htmlstring = "<button type='button' title='Editar'  class='btn btn-blue btn-lg'  onClick = 'return Editar('" +  parValordeRegistro + "')>";

    }
    function AgregarBotonEliminar(parValordeRegistro)
    { }
    function AgregarBotonVer(parValordeRegistro) {

    }
    function AgregarBotonImprimir(parValordeRegistro) {

    }
    /*---- Funciones para  botones -----*/
    function Editar(parametroCodigo) {
        return false;
    }
    function Eliminar(parametroCodigo) {
        return false;
    }
   
    
        

    

}