using System;
namespace Maticsoft.Model.NewPort
{
	/// <summary>
	/// Table_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_user
	{
		public Table_user()
		{}
		#region Model
		private string _user_id;
		private string _user_name;
		private string _user_dept;
		private string _user_liableperson;
		private string _user_contacterinfo;
		private int? _user_authority;
		private string _user_password;
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
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_dept
		{
			set{ _user_dept=value;}
			get{return _user_dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_liablePerson
		{
			set{ _user_liableperson=value;}
			get{return _user_liableperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_contacterInfo
		{
			set{ _user_contacterinfo=value;}
			get{return _user_contacterinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_authority
		{
			set{ _user_authority=value;}
			get{return _user_authority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_password
		{
			set{ _user_password=value;}
			get{return _user_password;}
		}
		#endregion Model

	}
}

