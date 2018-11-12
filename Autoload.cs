﻿/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 9:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CJGui
{
	/// <summary>
	/// Description of Autoload.
	/// </summary>
	public class Autoload
	{
		public Dictionary<string, StrArr> psr_0;
		public Dictionary<string, StrArr> psr_4;
		public Dictionary<string, List<string>> classmap;
		public Dictionary<string, List<string>> files;
		public Dictionary<string, List<string>> exclude_from_classmap;
		
		public Autoload()
		{
		}
	}
}