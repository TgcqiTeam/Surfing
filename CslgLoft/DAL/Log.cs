using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Matisoft.DAL
{
	/// <summary>
	/// 数据访问类:Log
	/// </summary>
	public partial class Log
	{
		public Log()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Log");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Matisoft.Model.Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Log(");
			strSql.Append("LogID,CustomerID,TimeDate,Contents,LogImageUrl,LogImageConUrl,LogState,LogShareTime,LogZanTime)");
			strSql.Append(" values (");
			strSql.Append("@LogID,@CustomerID,@TimeDate,@Contents,@LogImageUrl,@LogImageConUrl,@LogState,@LogShareTime,@LogZanTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.Int,4),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@TimeDate", SqlDbType.DateTime),
					new SqlParameter("@Contents", SqlDbType.NChar,10),
					new SqlParameter("@LogImageUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@LogImageConUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@LogState", SqlDbType.Int,4),
					new SqlParameter("@LogShareTime", SqlDbType.Int,4),
					new SqlParameter("@LogZanTime", SqlDbType.Int,4)};
			parameters[0].Value = model.LogID;
			parameters[1].Value = model.CustomerID;
			parameters[2].Value = model.TimeDate;
			parameters[3].Value = model.Contents;
			parameters[4].Value = model.LogImageUrl;
			parameters[5].Value = model.LogImageConUrl;
			parameters[6].Value = model.LogState;
			parameters[7].Value = model.LogShareTime;
			parameters[8].Value = model.LogZanTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Matisoft.Model.Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Log set ");
			strSql.Append("LogID=@LogID,");
			strSql.Append("CustomerID=@CustomerID,");
			strSql.Append("TimeDate=@TimeDate,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("LogImageUrl=@LogImageUrl,");
			strSql.Append("LogImageConUrl=@LogImageConUrl,");
			strSql.Append("LogState=@LogState,");
			strSql.Append("LogShareTime=@LogShareTime,");
			strSql.Append("LogZanTime=@LogZanTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.Int,4),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@TimeDate", SqlDbType.DateTime),
					new SqlParameter("@Contents", SqlDbType.NChar,10),
					new SqlParameter("@LogImageUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@LogImageConUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@LogState", SqlDbType.Int,4),
					new SqlParameter("@LogShareTime", SqlDbType.Int,4),
					new SqlParameter("@LogZanTime", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.LogID;
			parameters[1].Value = model.CustomerID;
			parameters[2].Value = model.TimeDate;
			parameters[3].Value = model.Contents;
			parameters[4].Value = model.LogImageUrl;
			parameters[5].Value = model.LogImageConUrl;
			parameters[6].Value = model.LogState;
			parameters[7].Value = model.LogShareTime;
			parameters[8].Value = model.LogZanTime;
			parameters[9].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Log ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Log ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Matisoft.Model.Log GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,LogID,CustomerID,TimeDate,Contents,LogImageUrl,LogImageConUrl,LogState,LogShareTime,LogZanTime from Log ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Matisoft.Model.Log model=new Matisoft.Model.Log();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Matisoft.Model.Log DataRowToModel(DataRow row)
		{
			Matisoft.Model.Log model=new Matisoft.Model.Log();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["LogID"]!=null && row["LogID"].ToString()!="")
				{
					model.LogID=int.Parse(row["LogID"].ToString());
				}
				if(row["CustomerID"]!=null && row["CustomerID"].ToString()!="")
				{
					model.CustomerID=int.Parse(row["CustomerID"].ToString());
				}
				if(row["TimeDate"]!=null && row["TimeDate"].ToString()!="")
				{
					model.TimeDate=DateTime.Parse(row["TimeDate"].ToString());
				}
				if(row["Contents"]!=null)
				{
					model.Contents=row["Contents"].ToString();
				}
				if(row["LogImageUrl"]!=null)
				{
					model.LogImageUrl=row["LogImageUrl"].ToString();
				}
				if(row["LogImageConUrl"]!=null)
				{
					model.LogImageConUrl=row["LogImageConUrl"].ToString();
				}
				if(row["LogState"]!=null && row["LogState"].ToString()!="")
				{
					model.LogState=int.Parse(row["LogState"].ToString());
				}
				if(row["LogShareTime"]!=null && row["LogShareTime"].ToString()!="")
				{
					model.LogShareTime=int.Parse(row["LogShareTime"].ToString());
				}
				if(row["LogZanTime"]!=null && row["LogZanTime"].ToString()!="")
				{
					model.LogZanTime=int.Parse(row["LogZanTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,LogID,CustomerID,TimeDate,Contents,LogImageUrl,LogImageConUrl,LogState,LogShareTime,LogZanTime ");
			strSql.Append(" FROM Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,LogID,CustomerID,TimeDate,Contents,LogImageUrl,LogImageConUrl,LogState,LogShareTime,LogZanTime ");
			strSql.Append(" FROM Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Log";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

