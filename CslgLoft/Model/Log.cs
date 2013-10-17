using System;
namespace Matisoft.Model
{
	/// <summary>
	/// Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Log
	{
		public Log()
		{}
		#region Model
		private int _id;
		private int _logid;
		private int _customerid;
		private DateTime _timedate;
		private string _contents;
		private string _logimageurl;
		private string _logimageconurl;
		private int _logstate;
		private int _logsharetime=0;
		private int _logzantime=0;
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
		public int LogID
		{
			set{ _logid=value;}
			get{return _logid;}
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
		public DateTime TimeDate
		{
			set{ _timedate=value;}
			get{return _timedate;}
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
		public string LogImageUrl
		{
			set{ _logimageurl=value;}
			get{return _logimageurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogImageConUrl
		{
			set{ _logimageconurl=value;}
			get{return _logimageconurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LogState
		{
			set{ _logstate=value;}
			get{return _logstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LogShareTime
		{
			set{ _logsharetime=value;}
			get{return _logsharetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LogZanTime
		{
			set{ _logzantime=value;}
			get{return _logzantime;}
		}
		#endregion Model

	}
}

