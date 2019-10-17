$(document).ready(
    function () {
        $('button[name="btnConverter"]').click(function () {

            var valorDolar = 4.16;
            var valorReal = $('input[name="valorReal"]').val().replace(".", "").replace(",", ".");
            var convercao = (valorReal / valorDolar).toFixed(2).toString().replace(/(\d)(\d{2})$/, "$1,$2");
            $('input[name="valorDolar"]').val(convercao);

        });
        $('input[name="valorReal"]').mask('000.000,00');
    }
);