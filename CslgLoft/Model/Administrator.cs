using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Administrator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Administrator
	{
		public Administrator()
		{}
		#region Model
		private int _id;
		private string _admin;
		private string _password;
		private string _adminiemail;
		private int _adminstate;
		private int _authorityid;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Admin
		{
			set{ _admin=value;}
			get{return _admin;}
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
		public string AdminiEmail
		{
			set{ _adminiemail=value;}
			get{return _adminiemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AdminState
		{
			set{ _adminstate=value;}
			get{return _adminstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuthorityID
		{
			set{ _authorityid=value;}
			get{return _authorityid;}
		}
		#endregion Model

	}
}

