namespace SmartCRM.Presentation
{
    using DevExpress.XtraEditors;

    public partial class XF_Login : XtraForm
    {
        public XF_Login()
        {
            this.InitializeComponent();
            this.btnEnter.Click += this.btnEnter_Click;
        }

        void btnEnter_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
