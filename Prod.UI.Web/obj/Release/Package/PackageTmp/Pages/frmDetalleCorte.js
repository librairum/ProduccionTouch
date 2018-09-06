//Constantes
var K_ACCION = "";
var K_NUEVO = "I";
var K_EDIT = "U";
var qsRegex;
var $grid_TextFilter;
//#Region "Evento Load"
$(function () {
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
        BuscarCliente();
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
            "Cancelar": function () {
                $("#divAyudaTurno").dialog("close");
                return false;
            }
        },
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
        }
    };
    // bind filter button click
    $('#filters').on('click', 'button', function () {
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

var BuscarCliente= function()
{
    var tipoAnalisis = '01';
    listarClientes(tipoAnalisis);
    //$grid_TextFilter('#'
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
        descripcion = $(opcionSeleccionado).find('.number').text().trim();
        $("#txtCodigoMaquina").val(codigo);
        $("#txtmaquina").text(descripcion);
        $("#DivAyudaMaquina").dialog("close");

    } else if (tipoAyuda == "divAyudaTurno") {
        codigo = $(opcionSeleccionado).find('.codigoHorario').text().trim();
        descripcion = $(opcionSeleccionado).find('.number').text().trim();
        $("#txtCodigoTurno").val(codigo);
        $("#txtturno").text(descripcion);
        $("#divAyudaTurno").dialog("close");
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
