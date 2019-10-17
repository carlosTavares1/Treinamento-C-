$(document).ready(function () {
    $("#real").mask('#.##0,00', { reverse: true });

function funcao() {
    var real = $('input[name="real"]').val();
    var resultado = real / 4.18;
    $('input[name="convertido"]').val(resultado);
}