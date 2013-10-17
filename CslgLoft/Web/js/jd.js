$(function()
{
	initEvents();
	xunhuan();
});
var width;
var time=0;
function xunhuan()
{
	 setInterval(function(){
	 	time=time%100;
		
			width=time*1.7;
			$(".div_lusetiao").css("width",width+"px");
			$(".time").text(100-time);
		time++;
	}, 1000);
}
function initEvents()
{
	$(".divyuan").click(function() {
		var ff=$(this).attr("ff");
		$(".divyuan").css("background-color","rgb(153, 153, 153)");
		$(this).css("background-color","rgb(204, 0, 0)");
		if(ff==1)
		{
			$("#hdpimg").attr("src","css/images/rBEHZ1DFgAoIAAAAAADUBSc-4t8AADNHgBFL6IAANQd235.gif");
		}
		if(ff==2)
		{
			$("#hdpimg").attr("src","css/images/rBEQYVGRpEYIAAAAAAHvprRHmZoAABGaQBhyWsAAe--832.jpg");
		}
		if(ff==3)
		{
			$("#hdpimg").attr("src","css/images/rBEQYFGdf2oIAAAAAADrRLX0-mQAABzOgGmV8oAAOtc392.jpg");
		}
		if(ff==4)
		{
			$("#hdpimg").attr("src","css/images/rBEQWVF3STEIAAAAAAEi9ro0iMAAAE01gB2HTQAASMO468.jpg");
		}
		
		
	
		
	});
	$(".itemtit").hover(function() {
		$(this).css("background-color","rgb(251, 245, 235)");
		$(this).find(".itemcontent").show();
	}, function() {
		$(this).css("background-color","#fff");
		$(this).find(".itemcontent").hide();
	});
	$(".xl_dd").hover(function() {
		$(this).css("background-color","#ccc");
		$(this).find("#xl_soan2").css("color","rgb(200,0,0)");
	}, function() {
		$(this).css("background-color","#fff");
		$(this).find("#xl_soan2").css("color","rgb(0, 94, 167)");
	});
	$(".div_c").hover(function() {
		$(this).css("background-color","rgb(150,42,44)");
	}, function() {
		$(this).css("background-color","rgb(220,50,44)");
	});
	$("#dmd").hover(function() {
		$(this).css("background-color","rgb(150,42,44)");
	}, function() {
		$(this).css("background-color","rgb(150,42,44)");
	});
	$(".xl_dd2").hover(function() {
		$(this).css("background-color","#ccc");
	}, function() {
		$(this).css("background-color","#fff");
	});
	$("#div11").hover(function() {
		$("#myd_xl").show();
	}, function() {
		$("#myd_xl").hide();
	});
	$("#searchFlag").hover(function() {
		$("#dmd_xl").show();
	}, function() {
		$("#dmd_xl").hide();
	});
	var ele;
	$("a").hover(function() {
		 ele=$(this).css("color");
		$(this).css("color","rgb(200,0,0)");
	}, function() {
		$(this).css("color",ele);
	});
	$("#pt").hover(function() {
		$(this).css("text-align","underline");
		$(this).css("color","#fff");
	}, function() {
		$(this).css("text-align","none");
	});
	$("#d1").hover(function() {
		$(this).css("background-color","#fff");
		$(this).css("border","1px solid #ccc");
		$(this).css("border-bottom","0px solid #ccc");
		$("#wzdh_xl").show();
	}, function() {
		$(this).css("background-color","rgb(248, 248, 248)");
		$(this).css("border","1px solid rgb(248, 248, 248)");
		$("#wzdh_xl").hide();
	});
	$("#d2").hover(function() {
		$(this).css("background-color","#fff");
		$(this).css("border","1px solid #ccc");
		$(this).css("border-bottom","0px solid #ccc");
		$("#khff_xl").show();
	}, function() {
		$(this).css("background-color","rgb(248, 248, 248)");
		$(this).css("border","1px solid rgb(248, 248, 248)");
		$("#khff_xl").hide();
	});
}