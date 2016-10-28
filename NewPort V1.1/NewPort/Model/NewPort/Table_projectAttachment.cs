using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_projectAttachment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_projectAttachment
	{
		public Table_projectAttachment()
		{}
		#region Model
		private string _projectattachment_id;
		private string _project_id;
		private string _projectattachment_path;
		private string _projectattachment_name;
		private DateTime? _projectattachment_uploadtime;
		/// <summary>
		/// 
		/// </summary>
		public string projectAttachment_id
		{
			set{ _projectattachment_id=value;}
			get{return _projectattachment_id;}
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
		public string projectAttachment_path
		{
			set{ _projectattachment_path=value;}
			get{return _projectattachment_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string projectAttachment_name
		{
			set{ _projectattachment_name=value;}
			get{return _projectattachment_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? projectAttachment_uploadTime
		{
			set{ _projectattachment_uploadtime=value;}
			get{return _projectattachment_uploadtime;}
		}
		#endregion Model

	}
}

