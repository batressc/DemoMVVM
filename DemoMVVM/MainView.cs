using DevExpress.Utils.MVVM;

namespace DemoMVVM {
    public partial class MainView : DevExpress.XtraEditors.XtraForm {
        public MainView() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) InitializeBindings();
        }

        private void InitializeBindings() {
            MVVMContextFluentAPI<MainViewModel> fluent = mvvmContext.OfType<MainViewModel>();
            fluent.SetBinding(textEditWebsiteName, x => x.Text, x => x.WebsiteName);
            fluent.SetBinding(textEditWebsiteUrl, x => x.Text, x => x.WebsiteUrl);
            fluent.SetBinding(memoEditJSON, x => x.Text, x => x.JSONData);
            fluent.BindCommand(simpleButtonConvert, x => x.ConvertInputToJSON());
        }
    }
}
