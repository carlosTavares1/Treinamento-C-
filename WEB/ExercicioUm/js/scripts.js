$(document).ready(
    function () {
        $('button[name="btnBoasVindas"]').click(function () {

        
        var nomeUsuario = $('input[name="nome"]').val();

            $('span[name="usuarioText"]').text(nomeUsuario);
        });
    }
);