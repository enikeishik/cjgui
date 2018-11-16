/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 16.11.2018
 * Time: 9:02
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;

namespace CJGui
{
    /// <summary>
    /// Description of ConfigHttpBasic.
    /// </summary>
    public class ConfigHttpBasic
    {
        public string username;
        public string password;
        
        public ConfigHttpBasic()
        {
            username = "";
            password = "";
        }
        
        public ConfigHttpBasic(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
