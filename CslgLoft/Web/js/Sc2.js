$(function(){
	
	initEvents();
	menu();
});
function initEvents()
{
	$("#select_area").click(function(){
		if($(this).attr("op")=="cl")
		{
			$(".selected").show();
			$(this).attr("op","op");
		}
		else
		{
			$(".selected").hide();
			$(this).attr("op","cl");
		}
	});




}

var height;
function xunhuan()
{
	height=$(this).css("height");
	alert(height);
	 setInterval(function(){
	 	
	}, 1000);
}
function menu()
{
	$("#menu_1").hover(function() {

		$(this).css("background-position","0% -68px");
	}, function() {
		$(this).css("background-position","0% 0%");
	});
	$("#menu_2").hover(function() {

		$(this).css("background-position","14.2% -68px");
		$("#Dropdown1").slideDown();
		    
	}, function() {
		$(this).css("background-position","14.2% 0%");
		$("#Dropdown1").slideUp();
	});
	$("#menu_3").hover(function() {

		$(this).css("background-position","28.5% -68px");
		$("#Dropdown2").slideDown();
	}, function() {
		$(this).css("background-position","28.5% 0%");
		$("#Dropdown2").slideUp();
	});
	$("#menu_4").hover(function() {

		$(this).css("background-position","42.9% -68px");
		$("#Dropdown3").slideDown();
	}, function() {
		$(this).css("background-position","42.9% 0%");
		$("#Dropdown3").slideUp();
	});
	$("#menu_5").hover(function() {

		$(this).css("background-position","57.2% -68px");
		$("#Dropdown4").slideDown();
	}, function() {
		$(this).css("background-position","57.2% 0%");
		$("#Dropdown4").slideUp();
	});
	$("#menu_6").hover(function() {

		$(this).css("background-position","71.4% -68px");
	}, function() {
		$(this).css("background-position","71.4% 0%");
	});
	$("#menu_7").hover(function() {

		$(this).css("background-position","85.6% -68px");
		$("#Dropdown5").slideDown();
	}, function() {
		$(this).css("background-position","85.6% 0%");
		$("#Dropdown5").slideUp();
	});
	$("#menu_8").hover(function() {

		$(this).css("background-position","100% -68px");
	}, function() {
		$(this).css("background-position","100% 0%");
	});
	$(".mask_li").hover(function() {
		$(".mask_li").css("background-position","0% 0%");
		$(this).css("background-position","0% 100%");
	}, function() {
		$(this).css("background-position","0% 0%");
	});
	$("#mask_a").hover(function() {
		$(this).css("color","rgb(255, 255, 255)");
	}, function() {
		$(this).css("color","rgb(242, 200, 252)");
	});
	$("#li1").click(function(){
		$("#mask").css("background","url('css/images/21.jpg')");
		$("#mask_a").text("疯狂开学季：三族免费 头像奖励！");
	});
	$("#li2").click(function(){
		$("#mask").css("background","url('css/images/20.jpg')");
		$("#mask_a").text("网爆ZOO经理LoveTT做假账 真实性待考");
	});
	$("#li3").click(function(){
		$("#mask").css("background","url('css/images/19.jpg')");
		$("#mask_a").text("包哥下课！iloveoov接替执掌SKT1教鞭");
	});
	$("#li4").click(function(){
		$("#mask").css("background","url('css/images/18.jpg')");
		$("#mask_a").text(" WCS美洲区：MacSed晋级线下16强");
	});
	$("#li5").click(function(){
		$("#mask").css("background","url('css/images/14.jpg')");
		$("#mask_a").text("平衡性测试图修改：隐刀提速移除");
	});
	$(".r_a").hover(function() {
		$(".r_a").css("background","none");
		$(this).css("background","url('css/images/right-menu-active.png')");
		$(this).css("background-position","0px 0px");
		$(this).css("height","28px");
		$(".r_content").css("display","none");
		$("#r_content"+$(this).attr("ff")).show();

	}, function() {
		
	});
	$(".fontstyle2").hover(function() {
		$(this).css("color","rgb(219, 146, 219)");
	}, function() {
		$(this).css("color","#3c1f42");
	});
	$(".fontstyle").hover(function() {
		$(this).css("color","#fff");
	}, function() {
		$(this).css("color","rgb(219, 146, 219)");
	});
	$(".fl").hover(function() {
		$(this).css("color","#fff");
	}, function() {
		$(this).css("color","rgb(219, 146, 219)");
	});
	var c;
	$(".title_a").hover(function() {
		 c=$(this).css("color");
		$(this).css("color","#fff");
	}, function() {
		$(this).css("color",c);
	});
	$(".a_font").hover(function() {
		 c=$(this).css("color");
		$(this).css("color","#fff");
	}, function() {
		$(this).css("color",c);
	});
	$(".n_me").hover(function() {
		$(this).css("background","url('css/images/right-menu-active.png')");
		$(this).css("background-position","0 0px");
		$(this).css("height","26px");
	}, function() {
		$(this).css("background","url('css/images/right-menu-li.png')");
		$(this).css("background-position","0 0px");
		$(this).css("height","22px");
	});
	$(".n_me").hover(function() {
		$(this).css("background","url('css/images/right-menu-active.png')");
		$(this).css("background-position","0 0px");
		$(this).css("height","26px");

	}, function() {
		$(this).css("background","url('css/images/right-menu-li.png')");
		$(this).css("background-position","0 0px");
		$(this).css("height","22px");
	});

}