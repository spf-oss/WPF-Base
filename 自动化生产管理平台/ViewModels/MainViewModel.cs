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
        public List<MonitorItemModel> Evironment { get; set; }

        public List<AlarmItemModel> AlarmItemModels { get; set; }

        public object? PageContent { get => _pageContent; set => SetProperty(ref _pageContent, value); }
        public string Total { get => _total; set => SetProperty(ref _total, value); }
        public string ProductionCount { get => _productionCount; set => SetProperty(ref _productionCount, value); }
        public string BadCount { get => _badCount; set => SetProperty(ref _badCount, value); }

        public MainViewModel()
        {
            this.Total = 197.ToString("0000");

            this.BadCount = 111.ToString("000");

            this.ProductionCount = 1998.ToString("0000");

            #region 初始化环境集合
            this.Evironment = new();
            this.Evironment.Add(new MonitorItemModel() { Header = "光照（Lux）" });
            this.Evironment.Add(new MonitorItemModel() { Header = "噪音（db）" });
            this.Evironment.Add(new MonitorItemModel() { Header = "温度（℃）" });
            this.Evironment.Add(new MonitorItemModel() { Header = "湿度" });
            this.Evironment.Add(new MonitorItemModel() { Header = "PM2.5" });
            this.Evironment.Add(new MonitorItemModel() { Header = "硫化氢（ppm）" });
            this.Evironment.Add(new MonitorItemModel() { Header = "氮气（ppm）" });
            #endregion

            #region 初始化报警记录集合
            this.AlarmItemModels = new();
            this.AlarmItemModels.Add(
                new AlarmItemModel()
                {
                    Len = 1,
                    Message = "我现在好烦",
                    Num = "2",
                    Time = DateTime.Now.ToString("yyyy/MM/dd")
                });
            this.AlarmItemModels.Add(
                new AlarmItemModel()
                {
                    Len = 1,
                    Message = "我现在好烦",
                    Num = "2",
                    Time = DateTime.Now.ToString("yyyy/MM/dd")
                });
            this.AlarmItemModels.Add(
                new AlarmItemModel()
                {
                    Len = 1,
                    Message = "我现在好烦",
                    Num = "2",
                    Time = DateTime.Now.ToString("yyyy/MM/dd")
                }); 
            #endregion
        }
    }
}
