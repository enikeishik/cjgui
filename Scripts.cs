/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 14.11.2018
 * Time: 11:08
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
    /// Description of Scripts.
    /// </summary>
    public class Scripts
    {
        public StrArr pre_install_cmd;
        public StrArr post_install_cmd;
        public StrArr pre_update_cmd;
        public StrArr post_update_cmd;
        public StrArr post_status_cmd;
        public StrArr pre_archive_cmd;
        public StrArr post_archive_cmd;
        public StrArr pre_autoload_dump;
        public StrArr post_autoload_dump;
        public StrArr post_root_package_install;
        public StrArr post_create_project_cmd;
        public Dictionary<string, StrArr> custom;
            
        public Scripts()
        {
            pre_install_cmd = new StrArr();
            post_install_cmd = new StrArr();
            pre_update_cmd = new StrArr();
            post_update_cmd = new StrArr();
            post_status_cmd = new StrArr();
            pre_archive_cmd = new StrArr();
            post_archive_cmd = new StrArr();
            pre_autoload_dump = new StrArr();
            post_autoload_dump = new StrArr();
            post_root_package_install = new StrArr();
            post_create_project_cmd = new StrArr();
            custom = new Dictionary<string, StrArr>();
        }
    }
}
