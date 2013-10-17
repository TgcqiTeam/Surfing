function colorchange()
{
	setInterval("light();",500);
}

var index=1;
var flag_l=0;
var finishornot=0;

function light()
{
	
	var ele=document.getElementById("test"+index);
	if(flag_l==0)
	{
	ele.style.backgroundColor="#ff0000";
	}
	else
	{
	ele.style.backgroundColor="#f1f1f1";
	}
	if(flag_l==0)
	{
		index++;	
		if(index==11)
		{
			flag_l=1;
		}
	}
	if(flag_l==1)
	{
		index--;
		if(index==0)
		{
		index=1;
		flag_l=0;
	    finishornot=0;
		}
	}

}