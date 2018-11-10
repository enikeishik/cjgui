/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 8:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CJGui
{
	/// <summary>
	/// Description of Support.
	/// </summary>
	public class Support
	{
		public string email;
		public string issues;
		public string forum;
		public string wiki;
		public string irc;
		public string source;
		public string docs;
		public string rss;
		
		public Support()
		{
		}
		
		public Support(string email)
		{
			this.email = email;
		}
		
		public Support(string email, string issues)
		{
			this.email = email;
			this.issues = issues;
		}
		
		public Support(string email, string issues, string forum, string wiki, string irc, string source, string docs, string rss)
		{
			this.email = email;
			this.issues = issues;
			this.forum = forum;
			this.wiki = wiki;
			this.irc = irc;
			this.source = source;
			this.docs = docs;
			this.rss = rss;
		}
	}
}
