using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_plan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_plan
	{
		public Table_plan()
		{}
		#region Model
		private string _plan_id;
		private string _plan_name;
		private string _plan_description;
		private DateTime? _plan_starttime;
		private DateTime? _plan_endtime;
		/// <summary>
		/// 
		/// </summary>
		public string plan_id
		{
			set{ _plan_id=value;}
			get{return _plan_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plan_name
		{
			set{ _plan_name=value;}
			get{return _plan_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plan_description
		{
			set{ _plan_description=value;}
			get{return _plan_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? plan_startTime
		{
			set{ _plan_starttime=value;}
			get{return _plan_starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? plan_endTime
		{
			set{ _plan_endtime=value;}
			get{return _plan_endtime;}
		}
		#endregion Model

	}
}

