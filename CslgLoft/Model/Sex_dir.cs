using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Sex_dir:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sex_dir
	{
		public Sex_dir()
		{}
		#region Model
		private int _customersex;
		private string _customersex_exp;
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
		public string CustomerSex_exp
		{
			set{ _customersex_exp=value;}
			get{return _customersex_exp;}
		}
		#endregion Model

	}
}

