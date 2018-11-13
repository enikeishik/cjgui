/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 9:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CJGui
{
	/// <summary>
	/// Description of StrArr.
	/// </summary>
	public class StrArr
	{
		protected List<string> strarr;
		
		public string Value
		{
			get
			{
				if (strarr.Count == 0) {
					return "";
				}
				
				if (strarr.Count == 1) {
					return strarr[0];
				}
				
				var str = "[";
				foreach (var val in strarr) {
					str += "\"" + val + "\",";
				}
				return str.Substring(0, str.Length - 1) + "]";
			}
			
			set
			{
				strarr.Clear();
				
				if (value.IndexOf("[\"") == 0 && value.LastIndexOf("\"]") == (value.Length - 1)) {
					var arr = value
						.Trim(new [] {'[', ']'})
						.Replace("\", \"", "\",\"")
						.Split(
							new [] {"\",\""}, 
							StringSplitOptions.RemoveEmptyEntries
						);
					foreach (var s in arr) {
						strarr.Add(s);
					}
				} else {
					strarr.Add(value);
				}
			}
		}
		
		public override string ToString()
		{
			return Value;
		}
		
		protected StrArr()
		{
			strarr = new List<string>();
		}
		
		public StrArr(string str) 
			: this()
		{
			Value = str;
		}
		
		public StrArr(List<string> strs)
			: this()
		{
			strarr = strs;
		}
	}
}
