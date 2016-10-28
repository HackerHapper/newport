﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model.NewPort;
namespace Maticsoft.BLL.NewPort
{
	/// <summary>
	/// Table_specialFundRecord
	/// </summary>
	public partial class Table_specialFundRecord
	{
		private readonly Maticsoft.DAL.NewPort.Table_specialFundRecord dal=new Maticsoft.DAL.NewPort.Table_specialFundRecord();
		public Table_specialFundRecord()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string specialFundRecord_id)
		{
			return dal.Exists(specialFundRecord_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.NewPort.Table_specialFundRecord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.NewPort.Table_specialFundRecord model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string specialFundRecord_id)
		{
			
			return dal.Delete(specialFundRecord_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string specialFundRecord_idlist )
		{
			return dal.DeleteList(specialFundRecord_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.NewPort.Table_specialFundRecord GetModel(string specialFundRecord_id)
		{
			
			return dal.GetModel(specialFundRecord_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.NewPort.Table_specialFundRecord GetModelByCache(string specialFundRecord_id)
		{
			
			string CacheKey = "Table_specialFundRecordModel-" + specialFundRecord_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(specialFundRecord_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.NewPort.Table_specialFundRecord)objModel;
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
		public List<Maticsoft.Model.NewPort.Table_specialFundRecord> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.NewPort.Table_specialFundRecord> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.NewPort.Table_specialFundRecord> modelList = new List<Maticsoft.Model.NewPort.Table_specialFundRecord>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.NewPort.Table_specialFundRecord model;
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

