/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 12.11.2018
 * Time: 9:32
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
    /// Description of Autoload.
    /// </summary>
    public class Autoload
    {
        public Dictionary<string, StrArr> psr_0;
        public Dictionary<string, StrArr> psr_4;
        public List<string> classmap;
        public List<string> files;
        public List<string> exclude_from_classmap;
        
        public Autoload()
        {
        }
    }
}
