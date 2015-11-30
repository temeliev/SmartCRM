namespace SmartCRM.Presentation.Projects
{
    using System.Windows.Forms;

    using SmartCRM.BOL.Controllers;

    public partial class UC_ProjectCategories : UserControl
    {
        private ProjectDataController controller;

        public UC_ProjectCategories()
        {
            this.InitializeComponent();
            this.Load += this.UC_ProjectCategories_Load;
        }

        void UC_ProjectCategories_Load(object sender, System.EventArgs e)
        {
            this.controller.SetProjectCategories();
            this.gridControlProjectCategories.DataSource = this.controller.ProjectCategories;
        }

        public static UC_ProjectCategories GetUserControl(ProjectDataController projectController)
        {
            UC_ProjectCategories uc = new UC_ProjectCategories();
            uc.controller = projectController;
            return uc;
        }
    }
}
