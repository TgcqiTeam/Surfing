using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Matisoft.DAL
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
	public partial class Customer
	{
		public Customer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CustomerID", "Customer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CustomerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Customer");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Matisoft.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Customer(");
			strSql.Append("Password,CustomerState,CustomerName,CustomerXiaoxue,CustomerChuzhong,CustomerGaozhong,CustomerDaxue,CustomerXueli,CustomerSex,CustomerBirthday,CustomerWorkplace,CustomerEmail,CustomerQQ)");
			strSql.Append(" values (");
			strSql.Append("@Password,@CustomerState,@CustomerName,@CustomerXiaoxue,@CustomerChuzhong,@CustomerGaozhong,@CustomerDaxue,@CustomerXueli,@CustomerSex,@CustomerBirthday,@CustomerWorkplace,@CustomerEmail,@CustomerQQ)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerState", SqlDbType.Int,4),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CustomerXiaoxue", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerChuzhong", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerGaozhong", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerDaxue", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerXueli", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerSex", SqlDbType.Int,4),
					new SqlParameter("@CustomerBirthday", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerWorkplace", SqlDbType.NVarChar,100),
					new SqlParameter("@CustomerEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerQQ", SqlDbType.NVarChar,15)};
			parameters[0].Value = model.Password;
			parameters[1].Value = model.CustomerState;
			parameters[2].Value = model.CustomerName;
			parameters[3].Value = model.CustomerXiaoxue;
			parameters[4].Value = model.CustomerChuzhong;
			parameters[5].Value = model.CustomerGaozhong;
			parameters[6].Value = model.CustomerDaxue;
			parameters[7].Value = model.CustomerXueli;
			parameters[8].Value = model.CustomerSex;
			parameters[9].Value = model.CustomerBirthday;
			parameters[10].Value = model.CustomerWorkplace;
			parameters[11].Value = model.CustomerEmail;
			parameters[12].Value = model.CustomerQQ;

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
		public bool Update(Matisoft.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Customer set ");
			strSql.Append("Password=@Password,");
			strSql.Append("CustomerState=@CustomerState,");
			strSql.Append("CustomerName=@CustomerName,");
			strSql.Append("CustomerXiaoxue=@CustomerXiaoxue,");
			strSql.Append("CustomerChuzhong=@CustomerChuzhong,");
			strSql.Append("CustomerGaozhong=@CustomerGaozhong,");
			strSql.Append("CustomerDaxue=@CustomerDaxue,");
			strSql.Append("CustomerXueli=@CustomerXueli,");
			strSql.Append("CustomerSex=@CustomerSex,");
			strSql.Append("CustomerBirthday=@CustomerBirthday,");
			strSql.Append("CustomerWorkplace=@CustomerWorkplace,");
			strSql.Append("CustomerEmail=@CustomerEmail,");
			strSql.Append("CustomerQQ=@CustomerQQ");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerState", SqlDbType.Int,4),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CustomerXiaoxue", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerChuzhong", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerGaozhong", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerDaxue", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerXueli", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerSex", SqlDbType.Int,4),
					new SqlParameter("@CustomerBirthday", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerWorkplace", SqlDbType.NVarChar,100),
					new SqlParameter("@CustomerEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerQQ", SqlDbType.NVarChar,15),
					new SqlParameter("@CustomerID", SqlDbType.Int,4)};
			parameters[0].Value = model.Password;
			parameters[1].Value = model.CustomerState;
			parameters[2].Value = model.CustomerName;
			parameters[3].Value = model.CustomerXiaoxue;
			parameters[4].Value = model.CustomerChuzhong;
			parameters[5].Value = model.CustomerGaozhong;
			parameters[6].Value = model.CustomerDaxue;
			parameters[7].Value = model.CustomerXueli;
			parameters[8].Value = model.CustomerSex;
			parameters[9].Value = model.CustomerBirthday;
			parameters[10].Value = model.CustomerWorkplace;
			parameters[11].Value = model.CustomerEmail;
			parameters[12].Value = model.CustomerQQ;
			parameters[13].Value = model.CustomerID;

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
		public bool Delete(int CustomerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

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
		public bool DeleteList(string CustomerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CustomerID in ("+CustomerIDlist + ")  ");
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
		public Matisoft.Model.Customer GetModel(int CustomerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CustomerID,Password,CustomerState,CustomerName,CustomerXiaoxue,CustomerChuzhong,CustomerGaozhong,CustomerDaxue,CustomerXueli,CustomerSex,CustomerBirthday,CustomerWorkplace,CustomerEmail,CustomerQQ from Customer ");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

			Matisoft.Model.Customer model=new Matisoft.Model.Customer();
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
		public Matisoft.Model.Customer DataRowToModel(DataRow row)
		{
			Matisoft.Model.Customer model=new Matisoft.Model.Customer();
			if (row != null)
			{
				if(row["CustomerID"]!=null && row["CustomerID"].ToString()!="")
				{
					model.CustomerID=int.Parse(row["CustomerID"].ToString());
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["CustomerState"]!=null && row["CustomerState"].ToString()!="")
				{
					model.CustomerState=int.Parse(row["CustomerState"].ToString());
				}
				if(row["CustomerName"]!=null)
				{
					model.CustomerName=row["CustomerName"].ToString();
				}
				if(row["CustomerXiaoxue"]!=null)
				{
					model.CustomerXiaoxue=row["CustomerXiaoxue"].ToString();
				}
				if(row["CustomerChuzhong"]!=null)
				{
					model.CustomerChuzhong=row["CustomerChuzhong"].ToString();
				}
				if(row["CustomerGaozhong"]!=null)
				{
					model.CustomerGaozhong=row["CustomerGaozhong"].ToString();
				}
				if(row["CustomerDaxue"]!=null)
				{
					model.CustomerDaxue=row["CustomerDaxue"].ToString();
				}
				if(row["CustomerXueli"]!=null)
				{
					model.CustomerXueli=row["CustomerXueli"].ToString();
				}
				if(row["CustomerSex"]!=null && row["CustomerSex"].ToString()!="")
				{
					model.CustomerSex=int.Parse(row["CustomerSex"].ToString());
				}
				if(row["CustomerBirthday"]!=null)
				{
					model.CustomerBirthday=row["CustomerBirthday"].ToString();
				}
				if(row["CustomerWorkplace"]!=null)
				{
					model.CustomerWorkplace=row["CustomerWorkplace"].ToString();
				}
				if(row["CustomerEmail"]!=null)
				{
					model.CustomerEmail=row["CustomerEmail"].ToString();
				}
				if(row["CustomerQQ"]!=null)
				{
					model.CustomerQQ=row["CustomerQQ"].ToString();
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
			strSql.Append("select CustomerID,Password,CustomerState,CustomerName,CustomerXiaoxue,CustomerChuzhong,CustomerGaozhong,CustomerDaxue,CustomerXueli,CustomerSex,CustomerBirthday,CustomerWorkplace,CustomerEmail,CustomerQQ ");
			strSql.Append(" FROM Customer ");
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
			strSql.Append(" CustomerID,Password,CustomerState,CustomerName,CustomerXiaoxue,CustomerChuzhong,CustomerGaozhong,CustomerDaxue,CustomerXueli,CustomerSex,CustomerBirthday,CustomerWorkplace,CustomerEmail,CustomerQQ ");
			strSql.Append(" FROM Customer ");
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
			strSql.Append("select count(1) FROM Customer ");
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
				strSql.Append("order by T.CustomerID desc");
			}
			strSql.Append(")AS Row, T.*  from Customer T ");
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
			parameters[0].Value = "Customer";
			parameters[1].Value = "CustomerID";
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

