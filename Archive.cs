/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 14.11.2018
 * Time: 9:22
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
    /// Description of Archive.
    /// </summary>
    public class Archive
    {
        public List<string> exclude;
            
        public Archive()
        {
            exclude = new List<string>();
        }
        
        public Archive(List<string> exclude)
        {
            this.exclude = exclude;
        }
    }
}
