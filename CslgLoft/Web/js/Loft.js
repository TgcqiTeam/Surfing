$(function(){
	
	initEvents();
});

function initEvents()
{

	$("#mostbigimage").hover(function() {
		$(this).find("#image_i2").show();
	}, function() {
		$(this).find("#image_i2").hide();
	});
	$(".image").hover(function() {
		$(this).find("#image_i1").show();
	}, function() {
		$(this).find("#image_i1").hide();
	});
	$(".image_c").hover(function() {
		$(this).css("color","rgb(1,1,1)");
	}, function() {
		$(this).css("color","rgb(100,100,100)");
	});

	$(".divbuttom_1").hover(function() {

		$(this).css("color","rgb(204,204,204)");
	}, function() {
		$(this).css("color","rgb(100,100,100)");
	});
	$(".spanclick").hover(function() {

		$(this).css("color","rgb(204,204,204)");
	}, function() {
		$(this).css("color","rgb(100,100,100)");
	});
	$("#shuaxing").hover(function() {

		$(this).css("background-position","-224px -656px");
	}, function() {
		$(this).css("background-position","-174px -656px");
	});
	$("#dengluimage1").hover(function() {

		$(this).css("background-position","-201px -504px");
	}, function() {
		$(this).css("background-position","-1px -504px");
	});

	$("#dengluimage2").hover(function() {

		$(this).css("background-position","-201px -559px");
	}, function() {
		$(this).css("background-position","-1px -559px");
	});

	$("#dengluimage3").hover(function() {

		$(this).css("background-position","-201px -614px");
	}, function() {
		$(this).css("background-position","-1px -614px");
	});
	$(".bl").hover(function() {

		$(this).css("background-position","0 -1137px");
	}, function() {
		$(this).css("background-position","0 -1084px");
	});
	
	$(".cc").hover(function() {
		
		$(this).css("background-color","#444444");
	}, function() {
		$(this).css("background-color","#000000");
	});
	$("#btn12").click(function(){

	$("#divfirst").hide();
	$("#jieshao").show();

	});
	$("#span1").click(function(){
		
	$("#divfirst").css("background","url('css/images/4566087072217127787.jpg')")

	});
	$("#span2").click(function(){
	
	$("#divfirst").css("background","url('css/images/644014746731105760.jpg')")

	});
	$("#Login_a").click(function(){

	$("#divfirst").show();
	$("#jieshao").hide();

	});
	$(".btn").hover(function() {
		if($(this).attr("ba")!=2)
		{
			$(this).css("background-color","#111111");
		}
		else
		{
			$(this).css("background-color","#eeeeee");
		}
	
	
	}, function() {
			if($(this).attr("ba")!=2)
		{
			$(this).css("background-color","#000000");
		}
		else
		{
			$(this).css("background-color","#cccccc");
		}
	});
	$("#divUp").hover(function() {
		
		$(this).css("background-position","-49px -933px");
	}, function() {
		$(this).css("background-position","1px   -933px");
	});
	$(window).scroll(function(){
		ScollPosition();
		if(tt<600)
		{
			
			$("#divUp").hide();
		}
		else
		{
			
			$("#divUp").show();
		}
	});
	$("#divUp").click(function() {
		document.body.scrollTop=0;
	});
	$(".btn").click(function() {
		
		if($(this).attr("ba")==0&$(this).attr("op")==0)
		{
			$("#sanjiao").show();
			$("#zhuce_left_2").hide();
			$("#zhuce_left").show();
			$("#sanjiao").css("left","460px");
			$("#divbuttom").show();
			$("#logoT").css("top","20px");
			$("#btndiv").css("top","238px");
			$("#btn10").attr("op","1");
			$("#btn11").attr("op","0");
			
		}
		else{
			if($(this).attr("ba")==0&$(this).attr("op")==1)
		{	
			
			$("#sanjiao").hide();
			$("#divbuttom").hide();
			$("#logoT").css("top","120px");
			$("#btndiv").css("top","338px");
			$(this).attr("op","0");
			
		}
		}
		if($(this).attr("ba")==1&$(this).attr("op")==0)
		{	
			$("#zhuce_left_2").show();
			$("#zhuce_left").hide();
			$("#sanjiao").show();
			$("#sanjiao").css("left","660px");
			$("#divbuttom").show();
			$("#logoT").css("top","20px");
			$("#btndiv").css("top","238px");

			$("#btn10").attr("op","0");
			$("#btn11").attr("op","1");
			
		}
		else{
			if($(this).attr("ba")==1&$(this).attr("op")==1)
		{
			
			$("#sanjiao").hide();
			$("#divbuttom").hide();
			$("#logoT").css("top","120px");
			$("#btndiv").css("top","338px");
			$(this).attr("op","0");
			
		}
		}

	});
}
var tt;
function ScollPosition()
{
	var t,l,w,h;
	if(document.documentElement&&document.documentElement.scrollTop)
	{
		t=document.documentElement.scrollTop;
		h=document.documentElement.scrollHeight;
	}
	else if(document.body)
	{
		t=document.body.scrollTop;
		h=document.body.scrollHeight;
	}
	tt=t;
}