$(function(){
	init();
	
});

function init(){
    changeimg();

}
function changeimg(){

	  $("#piaofu").hover(function(){
            $("#piaofu").css("background-position","-477px -25px");
	  },function(){
           $("#piaofu").css("background-position","-477px -0px");
	  });

	  $(".heada").hover(function(){
            $(this).find(".span1").css("color","rgb(10, 140, 210)");
            $(this).find(".span2").css("color","rgb(10, 140, 210)");
	  },function(){
           $(this).find(".span1").css("color","rgb(51, 51, 51)");
           $(this).find(".span2").css("color","rgb(51, 51, 51)");
	  });
}