$(function()
{
	initEvents();
});

function initEvents()
{
	$("#TopNavi_yingyong").hover(function() {

		$(TopNavi_yingyong_dropdown).css("display","block");
	}, function() {
		$(TopNavi_yingyong_dropdown).css("display","none");
	});
	$(".TopNavi_yingyong_d").hover(function(){
		$(this).css("backgroundColor","#eee");
	},function(){
		$(this).css("backgroundColor","#ffffff");
	});
	$("#top_denglu").hover(function(){
		$(TopNavi_yingyong_d_denglu).css("display","block");
	},function(){
		$(TopNavi_yingyong_d_denglu).css("display","none");
	});
	$("#forgetpwd").hover(function(){
		$(forgetpwd).css("color","#ff0000");
	},function(){
		$(forgetpwd).css("color","#000");
	});
	$("#youxiang").keypress( function(event) {

    if($("#youxiang").val()=="网易通行证/登录邮箱")
    {
    	$("#youxiang").val("");
    }
    if($("#youxiang").val().length==1&event.keyCode==8)
    {
    	$("#youxiang").val("网易通行证/登录邮箱 ");
    }
  });
	$("#pwd").keypress( function(event) {

    if($("#pwd").val()=="请输入密码")
    {
    	$("#pwd").val("");
    }
    if($("#pwd").val().length==1&event.keyCode==8)
    {
    	$("#pwd").val("请输入密码 ");
    }
  });
	

}

function imageMove(flag)
	{
		var ele;
		var left;
		var right;
		ele=document.getElementById("image_show");
		left=document.getElementById("left");
		right=document.getElementById("right");
		if(flag==0){
		left.style.backgroundColor="#454948";
		left.innerHTML="<";
		
		right.style.backgroundColor="#454948";
		right.innerHTML=">";
		}
		else
		{
		left.style.backgroundColor="transparent";
		left.innerHTML="";
		
		right.style.backgroundColor="transparent";
		right.innerHTML="";
		}
	}
var a_index=1;
function imageChangeClick(index)
{		
		var i=0;
		var ele;
		var left;
		var right;
		var div;
		div=document.getElementById("image_show");
		left=document.getElementById("left");
		right=document.getElementById("right");
		for(i=1;i<=6;i++)
		{
			document.getElementById("circlediv"+i).style.backgroundPosition=-25 + "px " + 0 + "px";
		}
		if (index==0) 
			{
				
			if(a_index==1)
			{
				a_index=6;
				ele=document.getElementById("circlediv6");
				ele.style.backgroundPosition = 0 + "px " + 0 + "px";
			}
			else
			{
				a_index--;
				ele=document.getElementById("circlediv"+a_index);
				ele.style.backgroundPosition = 0 + "px " + 0 + "px";
			}

			if(a_index==1)
			{

			div.style.backgroundImage="url(css/images/2013091208453975c80.jpg)";
			txt.innerHTML="052D与052C战舰垂发系统对比图曝光";
			}
			if(a_index==2)
			{
			div.style.backgroundImage="url(css/images/20130912140336986f2.jpg)";
				txt.innerHTML="F-35A和F-35C战机同时进行加油作业";
			}
			if(a_index==3)
			{
			div.style.backgroundImage="url(css/images/2013091211271571525.jpg)";
				txt.innerHTML="叙反对派军工厂 10岁童工造炮弹";
			}
			if(a_index==4)
			{
			div.style.backgroundImage="url(css/images/201309121111512857e.jpg)";
				txt.innerHTML="潜水员寻找唯一存世飞虎队战机";
			}
			if(a_index==5)
			{
			div.style.backgroundImage="url(css/images/2013091209335665f05.jpg)";
				txt.innerHTML="解放军红旗16导弹群在高原布阵";
			}
			if(a_index==6)
			{

				div.style.backgroundImage="url(css/images/20130912092454e2178.jpg)";
				txt.innerHTML="全国特警大比武：大胆上演飞车绝技";
			}
			}
			else
			{
				if(a_index==6)
			{
				a_index=1;
				ele=document.getElementById("circlediv6");
				ele.style.backgroundPosition = 0 + "px " + 0 + "px";
			}
			else
			{
				a_index++;
				ele=document.getElementById("circlediv"+a_index);
				ele.style.backgroundPosition = 0 + "px " + 0 + "px";
			}

			if(a_index==1)
			{

			div.style.backgroundImage="url(css/images/2013091208453975c80.jpg)";
			txt.innerHTML="052D与052C战舰垂发系统对比图曝光";
			}
			if(a_index==2)
			{
			div.style.backgroundImage="url(css/images/20130912140336986f2.jpg)";
				txt.innerHTML="F-35A和F-35C战机同时进行加油作业";
			}
			if(a_index==3)
			{
			div.style.backgroundImage="url(css/images/2013091211271571525.jpg)";
				txt.innerHTML="叙反对派军工厂 10岁童工造炮弹";
			}
			if(a_index==4)
			{
			div.style.backgroundImage="url(css/images/201309121111512857e.jpg)";
				txt.innerHTML="潜水员寻找唯一存世飞虎队战机";
			}
			if(a_index==5)
			{
			div.style.backgroundImage="url(css/images/2013091209335665f05.jpg)";
				txt.innerHTML="解放军红旗16导弹群在高原布阵";
			}
			if(a_index==6)
			{

				div.style.backgroundImage="url(css/images/20130912092454e2178.jpg)";
				txt.innerHTML="全国特警大比武：大胆上演飞车绝技";
			}
			}
	}

function circleChange(index,flag)
	{
		for(i=1;i<=6;i++)
		{
			document.getElementById("circlediv"+i).style.backgroundPosition=-25 + "px " + 0 + "px";
		}
		var ele;
		var div;
		var txt;
		div=document.getElementById("image_show");
		ele=document.getElementById("circlediv"+index);
		txt=document.getElementById("div_title");
	
		if(flag==0)
		{
			ele.style.backgroundPosition = 0 + "px " + 0 + "px";
			if(index==1)
			{
				
			div.style.backgroundImage="url(css/images/2013091208453975c80.jpg)";
			txt.innerHTML="052D与052C战舰垂发系统对比图曝光";
			}
			if(index==2)
			{
			div.style.backgroundImage="url(css/images/20130912140336986f2.jpg)";
				txt.innerHTML="F-35A和F-35C战机同时进行加油作业";
			}
			if(index==3)
			{
			div.style.backgroundImage="url(css/images/2013091211271571525.jpg)";
				txt.innerHTML="叙反对派军工厂 10岁童工造炮弹";
			}
			if(index==4)
			{
			div.style.backgroundImage="url(css/images/201309121111512857e.jpg)";
				txt.innerHTML="潜水员寻找唯一存世飞虎队战机";
			}
			if(index==5)
			{
			div.style.backgroundImage="url(css/images/2013091209335665f05.jpg)";
				txt.innerHTML="解放军红旗16导弹群在高原布阵";
			}
			if(index==6)
			{
			div.style.backgroundImage="url(css/images/20130912092454e2178.jpg)";
				txt.innerHTML="全国特警大比武：大胆上演飞车绝技";
			}
			a_index=index;
		}
		else
		{
			ele.style.backgroundPosition= -25 + "px " + 0 + "px";
		}
	}
function test(flag)
	{
		
		var ele;
		ele=document.getElementById("top_denglu");
		
		if(flag==1){
		ele.style.backgroundColor="#D61313";
		}
		else{	ele.style.backgroundColor="BB0707";}
		
	}
	function colorchange()
{
	setInterval("light();",500);
}

var index=1;
function light()
{
	alert(index);
	var ele=document.getElementById("test"+index);
	ele.style.backgroundColor="#ff0000";
}
	function backgroundchange(flag)
	{
		
		
		ele1=document.getElementById("div");
	    ele2=document.getElementById("div2");
		ele3=document.getElementById("div3");
		ele4=document.getElementById("div4");
		ele5=document.getElementById("TopNavi_yingyong");
		if(flag==1){
		ele1.style.backgroundColor="#181818";
		}
		if(flag==2){
		ele1.style.backgroundColor="#333333";
		}
		if(flag==3){
		ele2.style.backgroundColor="#181818";
		}
		if(flag==4){
		ele2.style.backgroundColor="#333333";
		}
		if(flag==5){
		ele3.style.backgroundColor="#181818";
		}
		if(flag==6){
		ele3.style.backgroundColor="#333333";
		}
		if(flag==7){
		ele4.style.backgroundColor="#181818";
		}
		if(flag==8){
		ele4.style.backgroundColor="#333333";
		}
		if(flag==9){
		ele5.style.backgroundColor="#181818";
		}
		if(flag==10){
		ele5.style.backgroundColor="#333333";
		}

		

	}