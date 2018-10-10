$(document).ready(function(){
$('.titulo').click(function(){
	var conteudo = $(this).parent().find('.conteudo');
	if(!conteudo.hasClass('show')){
		$('.conteudo').css('overflow', '200px');
		$('.caixa_som').find('.show').slideUp('fast', function(){
			$(this).addClass('hide').removeClass('show');
		});

		conteudo.slideDown('fast', function(){
			$(this).addClass('show').removeClass('hide');
		});
	}
});
    

});