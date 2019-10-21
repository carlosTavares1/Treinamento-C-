var bicicleta = {marca:"caloi",modelo:"c1230",valor:150,peso:20}
$(document).ready(
	function(){
		$('input[name="btnSalvar"]').click(function(){
			bicicleta.marca = $('input[name="marca"]').val();
			bicicleta.modelo = $('input[name="modelo"]').val();
			bicicleta.valor = $('input[name="valor"]').val();
			bicicleta.peso = $('input[name="peso"]').val();
		});	
		$('input[name="btnMostrar"]').click(function(){
			alert("Marca: "+bicicleta.marca+"\nModelo: "+bicicleta.modelo+"\nValor: "+bicicleta.valor+"\nPeso: "+bicicleta.peso);
		});
	}
);