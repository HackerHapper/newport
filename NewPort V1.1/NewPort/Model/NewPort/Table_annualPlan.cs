using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_annualPlan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_annualPlan
	{
		public Table_annualPlan()
		{}
		#region Model
		private string _annualplan_sn;
		private string _project_id;
		private string _plan_id;
		private decimal? _annualplan_targetcompletion;
		private string _annualplan_targetdescription;
		private string _annualplan_earlyprogress;
		private string _annualplan_checkstate;
        private string _planYear;
		/// <summary>
		/// 
		/// </summary>
		public string annualPlan_sn
		{
			set{ _annualplan_sn=value;}
			get{return _annualplan_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
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
		public decimal? annualPlan_targetCompletion
		{
			set{ _annualplan_targetcompletion=value;}
			get{return _annualplan_targetcompletion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string annualPlan_targetDescription
		{
			set{ _annualplan_targetdescription=value;}
			get{return _annualplan_targetdescription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string annualPlan_earlyProgress
		{
			set{ _annualplan_earlyprogress=value;}
			get{return _annualplan_earlyprogress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string annualPlan_checkState
		{
			set{ _annualplan_checkstate=value;}
			get{return _annualplan_checkstate;}
		}

        public string planYear
        {
            set { _planYear = value; }
            get { return _planYear; }
        }

		#endregion Model

	}
}

