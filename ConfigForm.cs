/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 16.11.2018
 * Time: 15:26
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CJGui
{
    /// <summary>
    /// Description of ConfigForm.
    /// </summary>
    public partial class ConfigForm : Form
    {
        protected readonly Config config;
        
        protected ConfigForm()
        {
            InitializeComponent();
        }
        
        public ConfigForm(Config config)
            : this()
        {
            this.config = config;
        }
    }
}
