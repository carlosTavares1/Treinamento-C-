$(document).ready(function () {
    $("#money").inputmask('currency', {
        "autoUnmask": true,
        radixPoint: ",",
        groupSeparator: ".",
        allowMinus: false,
        prefix: 'R$ ',
        digits: 2,
        digitsOptional: false,
        rightAlign: true,
        unmaskAsNumber: true
    });
function funcao() {
    var real = $('input[name="real"]').val();
    var resultado = real / 4.18;
    $('input[name="convertido"]').val(resultado);
}