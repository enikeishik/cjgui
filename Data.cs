/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 07.11.2018
 * Time: 16:35
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
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
        public string type = "library"; // library|project|metapackage|composer-plugin|[a-z0-9-]+
        public string keywords;
        public string homepage;
        public string readme;
        public string time; // 'YYYY-MM-DD'|'YYYY-MM-DD HH:MM:SS'|'YYYY-MM-DDTHH:MM:SSZ'
        public string license; // array<string>
        public List<Author> authors;
        public Support support;
        public Dictionary<string, string> require;
        public Dictionary<string, string> require_dev;
        public Dictionary<string, string> conflict;
        public Dictionary<string, string> replace;
        public Dictionary<string, string> provide;
        public Dictionary<string, string> suggest;
        public Autoload autoload;
        public Autoload autoload_dev;
        public string minimum_stability; // "^dev|alpha|beta|rc|RC|stable$"
        public bool prefer_stable = true;
        public object repositories;
        public object config;
        public object scripts;
        public object extra;
        public StrArr bin;
        public Archive archive;
        public bool abandoned = false; //|string
        public List<string> non_feature_branches; //[]
    }
}
