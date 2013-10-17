$(function(){
	
	initEvents();
	xunhuan();
});
var time=1;
function xunhuan()
{
	 setInterval(function(){
	 	time=time%3;
		if(time==1)
		{
			$("#div_center_img").attr("src","css/images/prod_Surface2V2_hl.jpg");
			$("#div_title").text("Microsoft unveils Surface 2, Surface Pro 2 and new accessories");
			$("#div_neirong").text(" Pre-order will begin at 8 a.m. ET, Sept. 24. See webcast, slideshow, videos and more as Microsoft unveils the next generation of the Surface family.");
		}
		
		if(time==2)
		{
			$("#div_center_img").attr("src","css/images/feat_FashionWeek_hl.jpg");
			$("#div_title").text("Tech: The necessary accessory for New York Fashion Week 2013");
			$("#div_neirong").text("  See the video to find out how fashion designer Cesar Galindo employed Bing, Windows Phone and Surface to realize his vision of “going virtual” in both the presentation and production of an installation at Lincoln Center.");
		}
		if(time==0)
		{
			$("#div_center_img").attr("src","css/images/theme_surfaceBing_hl.jpg");
			$("#div_title").text("Tech: The necessary accessory for New York Fashion Week 2013");
			$("#div_neirong").text("  New design focuses on simplicity, speed and visual appeal to give people a better search experience across all devices.");
		}
		time++;
	}, 10000);
}
function initEvents()
{
	$("#StoreLink").hover(function() {
		$(this).css("text-decoration","underline");
		$(this).css("color","rgb(34,34,34)");
	}, function() {
		$(this).css("text-decoration","none");
		$(this).css("color","rgb(0,0,200)");
	});
	$("#diva").hover(function() {
		$(this).css("text-decoration","underline");
		$(this).css("color","rgb(34,34,34)");
	}, function() {
		$(this).css("text-decoration","none");
		$(this).css("color","#3cb7f0");
	});
	$("#forwork_a").hover(function() {
		$(this).css("background-color","rgb(40,40,40)");
	}, function() {
		$(this).css("background-color","rgb(21,112,166)");
	});
	$(".imageshuo").hover(function() {
		$(this).find("#mengban").show();
		$(this).find("#shuoming").css("color","rgb(34,34,34)");
		$(this).find("#shuoming").css("text-decoration","underline");
	}, function() {
		$(this).find("#mengban").hide();
		$(this).find("#shuoming").css("color","#3cb7f0");
		$(this).find("#shuoming").css("text-decoration","none");
	});
	$(".footlast").hover(function() {
		$(this).css("color","rgb(34,34,34)");
		$(this).css("text-decoration","underline");
	}, function() {
		$(this).css("color","#3cb7f0");
		$(this).css("text-decoration","none");
	});
	$(".features_chanping").hover(function() {
		$(this).css("color","rgb(34,34,34)");
		$(this).css("text-decoration","underline");
	}, function() {
		$(this).css("color","#3cb7f0");
		$(this).css("text-decoration","none");
	});
	$(".h_li").hover(function() {
		$(this).css("color","rgb(34,34,34)");
		$(this).css("text-decoration","underline");
	}, function() {
		$(this).css("color","#3cb7f0");
		$(this).css("text-decoration","none");
	});
	$(".h_li2").hover(function() {
		$(this).css("color","rgb(34,34,34)");
		$(this).css("text-decoration","underline");
	}, function() {
		$(this).css("color","rgb(255,255,255)");
		$(this).css("text-decoration","none");
	});
	$(".div_buttom_li").hover(function() {
		
		$(this).css("text-decoration","underline");
	}, function() {
	
		$(this).css("text-decoration","none");
	});
		$(".DropDown").hover(function() {
		
		$(this).css("color","#3cb7f0");
		$(this).find("#img1").attr("src","css/images/2013-09-24T02-09-20.114Z.png");
	}, function() {
		$(this).css("color","rgb(34,34,34)");
		$(this).find("#img1").attr("src","css/images/2013-09-24T02-10-51.597Z.png");
	});
		$("#div_center_right").hover(function() {
		
		$(this).css("background-color","rgba(0, 0, 0, 0.3)");
		
	}, function() {
		$(this).css("background-color","rgba(0, 0, 0, 0.16)");
	
	});
		$(".DropDown").click(function() {
			var a=$(this).attr("fll");
			
			$(".selectedbox").css("display","none");
			if(	$(this).attr("op")=="cl")
			{
			
					if($("#selectedbox1").attr("fll")==a)
					{
						$("#selectedbox1").css("display","block");
					}
					if($("#selectedbox2").attr("fll")==a)
					{
						$("#selectedbox2").css("display","block");
					}
					if($("#selectedbox3").attr("fll")==a)
					{
						$("#selectedbox3").css("display","block");
					}
					if($("#selectedbox4").attr("fll")==a)
					{
						$("#selectedbox4").css("display","block");
					}
				$(".DropDown").each(function(){
					$(".DropDown").attr("op","cl");	
				});
				$(this).attr("op","op");
			}
			else
			{
				$(".selectedbox").each(function(){
					$(".selectedbox").css("display","none");
				});
				$(this).attr("op","cl");	
			}
		
		});
		$(".no1-3").click(function(){
			$(".no1-3").css("background-color","rgb(255,255,255)");
			$(this).css("background-color","rgb(50,50,150)");

			if($(this).attr("ff")==1)
			{
				$("#imageM").attr("src","css/images/Surface_PreorderBG_0923_1600x540_EN_UK.jpg");
			}
			if($(this).attr("ff")==2)
			{
				$("#imageM").attr("src","css/images/WPnokia1020_yellowBG_0729_1600x540_EN_US.jpg");
			}
			if($(this).attr("ff")==3)
			{
				$("#imageM").attr("src","css/images/Office365_HPIotaBG_0128_1600x540_EN_US.jpg");
			}
			if($(this).attr("ff")==4)
			{
				$("#imageM").attr("src","css/images/XboxOne_BlackBG_0729_1600x540_EN_US.jpg");
			}
		});


}
