using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_project
	{
		public Table_project()
		{}
		#region Model
		private string _project_id;
        private string _project_responUnit;
		private string _project_name;
		private string _project_owner;
		private string _project_positon;
		private string _project_type;
		private string _project_constrcontent;
		private decimal? _project_scale;
		private decimal? _project_designcapacity;
		private string _project_designcapacityunit;
		private string _project_designcapacityremarks;
		private decimal? _project_totalinvestment;
		private DateTime? _project_constrstarttime;
		private DateTime? _project_constrendtime;
		private decimal? _project_coveredarea;
		private string _project_state;
		private DateTime? _project_statechangedtime;
        private string _project_check;
        private string _project_writer;
        private string _project_year;
        private string _project_class;
        private string _project_area;
            
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
        /// 
        public string project_responUnit
        {
            set { _project_responUnit = value; }
            get { return _project_responUnit; }
        }
        /// 
		/// </summary>
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_owner
		{
			set{ _project_owner=value;}
			get{return _project_owner;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_positon
		{
			set{ _project_positon=value;}
			get{return _project_positon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_type
		{
			set{ _project_type=value;}
			get{return _project_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_constrContent
		{
			set{ _project_constrcontent=value;}
			get{return _project_constrcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? project_scale
		{
			set{ _project_scale=value;}
			get{return _project_scale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? project_designCapacity
		{
			set{ _project_designcapacity=value;}
			get{return _project_designcapacity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_designCapacityUnit
		{
			set{ _project_designcapacityunit=value;}
			get{return _project_designcapacityunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_designCapacityRemarks
		{
			set{ _project_designcapacityremarks=value;}
			get{return _project_designcapacityremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? project_totalInvestment
		{
			set{ _project_totalinvestment=value;}
			get{return _project_totalinvestment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_constrStartTime
		{
			set{ _project_constrstarttime=value;}
			get{return _project_constrstarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_constrEndTime
		{
			set{ _project_constrendtime=value;}
			get{return _project_constrendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? project_coveredArea
		{
			set{ _project_coveredarea=value;}
			get{return _project_coveredarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_state
		{
			set{ _project_state=value;}
			get{return _project_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? project_stateChangedTime
		{
			set{ _project_statechangedtime=value;}
			get{return _project_statechangedtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_check
		{
			set{ _project_check=value;}
			get{return _project_check;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string project_writer
        {
            set { _project_writer = value; }
            get { return _project_writer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string project_year
        {
            set { _project_year = value; }
            get { return _project_year; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string project_class
        {
            set { _project_class = value; }
            get { return _project_class; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string project_area
        {
            set { _project_area = value; }
            get { return _project_area; }
        }
		#endregion Model

	}
}

