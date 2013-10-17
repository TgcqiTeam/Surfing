using System;
namespace Matisoft.Model
{
	/// <summary>
	/// State_dir:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class State_dir
	{
		public State_dir()
		{}
		#region Model
		private int _state;
		private string _operation;
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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

