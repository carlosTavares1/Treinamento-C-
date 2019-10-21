var doguinho = { nome: "Giomar",idade: 19,raca: srd,coloracao: caramelo };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nome"]').val(doguinho.nome);
        $('input[name="idade"]').val(doguinho.nome);
        $('input[name="raca"]').val(doguinho.nome);
        $('input[name="colocaracao"]').val(doguinho.nome);


        $('input[name="bntsalvar"]').click(function () {
            doguinho.nome = $('input[name="nomeusuario"]').val();
            doguinho.idade = $('input[name="nomeusuario"]').val();
            doguinho.raca = $('input[name="nomeusuario"]').val();
            doguinho.coloracao = $('input[name="nomeusuario"]').val();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(doguinho.nome,);
        });

    }
);