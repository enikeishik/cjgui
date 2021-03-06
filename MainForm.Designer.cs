﻿/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 07.11.2018
 * Time: 15:45
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
namespace CJGui
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox keywords;
        private System.Windows.Forms.ComboBox license;
        private System.Windows.Forms.TextBox json;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox homepage;
        private System.Windows.Forms.TextBox readme;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox minimum_stability;
        private System.Windows.Forms.TextBox authors;
        private System.Windows.Forms.TextBox supports;
        private System.Windows.Forms.TextBox require;
        private System.Windows.Forms.TextBox require_dev;
        private System.Windows.Forms.TextBox conflict;
        private System.Windows.Forms.TextBox replace;
        private System.Windows.Forms.TextBox provide;
        private System.Windows.Forms.TextBox suggest;
        private System.Windows.Forms.TextBox autoload;
        private System.Windows.Forms.TextBox autoload_dev;
        private System.Windows.Forms.CheckBox prefer_stable;
        private System.Windows.Forms.CheckBox abandoned;
        private System.Windows.Forms.TextBox bin;
        private System.Windows.Forms.TextBox repositories;
        private System.Windows.Forms.TextBox config;
        private System.Windows.Forms.TextBox scripts;
        private System.Windows.Forms.TextBox extra;
        private System.Windows.Forms.TextBox archive;
        private System.Windows.Forms.TextBox non_feature_branches;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.keywords = new System.Windows.Forms.TextBox();
            this.license = new System.Windows.Forms.ComboBox();
            this.json = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.homepage = new System.Windows.Forms.TextBox();
            this.readme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.minimum_stability = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.authors = new System.Windows.Forms.TextBox();
            this.supports = new System.Windows.Forms.TextBox();
            this.require = new System.Windows.Forms.TextBox();
            this.require_dev = new System.Windows.Forms.TextBox();
            this.conflict = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.TextBox();
            this.provide = new System.Windows.Forms.TextBox();
            this.suggest = new System.Windows.Forms.TextBox();
            this.autoload = new System.Windows.Forms.TextBox();
            this.autoload_dev = new System.Windows.Forms.TextBox();
            this.prefer_stable = new System.Windows.Forms.CheckBox();
            this.abandoned = new System.Windows.Forms.CheckBox();
            this.bin = new System.Windows.Forms.TextBox();
            this.repositories = new System.Windows.Forms.TextBox();
            this.config = new System.Windows.Forms.TextBox();
            this.scripts = new System.Windows.Forms.TextBox();
            this.extra = new System.Windows.Forms.TextBox();
            this.archive = new System.Windows.Forms.TextBox();
            this.non_feature_branches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "name*";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "description*";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "keywords";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "license";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "authors";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "require";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "autoload";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(269, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.FieldChanged);
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.FieldValidating);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(118, 29);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(269, 20);
            this.description.TabIndex = 2;
            this.description.TextChanged += new System.EventHandler(this.FieldChanged);
            this.description.Validating += new System.ComponentModel.CancelEventHandler(this.FieldValidating);
            // 
            // keywords
            // 
            this.keywords.Location = new System.Drawing.Point(118, 98);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(269, 20);
            this.keywords.TabIndex = 5;
            this.keywords.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // license
            // 
            this.license.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.license.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.license.FormattingEnabled = true;
            this.license.Items.AddRange(new object[] {
            "Apache-2.0",
            "BSD-2-Clause",
            "BSD-3-Clause",
            "BSD-4-Clause",
            "GPL-2.0-only",
            "GPL-2.0-or-later",
            "GPL-3.0-only",
            "GPL-3.0-or-later",
            "LGPL-2.1-only",
            "LGPL-2.1-or-later",
            "LGPL-3.0-only",
            "LGPL-3.0-or-later",
            "MIT",
            "proprietary"});
            this.license.Location = new System.Drawing.Point(118, 190);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(269, 21);
            this.license.TabIndex = 9;
            this.license.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // json
            // 
            this.json.Dock = System.Windows.Forms.DockStyle.Right;
            this.json.Location = new System.Drawing.Point(427, 0);
            this.json.Multiline = true;
            this.json.Name = "json";
            this.json.ReadOnly = true;
            this.json.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.json.Size = new System.Drawing.Size(314, 676);
            this.json.TabIndex = 0;
            this.json.WordWrap = false;
            this.json.Click += new System.EventHandler(this.SelectJson);
            this.json.Enter += new System.EventHandler(this.SelectJson);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "version";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "type";
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(118, 52);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(269, 20);
            this.version.TabIndex = 3;
            this.version.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "library",
            "project",
            "metapackage",
            "composer-plugin"});
            this.type.Location = new System.Drawing.Point(118, 75);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(269, 21);
            this.type.TabIndex = 4;
            this.type.Text = "library";
            this.type.TextChanged += new System.EventHandler(this.FieldChanged);
            this.type.Validating += new System.ComponentModel.CancelEventHandler(this.FieldValidating);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "homepage";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "readme";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "time";
            // 
            // homepage
            // 
            this.homepage.Location = new System.Drawing.Point(118, 121);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(269, 20);
            this.homepage.TabIndex = 6;
            this.homepage.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // readme
            // 
            this.readme.Location = new System.Drawing.Point(118, 144);
            this.readme.Name = "readme";
            this.readme.Size = new System.Drawing.Size(269, 20);
            this.readme.TabIndex = 7;
            this.readme.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "support";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "require-dev";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 24;
            this.label15.Text = "conflict";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 25;
            this.label16.Text = "replace";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 26;
            this.label17.Text = "provide";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(12, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 27;
            this.label18.Text = "suggest";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(12, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 28;
            this.label19.Text = "autoload-dev";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 446);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 29;
            this.label20.Text = "minimum-stability";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(12, 469);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 30;
            this.label21.Text = "prefer-stable";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(12, 492);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 31;
            this.label22.Text = "repositories";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(12, 515);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 32;
            this.label23.Text = "config";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(12, 538);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 33;
            this.label24.Text = "scripts";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(12, 561);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 34;
            this.label25.Text = "extra";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(12, 584);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 35;
            this.label26.Text = "bin";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(12, 607);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 36;
            this.label27.Text = "archive";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(12, 630);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 37;
            this.label28.Text = "abandoned";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(12, 653);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 38;
            this.label29.Text = "non-feature-branches";
            // 
            // minimum_stability
            // 
            this.minimum_stability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minimum_stability.FormattingEnabled = true;
            this.minimum_stability.Items.AddRange(new object[] {
            "dev",
            "alpha",
            "beta",
            "rc",
            "RC",
            "stable"});
            this.minimum_stability.Location = new System.Drawing.Point(118, 443);
            this.minimum_stability.Name = "minimum_stability";
            this.minimum_stability.Size = new System.Drawing.Size(269, 21);
            this.minimum_stability.TabIndex = 20;
            this.minimum_stability.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.minimum_stability.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(118, 167);
            this.time.Mask = "0000-00-00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(269, 20);
            this.time.TabIndex = 8;
            this.time.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // authors
            // 
            this.authors.Location = new System.Drawing.Point(118, 213);
            this.authors.Name = "authors";
            this.authors.ReadOnly = true;
            this.authors.Size = new System.Drawing.Size(269, 20);
            this.authors.TabIndex = 10;
            this.authors.TabStop = false;
            this.authors.Enter += new System.EventHandler(this.AuthorsEnter);
            // 
            // supports
            // 
            this.supports.Location = new System.Drawing.Point(118, 236);
            this.supports.Name = "supports";
            this.supports.ReadOnly = true;
            this.supports.Size = new System.Drawing.Size(269, 20);
            this.supports.TabIndex = 11;
            this.supports.TabStop = false;
            this.supports.Enter += new System.EventHandler(this.SupportsEnter);
            // 
            // require
            // 
            this.require.Location = new System.Drawing.Point(118, 259);
            this.require.Name = "require";
            this.require.ReadOnly = true;
            this.require.Size = new System.Drawing.Size(269, 20);
            this.require.TabIndex = 12;
            this.require.TabStop = false;
            this.require.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // require_dev
            // 
            this.require_dev.Location = new System.Drawing.Point(118, 282);
            this.require_dev.Name = "require_dev";
            this.require_dev.ReadOnly = true;
            this.require_dev.Size = new System.Drawing.Size(269, 20);
            this.require_dev.TabIndex = 13;
            this.require_dev.TabStop = false;
            this.require_dev.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // conflict
            // 
            this.conflict.Location = new System.Drawing.Point(118, 305);
            this.conflict.Name = "conflict";
            this.conflict.ReadOnly = true;
            this.conflict.Size = new System.Drawing.Size(269, 20);
            this.conflict.TabIndex = 14;
            this.conflict.TabStop = false;
            this.conflict.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(118, 328);
            this.replace.Name = "replace";
            this.replace.ReadOnly = true;
            this.replace.Size = new System.Drawing.Size(269, 20);
            this.replace.TabIndex = 15;
            this.replace.TabStop = false;
            this.replace.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // provide
            // 
            this.provide.Location = new System.Drawing.Point(118, 351);
            this.provide.Name = "provide";
            this.provide.ReadOnly = true;
            this.provide.Size = new System.Drawing.Size(269, 20);
            this.provide.TabIndex = 16;
            this.provide.TabStop = false;
            this.provide.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // suggest
            // 
            this.suggest.Location = new System.Drawing.Point(118, 374);
            this.suggest.Name = "suggest";
            this.suggest.ReadOnly = true;
            this.suggest.Size = new System.Drawing.Size(269, 20);
            this.suggest.TabIndex = 17;
            this.suggest.TabStop = false;
            this.suggest.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // autoload
            // 
            this.autoload.Location = new System.Drawing.Point(118, 397);
            this.autoload.Name = "autoload";
            this.autoload.ReadOnly = true;
            this.autoload.Size = new System.Drawing.Size(269, 20);
            this.autoload.TabIndex = 18;
            this.autoload.TabStop = false;
            this.autoload.Enter += new System.EventHandler(this.AutoloadEnter);
            // 
            // autoload_dev
            // 
            this.autoload_dev.Location = new System.Drawing.Point(118, 420);
            this.autoload_dev.Name = "autoload_dev";
            this.autoload_dev.ReadOnly = true;
            this.autoload_dev.Size = new System.Drawing.Size(269, 20);
            this.autoload_dev.TabIndex = 19;
            this.autoload_dev.TabStop = false;
            this.autoload_dev.Enter += new System.EventHandler(this.AutoloadEnter);
            // 
            // prefer_stable
            // 
            this.prefer_stable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prefer_stable.Location = new System.Drawing.Point(118, 464);
            this.prefer_stable.Name = "prefer_stable";
            this.prefer_stable.Size = new System.Drawing.Size(269, 24);
            this.prefer_stable.TabIndex = 21;
            this.prefer_stable.UseVisualStyleBackColor = true;
            this.prefer_stable.Click += new System.EventHandler(this.Prefer_stableClick);
            // 
            // abandoned
            // 
            this.abandoned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abandoned.Location = new System.Drawing.Point(118, 625);
            this.abandoned.Name = "abandoned";
            this.abandoned.Size = new System.Drawing.Size(269, 24);
            this.abandoned.TabIndex = 28;
            this.abandoned.UseVisualStyleBackColor = true;
            this.abandoned.Click += new System.EventHandler(this.AbandonedClick);
            // 
            // bin
            // 
            this.bin.Location = new System.Drawing.Point(118, 581);
            this.bin.Name = "bin";
            this.bin.ReadOnly = true;
            this.bin.Size = new System.Drawing.Size(269, 20);
            this.bin.TabIndex = 26;
            this.bin.TabStop = false;
            this.bin.Enter += new System.EventHandler(this.BinEnter);
            // 
            // repositories
            // 
            this.repositories.Location = new System.Drawing.Point(118, 489);
            this.repositories.Name = "repositories";
            this.repositories.Size = new System.Drawing.Size(269, 20);
            this.repositories.TabIndex = 22;
            this.repositories.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(118, 512);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(269, 20);
            this.config.TabIndex = 23;
            this.config.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // scripts
            // 
            this.scripts.Location = new System.Drawing.Point(118, 535);
            this.scripts.Name = "scripts";
            this.scripts.ReadOnly = true;
            this.scripts.Size = new System.Drawing.Size(269, 20);
            this.scripts.TabIndex = 24;
            this.scripts.TabStop = false;
            this.scripts.Enter += new System.EventHandler(this.ScriptsEnter);
            // 
            // extra
            // 
            this.extra.Location = new System.Drawing.Point(118, 558);
            this.extra.Name = "extra";
            this.extra.ReadOnly = true;
            this.extra.Size = new System.Drawing.Size(269, 20);
            this.extra.TabIndex = 25;
            this.extra.TabStop = false;
            this.extra.Enter += new System.EventHandler(this.DictFieldEnter);
            // 
            // archive
            // 
            this.archive.Location = new System.Drawing.Point(118, 604);
            this.archive.Name = "archive";
            this.archive.ReadOnly = true;
            this.archive.Size = new System.Drawing.Size(269, 20);
            this.archive.TabIndex = 27;
            this.archive.TabStop = false;
            this.archive.Enter += new System.EventHandler(this.ArchiveEnter);
            // 
            // non_feature_branches
            // 
            this.non_feature_branches.Location = new System.Drawing.Point(118, 650);
            this.non_feature_branches.Name = "non_feature_branches";
            this.non_feature_branches.ReadOnly = true;
            this.non_feature_branches.Size = new System.Drawing.Size(269, 20);
            this.non_feature_branches.TabIndex = 29;
            this.non_feature_branches.TabStop = false;
            this.non_feature_branches.Enter += new System.EventHandler(this.Non_feature_branchesEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(758, 461);
            this.Controls.Add(this.non_feature_branches);
            this.Controls.Add(this.archive);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.scripts);
            this.Controls.Add(this.config);
            this.Controls.Add(this.repositories);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.abandoned);
            this.Controls.Add(this.prefer_stable);
            this.Controls.Add(this.autoload_dev);
            this.Controls.Add(this.autoload);
            this.Controls.Add(this.suggest);
            this.Controls.Add(this.provide);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.conflict);
            this.Controls.Add(this.require_dev);
            this.Controls.Add(this.require);
            this.Controls.Add(this.supports);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.time);
            this.Controls.Add(this.minimum_stability);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.readme);
            this.Controls.Add(this.homepage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.type);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.json);
            this.Controls.Add(this.license);
            this.Controls.Add(this.keywords);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CJGui";
            this.Load += new System.EventHandler(this.FieldChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
