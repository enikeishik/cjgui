/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 09.11.2018
 * Time: 15:25
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
    /// Description of AuthorForm.
    /// </summary>
    public partial class AuthorForm : Form
    {
        protected Author author;
        
        protected AuthorForm()
        {
            InitializeComponent();
        }
        
        public AuthorForm(Author author)
            : this()
        {
            this.author = author;
            if (author.name != null) {
                name.Text = author.name;
                email.Text = author.email;
                homepage.Text = author.homepage;
                role.Text = author.role;
            }
        }
        
        void CancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        void SaveClick(object sender, EventArgs e)
        {
            author.name = name.Text;
            author.email = email.Text;
            author.homepage = homepage.Text;
            author.role = role.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
