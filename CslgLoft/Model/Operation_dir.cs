using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Operation_dir:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Operation_dir
	{
		public Operation_dir()
		{}
		#region Model
		private int _operationid;
		private string _note;
		/// <summary>
		/// 
		/// </summary>
		public int OperationID
		{
			set{ _operationid=value;}
			get{return _operationid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		#endregion Model

	}
}

