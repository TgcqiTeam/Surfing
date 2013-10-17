$(function()
{
	initEvents();
});


function initEvents()
{
	$("#divsearch_right").click(function() {
		$(this).css("background-position","0% 100%");

	});
	$("#divsearch_right").blur(function() {
		$(this).css("background-position","0% 0%");

	});
}