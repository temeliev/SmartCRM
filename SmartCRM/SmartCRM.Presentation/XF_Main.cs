namespace SmartCRM.Presentation
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraEditors;

    public partial class XF_Main : RibbonForm
    {
        public XF_Main()
        {
            this.InitializeComponent();
            this.Load += this.XF_Main_Load;
        }

        void XF_Main_Load(object sender, System.EventArgs e)
        {

        }

         
    }
}
