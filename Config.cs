/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 15.11.2018
 * Time: 16:21
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
    /// Description of Config.
    /// </summary>
    public class Config
    {
        public enum BinCompat : byte { auto, fill };
        
        public int process_timeout;
        public bool use_include_path;
        public StrObj preferred_install;
        public bool notify_on_install;
        public List<string> github_protocols;
        public Dictionary<string, string> github_oauth;
        public Dictionary<string, string> gitlab_oauth;
        public Dictionary<string, string> gitlab_token;
        public bool disable_tls;
        public bool secure_http;
        public string cafile;
        public string capath;
        public ConfigHttpBasic http_basic;
        public StrBool store_auths;
        public Dictionary<string, string> platform;
        public string vendor_dir;
        public string bin_dir;
        public string data_dir;
        public string cache_dir;
        public string cache_files_dir;
        public string cache_repo_dir;
        public string cache_vcs_dir;
        public int cache_ttl;
        public int cache_files_ttl;
        public string cache_files_maxsize;
        public BinCompat bin_compat;
        public StrBool discard_changes;
        public string autoloader_suffix;
        public bool optimize_autoloader;
        public bool prepend_autoloader;
        public bool classmap_authoritative;
        public bool apcu_autoloader;
        public List<string> github_domains;
        public bool github_expose_hostname;
        public List<string> gitlab_domains;
        public string archive_format;
        public string archive_dir;
        public bool htaccess_protect;
        public bool sort_packages;
        
        public void SetDefaults()
        {
            process_timeout = 300;
            use_include_path = false;
            notify_on_install = true;
            disable_tls = false;
            secure_http = true;
            cafile = "";
            capath = "";
            store_auths = new StrBool("prompt");
            vendor_dir = "vendor";
            bin_dir = "vendor/bin";
            data_dir = "$home";
            cache_dir = "%LOCALAPPDATA%\\Composer"; // ~/.composer/cache - for *nix 
            cache_files_dir = "{$cache-dir}/files";
            cache_repo_dir = "{$cache-dir}/repo";
            cache_vcs_dir = "{$cache-dir}/vcs";
            cache_ttl = 15552000;
            cache_files_ttl = cache_ttl;
            cache_files_maxsize = "300MiB";
            bin_compat = BinCompat.auto;
            discard_changes = new StrBool(false);
            autoloader_suffix = "";
            optimize_autoloader = true;
            prepend_autoloader = true;
            classmap_authoritative = false;
            apcu_autoloader = false;
            github_expose_hostname = true;
            archive_format = "tar";
            archive_dir = ".";
            htaccess_protect = true;
            sort_packages = false;
        }
        
        public Config()
        {
            preferred_install = new StrObj();
            github_protocols = new List<string>();
            github_oauth = new Dictionary<string, string>();
            gitlab_oauth = new Dictionary<string, string>();
            gitlab_token = new Dictionary<string, string>();
            http_basic = new ConfigHttpBasic();
            platform = new Dictionary<string, string>();
            github_domains = new List<string>();
            gitlab_domains = new List<string>();
        }
    }
}
