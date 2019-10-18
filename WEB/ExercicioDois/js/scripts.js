$(document).ready(
    function () {

        $('button[name="btnConverter"]').click(function () {

            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json"

            $.getJSON(url, function (data) {

                var valorDolar = data.value[0].cotacaoVenda;
                /*  Obter um valor */
                var valoreal = $('input[name="valorReal"]').val()
                    .replace(".", "")
                    .replace(".", "")
                    .replace(",", ".");


                var convercao = (valorReal / valorDolar)
                    .toLocaleString('en-US', { minimumFractionDigits: 2, currency: 'USD' });

                /* Inserir um valor*/
                $('input[name="valorDolar"]').val(convercao);
        });
        //$('input[name="valorReal"]').mask('000.000,00');
        $('input[name="valorReal"]').maskMoney({ showSymbol: true, symbol: "R$", decimal: ",", thousands: ".", defaultZero: false, allowZero: true, allowNegative: true });
    }
);