using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Comment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Comment
	{
		public Comment()
		{}
		#region Model
		private int _id;
		private string _contents;
		private int _customerid;
		private int _commentstate;
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
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
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
		public int CommentState
		{
			set{ _commentstate=value;}
			get{return _commentstate;}
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

