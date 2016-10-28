using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_notice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_notice
	{
		public Table_notice()
		{}
		#region Model
		private string _notice_id;
		private DateTime? _notice_time;
		private string _notice_topic;
		private string _notice_content;
		private string _notice_attachmentpath;
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
		public DateTime? notice_time
		{
			set{ _notice_time=value;}
			get{return _notice_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string notice_topic
		{
			set{ _notice_topic=value;}
			get{return _notice_topic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string notice_content
		{
			set{ _notice_content=value;}
			get{return _notice_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string notice_attachmentPath
		{
			set{ _notice_attachmentpath=value;}
			get{return _notice_attachmentpath;}
		}
		#endregion Model

	}
}

