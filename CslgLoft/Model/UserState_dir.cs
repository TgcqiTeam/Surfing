using System;
namespace Matisoft.Model
{
	/// <summary>
	/// UserState_dir:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserState_dir
	{
		public UserState_dir()
		{}
		#region Model
		private int _userstate;
		private string _state_name;
		/// <summary>
		/// 
		/// </summary>
		public int UserState
		{
			set{ _userstate=value;}
			get{return _userstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State_name
		{
			set{ _state_name=value;}
			get{return _state_name;}
		}
		#endregion Model

	}
}

