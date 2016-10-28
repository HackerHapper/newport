using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_noticeReceiveRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_noticeReceiveRecord
	{
		public Table_noticeReceiveRecord()
		{}
		#region Model
		private string _user_id;
		private string _notice_id;
		private DateTime? _noticereceiverecord_readtime;
		/// <summary>
		/// 
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string notice_id
		{
			set{ _notice_id=value;}
			get{return _notice_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? noticeReceiveRecord_readTime
		{
			set{ _noticereceiverecord_readtime=value;}
			get{return _noticereceiverecord_readtime;}
		}
		#endregion Model

	}
}

