using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace DemoMVVM {
    [POCOViewModel()]
    public class MainViewModel {
        public MainViewModel(IConfiguration configuration) {
            WebsiteName = configuration.GetValue<string>("WebsiteMetadata:Name");
            WebsiteUrl = configuration.GetValue<string>("WebsiteMetadata:Url");
        }

        public virtual string WebsiteName { get; set; }
        public virtual string WebsiteUrl { get; set; }
        public virtual string JSONData { get; set; }

        public void ConvertInputToJSON() {
            JSONData = JsonConvert.SerializeObject(new { WebsiteName, WebsiteUrl }, Formatting.Indented);
            this.RaisePropertyChanged(x => x.JSONData);
        }
    }
}
