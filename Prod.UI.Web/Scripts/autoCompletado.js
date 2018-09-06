function initOpcionAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Opcion/OpcionAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};
function initSistemaAutoCompletar(control, controlHidden, funcion, isOpt) {
    $("#" + control).autocomplete({
        source: "../Sistema/SistemaAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
            if (funcion != undefined) {
                if(funcion == "ddlModulo" || funcion == "ddlModuloFiltro"){
                    listarModuloXSistema(funcion, K_MensajeSelect.Todos, ui.item.Code);
                    if (isOpt != undefined) {
                        buscarHtml();
                    }
                }
                else if (funcion == "ddlPerfilFiltro" || funcion == "ddlPerfil") {
                    listarPerfilXSistema(funcion, K_MensajeSelect.Todos, ui.item.Code);
                }
            }
        }
    });
};
function initUsuarioAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Usuario/UsuarioAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};
function initOpcionXPerfilAutoCompletar(control, controlHidden,controlPerfil) {
    $("#" + control).autocomplete({
        source: function (request, response) {
            $.ajax({
                url:"../Opcion/OpcionXPerfilAutoCompletar",
                datatype:"json",
                data:{
                    term:request.term,
                    tisn:$("#"+controlPerfil).val()
                },
                success:function(data){
                    response($.map(data,function(item){
                        return{
                            label:item.value,
                            value:item.Descripcion,
                            Codigo:item.Code
                        }
                    }))
                }
            })
        },
        select:function(event,ui){
            $("#"+controlHidden).val(ui.item.Codigo);
        }
    });
};
/* ERP TEON */
function initProveedorAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Proveedor/ProveedorAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        } 
    });
};

function initUnidadMedidaAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Unidad/UnidadAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};

function initAlmacenAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Almacen/AlmacenAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};

function initAlmacenAutoCompletarDisArticulo(control, controlHidden,controlDisabled) {
    $("#" + control).autocomplete({
        source: "../Almacen/AlmacenAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
            var x = $("#" + control).val() == "" ? true : false;
            $("#" + controlDisabled).prop("disabled", x);
            $("#" + controlDisabled).focus();
        }
    });
};

function initArticuloAutoCompletar(control, controlHidden,controlAlmacen) {
    $("#" + control).autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "../Articulo/ArticuloXAlmacenAutoCompletar",
                datatype:"json",
                data:{
                    term:request.term,
                    tisn: $("#" + controlAlmacen).val()
                },
                success:function(data){
                    response($.map(data,function(item){
                        return{
                            label:item.value,
                            value:item.Descripcion,
                            Code:item.Code
                        }
                    }))
                }
            })
        },
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};

function initCentroCostoAutoCompletar(control, controlHidden,numPed) {
    $("#" + control).autocomplete({
        source: "../CentroCosto/CentroCostoAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
            if (numPed != undefined) {
                obtenerCodigoPedido(ui.item.Code);
                $("#txtResponsable").focus();
            }
        }
    });
};

function initResponsableAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Responsable/ResponsableAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
            $("#txtFechaPedido").focus();
        }
    });
};

function initServicioAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Servicio/ServicioAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};

function initAnalisisAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Analisis/AnalisisAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};

function initEmpresaAutoCompletar(control, controlHidden) {
    $("#" + control).autocomplete({
        source: "../Empresa/EmpresaAutoCompletar",
        select: function (event, ui) {
            $("#" + controlHidden).val(ui.item.Code);
        }
    });
};