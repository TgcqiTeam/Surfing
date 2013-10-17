using System;
namespace Matisoft.Model
{
	/// <summary>
	/// FollowTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FollowTable
	{
		public FollowTable()
		{}
		#region Model
		private int _id;
		private int _customerid;
		private string _fansemail;
		private DateTime _timedate;
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
		public int CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FansEmail
		{
			set{ _fansemail=value;}
			get{return _fansemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeDate
		{
			set{ _timedate=value;}
			get{return _timedate;}
		}
		#endregion Model

	}
}

