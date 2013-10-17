using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Matisoft.Model;
namespace Matisoft.BLL
{
	/// <summary>
	/// UserState_dir
	/// </summary>
	public partial class UserState_dir
	{
		private readonly Matisoft.DAL.UserState_dir dal=new Matisoft.DAL.UserState_dir();
		public UserState_dir()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserState)
		{
			return dal.Exists(UserState);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Matisoft.Model.UserState_dir model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Matisoft.Model.UserState_dir model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserState)
		{
			
			return dal.Delete(UserState);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserStatelist )
		{
			return dal.DeleteList(UserStatelist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Matisoft.Model.UserState_dir GetModel(int UserState)
		{
			
			return dal.GetModel(UserState);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Matisoft.Model.UserState_dir GetModelByCache(int UserState)
		{
			
			string CacheKey = "UserState_dirModel-" + UserState;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserState);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Matisoft.Model.UserState_dir)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Matisoft.Model.UserState_dir> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Matisoft.Model.UserState_dir> DataTableToList(DataTable dt)
		{
			List<Matisoft.Model.UserState_dir> modelList = new List<Matisoft.Model.UserState_dir>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Matisoft.Model.UserState_dir model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

