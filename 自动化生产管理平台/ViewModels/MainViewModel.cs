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

        public object? PageContent { get => _pageContent; set => SetProperty(ref _pageContent, value); }

        public MainViewModel()
        {

        }
    }
}
