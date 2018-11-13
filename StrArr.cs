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
		
		public string Value
		{
			get
			{
				if (Values.Count == 0) {
					return "\"\"";
				}
				
				if (Values.Count == 1) {
					return "\"" + Values[0] + "\"";
				}
				
				var str = "[";
				foreach (var val in Values) {
					str += "\"" + val + "\",";
				}
				return str.Substring(0, str.Length - 1) + "]";
			}
			
			set
			{
				Values.Clear();
				
				if (value.IndexOf("[\"") == 0 && value.LastIndexOf("\"]") == (value.Length - 2)) {
					var arr = value
						.Trim(new [] {'[', ']'})
						.Replace("\", \"", "\",\"")
						.Split(
							new [] {"\",\""}, 
							StringSplitOptions.RemoveEmptyEntries
						);
					foreach (var s in arr) {
						Values.Add(s);
					}
				} else if (value.IndexOf('"') == 0 && value.LastIndexOf('"') == (value.Length - 1)) {
					Values.Add(value.Trim(new [] {'"'}));
				} else {
					Values.Add(value);
				}
			}
		}
		
		public List<string> Values
		{
			get; set;
		}
		
		public override string ToString()
		{
			return Value;
		}
		
		public StrArr()
		{
			Values = new List<string>();
		}
		
		public StrArr(string str) 
			: this()
		{
			Value = str;
		}
		
		public StrArr(List<string> strs)
			: this()
		{
			Values = strs;
		}
	}
}
