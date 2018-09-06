//Constantes
var K_ACCION = "";
var K_NUEVO = "I";
var K_EDIT = "U";
var qsRegex;
var $grid_TextFilter;
//#Region "Evento Load"
$(function () {
    alert(variable_Utilitario);
    //Inicio de evento de botones
    $("#btnCancelar").click(function () {
        Cancelar();
    });
    $("#btnAyudaTurno").click(function () {
        $("#divAyudaTurno").dialog("open");
    });
    $("#btnAyudaMaquina").click(function () {
        $("#DivAyudaMaquina").dialog("open");
    });

    $("#btnAyudaTipo").click(function () {
        $("#divAyudaTipo").dialog("open");
    });

    $("#btnAyudaColor").click(function () {
        $("#divAyudaColor").dialog("open");
        BuscarColor();
    });
    $("#btnGuardar").click(function () {
        GuardarCabecera();
        //Asignar numero de OT
        $("#txtNumeroOT").val("00001");
        $("#txtNumeroOT").prop("disabled", true);
    });
    //Inicio de ventans de ayuda
    $("#DivAyudaMaquina").dialog({
        autoOpen: false,
        buttons:
            {
                "Guardar": GuardarMaquinaSeleccionado,
                "Cancelar": function () {
                    $("#DivAyudaMaquina").dialog("close");
                    return false;
                }
            }
            ,
        height: 420,
        width: 680,

        modal: true,
        show:
            {
                effect: "highlight",
                duration: 10
            },
        hide:
            {
                effect: "highlight",
                duration: 10
            },
        open: function () {
            $grid.isotope({
                filter: function () {
                    // _this_ is the item element. Get text of element's .number
                    var number = $(this).find('.number').text();
                    //return true to show, false to hide
                    return parseInt(number, 10) < 11;
                }
            });
        }
    });
    $("#divAyudaTurno").dialog({
        autoOpen: false,
        buttons:
        {
            "Guardar": GuardarTurnoSeleccionado,
            "Cancelar": function () { $("#divAyudaTurno").dialog("close"); return false; }
        },
        height: 420,
        width: 680,
        modal: true,
        show: { effect: "highlight", duration: 10 },
        hide: { effect: "highlight", duration: 10 },
        open: function () {
            $grid.isotope({
                filter: function () {
                    // _this_ is the item element. Get text of element's .number
                    var number = $(this).find('.codigoDeOrden').text();
                    //return true to show, false to hide
                    return parseInt(number, 10) < 11;
                }
            });

        }
    });
    $("#divAyudaTipo").dialog({
        autoOpen: false,
        buttons:
        {
            "Guardar": GuardarTipoSeleccionado,
            "Cancelar": function () { $("#divAyudaTipo").dialog("close"); return false; }
        },
        height: 420, width: 680, modal: true,
        show: { effect: "highlight", duration: 10 },
        hide: { effect: "highlight", duration: 10 },
        open: function () {
            $('.quicksearch').keyup(debounce(function () {
                qsRegex = new RegExp("", 'gi');
                $grid.isotope();
            }, 200));
        }

    });
    $("#divAyudaColor").dialog({
        autoOpen: false,
        buttons:
        {
            "Guadar": GuardarColorSeleccionado,
            "Cancelar": function () { $("#divAyudaColor").dialog("close"); return false; }
        },
        height: 420, width: 620, modal: true,
        show: { effect: "highlight", duration: 10 },
        hide: { effect: "highlight", duration: 10 },
        open: function () {
            $grid.isotope({
                filter: function () {
                    var $number = $(this).find('.codigoDeOrden').text();
                    return parseInt($number, 10) < 11;
                }
            });
        }
    });
    $("#txtBloque").focusout(function () {
        var $txtBloque = $("#txtBloque").val();
        if ($txtBloque == "") {
            $("#txtDescripcion").val("");
            $("#txtAnchoMP").val("");
            $("#txtLargoMP").val("");
            $("#txtAltoMP").val("");
            $("#txtVolumen").val("");
            $("#txtCantera").val("");
        } else {
            $("#txtDescripcion").val("Materia prima");
            $("#txtAnchoMP").val("10");
            $("#txtLargoMP").val("10");
            $("#txtAltoMP").val("10");
            $("#txtVolumen").val("1000");
            $("#txtCantera").val("223367");
        }
    });

    //Evento boton guardar cepillado
    $("#btnGuardarCepillado").click(function () {
        var nombreOperario = "PALOMINO VELIZ JOEL";
        var cantidad = "1";
        var tipoProducto = "escalla";
        var nombreAlmacen = "Almacen escalla";
        var color = "Laguna"; //Verificar de donde saco el color -->txtColorOT

        var honaInicio = $("#txtHoraInicio").val();
        var horaFin = $("#txtFin").val();

        //Leer medidas de bloque de materia prima
        var ancho = $("#txtAnchoMP").val();
        var largo = $("#txtLargoMP").val();
        var alto = $("#txtAltoMP").val();

        var LadoSuoerior = $("#txtSuperior").val();
        var Lado1 = $("#txtLado1").val();
        var Lado2 = $("#txtLado2").val();

        //Calcular medidas de escalla superior
        var escsupLargo = largo;
        var escsupAncho = ancho;
        var escsupAlto = LadoSuoerior * 10; // se conviero a milimetros

        //Calcular medidas de escalla lateral 1 
        var esclat1Largo = largo;
        var esclat1Ancho = alto;
        var esclat1Alto = Lado1 * 10;

        //Calcular medidas de escalla lateral 2 
        var esclat2Largo = largo;
        var esclat2Ancho = alto;
        var esclat2Alto = Lado1 * 10;

        // Medidas de costra
        //double costraLargo = largo;
        //double costraAncho = ancho;
        //double costraAlto = altoCostra * 10;

        var canastilla = "5547";
        var horaSalida = "00.00";
        var unidadMedida = "UNI";
        var motivo = "Motivo dinamico";
        var metrosCuadrados = escsupLargo * escsupAncho;
        var metroCubicos = LadoSuoerior * Lado1 * Lado2;
        var cantidadFilas = $("#tblDetalleCorte > tbody > tr").length;
        var botonEliminar = "";
        botonEliminar = '<button type="button" id="Button11" class="btn" onclick="return EliminarDetalleCorte('
        + cantidadFilas + ')"><i class="fa fa-trash fa-2x"></i></button>';
        var filaEscallaSuperior = "", filaEscallaLateral1 = "", filaEscallaLateral2 = "";

        filaEscallaSuperior = "<tr style='font-size: 12px;'>" +
            "<td>" + nombreOperario + "</td>" +
            "<td>" + honaInicio + "</td>" +
            "<td>" + horaFin + "</td>" +
            "<td>" + cantidad + "</td>" +
            "<td>" + nombreAlmacen + "</td>" +
            "<td>" + (tipoProducto + " " + color + " "
                + escsupLargo + "X" + escsupAncho + "X" + escsupAlto) + "</td>" +
            "<td>" + unidadMedida + "</td>" +
            "<td>" + escsupLargo + "</td>" +
            "<td>" + escsupAncho + "</td>" +
            "<td>" + escsupAlto + "</td>" +
            "<td>" + (largo * ancho) + "</td>" +
            "<td>" + (largo * ancho * LadoSuoerior) + "</td>" +
            "<td>" + canastilla + "</td>" +
            "<td>" + horaSalida + "</td>" +
            "<td>" + motivo + "</td>" +
            "<td>" + botonEliminar + "</td>" +
            "</tr>";
        filaEscallaLateral1 = "<tr style='font-size: 12px;'>" +
            "<td>" + nombreOperario + "</td>" +
            "<td>" + honaInicio + "</td>" +
            "<td>" + horaFin + "</td>" +
            "<td>" + cantidad + "</td>" +
            "<td>" + nombreAlmacen + "</td>" +
            "<td>" + (tipoProducto + " " + color + " " + esclat1Largo + "X" + esclat1Ancho + "X" + esclat1Alto) + "</td>" +
            "<td>" + unidadMedida + "</td>" +
            "<td>" + esclat1Largo + "</td>" +
            "<td>" + esclat1Ancho + "</td>" +
            "<td>" + esclat1Alto + "</td>" +
            "<td>" + (largo * ancho) + "</td>" +
            "<td>" + (largo * alto * Lado1) + "</td>" +
            "<td>" + canastilla + "</td>" +
            "<td>" + horaSalida + "</td>" +
            "<td>" + motivo + "</td>" +
            "<td>" + botonEliminar + "</td>" +
            "</tr>";
        filaEscallaLateral2 = "<tr style='font-size: 12px;'>" +
            "<td>" + nombreOperario + "</td>" +
            "<td>" + honaInicio + "</td>" +
            "<td>" + horaFin + "</td>" +
            "<td>" + cantidad + "</td>" +
            "<td>" + nombreAlmacen + "</td>" +
            "<td>" + (tipoProducto + " " + color + " " + esclat2Largo + "X" + esclat2Ancho + "X" + esclat2Alto) + "</td>" +
            "<td>" + unidadMedida + "</td>" +
            "<td>" + esclat2Largo + "</td>" +
            "<td>" + esclat2Ancho + "</td>" +
            "<td>" + esclat2Alto + "</td>" +
            "<td>" + (largo * ancho) + "</td>" +
            "<td>" + (largo * alto * Lado2) + "</td>" +
            "<td>" + canastilla + "</td>" +
            "<td>" + horaSalida + "</td>" +
            "<td>" + motivo + "</td>" +
            "<td>" + botonEliminar + "</td>" +
            "</tr>";

        $("#tblDetalleCorte  tbody").append(filaEscallaSuperior);
        $("#tblDetalleCorte  tbody").append(filaEscallaLateral1);
        $("#tblDetalleCorte  tbody").append(filaEscallaLateral2);

        //$('#myTable > tbody:last-child').append('<tr>...</tr><tr>...</tr>');
    });
    //Evento boton guardar bajada
    $("#btnGuardarBajada").click(function () {
        var horaInicioBajada = $("#txtHoraInicioBajada").val();
        var horaFinBajada = $("#txtHoraFinBajada").val();
        var alto = $("#txtAltoBajada").val();
        var largo = $("#txtLargoBajada").val();
        var ancho = $("#txtAnchoBajada").val();

        var horaSalida = $("#txtHoraSalida").val();
        var motivo = $("#txtMotivo").val();
        //valor por eddefectoa canastilla
        var estadoCanasta = "SI";
        var filaDeBajada = "";
        var nombreOperario = "PALOMINO VELIZ JOEL";
        var nombreAlmacen = "Almacen de corte";
        var color = "Laguna";
        var tipoProducto = "Filaña";
        var unidadMedida = "UNI";
        var motivo = "--";
        var botonEliminar = "";

        //Bloque de piezas buenas
        var cantidad = $("#txtCantPzasBuenas").val();
        var canastilla = $("#txtCanastillaPzasBuenas").val();

        //Bloque de piezas malas
        var cantidadPzasMalas = $("#txtCantPzasMalas").val();
        var canastillaPzaMala = $("#xtCanastillaPzasMalas").val();
        var cantidadFilas = $("#tblDetalleCorte > tbody > tr").length;

        botonEliminar = '<button type="button" id="Button11" class="btn" onclick="return EliminarDetalleCorte(' + cantidadFilas + ')"><i class="fa fa-trash fa-2x"></i></button>';
        if (cantidad > 0) {

            
            filaDeBajada = "<tr style='font-size: 12px;'>" +
            "<td>" + nombreOperario + "</td>" +
            "<td>" + horaInicioBajada + "</td>" +
            "<td>" + horaFinBajada + "</td>" +
            "<td>" + cantidad + "</td>" +
            "<td>" + nombreAlmacen + "</td>" +
            "<td>" + (tipoProducto + " " + color + " " + largo + "X" + ancho + "X" + alto) + "</td>" +
            "<td>" + unidadMedida + "</td>" +
            "<td>" + largo + "</td>" +
            "<td>" + ancho + "</td>" +
            "<td>" + alto + "</td>" +
            "<td>" + (largo * ancho) + "</td>" +
            "<td>" + (largo * alto * alto) + "</td>" +
            "<td>" + canastilla + "</td>" +
            "<td>" + horaSalida + "</td>" +
            "<td>" + motivo + "</td>" +
            "<td>" + botonEliminar + "</td>" +
            "</tr>";
            $("#tblDetalleCorte  tbody").append(filaDeBajada);
        }
        if (cantidadPzasMalas > 0) {

            var filaBajadaMala = "";
            filaBajadaMala = "<tr style='font-size: 12px;'>" +
            "<td>" + nombreOperario + "</td>" +
            "<td>" + horaInicioBajada + "</td>" +
            "<td>" + horaFinBajada + "</td>" +
            "<td>" + cantidadPzasMalas + "</td>" +
            "<td>" + nombreAlmacen + "</td>" +
            "<td>" + (tipoProducto + " " + color + " " + largo + "X" + ancho + "X" + alto) + "</td>" +
            "<td>" + unidadMedida + "</td>" +
            "<td>" + largo + "</td>" +
            "<td>" + ancho + "</td>" +
            "<td>" + alto + "</td>" +
            "<td>" + (largo * ancho) + "</td>" +
            "<td>" + (largo * alto * alto) + "</td>" +
            "<td>" + canastillaPzaMala + "</td>" +
            "<td>" + horaSalida + "</td>" +
            "<td>" + motivo + "</td>" +
            "<td>" + botonEliminar + "</td>" +
            "</tr>";

            $("#tblDetalleCorte  tbody").append(filaBajadaMala);
        }
    });

    $("#btnGuardarCostra").click(function () {
        var anchoCostra = $("#txtAnchoCostra").val()
        var largoCostra = $("#txtLargoCostra").val();
        var altoCostra = $("#txtAltoCostra").val();
        var obsCostra = $("#txtObservacionCostra").val();

    });
    //inicio de grilla de isotop
    $grid = $(".grid").isotope(
    {
        itemSelector: '.element-item',
        layoutMode: 'fitRows',
        getSortData: {
            category: '[data-category]',
            weight: function (itemElem) {
                var weight = $(itemElem).find('.weight').text();
                return parseFloat(weight.replace(/[\(\)]/g, ''));
            }
        }

    });

    // filter functions
    var filterFns = {
        // show if number is greater than 50
        numberGreaterThan50: function () {
            var number = $(this).find('.number').text();
            return parseInt(number, 10) > 50;
        },
        // show if name ends with -ium
        ium: function () {
            var name = $(this).find('.name').text();
            return name.match(/ium$/);
        },
        numberFilterByGroup1: function () {
            var number = $(this).find('.number').text();
            return parseInt(number, 10) < 11;
        },
        numberFilterByGroup2: function () {
            var number = $(this).find('.number').text();
            return 10 < parseInt(number, 10);
        },
        numberFilterByValue: function () {
            var $category = $(this).attr("data-category").text();
            alert($category);
        }
    };
    // bind filter button click
    $('#filters').on('click', 'button', function () {
        var filterValue = $(this).attr('data-filter');
        // use filterFn if matches value                
        filterValue = filterFns[filterValue] || filterValue;
        $grid.isotope({ filter: filterValue });
    });
    $("#filtersByValue").on('click', 'button', function () {
        var filterValue = $(this).attr('data-filter');
        // use filterFn if matches value                
        filterValue = filterFns[filterValue] || filterValue;
        $grid.isotope({ filter: filterValue });
    });

    // change is-checked class on buttons
    $('.button-group').each(function (i, buttonGroup) {
        var $buttonGroup = $(buttonGroup);
        $buttonGroup.on('click', 'button', function () {
            $buttonGroup.find('.is-checked').removeClass('is-checked');
            $(this).addClass('is-checked');
        });
    });

    //Capturar el primer boton de cadad menu desplegable
    IniciarTabControl();


});
function IniciarTabControl()
{
//    //Enfocar el primer elemento de <a> contenido en tablinks_Basico
//    var listaTabListaBasico = $(".tablinks_Basico");
//    var listaTabListaSecundario = $(".tablinks");
//    // Los botones del menu del tablink son enfocados
//    listaTabListaBasico.eq(0).attr("class", " active");
//    listaTabListaSecundario.eq(0).attr("class", " active");

//    var listaTabContentBasico = $(".tabcontent_Basico");
//    var listaTabContent = $(".tabcontent");
//    listaTabContentBasico.eq(0).css("display", "block");
//    listaTabContent.eq(0).css("display", "block");

}
//#Endregion
//#Region
var BuscarColor = function () {
    ListarColores();
}
var BuscarCliente= function()
{
    var tipoAnalisis = '01';
    listarClientes(tipoAnalisis);
    //$grid_TextFilter('#'
}

function ListarMaquinas() {
    var args = "";
    //BuscarMaquinaCallBack(args, function

    //BuscarMaquinaCallBack(

}

function CrearDivOpcion(parIdOpcion, parDescripcionOpcion) {
    // datos[i].Value --> parIdOpcion
    // datos[i].Text --> parDescripcionOpcion

    var contenedor = "", etiquetaCodigo = "", etiquetaDescripcion = "";

    //Identificar los Selectores para acceder al contenedor
    selectores = "#divAyudaColor > #resultadodebusqueda";

    //Definir primero el codigo html de codigo y descripcion
    etiquetaCodigo = "<h1 class='codigoMaquina'  style='display:none;' >" + parIdOpcion + "</h1>";
    etiquetaDescripcion = "<h5 class='etiqueta number' style='font-size:20px;'>" 
                        + parDescripcionOpcion + "</h5>";

    contenedor = "<div class='element-item maquina' onclick='SeleccionarMaquina(this)'>"
                    + etiquetaCodigo  + etiquetaDescripcion  +"</div>";

    $(selectores).append(contenedor);
    

}
function AgregarElementosaBusqueda(parIdOpcion, parDescripcionOpcion, parNroOrden) {
    var contenedor = "", codigo = "", descripcion = "", nroDeOrden = "", $htmlDinanmico="";
    nroDeOrden = "<span class='codigoDeOrden' style='display:none;'>" + parNroOrden + "</span>";
    codigo = "<h1 class='codigoMaquina'  style='display:none;' >" + parIdOpcion + "</h1>";
    descripcion = "<h5 class='etiqueta number' style='font-size:20px;'>"
     + parDescripcionOpcion + "</h5>";
    contenedor = "<div class='element-item maquina' data-category='1' onclick='SeleccionarMaquina(this)'>"+
                        nroDeOrden + codigo + descripcion + "</div>";


    $htmlDinanmico = $htmlDinanmico + contenedor;
    //
    var $newItems = $($htmlDinanmico);
    $('#resultadodebusqueda').append($newItems).isotope('addItems', $newItems);
    //Codigo 3
}

function CrearPaginacion(parIdOpcion)
{

}


function AgregarhtmlDinamico() {
    var contenedor = "", codigo = "", descripcion = "", nroDeOrden = "";
  
    var $htmlDinanmico = "";
    //Codigo 1 
    nroDeOrden = "<span class='codigoDeOrden' style='display:none;'>01</span>";
    codigo = "<h1 class='codigoMaquina'  style='display:none;' >AL</h1>";
    descripcion = "<h5 class='etiqueta number' style='font-size:20px;'>Alpaquita</h5>";
    contenedor = "<div class='element-item maquina' data-category='1' onclick='SeleccionarMaquina(this)'>" +
                    nroDeOrden + codigo + descripcion + "</div>";
    $htmlDinanmico = $htmlDinanmico + contenedor;


    //Codigo 2
    nroDeOrden = "<span class='codigoDeOrden' style='display:none;'>02</span>";
    codigo = "<h1 class='codigoMaquina'  style='display:none;' >AG</h1>";
    descripcion = "<h5 class='etiqueta number' style='font-size:20px;'>Andes Gold</h5>";
    contenedor = "<div class='element-item maquina' data-category='1' onclick='SeleccionarMaquina(this)'>" +
                    nroDeOrden + codigo + descripcion + "</div>";

    $(contenedor).css("position", "absoulute");
    $(contenedor).css("left", "128px");
    $(contenedor).css("top", "0px");

    $htmlDinanmico = $htmlDinanmico + contenedor;
    //asignar valor de codigo de div aparta
    var div1 = '<div class="element-item" data-category="1">001<span class="codigoDeOrden">1</span></div>';
    var div2 = '<div class="element-item" data-category="1" >002<span class="codigoDeOrden">2</span></div>';
    var div3 = '<div class="element-item" data-category="1">003<span class="codigoDeOrden">3</span></div>';
    $htmlDinanmico = div1 + div2 + div3;
    var $newItems = $($htmlDinanmico);

    $('#resultadodebusqueda').append($newItems).isotope('addItems', $newItems);
}
function ListarColores() {
    var args = "";
    var datos = null;
//    AgregarhtmlDinamico();
    BuscarColorCallBack(args, function (output, context) {
        var result = (JSON.parse(output));
        datos = result.data;
        //Crear botones
        var cantidadRegistro = 0;
        
        
        for (var i = 1; i <= datos.length; i++) {
            //AgregarElementosaBusqueda(datos[i].Value, datos[i].Text, 1);
        }

    });
}
function listarClientes(tipAna) {
    //var tipAna = $("#ddlTipoAnalisis").val(); 
    var args = tipAna;

    if ($.fn.dataTable.isDataTable('#tbClientes')) {
        table = $('#tbClientes').DataTable();
        table.destroy();
    }
    $("#tbClientes tbody").empty();

    /*el parametreo args ->el parametro para ejeuctar la consulta*/
    /* el parametro output es la salida como arreglo del resultado de la consulta */
    /*la funcion BuscarClientesCallBack se encuentra registro en el codigo de la pagina web*/
    BuscarClientesCallBack(args, function (output, context) {
        /*JSON transforma los datos de arreglo  encapsularl cada registro en un objeto entidad */
        var result = (JSON.parse(output));
        var datos = result.data;
        for (var i = 0; i < datos.length; i++) {
            //$("#tbClientes tbody").append("<tr><td>" + datos[i].Value +"</td><td>" + datos[i].Text +"</td></tr>");
            $("#tbClientes tbody").append("<tr><td><span style='display:none;' >" + datos[i].Value + "</span>" + datos[i].Text + "</td></tr>");

        }

        var table = $('#tbClientes').DataTable({
            scrollY: false,
            scrollX: false,
            paging: true,
            searching: true,
            ordering: false,
            info: false
        });

    });

    return false;
};
//#Endregion
function GuardarTipoSeleccionado() {

}
function GuardarColorSeleccionado() {

}
function numberFilterByGroup() {

}

//#Region "ResaltaBotonSeleccionado"
function ResaltaBotonSeleccionado() { 
    //$("#divMaquinas").find("div").css(
}
//#Endregion

var codigoDeAyudaSeleccionado = "";
//#Region "SeleccionarMaquina"

function ResaltarOpcionSeleccionado(opcionSeleccionado) {
    /*
    //Asignar color rojo a todo las maquinas
    $(".grid").find('div').css("background-color", "red");
    $(".grid").find('H5').css("background-color", "red");
    //Asignar color a la opcion seleccionado
    $(opcionSeleccionado).css("background-color", "#1a8cff");
    $(opcionSeleccionado).find('H5').css("background-color", "#1a8cff");
    */
}
function SeleccionarMaquina(opcionSeleccionado) {

    var codigo = "", descripcion = "";
    //Captura cual tipo de ayuda selecciona
    var tipoAyuda = $(opcionSeleccionado).parent().parent().attr('id');
    if (tipoAyuda == "DivAyudaMaquina") {
        codigoDeAyudaSeleccionado = $(opcionSeleccionado).find('.codigoMaquina').text()
            + "," + $(opcionSeleccionado).find('.number').text();

        codigo = $(opcionSeleccionado).find('.codigoMaquina').text().trim();
        descripcion = $(opcionSeleccionado).find('.texto').text().trim();
        $("#txtmaquina").text(codigo);
        $("#txtCodigoMaquina").val(descripcion);
        $("#DivAyudaMaquina").dialog("close");

    } else if (tipoAyuda == "divAyudaTurno") {
        codigo = $(opcionSeleccionado).find('.codigoHorario').text().trim();
        descripcion = $(opcionSeleccionado).find('.number').text().trim();
        $("#txtturno").text(codigo);
        $("#txtCodigoTurno").val(descripcion);
        $("#divAyudaTurno").dialog("close");
    } else if (tipoAyuda == 'divAyudaColor') {
        codigo = $(opcionSeleccionado).find('.codigoDeColor').text().trim();
        descripcion = $(opcionSeleccionado).find('.texto').text().trim();
        $("#txtColorId").val(codigo);
        //alert($("#txtColorId").val());
        $("#txtColorOT").val(descripcion);
        $("#divAyudaColor").dialog("close");
    } else if (tipoAyuda == 'divAyudaTipo') {
        codigo = $(opcionSeleccionado).find('.codigoDeTipo').text().trim();
        descripcion = $(opcionSeleccionado).find('.texto').text().trim();
        $("#txtTipoId").val(codigo);
        $("#txtTipoOT").val(descripcion);
        $("#divAyudaTipo").dialog("close");
    }
    
    

    
    //var esDi $(opcionSeleccionado).find('.codigoHorario').length
    //codigoDeAyudaSeleccionado = $(opcionSeleccionado).find('.codigoHorario').text();

}
//#endregion
//#Region "GuardarTurnoSeleccionado"
function GuardarTurnoSeleccionado() {
    //Usar el valor de la variable de codigo selecioando a nivel global.
    var codigo = "", descripcion = "";
    codigo = $.trim(codigoDeAyudaSeleccionado.split(',')[0]);
    descripcion = $.trim(codigoDeAyudaSeleccionado.split(',')[1]);

    $("#txtCodigoTurno").text(codigo);
    $("#txtturno").val(descripcion);

    $("#divAyudaTurno").dialog("close");
}
//#Endregion

//#Region "GuardarMaquinaSeleccionado"
function GuardarMaquinaSeleccionado()
{
    //Recorrer los registro seleccionados de la ayuda
    var codigo = "", descripcion = "";

    codigo = codigoDeAyudaSeleccionado.split(',')[0];
    descripcion = codigoDeAyudaSeleccionado.split(',')[1];

    $("#txtCodigoMaquina").text(codigo);
    $("#txtmaquina").val(descripcion);

    $("#DivAyudaMaquina").dialog("close");
}
//#Endregion
//#Region "Cancelar"
 function Cancelar()
 {
    $(location).attr('href', "frmCorte.aspx");
    return false;
}
//#Endregion

//Metodo para abrir tabContent de Order de trabajo y materia prima
function NavegarTabControl(evt, nombreDeTab) {
    var i, tabcontent, tablinks;
    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent_Basico");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks_Basico");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(nombreDeTab).style.display = "block";
    evt.currentTarget.className += " active";
}

// #Region OpenCity
function openCity(evt, cityName) {
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}
// #Endregion

//#Region EliminarDetalleCorte 
function EliminarDetalleCorte(indiceTablaCorte) {
    var confirma = confirm("¿Esta seguro de eliminar?");
    if (confirma == false) {
        return false;
    }
    var tblDetalleCorte = document.getElementById("tblDetalleCorte");
    tblDetalleCorte.deleteRow(indiceTablaCorte);
    alert("Registro eliminado");
    return true;
}
//#endregion "EliminarDetalleCorte"
//Filtrar istope por texto
 $grid_TextFilter = $(".grid").isotope({
    itemSelector: '.element-item',
    layoutMode: 'fitRows',
    filter: function () {
        return qsRegex ? $(this).text().match(qsRegex) : true;
    }
});

// use value of search field to filter
var $quicksearch = $('.quicksearch').keyup(debounce(function () {
    qsRegex = new RegExp($quicksearch.val(), 'gi');
    $grid_TextFilter.isotope();
}, 200));

// debounce so filtering doesn't happen every millisecond
function debounce(fn, threshold) {
    var timeout;
    threshold = threshold || 100;
    return function debounced() {
        clearTimeout(timeout);
        var args = arguments;
        var _this = this;
        function delayed() {
            fn.apply(_this, args);
        }
        timeout = setTimeout(delayed, threshold);
    };
}


/// Eventos para cabecera
function GuardarCabecera() {
    //btnGuardar evento click
    $("#txtCodigoDocumento").val("00001");
}