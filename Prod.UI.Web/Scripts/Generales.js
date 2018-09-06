$(function () {
    //Llenar combo Periodo //Periodo
    //obtenerPeriodoActualNuevo1();
    //cargarPeriodo();
    obtenerPeriodoActualNuevo1();

    $("#ddlPeriodo").change(function () {
        cambiarPeriodoMes();
    });

    $("#idLogout").click(function () {
        cerrarSesion();
    });

    $("#idLogout1").click(function () {
        cerrarSesion();
    });

});

/*Agregado: Edgar Huarcaya C.*/
var cargarPeriodo = function (codMes) {
    $("#ddlPeriodo option").remove();

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
                    $("#ddlPeriodo").append("<option value='" + item.ccb03cod + "'>" + item.ccb03des + "</option>");
                });
                //obtenerPeriodoActualNuevo();
                //obtenerPeriodoActualNuevo();                   
                //seleccionarPeriodoActivo();
                $("#ddlPeriodo").val(codMes);

            } else {
                alertify.error(dato.message);
            }

            //var myVar = setInterval(function () { obtenerPeriodoActualNuevo() }, 100);             

        }
    });

}

//Carga el periodo actual de la sesion
//Agregado por: Edgar Huarcaya C.
var obtenerPeriodoActual = function () {
    $.ajax({
        url: '../WS/wsComunes.asmx/ObtenerMesActual',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            var dato = response;
            var data = $.parseJSON(dato["d"]);
            var items = data.data;
            $("#ddlPeriodo").val(items.CodigoMes);
            //retorno = items.CodigoMes;
        }
    });
};

var seleccionarPeriodoActivo = function () {
    // var myVar = setInterval(function () { obtenerPeriodoActualNuevo() }, 1000);     

    obtenerPeriodoActualNuevo();
}

var obtenerPeriodoActualNuevo1 = function () {

    var arg = "";
    var args = arg;

    jQuery.ajax({
        url: '../Pages/frmLogon.aspx/ObtenerMesActualCallBack1',
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var datos = JSON.stringify(data);
            var resul = data["d"];
            //alert(data.d);
            var resul1 = data.d;


            var objJSON = $.parseJSON(resul);
            //alert(objJSON.CodigoMes);

            /*
            $.each(objJSON, function (key, val) {
                alert(val["CodigoMes"]);

                //$("#cmbServicio").append('<option value=' + val["srv_id"] + '>' + val["srv_nombre"] + '</option>');
            });
            */

            /*
            for (i = 0; i < resul.length; i++) {
            //alert("Ente");
            }
            */

            cargarPeriodo(objJSON.CodigoMes);
        }
    });
}


var obtenerPeriodoActualNuevo = function () {

    var arg = "";
    var args = arg;

    ObtenerMesActualCallBack1(args, function (output, context) {
        var result = (JSON.parse(output));

        //if (result.result == "1") {

        alert(result.data);
        var usuario = result.data;
        if (!($.isEmptyObject(usuario))) {
            $("#ddlPeriodo").val(usuario.CodigoMes);
        }
        //}

    });

}


var cambiarPeriodoMes = function () {
    var arg = $("#ddlPeriodo").val();
    var args = arg;
    //var args = "07";
    CambiarPeriodoMesCallBack(args, function (output, context) {
        var result = (JSON.parse(output));

        if (result.result == "1") {
            //$(location).attr('href', "Index.aspx");
        }

    });

    return false;
}

var cerrarSesion = function () {

    var arg = "";
    var args = arg;

    CerrarSesionCallBack(args, function (output, context) {
        var result = (JSON.parse(output));
        if (result.result == "1") {
            $(location).attr('href', "frmLogon.aspx");
        }

    });

    return false;
}

/* 
* To change this license header, choose License Headers in Project Properties.
* To change this template file, choose Tools | Templates
* and open the template in the editor.
*/

function validarRedirect(retorno) {
    //if (retorno.isRedirect) {
    //    alertify.error("La sesion actual ha expirado."); setTimeout(function () { document.location.href = retorno.redirectUrl; }, 2000);
    //}
}
function validarSesion() { $.ajax({ url: '../Login/ValidarSesion', type: 'POST', success: function (response) { var retorno = response; validarRedirect(retorno); } }); }

function validateFloatKeyPress(el, evt, ints, decimals) {
    var comaAscii = 46;
    var coma = ".";

    // El punto lo cambiamos por la coma
    /*            if (evt.keyCode == 46) {
    evt.keyCode = comaAscii;
    }
    */

    // Valores numéricos
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode != comaAscii && charCode > 31
        && (charCode < 48 || charCode > 57)) {
        return false;
    }

    // Sólo una coma
    if (charCode == comaAscii) {
        if (el.value.indexOf(coma) !== -1) {
            return false;
        }

        return true;
    }

    // Determinamos si hay decimales o no
    if (el.value.indexOf(coma) == -1) {
        // Si no hay decimales, directamente comprobamos que el número que hay ya supero el número de enteros permitidos
        if (el.value.length >= ints) {
            return false;
        }
    }
    else {

        // Damos el foco al elemento
        el.focus();

        // Para obtener la posición del cursor, obtenemos el rango de la selección vacía
        var oSel = document.selection.createRange();

        // Movemos el inicio de la selección a la posición 0
        oSel.moveStart('character', -el.value.length);

        // La posición de caret es la longitud de la selección
        iCaretPos = oSel.text.length;

        // Distancia que hay hasta la coma
        var dec = el.value.indexOf(coma);

        // Si la posición es anterior a los decimales, el cursor está en la parte entera
        if (iCaretPos <= dec) {
            // Obtenemos la longitud que hay desde la posición 0 hasta la coma, y comparamos
            if (dec >= ints) {
                return false;
            }
        }
        else { // El cursor está en la parte decimal
            // Obtenemos la longitud de decimales (longitud total menos distancia hasta la coma menos el carácter coma)
            var numDecimals = el.value.length - dec - 1;

            if (numDecimals >= decimals) {
                return false;
            }
        }
    }

    return true;
}

function solonumeros(e) {
    var target = (e.target ? e.target : e.srcElement);
    var key = (e ? e.keyCode || e.which : window.event.keyCode);
    if (key == 46)
        return (target.value.length > 0 && target.value.indexOf(".") == -1);
    return (key <= 12 || (key >= 48 && key <= 57) || key == 0);
}

function limpiarRequerido() {
    $('.requerido').each(function (i, elem) {
        $(elem).css({ 'border': '1px solid gray' });
    });
}

function QuitarRequerido(tabla) {
    $("#" + tabla + " tr td").each(function (i, elem) {
        $(":input [type:text]").removeAttr('class');
    });
}
function AgregarRequerido(tabla) {
    $("#" + tabla + " tbody tr ").each(function (i, elem) {
        $(":input [type=text]").attr('class', 'requerido');
    });
}
/*valida los controles que tengan la clase requerido o requeridoLst y muestra el mensaje el Id del div como parametro */
var ValidarObligatorio = function (divForm) {
    var error = 0;
    $(divForm + ' .require').each(function (i, elem) {
        if ($.trim($(elem).val()) == '') {
            $(elem).css({ 'border': '1px solid red' });
            error++;
        } else {
            $(elem).css({ 'border': '1px solid gray' });
        }
    });
    $(divForm + ' .selectpicker').each(function (i, elem) {
        /// alert($(elem).val() );
        if ($(elem).val() == '000' || $(elem).val() == '00000' || $(elem).val() == '0') {
            $(elem).css({ 'border': '1px solid red' });
            error++;
        } else {
            $(elem).css({ 'border': '1px solid gray' });
        }
    });
    $(divForm + ' .response').each(function (i, elem) {
        var lbl = $(elem).attr("for");
        if ($.trim($(elem).text()) == '') {

            $("#" + lbl).css({ 'border': '1px solid red' });
            error++;
        } else {

            $("#" + lbl).css({ 'border': '1px solid gray' });
        }

    });
    $(divForm + ' .mayorcero').each(function (i, elem) {
        if ((($(elem).val()) == 0) || (($(elem).val())<= 0.0)) {
            $(elem).css({ 'border': '1px solid red' });
            error++;
        } else {
            $(elem).css({ 'border': '1px solid gray' });
        }
    });
    if (error > 0) {
        //msgError( "Debe ingresar los campos requeridos ");
        return false;
    } else {
        // msgError(divAviso, "");
        return true;
    }
};
var FechaConfig = function () {
    $.datepicker.regional['es'] = {
        closeText: 'Cerrar',
        prevText: 'Previo',
        nextText: 'Próximo',
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        monthStatus: 'Ver otro mes',
        yearStatus: 'Ver otro año',
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sáb'],
        dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
        dateFormat: 'dd/mm/yy', firstDay: 0,
        initStatus: 'Selecciona la fecha', isRTL: false
    };

    $.datepicker.setDefaults($.datepicker.regional['es']);
};

function GetQueryStringParams(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
};

function InicializarTab() {
    $('#tabs').tabs("disable");
};

function EjecutarAccion(purl, pdata, hasPopUp) {
    $.ajax({
        data: pdata,
        url: purl,
        type: 'POST',
        success: function (response) {
            var dato = response;
            validarRedirect(dato);
            if (dato.result == K_ResultadoAjax.Exito) {
                alertify.success(dato.message);
                if (hasPopUp != undefined) {
                    closePopup();
                }
            } else if (dato.result == K_ResultadoAjax.Error) {
                alertify.error(dato.message);
            }
        }
    });
};

//Agregar por: Edgar Huarcaya
function solonumerosypunto(e) {
    var target = (e.target ? e.target : e.srcElement);
    var key = (e ? e.keyCode || e.which : window.event.keyCode);
    if (key == 46) return (target.value.length > 0 && target.value.indexOf(".") == -1);
    return (key <= 12 || (key >= 48 && key <= 57) || key == 0);
} // Fin de solonumerosypunto

function oNumero(numero) {
    //Propiedades 
    this.valor = numero || 0
    this.dec = -1;

    //Métodos 
    this.formato = numFormat;
    this.ponValor = ponValor;

    //Definición de los métodos
    function ponValor(cad) {
        if (cad == '-' || cad == '+') return
        if (cad.length == 0) return
        if (cad.indexOf('.') >= 0)
            this.valor = parseFloat(cad);
        else
            this.valor = parseInt(cad);
    }

    function numFormat(dec, miles) {
        var num = this.valor, signo = 3, expr;
        var cad = "" + this.valor;
        var ceros = "", pos, pdec, i;
        for (i = 0; i < dec; i++) {
            ceros += '0';
        }

        pos = cad.indexOf('.')
        if (pos < 0) {
            cad = cad + "." + ceros;
        } else {
            pdec = cad.length - pos - 1;

            if (pdec <= dec) {
                for (i = 0; i < (dec - pdec); i++) {

                    cad += '0';
                }
            } else {
                num = num * Math.pow(10, dec);
                num = Math.round(num);
                num = num / Math.pow(10, dec);
                cad = new String(num);
            }
        }

        pos = cad.indexOf('.')

        if (pos < 0) {
            pos = cad.lentgh;
        }

        if (cad.substr(0, 1) == '-' || cad.substr(0, 1) == '+') {
            signo = 4;
        }

        if (miles && pos > signo) {
            do {
                expr = /([+-]?\d)(\d{3}[\.\,]\d*)/
                cad.match(expr)
                cad = cad.replace(expr, RegExp.$1 + ',' + RegExp.$2);
            }

            while (cad.indexOf(',') > signo)
            {
                if (dec <= 0) {
                    cad = cad.replace(/\./, '');
                }
            }
        }
        return cad;
    }
} //Fin del objeto oNumero:

function fLeft(str, n) {
    if (n <= 0)
        return "";
    else if (n > String(str).length)
        return str;
    else
        return String(str).substring(0, n);
} //Fin de fLeft

function fRight(str, n) {
    if (n <= 0)
        return "";
    else if (n > String(str).length)
        return str;
    else {
        var iLen = String(str).length;
        return String(str).substring(iLen, iLen - n);
    }
} //Fin de function fRight

//Agregado por: Edgar Huarcaya
function setPageTitle(titulo) {
    $("#lblTitulo").html(titulo);
    $("#lblNavigator").html(titulo);


    /*
    var d = new Date();
    var curr_date = d.getDate();
    var curr_month = d.getMonth() + 1; //Months are zero based
    var curr_year = d.getFullYear();
    var resul = curr_date + "-" + curr_month + "-" + curr_year;

    $("#lblFechaSistema").html(resul);
    */
};

function GetQueryStringParams(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
};
