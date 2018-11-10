﻿/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 07.11.2018
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CJGui
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		public string name = ""; //!
		public string description = ""; //!
		public string version;
		public string type = ""; //! library|project|metapackage|composer-plugin|[a-z0-9-]+
		public string keywords;
		public string homepage;
		public string readme;
		public string time; // 'YYYY-MM-DD'|'YYYY-MM-DD HH:MM:SS'|'YYYY-MM-DDTHH:MM:SSZ'
		public string license; // array<string>
		public List<Author> authors;
		public List<Support> support;
		public object require;
		public object require_dev;
		public object conflict;
		public object replace;
		public object provide;
		public object suggest;
		public object autoload;
		public object autoload_dev;
		public string minimum_stability; // "^dev|alpha|beta|rc|RC|stable$"
		public bool prefer_stable = true;
		public object repositories;
		public object config;
		public object scripts;
		public object extra;
		public object bin;
		public object archive;
		public bool abandoned = false; //|string
		public object non_feature_branches; //[]
	}
}