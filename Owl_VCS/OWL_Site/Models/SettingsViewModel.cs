﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OWL_Site.Models
{
    public class SettingsViewModel
    {
        public int Id { get; set; }
        public string AuthDnAddress { get; set; }
        public string OU { get; set; }
        public string UserGroup { get; set; }
        public string AdminGroup { get; set; }
        public string DnAdminUn { get; set; }
        public string DnAdminPass { get; set; }
        public string CobaMngAddress { get; set; }
        public string CobaCfgAddress { get; set; }
        public string CobaRecordsAddress { get; set; }
        public string CobaRecLogin { get; set; }
        public string CobaRecPass { get; set; }
        public string CobaRecBdName { get; set; }
        public string CobaRecBdTable { get; set; }
        public string SmtpServer { get; set; }
        public Nullable<int> SmtpPort { get; set; }
        public bool SmtpSSL { get; set; }
        public string SmtpLogin { get; set; }
        public string SmtpPassword { get; set; }
        public string MailFrom_email { get; set; }
        public string MailFrom_name { get; set; }
        public string CobaMngLogin { get; set; }
        public string CobaMngPass { get; set; }
    }
}