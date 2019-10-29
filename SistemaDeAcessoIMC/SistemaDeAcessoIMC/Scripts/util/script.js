$(document).ready(function () {
    $('input[name="btnConsultar"]').click(function () {
        var informacoes = $('form[name="formulario"]').serialize();

        var url = "http://localhost:54615/api/CalculoIMC?";
        $.getJSON(url + informacaoes, function (data) {
            alert(data);
        });
    });
});