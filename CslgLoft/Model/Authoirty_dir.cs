using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Authoirty_dir:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Authoirty_dir
	{
		public Authoirty_dir()
		{}
		#region Model
		private int _authorityid;
		private string _operation;
		/// <summary>
		/// 
		/// </summary>
		public int AuthorityID
		{
			set{ _authorityid=value;}
			get{return _authorityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operation
		{
			set{ _operation=value;}
			get{return _operation;}
		}
		#endregion Model

	}
}

