using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_monthlyFeedback:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_monthlyFeedback
	{
		public Table_monthlyFeedback()
		{}
		#region Model
		private string _monthlyfeedback_sn;
		private DateTime? _monthlyfeedback_yyyymm;
		private string _project_id;
		private decimal? _monthlyfeedback_fulfilment;
        private string _monthlyfeedback_fulfilmentdescription;
        private string _monthlyFeedback_writer;
		/// <summary>
		/// 
		/// </summary>
		public string monthlyFeedback_sn
		{
			set{ _monthlyfeedback_sn=value;}
			get{return _monthlyfeedback_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? monthlyFeedback_yyyyMM
		{
			set{ _monthlyfeedback_yyyymm=value;}
			get{return _monthlyfeedback_yyyymm;}
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
		public decimal? monthlyFeedback_fulfilment
		{
			set{ _monthlyfeedback_fulfilment=value;}
			get{return _monthlyfeedback_fulfilment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string monthlyFeedback_fulfilmentDescription
		{
			set{ _monthlyfeedback_fulfilmentdescription=value;}
			get{return _monthlyfeedback_fulfilmentdescription;}
		}
        public string monthlyFeedback_writer
        {
            set { _monthlyFeedback_writer = value; }
            get { return _monthlyFeedback_writer; }
        }
		#endregion Model

	}
}

