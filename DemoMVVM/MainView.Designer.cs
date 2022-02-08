namespace DemoMVVM {
    partial class MainView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.simpleButtonConvert = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditJSON = new DevExpress.XtraEditors.MemoEdit();
            this.textEditWebsiteUrl = new DevExpress.XtraEditors.TextEdit();
            this.textEditWebsiteName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemWebsiteName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemControls = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemWebsiteUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemJSON = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemConvert = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemButton = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditJSON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWebsiteUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWebsiteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWebsiteName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWebsiteUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.simpleButtonConvert);
            this.dataLayoutControl.Controls.Add(this.memoEditJSON);
            this.dataLayoutControl.Controls.Add(this.textEditWebsiteUrl);
            this.dataLayoutControl.Controls.Add(this.textEditWebsiteName);
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(875, 111, 650, 400);
            this.dataLayoutControl.Root = this.layoutControlGroup;
            this.dataLayoutControl.Size = new System.Drawing.Size(596, 314);
            this.dataLayoutControl.TabIndex = 0;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // simpleButtonConvert
            // 
            this.simpleButtonConvert.Location = new System.Drawing.Point(299, 280);
            this.simpleButtonConvert.Name = "simpleButtonConvert";
            this.simpleButtonConvert.Size = new System.Drawing.Size(285, 22);
            this.simpleButtonConvert.StyleController = this.dataLayoutControl;
            this.simpleButtonConvert.TabIndex = 7;
            this.simpleButtonConvert.Text = "Show JSON";
            // 
            // memoEditJSON
            // 
            this.memoEditJSON.Location = new System.Drawing.Point(93, 60);
            this.memoEditJSON.Name = "memoEditJSON";
            this.memoEditJSON.Properties.ReadOnly = true;
            this.memoEditJSON.Size = new System.Drawing.Size(491, 186);
            this.memoEditJSON.StyleController = this.dataLayoutControl;
            this.memoEditJSON.TabIndex = 6;
            // 
            // textEditWebsiteUrl
            // 
            this.textEditWebsiteUrl.Location = new System.Drawing.Point(93, 36);
            this.textEditWebsiteUrl.Name = "textEditWebsiteUrl";
            this.textEditWebsiteUrl.Size = new System.Drawing.Size(491, 20);
            this.textEditWebsiteUrl.StyleController = this.dataLayoutControl;
            this.textEditWebsiteUrl.TabIndex = 5;
            // 
            // textEditWebsiteName
            // 
            this.textEditWebsiteName.Location = new System.Drawing.Point(93, 12);
            this.textEditWebsiteName.Name = "textEditWebsiteName";
            this.textEditWebsiteName.Size = new System.Drawing.Size(491, 20);
            this.textEditWebsiteName.StyleController = this.dataLayoutControl;
            this.textEditWebsiteName.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemWebsiteName,
            this.emptySpaceItemControls,
            this.layoutControlItemWebsiteUrl,
            this.layoutControlItemJSON,
            this.layoutControlItemConvert,
            this.emptySpaceItemButton});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(596, 314);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItemWebsiteName
            // 
            this.layoutControlItemWebsiteName.Control = this.textEditWebsiteName;
            this.layoutControlItemWebsiteName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemWebsiteName.Name = "layoutControlItemWebsiteName";
            this.layoutControlItemWebsiteName.Size = new System.Drawing.Size(576, 24);
            this.layoutControlItemWebsiteName.Text = "Website Name";
            this.layoutControlItemWebsiteName.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItemControls
            // 
            this.emptySpaceItemControls.AllowHotTrack = false;
            this.emptySpaceItemControls.Location = new System.Drawing.Point(0, 238);
            this.emptySpaceItemControls.Name = "emptySpaceItemControls";
            this.emptySpaceItemControls.Size = new System.Drawing.Size(576, 30);
            this.emptySpaceItemControls.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemWebsiteUrl
            // 
            this.layoutControlItemWebsiteUrl.Control = this.textEditWebsiteUrl;
            this.layoutControlItemWebsiteUrl.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemWebsiteUrl.Name = "layoutControlItemWebsiteUrl";
            this.layoutControlItemWebsiteUrl.Size = new System.Drawing.Size(576, 24);
            this.layoutControlItemWebsiteUrl.Text = "Website Url";
            this.layoutControlItemWebsiteUrl.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemJSON
            // 
            this.layoutControlItemJSON.Control = this.memoEditJSON;
            this.layoutControlItemJSON.CustomizationFormText = "JSON";
            this.layoutControlItemJSON.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemJSON.Name = "layoutControlItemJSON";
            this.layoutControlItemJSON.Size = new System.Drawing.Size(576, 190);
            this.layoutControlItemJSON.Text = "JSON";
            this.layoutControlItemJSON.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemConvert
            // 
            this.layoutControlItemConvert.Control = this.simpleButtonConvert;
            this.layoutControlItemConvert.Location = new System.Drawing.Point(287, 268);
            this.layoutControlItemConvert.Name = "layoutControlItemConvert";
            this.layoutControlItemConvert.Size = new System.Drawing.Size(289, 26);
            this.layoutControlItemConvert.Text = "Convert";
            this.layoutControlItemConvert.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemConvert.TextVisible = false;
            // 
            // emptySpaceItemButton
            // 
            this.emptySpaceItemButton.AllowHotTrack = false;
            this.emptySpaceItemButton.Location = new System.Drawing.Point(0, 268);
            this.emptySpaceItemButton.Name = "emptySpaceItemButton";
            this.emptySpaceItemButton.Size = new System.Drawing.Size(287, 26);
            this.emptySpaceItemButton.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(DemoMVVM.MainViewModel), "WebsiteName", this.textEditWebsiteName, "Text")});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DemoMVVM.MainViewModel);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 314);
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditJSON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWebsiteUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWebsiteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWebsiteName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWebsiteUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemJSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraEditors.MemoEdit memoEditJSON;
        private DevExpress.XtraEditors.TextEdit textEditWebsiteUrl;
        private DevExpress.XtraEditors.TextEdit textEditWebsiteName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemWebsiteName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemControls;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemWebsiteUrl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemJSON;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConvert;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemConvert;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemButton;
    }
}

