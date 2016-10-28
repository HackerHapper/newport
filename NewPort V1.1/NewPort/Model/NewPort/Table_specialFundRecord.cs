using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_specialFundRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_specialFundRecord
	{
		public Table_specialFundRecord()
		{}
		#region Model
		private string _project_id;
		private string _specialfundrecord_id;
		private string _specialfundrecord_description;
		private decimal? _specialfundrecord_amount;
		private string _specialfundrecord_methods;
		private string _specialfundrecord_channel;
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
		public string specialFundRecord_id
		{
			set{ _specialfundrecord_id=value;}
			get{return _specialfundrecord_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specialFundRecord_description
		{
			set{ _specialfundrecord_description=value;}
			get{return _specialfundrecord_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? specialFundRecord_amount
		{
			set{ _specialfundrecord_amount=value;}
			get{return _specialfundrecord_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specialFundRecord_methods
		{
			set{ _specialfundrecord_methods=value;}
			get{return _specialfundrecord_methods;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specialFundRecord_channel
		{
			set{ _specialfundrecord_channel=value;}
			get{return _specialfundrecord_channel;}
		}
		#endregion Model

	}
}

