/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 09.11.2018
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CJGui
{
	/// <summary>
	/// Description of Author.
	/// </summary>
	public class Author
	{
		public string name;
		public string email;
		public string homepage;
		public string role;
		
		public Author()
		{
		}
		
		public Author(string name, string email, string homepage, string role)
		{
			this.name = name;
			this.email = email;
			this.homepage = homepage;
			this.role = role;
		}
	}
}
