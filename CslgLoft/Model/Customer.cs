using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Customer
	{
		public Customer()
		{}
		#region Model
		private int _customerid;
		private string _password;
		private int _customerstate;
		private string _customername;
		private string _customerxiaoxue;
		private string _customerchuzhong;
		private string _customergaozhong;
		private string _customerdaxue;
		private string _customerxueli;
		private int _customersex;
		private string _customerbirthday;
		private string _customerworkplace;
		private string _customeremail;
		private string _customerqq;
		/// <summary>
		/// 
		/// </summary>
		public int CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CustomerState
		{
			set{ _customerstate=value;}
			get{return _customerstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerXiaoxue
		{
			set{ _customerxiaoxue=value;}
			get{return _customerxiaoxue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerChuzhong
		{
			set{ _customerchuzhong=value;}
			get{return _customerchuzhong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerGaozhong
		{
			set{ _customergaozhong=value;}
			get{return _customergaozhong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerDaxue
		{
			set{ _customerdaxue=value;}
			get{return _customerdaxue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerXueli
		{
			set{ _customerxueli=value;}
			get{return _customerxueli;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CustomerSex
		{
			set{ _customersex=value;}
			get{return _customersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerBirthday
		{
			set{ _customerbirthday=value;}
			get{return _customerbirthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerWorkplace
		{
			set{ _customerworkplace=value;}
			get{return _customerworkplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerEmail
		{
			set{ _customeremail=value;}
			get{return _customeremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerQQ
		{
			set{ _customerqq=value;}
			get{return _customerqq;}
		}
		#endregion Model

	}
}

