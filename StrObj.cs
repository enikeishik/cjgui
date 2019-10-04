/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 16.11.2018
 * Time: 13:11
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CJGui
{
    /// <summary>
    /// Description of StrObj.
    /// </summary>
    public class StrObj
    {
        public string Value
        {
            get
            {
                if (Values.Count == 0)
                    return "\"\"";
                
                if (Values.Count == 1 && Values.Keys.First() == "")
                    return "\"" + Values.Values.First() + "\"";
                
                var str = "{";
                foreach (var val in Values)
                    str += "\"" + val.Key + "\":\"" + val.Value + "\",";
                
                return str.Substring(0, str.Length - 1) + "}";
            }
            
            set
            {
                Values.Clear();
                
                if (value.IndexOf("{\"") == 0 && value.LastIndexOf("\"}") == (value.Length - 2)) {
                    var arr = value
                        .Trim(new [] {'{', '}'})
                        .Replace("\", \"", "\",\"")
                        .Split(
                            new [] {"\",\""}, 
                            StringSplitOptions.RemoveEmptyEntries
                        );
                    foreach (var s in arr) {
                        var a = s.Split(':');
                        if (a.Length == 2)
                            Values.Add(a[0], a[1]);
                    }
                } else if (value.IndexOf('"') == 0 && value.LastIndexOf('"') == (value.Length - 1)) {
                    Values.Add("", value.Trim(new [] {'"'}));
                } else {
                    Values.Add("", value);
                }
            }
        }
        
        public Dictionary<string, string> Values
        {
            get; set;
        }
        
        public override string ToString()
        {
            return Value;
        }
        
        public StrObj()
        {
            Values = new Dictionary<string, string>();
        }
        
        public StrObj(string str) 
            : this()
        {
            Value = str;
        }
        
        public StrObj(Dictionary<string, string> strs)
            : this()
        {
            Values = strs;
        }
    }
}
