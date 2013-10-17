<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Matisoft.Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta content="text/html; charset=utf-8" http-equiv="Content-Type">	
		<link rel="stylesheet" type="text/css" href="css/Loft.css"></link>
		<script type="text/javascript" src="js/jQuery.js"></script>
		<script type="text/javascript" src="js/Loft.js"></script>
	</head>
	<body>
    <form id="form1" runat="server">
		<div id="divfirst">
			<div id="logoT">
				<div id="lg"></div>
				<div id="lg2">快速、漂亮、有趣的记录方式</div>
			</div>
			<div id="btndiv">
				<div class="btn" ba="0" op="0" id="btn10">登录</div> 
				<div class="btn" ba="1"  op="0" id="btn11">注册</div> 
				<div class="btn" id="btn12" ba="2" >浏览></div> 
			</div>
			<div id="divmostbuttom">
				<div class="divbuttom_1">网易公司版权所有</div>
				<div class="divbuttom_1">?1997-2013</div>
				<div class="divbuttom_1" id="divbuttom_2">粤ICP备20090191号</div>
				<div class="divbuttom_1" id="divbuttom_5">客户端</div>
				<div class="divbuttom_1" id="divbuttom_4">模板</div>
				<div class="divbuttom_1" id="divbuttom_4">关于</div>
				<div class="divbuttom_1" id="divbuttom_3">商务合作</div>
				<div class="divbuttom_1" id="divbuttom_3">官方博客</div>
				<div class="divbuttom_1" id="divbuttom_3">官方微博</div>
				<div id="divmostbuttom_right">
					<div class="spanclick" id="span1"></div>
					<div class="spanclick" id="span2"></div>
					<div class="spanclick" id="name">邪恶丘比特</div>
					<div class="spanclick" id="name">背景作品来自：</div>
				</div>
			</div>
			<div id="sanjiao"></div>
			<div id="divbuttom">
				<div id="zhuce">
						<div id="zhuce_left_2">
							<div class="zhuce_title">使用常用邮箱注册</div>
						<div class="divTxt">
							<input type="text" class="Txts"  placeholder="常用邮箱"></input>
						</div>
						<div class="divTxt">
							<input type="text" class="Txts"  placeholder="设置密码"></input>
						</div>
						<div class="divTxt">
							<input type="text" class="Txts"  placeholder="验证密码"></input>
							<div id="shuaxing"></div>
						</div>
						<div id="kaitong" class="btnLogin2 bl">
						开通我的LOFTER
						</div>
					
						</div>
					<div id="zhuce_left">
						<div class="zhuce_title">使用网易通行证/邮箱登录</div>
						<div id="Div1" class="divTxt" runat="server">
							  <asp:textbox  runat="server"  class="Txts" id="Customertx"   placeholder="邮箱" > </asp:TextBox>
						</div>
						<div id="Div2" class="divTxt" runat="server">
                      
                            <asp:textbox  runat="server"  class="Txts" id="Passwordtx"   placeholder="密码" > </asp:TextBox>
                       
                            <input type="hidden" id="bz" runat="server" />
						</div>
                       
                         <asp:ScriptManager ID="ScriptManager1" runat="server">
                         </asp:ScriptManager>
                         <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                              <ContentTemplate>
                            <div runat="server" id="Login_dl" class="btnLogin2 bl">
					        	登录
						    </div>
                        </ContentTemplate>
                         </asp:UpdatePanel>
                      
						
						<div id="forgetpwd">
							<input type="checkbox" id="cb"/>
							<a id="fpwd" href="#">记住密码</a>
							<a id="rpwd" href="#">忘记密码</a>
						</div>
					</div>
					<div id="zhuce_right">
						<div id="divspan"></div>
						<div id="spanhuo">或</div>
						<div class="zhuce_title">使用社交账号登录</div>
						<div class="dengluimage" id="dengluimage1">使用新浪微博登录</div>
						<div class="dengluimage" id="dengluimage2">使用腾讯QQ登录</div>
						<div class="dengluimage" id="dengluimage3">使用人人账号登录</div>
					</div>
				</div>
			</div>
			

		</div>
		<div id="jieshao">
		<div id="head">
			<div id="divUp"></div>
			<div id="Login">
				已有账号？
				<a href="#" id="Login_a">直接登录</a>
			</div>
			<div class="h2" id="h2_ch"> 
				<span class="h2" id="h2_e">LOFTER,</span>
				快速、漂亮、有趣的记录方式
			</div>
			<div id="h3">
				数百万热爱记录和分享的人，每天逾10万篇日志，用绘画、文字、拍照、音乐等方式，轻松记录所爱的一切
			</div>
			<div id="btnLogin" class="bl">
				10秒加入，立即体验
			</div>
		</div>
		<div id="fast">
			<div id="fast_1">快速
			</div>
			<div id="fast_2">轻松便捷的记录,随时随地的体验
			</div>
			<div id="fast_3">
				<div class="cc" id="btn1">iPhone</div>
				<div  class="cc" id="btn1">Android</div>
				<div  class="cc" id="btn1">iPad</div>
			</div>
			<div id="img">
			</div>
		</div>
		<div id="piaoliang">
			<div id="fast_1">漂亮
			</div>
			<div id="fast_2">你的每一次记录，都值得精美演示
			</div>
			<div id="bg">

			</div>
			<div id="spanbg"></div>
		</div>
		<div id="youqu">
			<div id="fast_1">有趣
			</div>
			<div id="fast_2">关注有爱的人，分享精彩的事
			</div>
			<div id="d">
				<div id="d_left">
					<div class="image">
						<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize.ph.126.net.jpg">
					    </img>
						<div id="image_b">
							<img src="css/images/1.jpg" class="image_icon"></img>
							<div class="image_c">大悲宇宙-林血
							</div>
						</div>
					</div>
					<div class="image">
						<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize2.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/2.jpg"></img>	
							<div class="image_c"> 谷住 - chihato 
							</div>

						</div>
					</div>
					<div class="image">
						<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize3.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/3.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
				</div>
				<div id="divcenter">
					<div id="mostbigimage">
						<div id="image_i2"></div>
						<div id="image_most"></div>
						<div id="image_b">
							<img class="image_icon" src="css/images/4.jpg"></img>
							大悲宇宙-林血
							</div>
					</div>
					<div class="image">
						<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize4.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/5.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/6597932883285231538.gif"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/6.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize11.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/7.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
						<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize2.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/8.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize12.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/1.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i"  src="css/images/imgsize13.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/2.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/3.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize13.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/4.jpg"></img>	
							<div class="image_c">Hoper
							</div>
						</div>
					</div>
				</div>
				<div id="d_left">
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize4.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/5.jpg"></img>	
							<div class="image_c">大悲宇宙-林血
							</div>

						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/6.jpg"></img>	
							<div class="image_c"> 谷住 - chihato 
							</div>

						</div>
					</div>
					<div class="image">
							<div id="image_i1"></div>
						<img class="image_i" src="css/images/imgsize.ph.126.net.jpg"></img>
						<div id="image_b">
							<img class="image_icon" src="css/images/6.jpg"></img>	
							<div class="image_c"> 谷住 - chihato 
							</div>

						</div>
					</div>
				
				
				
			</div> 
		</div>
		<div id="buttom">
			<div id="buttom_blank">
			</div>
			<div id="fast_2">加入我们，记录和分享你的所爱
			</div>
			<div id="btnLogin1" class="bl">
				10秒加入，立即体验
			</div>
			<div id="buttom_blank">
			</div>
			<div id="buttom_blank">
			</div>
			<div id="about">
				<div class="buttom_guan" id="buttom_guan1">关于LOFTER
				</div>
				<div class="buttom_guan" id="buttom_guan2">联系我们
				</div>
				<div class="buttom_guan" id="buttom_guan2">招贤纳士
				</div>
				<div class="buttom_guan" id="buttom_guan2">移动客户端
				</div>
				<div class="buttom_guan" id="buttom_guan2">风格模板
				</div>
				<div class="buttom_guan" id="buttom_guan3">官方博客
				</div>
				<div class="buttom_guan" id="buttom_guan4">粤ICP备20090191号
				</div>
				<div class="buttom_guan" id="buttom_guan4">1997-2013
				</div>
				<div class="buttom_guan" id="buttom_guan4">网易公司版权所有
				</div>
				
			</div>
		</div>
	</div>
       </form>
	</body>
</html>