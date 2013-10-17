$(function()
{
	initEvents();
});


function initEvents()
{
   $("#btngetmore").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
		
		$(this).css("text-decoration","none");
	});
    $(".btomtitle").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
		
		$(this).css("text-decoration","none");
	});
   $(".divtitle2").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
		
		$(this).css("text-decoration","none");
	});
	$("a").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
		
		$(this).css("text-decoration","none");
	});
	$(".divtitle").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
		
		$(this).css("text-decoration","none");
	});
	$("#topamai").hover(function() {
		$(this).find("#Dropdown").show();
		$(this).css("border-top","1px solid #ccc");
	}, function() {
		$(this).find("#Dropdown").hide();
		$(this).css("border-top","0px");
	});
	$(".DropSdiv").hover(function() {
		$(this).css("background-color","rgb(221, 229, 244)");
	}, function() {
		$(this).find("#Dropdown").hide();
		$(this).css("background-color","#fff");
	});
	$("#topabang").hover(function() {
		$(this).find("#Dropdown").show();
		$(this).css("border-top","1px solid #ccc");
	}, function() {
		$(this).find("#Dropdown").hide();
		$(this).css("border-top","0px");
	});
	$(".divmenu").hover(function() {
		$(this).find("#zcggdiv").show();
		$(this).css("background-color","#fff");
		$(this).css("border","1px solid #ccc");
	}, function() {
		$(this).find("#zcggdiv").hide();
		$(this).css("background-color","rgb(248, 248, 248)");
		$(this).css("border","1px solid transparent");
		$(this).css("border-bottom","1px solid #ccc");
	});
		$(".nonediv").hover(function() {
		$(this).css("text-decoration","underline");
	}, function() {
		$(this).css("text-decoration","1px solid transparent");
		$(this).css("text-decoration","none");

	});
		$(".divn").click(function() {
		var ff=$(this).attr("ff");
		$(".divn").css("background-color","#fff");
		$(this).css("background-color","rgb(171, 171, 171)");
		if(ff==1)
		{
			$("#hdpimg").attr("src","css/images/1380525106【0929】分享嘉宾计划banner.jpg");
		}
		if(ff==2)
		{
			$("#hdpimg").attr("src","css/images/1380252644全面解析.jpg");
		}
		if(ff==3)
		{
			$("#hdpimg").attr("src","css/images/1380166560澳洲海外仓 banner.jpg");
		}
		if(ff==4)
		{
			$("#hdpimg").attr("src","css/images/1380089296万圣节banner770x245.jpg");
		}
		if(ff==5)
		{
			$("#hdpimg").attr("src","css/images/1378868586化繁而简-0828.jpg");
		}

		
	
		
	});
	

}