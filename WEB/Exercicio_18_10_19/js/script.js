var doguinho = { nome: "Giomar",idade: 19,raca: "srd",coloracao: "caramelo", };

$(document).ready(
    function () {

        $('input[name="btnSalvar"]').click(function () {
            doguinho.nome = $('input[name="nome"]').val();
            doguinho.idade = $('input[name="idade"]').val();
            doguinho.raca = $('input[name="raca"]').val();
            doguinho.coloracao = $('input[name="coloracao"]').val();
        });

        $('input[name="btnMostrar"]').click(function () {
            alert(doguinho.nome + "\n" + doguinho.idade + "\n" + doguinho.raca + "\n" + doguinho.coloracao);
        });

    }
);