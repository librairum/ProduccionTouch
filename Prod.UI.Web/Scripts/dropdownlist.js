var K_ResultadoAjax = { Exito: 1, Error: 0 };

/*Agregado: Edgar Huarcaya C.*/
var LlenarComboOrigen = function (control, mensaje, valor) {

    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");

    var codigoEmpresa = "01";
    var param = "{'codigoEmpresa':'" + codigoEmpresa + "'}";

    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerItemsOrigen',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: (param),
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;

            validarRedirect(dato);

            if (data.result == K_ResultadoAjax.Exito) {
                $.each(items, function (index, item) {
                    var selected = "";
                    // if (val === item.Value) selected = "Selected";

                    if (item.Value == "01") selected = "Selected";
                    $("#" + control).append("<option value='" + item.Value + "' " + selected + ">" + item.Text + "</option>");
                });
            } else {
                alertify.error(dato.message);
            }
        }
    });
}

/*Agregado: Edgar Huarcaya C.*/
var LlenarItemsTipoAnalisis = function (control, mensaje, valor) {

    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");

    var codigoEmpresa = "01";
    var param = "{'codigoEmpresa':'" + codigoEmpresa + "'}";

    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerItemsTipoAnalisis',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: (param),
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;

            validarRedirect(dato);

            if (data.result == K_ResultadoAjax.Exito) {
                $.each(items, function (index, item) {
                    var selected = "";
                    //if (val === item.Value) selected = "Selected";
                    if (item.Value == "01") selected = "Selected";
                    $("#" + control).append("<option value='" + item.Value + "' " + selected + ">" + item.Text + "</option>");
                });
            } else {
                alertify.error(dato.message);
            }
        }
    });
}

/*Agregado: Edgar Huarcaya C.*/
var LlenarItemsTipoDocumentoCliente = function (control, mensaje, valor) {

    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");

    var codigoEmpresa = "01";
    var param = "{'codigoEmpresa':'" + codigoEmpresa + "'}";

    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerItemsTipoDocumentoCliente',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: (param),
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;

            validarRedirect(dato);

            if (data.result == K_ResultadoAjax.Exito) {
                $.each(items, function (index, item) {
                    var selected = "";
                    //if (val === item.Value) selected = "Selected";
                    if (item.Value == "01") selected = "Selected";
                    $("#" + control).append("<option value='" + item.Value + "' " + selected + ">" + item.Text + "</option>");
                });
            } else {
                alertify.error(dato.message);
            }
        }
    });
}

/*Agregado: Edgar Huarcaya C.*/
var LlenarItemsPeriodo = function (control, mensaje, valor) {

    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");

    var codEmpresa = "01";
    var codAnio = "2015";

    var param = "{'codigoEmpresa':'" + codEmpresa + "', 'codigoAnio': '" + codAnio + "'}";

    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerItemsPeriodo',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: (param),
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;

            validarRedirect(dato);

            if (data.result == K_ResultadoAjax.Exito) {
                $.each(items, function (index, item) {
                    var selected = "";
                    if (val === item.Value) selected = "Selected";
                    $("#" + control).append("<option value='" + item.ccb03cod + "' " + selected + ">" + item.ccb03des + "</option>");
                });
            } else {
                alertify.error(dato.message);
            }
        }
    });
}

/*Agregado: Edgar Huarcaya C.*/
var LlenarComboDestino = function (control, mensaje, valor) {

    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");

    var codigoEmpresa = "01";
    var param = "{'codigoEmpresa':'" + codigoEmpresa + "'}";

    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerItemsDestino',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: (param),
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;

            validarRedirect(dato);

            if (data.result == K_ResultadoAjax.Exito) {
                $.each(items, function (index, item) {
                    var selected = "";
                    //selecciona NACIONAL POR DEFECTO
                    if (item.Value == "01") selected = "Selected";
                    $("#" + control).append("<option value='" + item.Value + "' " + selected + ">" + item.Text + "</option>");
                });
            } else {
                alertify.error(dato.message);
            }
        }
    });
}
/**Agregado por Ivan */
var LlenarComboFormato = function(control,mensaje,valor,codigoTabla){
	var val = valor == undefined ? 0 : valor;
	$("#" + control + " option").remove();
	$("#" + control).append("<option value='0'>" + mensaje + "</option>");
	var codigotabla = codigoTabla;
	var param = "{'codigoTabla':'"+ codigotabla +"'}";
	$.ajax({
		url:'../WS/wsComunes.asmx/ObtenerFormatos',
		type:'POST',
		contentType:"application/json;charset=utf-8",
		dataType:"json",
		data: (param),
		success:function(response){
			var dato = response;
			var data = $.parseJSON(dato["d"]);
			var items = data.data;
			validarRedirect(dato);
			if(data.result == K_ResultadoAjax.Exito) {
				$.each(items, function(index, item){
					var selected = "";
					
					$("#"+ control).append("<option value='" + item.Value + "' >" + item.Text + "</option>");
				});
			}else{
				alertify.error(dato.message);
				
			}
			
		}
		
	});
}


/*Agregao Ivan Atanacio */
var LlenarComboTipo = function (control, mensaje, valor, codigoTabla) {
    var val = valor == undefined ? 0 : valor;
    $("#" + control + " option").remove();
    $("#" + control).append("<option value='0'>" + mensaje + "</option>");
        var codigotabla = codigoTabla;
        var param = "{'codigoTabla':'" + codigotabla + "'}";
        $.ajax({
            url: '../WS/wsComunes.asmx/ObtenerTipos',
            type: 'POST',
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            data: (param),
            success: function (response) {
                var dato = response;
                var data = $.parseJSON(dato["d"]);
                var items = data.data;
                validarRedirect(dato);
                if (data.result == K_ResultadoAjax.Exito) {
                
                    $.each(items, function (index, item) {
                        var selected = "";
                        $("#" + control).append("<option value='" + item.Value + "' >" + item.Text + "</option>");
                    });

                } else { alertify.error(dato.message); }
            }
        });
    }
/* Agregado por Ivan Atanacio */

    var LlenarComboCliente = function (control, mensaje, valor) {
        var val = valor == undefined ? 0 : valor;
        var CodigodeEmpresa = "01";
        var codigotipoanalisis = '01';
        $("#" + control + " option").remove();
        $("#" + control).append("<option value='0'>" + mensaje + "</option>");
        
        //var param = "{'tipoAnalisis':'" + codigotipoanalisis + "'}";
        var param =
        {
            CodigoEmpresa : CodigodeEmpresa,
            tipoAnalisis : codigotipoanalisis

        };
        var args = JSON.stringify(param);
        $.ajax({
            url: '../WS/wsComunes.asmx/BuscarClientesCallBack',
            type: 'POST',
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            data: (args),
            success: function (response) {
                var dato = response;
                var data = $.parseJSON(dato["d"]);
                var items = data.data;
                validarRedirect(dato);

                if (data.result == K_ResultadoAjax.Exito) {
                    $.each(items, function (index, item) {
                        var selected = "";

                        $("#" + control).append("<option value='" + item.Value + "' >" + item.Text + "</option>");
                    });
                } else {
                    //alert(dato.message);
                    alertify.error(dato.message);
                }

            }
        });
    }
    var LlenarComboProformasxCliente = function (control, mensaje, valor) {
        var val = valor == undefined ? 0 : valor;
        var parCodigoEmpresa = "01";
        var parCodigoCliente = valor;
        var parClienteTipoDoc = "01";
        //        var parAnio = "2018";
        //        var parMes = "05";
        var param =
        {
            CodigoEmpresa: parCodigoEmpresa,
            ClienteTipoDoc: parClienteTipoDoc,
            CodigoCliente: parCodigoCliente
        };
        var args = JSON.stringify(param);
        $.ajax({
            url: '../WS/wsComunes.asmx/BuscarProformasxClienteCod',
            type: 'POST',
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            data: (args),
            success: function (response) {
                var dato = response;
                var data = $.parseJSON(dato["d"]);
                var items = data.data;
                // Limpiar las opciones del combo
                $("#" + control).html(' ');

                validarRedirect(dato);

                if (data.result == K_ResultadoAjax.Exito) {
                    $.each(items, function (index, item) {
                        var selected = "";

                        $("#" + control).append("<option value='" + item.Value + "' >" + item.Text + "</option>");
                    });
                } else {
                    //alert(dato.message);
                    alertify.error(dato.message);
                }

            }
        });

    }
//    var LlenarComboProforma = function (control, mensaje, valor) {
//    }