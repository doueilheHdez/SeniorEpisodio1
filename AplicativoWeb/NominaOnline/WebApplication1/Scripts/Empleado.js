$(function () {
    $("#btnBuscar").on('click', function () {
        fnBuscar();
    });
    $("#txtNumero").keydown(function (e) {
        if (e.keyCode == 13) {
            fnBuscar();
        }
    });
    $('#txtNumero').on('input', function (e) {
        if (!/^[0-9]*$/i.test(this.value)) {
            this.value = this.value.replace(/[^0-9]+/ig, "");
        }
    });
    $("#btnCalcular").on('click', function () {
        fnCalcular();
    });
    $("#btnCancelar").on('click', function () {
        fnLimpiar();
    });
});

function fnBuscar() {
    if (($("#txtNumero").val() == null || $("#txtNumero").val().trim() == ""))
        return false;

    if ($("#txtNumero").val().trim() != "0") {
        var param = { numero: $("#txtNumero").val() };

        var URL = "Empleado.aspx/Buscar";

        EnvioInformacion(param, URL, fnRespuestaBusq);
    }
}
function fnRespuestaBusq(objResponse) {

    if (!objResponse.Error) {
        if (objResponse.MjeAlerta != undefined) {
            alert(objResponse.MjeAlerta);
        }
        else {
            $('#txtNombre').val(objResponse.Empleado[0].Nombre);
            $('#txtRol').val(objResponse.Empleado[0].Rol);
            $('#txtTipo').val(objResponse.Empleado[0].Tipo);

            $("#txtNumero").attr("disabled", true);
            $("#btnBuscar").attr("disabled", true);
            $("#btnCalcular").attr("disabled", false);
            $("#btnCancelar").attr("disabled", false);
            $("#ddlAnio").attr("disabled", false);
            $("#ddlMes").attr("disabled", false);
        }
    }
}

function fnCalcular() {
    if (($("#txtNumero").val() == null || $("#txtNumero").val().trim() == ""))
        return false;

    if ($("#txtNumero").val().trim() != "0") {

        var param = { numero: $("#txtNumero").val(), anio: $("#ddlAnio").val(), mes: $("#ddlMes").val() };

        var URL = "Empleado.aspx/CalculoSalario";

        EnvioInformacion(param, URL, fnRespuestaCalculo);
    }
}

function fnRespuestaCalculo(objResponse) {
    if (!objResponse.Error) {
        if (objResponse.MjeAlerta != undefined) {
            alert(objResponse.MjeAlerta);
        }
        else {
            var _scriptHTML ="<br />";
            _scriptHTML += "<div style='width:80%'><div><h4 class='form-signin-heading'>Resumen</h4>  </div>";
            _scriptHTML += "<table id='table' class='table table-hover' width='100%'>";
            _scriptHTML += "<thead>";
            _scriptHTML += "<tr>";
            _scriptHTML += "<th style='width: 25%;'>Salario bruto</th>";
            _scriptHTML += "<th style='width: 25%;'>ISR</th>";
            _scriptHTML += "<th style='width: 25%;'>Salario neto</th>";
            _scriptHTML += "<th style='width: 25%;'>Vales</th>";
            _scriptHTML += "</tr>";
            _scriptHTML += "</thead>";

            for (var j = 0; j < objResponse.Calculo.length; j++) {
                _scriptHTML += "<tr>";
                _scriptHTML += "<td style='text-align: left;'> $" + objResponse.Calculo[j].SalarioBruto + "</td>";
                _scriptHTML += "<td style='text-align: left;'> $" + objResponse.Calculo[j].ISR + "</td>";
                _scriptHTML += "<td style='text-align: left;'> $" + objResponse.Calculo[j].SalarioNeto + "</td>";
                _scriptHTML += "<td style='text-align: left;'> $" + objResponse.Calculo[j].Vales + "</td>";
                _scriptHTML += "</tr>";
            }
            _scriptHTML += "</table></div>";

            $("#btnCalcular").attr("disabled", true);
            $("#divCalculo").css("display", "block");
            $("#divCalculo").html(_scriptHTML);
            $("#ddlAnio").attr("disabled", true);
            $("#ddlMes").attr("disabled", true);
        }
    }
}

function fnLimpiar() {
    $('#txtNumero').val("");
    $('#txtNombre').val("");
    $('#txtRol').val("");
    $('#txtTipo').val("");
    $("#txtNumero").attr("disabled", false);
    $("#btnBuscar").attr("disabled", false);
    $("#btnCalcular").attr("disabled", true);
    $("#btnCancelar").attr("disabled", true);
    $("#ddlAnio").attr("disabled", true);
    $("#ddlMes").attr("disabled", true);
    $("#ddlMes").val(10);
    $('#txtNumero').focus();
    $("#divCalculo").css("display", "none");
    $("#divCalculo").html("");
}