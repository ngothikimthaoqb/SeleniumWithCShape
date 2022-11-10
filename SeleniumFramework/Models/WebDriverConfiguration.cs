using SeleniumFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Models
{
    public class WebDriverConfiguration
    {
        public BrowserName BrowserName { get; set; }
        public string ScreenshotsPath { get; set; }
        public int DefaultTimeout { get; set; }
        public string BrowserLanguage { get; set; }
    }
}
