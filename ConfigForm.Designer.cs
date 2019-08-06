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
namespace CJGui
{
    partial class ConfigForm
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown process_timeout;
        private System.Windows.Forms.CheckBox use_include_path;
        private System.Windows.Forms.CheckBox notify_on_install;
        private System.Windows.Forms.CheckBox disable_tls;
        private System.Windows.Forms.CheckBox secure_http;
        private System.Windows.Forms.TextBox cafile;
        private System.Windows.Forms.TextBox capath;
        private System.Windows.Forms.TextBox vendor_dir;
        private System.Windows.Forms.TextBox bin_dir;
        private System.Windows.Forms.TextBox data_dir;
        private System.Windows.Forms.TextBox cache_dir;
        private System.Windows.Forms.TextBox cache_files_dir;
        private System.Windows.Forms.TextBox cache_repo_dir;
        private System.Windows.Forms.TextBox cache_vcs_dir;
        private System.Windows.Forms.NumericUpDown cache_ttl;
        private System.Windows.Forms.NumericUpDown cache_files_ttl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cache_files_maxsize;
        private System.Windows.Forms.TextBox autoloader_suffix;
        private System.Windows.Forms.CheckBox optimize_autoloader;
        private System.Windows.Forms.CheckBox prepend_autoloader;
        private System.Windows.Forms.CheckBox classmap_authoritative;
        private System.Windows.Forms.CheckBox apcu_autoloader;
        private System.Windows.Forms.CheckBox github_expose_hostname;
        private System.Windows.Forms.TextBox archive_format;
        private System.Windows.Forms.TextBox archive_dir;
        private System.Windows.Forms.CheckBox htaccess_protect;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox sort_packages;
        private System.Windows.Forms.Button close;
        
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.process_timeout = new System.Windows.Forms.NumericUpDown();
            this.use_include_path = new System.Windows.Forms.CheckBox();
            this.notify_on_install = new System.Windows.Forms.CheckBox();
            this.disable_tls = new System.Windows.Forms.CheckBox();
            this.secure_http = new System.Windows.Forms.CheckBox();
            this.cafile = new System.Windows.Forms.TextBox();
            this.capath = new System.Windows.Forms.TextBox();
            this.vendor_dir = new System.Windows.Forms.TextBox();
            this.bin_dir = new System.Windows.Forms.TextBox();
            this.data_dir = new System.Windows.Forms.TextBox();
            this.cache_dir = new System.Windows.Forms.TextBox();
            this.cache_files_dir = new System.Windows.Forms.TextBox();
            this.cache_repo_dir = new System.Windows.Forms.TextBox();
            this.cache_vcs_dir = new System.Windows.Forms.TextBox();
            this.cache_ttl = new System.Windows.Forms.NumericUpDown();
            this.cache_files_ttl = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cache_files_maxsize = new System.Windows.Forms.TextBox();
            this.autoloader_suffix = new System.Windows.Forms.TextBox();
            this.optimize_autoloader = new System.Windows.Forms.CheckBox();
            this.prepend_autoloader = new System.Windows.Forms.CheckBox();
            this.classmap_authoritative = new System.Windows.Forms.CheckBox();
            this.apcu_autoloader = new System.Windows.Forms.CheckBox();
            this.github_expose_hostname = new System.Windows.Forms.CheckBox();
            this.archive_format = new System.Windows.Forms.TextBox();
            this.archive_dir = new System.Windows.Forms.TextBox();
            this.htaccess_protect = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.sort_packages = new System.Windows.Forms.CheckBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.process_timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cache_ttl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cache_files_ttl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "process-timeout";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "use-include-path";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "preferred-install";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "notify-on-install";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "github-protocols";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "github-oauth";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "gitlab-oauth";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "gitlab-token";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "disable-tls";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "secure-http";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "cafile";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "capath";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "http-basic";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "platform";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "vendor-dir";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "bin-dir";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(12, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 17;
            this.label18.Text = "data-dir";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(12, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "cache-dir";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 423);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 19;
            this.label20.Text = "cache-files-dir";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(257, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 23);
            this.label21.TabIndex = 20;
            this.label21.Text = "cache-repo-dir";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(257, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 23);
            this.label22.TabIndex = 21;
            this.label22.Text = "cache-vcs-dir";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(257, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 23);
            this.label23.TabIndex = 22;
            this.label23.Text = "cache-ttl";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(257, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 23);
            this.label24.TabIndex = 23;
            this.label24.Text = "cache-files-maxsize";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(257, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 23);
            this.label25.TabIndex = 24;
            this.label25.Text = "bin-compat";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(257, 147);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(115, 23);
            this.label26.TabIndex = 25;
            this.label26.Text = "prepend-autoloader";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(257, 170);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 23);
            this.label27.TabIndex = 26;
            this.label27.Text = "autoloader-suffix";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(257, 193);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(115, 23);
            this.label28.TabIndex = 27;
            this.label28.Text = "optimize-autoloader";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(257, 216);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 23);
            this.label29.TabIndex = 28;
            this.label29.Text = "prepend-autoloader";
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(257, 239);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(115, 23);
            this.label30.TabIndex = 29;
            this.label30.Text = "classmap-authoritative";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(257, 262);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 23);
            this.label31.TabIndex = 30;
            this.label31.Text = "apcu-autoloader";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(257, 285);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(115, 23);
            this.label32.TabIndex = 31;
            this.label32.Text = "github-domains";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(257, 308);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 23);
            this.label33.TabIndex = 32;
            this.label33.Text = "gh-expose-hostname";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(257, 331);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(115, 23);
            this.label37.TabIndex = 36;
            this.label37.Text = "archive-format";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(257, 354);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(115, 23);
            this.label38.TabIndex = 37;
            this.label38.Text = "archive-dir";
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(257, 377);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(115, 23);
            this.label39.TabIndex = 38;
            this.label39.Text = "htaccess-protect";
            // 
            // process_timeout
            // 
            this.process_timeout.Location = new System.Drawing.Point(118, 7);
            this.process_timeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.process_timeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.process_timeout.Name = "process_timeout";
            this.process_timeout.Size = new System.Drawing.Size(120, 20);
            this.process_timeout.TabIndex = 39;
            this.process_timeout.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // use_include_path
            // 
            this.use_include_path.Location = new System.Drawing.Point(118, 27);
            this.use_include_path.Name = "use_include_path";
            this.use_include_path.Size = new System.Drawing.Size(120, 24);
            this.use_include_path.TabIndex = 40;
            this.use_include_path.UseVisualStyleBackColor = true;
            // 
            // notify_on_install
            // 
            this.notify_on_install.Checked = true;
            this.notify_on_install.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notify_on_install.Location = new System.Drawing.Point(118, 73);
            this.notify_on_install.Name = "notify_on_install";
            this.notify_on_install.Size = new System.Drawing.Size(120, 24);
            this.notify_on_install.TabIndex = 41;
            this.notify_on_install.UseVisualStyleBackColor = true;
            // 
            // disable_tls
            // 
            this.disable_tls.Location = new System.Drawing.Point(118, 188);
            this.disable_tls.Name = "disable_tls";
            this.disable_tls.Size = new System.Drawing.Size(120, 24);
            this.disable_tls.TabIndex = 42;
            this.disable_tls.UseVisualStyleBackColor = true;
            // 
            // secure_http
            // 
            this.secure_http.Checked = true;
            this.secure_http.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secure_http.Location = new System.Drawing.Point(118, 211);
            this.secure_http.Name = "secure_http";
            this.secure_http.Size = new System.Drawing.Size(120, 24);
            this.secure_http.TabIndex = 43;
            this.secure_http.UseVisualStyleBackColor = true;
            // 
            // cafile
            // 
            this.cafile.Location = new System.Drawing.Point(118, 236);
            this.cafile.Name = "cafile";
            this.cafile.Size = new System.Drawing.Size(120, 20);
            this.cafile.TabIndex = 44;
            // 
            // capath
            // 
            this.capath.Location = new System.Drawing.Point(118, 259);
            this.capath.Name = "capath";
            this.capath.Size = new System.Drawing.Size(120, 20);
            this.capath.TabIndex = 45;
            // 
            // vendor_dir
            // 
            this.vendor_dir.Location = new System.Drawing.Point(118, 328);
            this.vendor_dir.Name = "vendor_dir";
            this.vendor_dir.Size = new System.Drawing.Size(120, 20);
            this.vendor_dir.TabIndex = 46;
            // 
            // bin_dir
            // 
            this.bin_dir.Location = new System.Drawing.Point(118, 351);
            this.bin_dir.Name = "bin_dir";
            this.bin_dir.Size = new System.Drawing.Size(120, 20);
            this.bin_dir.TabIndex = 47;
            // 
            // data_dir
            // 
            this.data_dir.Location = new System.Drawing.Point(118, 374);
            this.data_dir.Name = "data_dir";
            this.data_dir.Size = new System.Drawing.Size(120, 20);
            this.data_dir.TabIndex = 48;
            // 
            // cache_dir
            // 
            this.cache_dir.Location = new System.Drawing.Point(118, 397);
            this.cache_dir.Name = "cache_dir";
            this.cache_dir.Size = new System.Drawing.Size(120, 20);
            this.cache_dir.TabIndex = 49;
            // 
            // cache_files_dir
            // 
            this.cache_files_dir.Location = new System.Drawing.Point(118, 420);
            this.cache_files_dir.Name = "cache_files_dir";
            this.cache_files_dir.Size = new System.Drawing.Size(120, 20);
            this.cache_files_dir.TabIndex = 50;
            // 
            // cache_repo_dir
            // 
            this.cache_repo_dir.Location = new System.Drawing.Point(378, 6);
            this.cache_repo_dir.Name = "cache_repo_dir";
            this.cache_repo_dir.Size = new System.Drawing.Size(114, 20);
            this.cache_repo_dir.TabIndex = 51;
            // 
            // cache_vcs_dir
            // 
            this.cache_vcs_dir.Location = new System.Drawing.Point(378, 29);
            this.cache_vcs_dir.Name = "cache_vcs_dir";
            this.cache_vcs_dir.Size = new System.Drawing.Size(114, 20);
            this.cache_vcs_dir.TabIndex = 52;
            // 
            // cache_ttl
            // 
            this.cache_ttl.Location = new System.Drawing.Point(378, 53);
            this.cache_ttl.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.cache_ttl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cache_ttl.Name = "cache_ttl";
            this.cache_ttl.Size = new System.Drawing.Size(114, 20);
            this.cache_ttl.TabIndex = 53;
            this.cache_ttl.Value = new decimal(new int[] {
            15552000,
            0,
            0,
            0});
            // 
            // cache_files_ttl
            // 
            this.cache_files_ttl.Location = new System.Drawing.Point(378, 76);
            this.cache_files_ttl.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.cache_files_ttl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cache_files_ttl.Name = "cache_files_ttl";
            this.cache_files_ttl.Size = new System.Drawing.Size(114, 20);
            this.cache_files_ttl.TabIndex = 54;
            this.cache_files_ttl.Value = new decimal(new int[] {
            15552000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(257, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "cache-files-ttl";
            // 
            // cache_files_maxsize
            // 
            this.cache_files_maxsize.Location = new System.Drawing.Point(378, 98);
            this.cache_files_maxsize.Name = "cache_files_maxsize";
            this.cache_files_maxsize.Size = new System.Drawing.Size(114, 20);
            this.cache_files_maxsize.TabIndex = 56;
            this.cache_files_maxsize.Text = "300MiB";
            // 
            // autoloader_suffix
            // 
            this.autoloader_suffix.Location = new System.Drawing.Point(378, 167);
            this.autoloader_suffix.Name = "autoloader_suffix";
            this.autoloader_suffix.Size = new System.Drawing.Size(114, 20);
            this.autoloader_suffix.TabIndex = 57;
            // 
            // optimize_autoloader
            // 
            this.optimize_autoloader.Checked = true;
            this.optimize_autoloader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optimize_autoloader.Location = new System.Drawing.Point(378, 188);
            this.optimize_autoloader.Name = "optimize_autoloader";
            this.optimize_autoloader.Size = new System.Drawing.Size(114, 24);
            this.optimize_autoloader.TabIndex = 58;
            this.optimize_autoloader.UseVisualStyleBackColor = true;
            // 
            // prepend_autoloader
            // 
            this.prepend_autoloader.Checked = true;
            this.prepend_autoloader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prepend_autoloader.Location = new System.Drawing.Point(378, 211);
            this.prepend_autoloader.Name = "prepend_autoloader";
            this.prepend_autoloader.Size = new System.Drawing.Size(114, 24);
            this.prepend_autoloader.TabIndex = 59;
            this.prepend_autoloader.UseVisualStyleBackColor = true;
            // 
            // classmap_authoritative
            // 
            this.classmap_authoritative.Location = new System.Drawing.Point(378, 234);
            this.classmap_authoritative.Name = "classmap_authoritative";
            this.classmap_authoritative.Size = new System.Drawing.Size(114, 24);
            this.classmap_authoritative.TabIndex = 60;
            this.classmap_authoritative.UseVisualStyleBackColor = true;
            // 
            // apcu_autoloader
            // 
            this.apcu_autoloader.Location = new System.Drawing.Point(378, 257);
            this.apcu_autoloader.Name = "apcu_autoloader";
            this.apcu_autoloader.Size = new System.Drawing.Size(114, 24);
            this.apcu_autoloader.TabIndex = 61;
            this.apcu_autoloader.UseVisualStyleBackColor = true;
            // 
            // github_expose_hostname
            // 
            this.github_expose_hostname.Checked = true;
            this.github_expose_hostname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.github_expose_hostname.Location = new System.Drawing.Point(378, 303);
            this.github_expose_hostname.Name = "github_expose_hostname";
            this.github_expose_hostname.Size = new System.Drawing.Size(114, 24);
            this.github_expose_hostname.TabIndex = 62;
            this.github_expose_hostname.UseVisualStyleBackColor = true;
            // 
            // archive_format
            // 
            this.archive_format.Location = new System.Drawing.Point(378, 328);
            this.archive_format.Name = "archive_format";
            this.archive_format.Size = new System.Drawing.Size(114, 20);
            this.archive_format.TabIndex = 63;
            this.archive_format.Text = "tar";
            // 
            // archive_dir
            // 
            this.archive_dir.Location = new System.Drawing.Point(378, 351);
            this.archive_dir.Name = "archive_dir";
            this.archive_dir.Size = new System.Drawing.Size(114, 20);
            this.archive_dir.TabIndex = 64;
            this.archive_dir.Text = ".";
            // 
            // htaccess_protect
            // 
            this.htaccess_protect.Checked = true;
            this.htaccess_protect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htaccess_protect.Location = new System.Drawing.Point(378, 372);
            this.htaccess_protect.Name = "htaccess_protect";
            this.htaccess_protect.Size = new System.Drawing.Size(114, 24);
            this.htaccess_protect.TabIndex = 65;
            this.htaccess_protect.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(257, 400);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 23);
            this.label34.TabIndex = 66;
            this.label34.Text = "sort-packages";
            // 
            // sort_packages
            // 
            this.sort_packages.Location = new System.Drawing.Point(378, 395);
            this.sort_packages.Name = "sort_packages";
            this.sort_packages.Size = new System.Drawing.Size(114, 24);
            this.sort_packages.TabIndex = 67;
            this.sort_packages.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(12, 466);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(480, 23);
            this.close.TabIndex = 68;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.CloseClick);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(504, 501);
            this.Controls.Add(this.close);
            this.Controls.Add(this.sort_packages);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.htaccess_protect);
            this.Controls.Add(this.archive_dir);
            this.Controls.Add(this.archive_format);
            this.Controls.Add(this.github_expose_hostname);
            this.Controls.Add(this.apcu_autoloader);
            this.Controls.Add(this.classmap_authoritative);
            this.Controls.Add(this.prepend_autoloader);
            this.Controls.Add(this.optimize_autoloader);
            this.Controls.Add(this.autoloader_suffix);
            this.Controls.Add(this.cache_files_maxsize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cache_files_ttl);
            this.Controls.Add(this.cache_ttl);
            this.Controls.Add(this.cache_vcs_dir);
            this.Controls.Add(this.cache_repo_dir);
            this.Controls.Add(this.cache_files_dir);
            this.Controls.Add(this.cache_dir);
            this.Controls.Add(this.data_dir);
            this.Controls.Add(this.bin_dir);
            this.Controls.Add(this.vendor_dir);
            this.Controls.Add(this.capath);
            this.Controls.Add(this.cafile);
            this.Controls.Add(this.secure_http);
            this.Controls.Add(this.disable_tls);
            this.Controls.Add(this.notify_on_install);
            this.Controls.Add(this.use_include_path);
            this.Controls.Add(this.process_timeout);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Config";
            ((System.ComponentModel.ISupportInitialize)(this.process_timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cache_ttl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cache_files_ttl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
