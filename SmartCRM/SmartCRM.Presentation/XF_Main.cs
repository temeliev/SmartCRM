namespace SmartCRM.Presentation
{
    using DevExpress.XtraEditors;

    public partial class XF_Main : XtraForm
    {
        public XF_Main()
        {
            this.InitializeComponent();
            this.Load += this.XF_Main_Load;
            this.btnCreateEditFirm.Click += this.btnCreateEditFirm_Click;
            this.btnCustomers.Click += this.btnCustomers_Click;
            this.btnEmployees.Click += this.btnEmployees_Click;
            this.btnFirmInfo.Click += this.btnFirmInfo_Click;
            this.btnSales.Click += this.btnSales_Click;
        }

        void XF_Main_Load(object sender, System.EventArgs e)
        {

        }

        void btnSales_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void btnFirmInfo_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void btnEmployees_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void btnCustomers_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void btnCreateEditFirm_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }       
    }
}
