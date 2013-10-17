using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Affire:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Affire
	{
		public Affire()
		{}
		#region Model
		private int _id;
		private string _customeremail;
		private DateTime _timedate;
		private int _operationid;
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
		public string CustomerEmail
		{
			set{ _customeremail=value;}
			get{return _customeremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeDate
		{
			set{ _timedate=value;}
			get{return _timedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperationID
		{
			set{ _operationid=value;}
			get{return _operationid;}
		}
		#endregion Model

	}
}

