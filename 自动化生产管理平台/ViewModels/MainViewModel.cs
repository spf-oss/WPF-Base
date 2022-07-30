using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动化生产管理平台
{
    internal class MainViewModel : NotifyPropertyChanged
    {
        private object? _pageContent;
        private string _total = String.Empty;
        private string _productionCount = String.Empty;
        private string _badCount = String.Empty;

        public object? PageContent { get => _pageContent; set => SetProperty(ref _pageContent, value); }
        public string Total { get => _total; set => SetProperty(ref _total, value); }
        public string ProductionCount { get => _productionCount; set => SetProperty(ref _productionCount, value); }
        public string BadCount { get => _badCount; set => SetProperty(ref _badCount, value); }

        public MainViewModel()
        {
            this.Total = 197.ToString("0000");

            this.BadCount = 111.ToString("000");

            this.ProductionCount = 1998.ToString("0000");
        }
    }
}
