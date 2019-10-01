/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 16.11.2018
 * Time: 9:05
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;

namespace CJGui
{
    /// <summary>
    /// Description of StrBool.
    /// </summary>
    public class StrBool
    {
        public string Value
        {
            get
            {
                if (Value.ToLower() == "true")
                    return "true";
                
                if (Value.ToLower() == "false")
                    return "false";
                
                return Value;
            }
            set
            {
                if (value.ToLower() == "true")
                    Value = "true";
                else if (value.ToLower() == "false")
                    Value = "false";
                else
                    Value = value;
            }
        }
            
        public StrBool()
        {
            Value = "false";
        }
        
        public StrBool(string str)
        {
            Value = str;
        }
        
        public StrBool(bool bln)
        {
            Value = bln ? "true" : "false";
        }
    }
}
