/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 09.11.2018
 * Time: 11:12
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
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
