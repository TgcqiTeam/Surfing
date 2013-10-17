$(function(){
	
	initEvents();
});

function initEvents()
{
	$("#image").hover(function() {
		$(this).css("background","url('css/images/4_1.jpg')");
	}, function() {
		$(this).css("background","url('css/images/4.jpg')");
	});
	$("#image").mousemove(function(e) {
		var pointx=-(e.pageX-$(this).offset().left);
		var pointy=-(e.pageY-$(this).offset().top);
		$(this).css("background-position",pointx+"px"+" "+pointy+"px");
		
	});
}