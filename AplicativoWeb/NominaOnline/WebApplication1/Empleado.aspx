<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="WebApplication1.Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="Scripts/EnvioJson.js?1.0003"></script>
    <script src="Scripts/Empleado.js?1.0005"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div class="form-group">
                <h3 class="form-signin-heading" style="margin-top: 0px">Cálculo de nómina
                </h3>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Número de empleados</label>
                <div class="col-xs-12 col-sm-3">
                    <input type="text" id="txtNumero" class="form-control input-small" maxlength="20" tabindex="1" value="" autofocus="autofocus" />
                </div>
                <div class="col-sm-2">
                    <button class="btn btn-default btn-md" type="button" id="btnBuscar" tabindex="2">
                        <span class="glyphicon glyphicon-search"></span>&nbsp;Buscar</button>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Nombre</label>
                <div class="col-xs-12 col-sm-8">
                    <input type="text" id="txtNombre" class="form-control input-small" maxlength="200"
                        tabindex="0" disabled="disabled" />
                </div>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Rol</label>
                <div class="col-xs-12 col-sm-5">
                    <input type="text" id="txtRol" class="form-control input-small" maxlength="200"
                        tabindex="0" disabled="disabled" />
                </div>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Tipo</label>
                <div class="col-xs-12 col-sm-5">
                    <input type="text" id="txtTipo" class="form-control input-small" maxlength="200"
                        tabindex="0" disabled="disabled" />
                </div>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Año</label>
                <div class="col-xs-12 col-sm-5">
                    <select id="ddlAnio" class="form-control dropdow" disabled="disabled">
                        <option value="2020" disabled="disabled">2020</option>
                        <option value="2021" disabled="disabled">2021</option>
                        <option value="2022" selected="selected">2022</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <label for="Título" class="control-label col-xs-12 col-sm-2">
                    Mes</label>
                <div class="col-xs-12 col-sm-5">
                    <select id="ddlMes" class="form-control dropdow" disabled="disabled">
                        <option value="1">Enero</option>
                        <option value="2">Febrero</option>
                        <option value="3">Marzo</option>
                        <option value="4">Abril</option>
                        <option value="5">Mayo</option>
                        <option value="6">Junio</option>
                        <option value="7">Julio</option>
                        <option value="8">Agosto</option>
                        <option value="9">Septiembre</option>
                        <option value="10" selected="selected">Octubre</option>
                        <option value="11" disabled="disabled">Noviembre</option>
                        <option value="12" disabled="disabled">Diciembre</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="container" >
            <div class="form-group" style="display:none" id="divCalculo">                    
            </div>
        </div>
        <div class="container">
            <div class="form-group" style="height: 30px;">
                <div class="col-sm-2 col-lg-offset-2">
                    <button class="btn btn-default btn-md" type="button" id="btnCalcular" tabindex="4" disabled="disabled">
                        <span class="glyphicon glyphicon-check"></span>&nbsp;Calcular</button>
                </div>
                <div class="col-sm-2">
                    <button class="btn btn-default btn-md" type="button" id="btnCancelar" tabindex="5" disabled="disabled">
                        <span class="glyphicon glyphicon-remove"></span>&nbsp;Cancelar</button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
