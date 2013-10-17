using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Matisoft.DAL
{
	/// <summary>
	/// 数据访问类:Sex_dir
	/// </summary>
	public partial class Sex_dir
	{
		public Sex_dir()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CustomerSex", "Sex_dir"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CustomerSex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sex_dir");
			strSql.Append(" where CustomerSex=@CustomerSex ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerSex", SqlDbType.Int,4)			};
			parameters[0].Value = CustomerSex;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Matisoft.Model.Sex_dir model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sex_dir(");
			strSql.Append("CustomerSex,CustomerSex_exp)");
			strSql.Append(" values (");
			strSql.Append("@CustomerSex,@CustomerSex_exp)");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerSex", SqlDbType.Int,4),
					new SqlParameter("@CustomerSex_exp", SqlDbType.NChar,10)};
			parameters[0].Value = model.CustomerSex;
			parameters[1].Value = model.CustomerSex_exp;

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
		public bool Update(Matisoft.Model.Sex_dir model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sex_dir set ");
			strSql.Append("CustomerSex_exp=@CustomerSex_exp");
			strSql.Append(" where CustomerSex=@CustomerSex ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerSex_exp", SqlDbType.NChar,10),
					new SqlParameter("@CustomerSex", SqlDbType.Int,4)};
			parameters[0].Value = model.CustomerSex_exp;
			parameters[1].Value = model.CustomerSex;

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
		public bool Delete(int CustomerSex)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sex_dir ");
			strSql.Append(" where CustomerSex=@CustomerSex ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerSex", SqlDbType.Int,4)			};
			parameters[0].Value = CustomerSex;

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
		public bool DeleteList(string CustomerSexlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sex_dir ");
			strSql.Append(" where CustomerSex in ("+CustomerSexlist + ")  ");
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
		public Matisoft.Model.Sex_dir GetModel(int CustomerSex)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CustomerSex,CustomerSex_exp from Sex_dir ");
			strSql.Append(" where CustomerSex=@CustomerSex ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerSex", SqlDbType.Int,4)			};
			parameters[0].Value = CustomerSex;

			Matisoft.Model.Sex_dir model=new Matisoft.Model.Sex_dir();
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
		public Matisoft.Model.Sex_dir DataRowToModel(DataRow row)
		{
			Matisoft.Model.Sex_dir model=new Matisoft.Model.Sex_dir();
			if (row != null)
			{
				if(row["CustomerSex"]!=null && row["CustomerSex"].ToString()!="")
				{
					model.CustomerSex=int.Parse(row["CustomerSex"].ToString());
				}
				if(row["CustomerSex_exp"]!=null)
				{
					model.CustomerSex_exp=row["CustomerSex_exp"].ToString();
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
			strSql.Append("select CustomerSex,CustomerSex_exp ");
			strSql.Append(" FROM Sex_dir ");
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
			strSql.Append(" CustomerSex,CustomerSex_exp ");
			strSql.Append(" FROM Sex_dir ");
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
			strSql.Append("select count(1) FROM Sex_dir ");
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
				strSql.Append("order by T.CustomerSex desc");
			}
			strSql.Append(")AS Row, T.*  from Sex_dir T ");
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
			parameters[0].Value = "Sex_dir";
			parameters[1].Value = "CustomerSex";
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

