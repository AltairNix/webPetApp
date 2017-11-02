<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMascota.aspx.cs" Inherits="webPetApp.Views.Mascota.RegistrarMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />

    <!--Import Google Icon Font-->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <!--Import materialize.css-->
    <link href="../../Content/materialize/css/materialize.min.css" rel="stylesheet" />
    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <!--Import jQuery before materialize.js-->
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="../../Content/materialize/js/materialize.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('select').material_select();
        });
    </script>

    <div class="row">
    <form class="col s12" runat="server">
        <div class="row">
            <div class="input-field col s12 m12">
                <input id="nom_mascota" class="validate" runat="server"/>
                <label for="nom_mascota">Nombre de la mascota</label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12 m6">
                <select id="id_tipo_masc" runat="server">
                    <option value="" disabled selected>Choose your option</option>
                </select>
                <label>Elija su mascota</label>
            </div>
            <div class="input-field col s12 m6">
                <input id="id_raza" class="validate" runat="server"/>
                <label for="id_raza">Fecha de nacimiento</label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12 m6">
                <input id="fec_nacimiento" class="validate" runat="server"/>
                <label for="fec_nacimiento">Fecha de nacimiento</label>
            </div>
            <div class="input-field col s12 m6">
                <input id="peso" class="validate" runat="server"/>
                <label for="peso">Peso</label>
            </div>
        </div>
    </form>
</div>
</body>
</html>
