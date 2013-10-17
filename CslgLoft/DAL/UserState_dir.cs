using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Matisoft.DAL
{
	/// <summary>
	/// 数据访问类:UserState_dir
	/// </summary>
	public partial class UserState_dir
	{
		public UserState_dir()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserState", "UserState_dir"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserState)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserState_dir");
			strSql.Append(" where UserState=@UserState ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserState", SqlDbType.Int,4)			};
			parameters[0].Value = UserState;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Matisoft.Model.UserState_dir model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserState_dir(");
			strSql.Append("UserState,State_name)");
			strSql.Append(" values (");
			strSql.Append("@UserState,@State_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@UserState", SqlDbType.Int,4),
					new SqlParameter("@State_name", SqlDbType.NText)};
			parameters[0].Value = model.UserState;
			parameters[1].Value = model.State_name;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Matisoft.Model.UserState_dir model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserState_dir set ");
			strSql.Append("State_name=@State_name");
			strSql.Append(" where UserState=@UserState ");
			SqlParameter[] parameters = {
					new SqlParameter("@State_name", SqlDbType.NText),
					new SqlParameter("@UserState", SqlDbType.Int,4)};
			parameters[0].Value = model.State_name;
			parameters[1].Value = model.UserState;

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
		public bool Delete(int UserState)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserState_dir ");
			strSql.Append(" where UserState=@UserState ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserState", SqlDbType.Int,4)			};
			parameters[0].Value = UserState;

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
		public bool DeleteList(string UserStatelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserState_dir ");
			strSql.Append(" where UserState in ("+UserStatelist + ")  ");
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
		public Matisoft.Model.UserState_dir GetModel(int UserState)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserState,State_name from UserState_dir ");
			strSql.Append(" where UserState=@UserState ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserState", SqlDbType.Int,4)			};
			parameters[0].Value = UserState;

			Matisoft.Model.UserState_dir model=new Matisoft.Model.UserState_dir();
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
		public Matisoft.Model.UserState_dir DataRowToModel(DataRow row)
		{
			Matisoft.Model.UserState_dir model=new Matisoft.Model.UserState_dir();
			if (row != null)
			{
				if(row["UserState"]!=null && row["UserState"].ToString()!="")
				{
					model.UserState=int.Parse(row["UserState"].ToString());
				}
				if(row["State_name"]!=null)
				{
					model.State_name=row["State_name"].ToString();
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
			strSql.Append("select UserState,State_name ");
			strSql.Append(" FROM UserState_dir ");
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
			strSql.Append(" UserState,State_name ");
			strSql.Append(" FROM UserState_dir ");
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
			strSql.Append("select count(1) FROM UserState_dir ");
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
				strSql.Append("order by T.UserState desc");
			}
			strSql.Append(")AS Row, T.*  from UserState_dir T ");
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
			parameters[0].Value = "UserState_dir";
			parameters[1].Value = "UserState";
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

