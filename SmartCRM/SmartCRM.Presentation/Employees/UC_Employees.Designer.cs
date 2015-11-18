namespace SmartCRM.Presentation.Employees
{
    partial class UC_Employees
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkAllEmployees = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlEmployees = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewEmployees = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBandPhoto = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bGridColPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBandNameAndEmail = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColEmployeeId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandAddress = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandBirthdayAndGender = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bGridColBirthday = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bGridGender = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandPhoneAndEmail = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColEmail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandUser = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bGridColComments = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bGridColStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlEmployees = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllEmployees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkAllEmployees);
            this.layoutControl1.Controls.Add(this.gridControlEmployees);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(309, 182, 250, 350);
            this.layoutControl1.Root = this.layoutControlEmployees;
            this.layoutControl1.Size = new System.Drawing.Size(975, 496);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // checkAllEmployees
            // 
            this.checkAllEmployees.Location = new System.Drawing.Point(12, 12);
            this.checkAllEmployees.Name = "checkAllEmployees";
            this.checkAllEmployees.Properties.Caption = "All Employees";
            this.checkAllEmployees.Size = new System.Drawing.Size(951, 19);
            this.checkAllEmployees.StyleController = this.layoutControl1;
            this.checkAllEmployees.TabIndex = 7;
            // 
            // gridControlEmployees
            // 
            this.gridControlEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlEmployees.Location = new System.Drawing.Point(12, 35);
            this.gridControlEmployees.MainView = this.advBandedGridViewEmployees;
            this.gridControlEmployees.Name = "gridControlEmployees";
            this.gridControlEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlEmployees.Size = new System.Drawing.Size(951, 449);
            this.gridControlEmployees.TabIndex = 6;
            this.gridControlEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewEmployees});
            // 
            // advBandedGridViewEmployees
            // 
            this.advBandedGridViewEmployees.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandPhoto,
            this.gridBandNameAndEmail,
            this.gridBandAddress,
            this.gridBandBirthdayAndGender,
            this.gridBandPhoneAndEmail,
            this.gridBandUser});
            this.advBandedGridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColEmployeeId,
            this.gridColFullName,
            this.gridColPhone,
            this.gridColEmail,
            this.gridColAddress,
            this.bGridColPhoto,
            this.bGridColBirthday,
            this.bGridGender,
            this.bGridColComments,
            this.bGridColStatus});
            this.advBandedGridViewEmployees.GridControl = this.gridControlEmployees;
            this.advBandedGridViewEmployees.Name = "advBandedGridViewEmployees";
            this.advBandedGridViewEmployees.OptionsFind.AlwaysVisible = true;
            this.advBandedGridViewEmployees.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridViewEmployees.OptionsView.ShowBands = false;
            this.advBandedGridViewEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // gridBandPhoto
            // 
            this.gridBandPhoto.Caption = "Photo";
            this.gridBandPhoto.Columns.Add(this.bGridColPhoto);
            this.gridBandPhoto.Name = "gridBandPhoto";
            this.gridBandPhoto.OptionsBand.FixedWidth = true;
            this.gridBandPhoto.VisibleIndex = 0;
            this.gridBandPhoto.Width = 81;
            // 
            // bGridColPhoto
            // 
            this.bGridColPhoto.AutoFillDown = true;
            this.bGridColPhoto.Caption = "Photo";
            this.bGridColPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.bGridColPhoto.FieldName = "Photo";
            this.bGridColPhoto.Name = "bGridColPhoto";
            this.bGridColPhoto.OptionsColumn.AllowFocus = false;
            this.bGridColPhoto.OptionsColumn.AllowSize = false;
            this.bGridColPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.bGridColPhoto.OptionsColumn.FixedWidth = true;
            this.bGridColPhoto.OptionsFilter.AllowAutoFilter = false;
            this.bGridColPhoto.OptionsFilter.AllowFilter = false;
            this.bGridColPhoto.Visible = true;
            this.bGridColPhoto.Width = 81;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // gridBandNameAndEmail
            // 
            this.gridBandNameAndEmail.Caption = "NameAndId";
            this.gridBandNameAndEmail.Columns.Add(this.gridColEmployeeId);
            this.gridBandNameAndEmail.Columns.Add(this.gridColFullName);
            this.gridBandNameAndEmail.Name = "gridBandNameAndEmail";
            this.gridBandNameAndEmail.VisibleIndex = 1;
            this.gridBandNameAndEmail.Width = 189;
            // 
            // gridColEmployeeId
            // 
            this.gridColEmployeeId.Caption = "Employee Id";
            this.gridColEmployeeId.FieldName = "Id";
            this.gridColEmployeeId.Name = "gridColEmployeeId";
            this.gridColEmployeeId.OptionsColumn.AllowFocus = false;
            this.gridColEmployeeId.Visible = true;
            this.gridColEmployeeId.Width = 189;
            // 
            // gridColFullName
            // 
            this.gridColFullName.Caption = "Name";
            this.gridColFullName.FieldName = "FullName";
            this.gridColFullName.Name = "gridColFullName";
            this.gridColFullName.OptionsColumn.AllowFocus = false;
            this.gridColFullName.RowIndex = 1;
            this.gridColFullName.Visible = true;
            this.gridColFullName.Width = 189;
            // 
            // gridBandAddress
            // 
            this.gridBandAddress.Caption = "Address";
            this.gridBandAddress.Columns.Add(this.gridColAddress);
            this.gridBandAddress.Name = "gridBandAddress";
            this.gridBandAddress.VisibleIndex = 2;
            this.gridBandAddress.Width = 220;
            // 
            // gridColAddress
            // 
            this.gridColAddress.AutoFillDown = true;
            this.gridColAddress.Caption = "Address";
            this.gridColAddress.FieldName = "Address";
            this.gridColAddress.Name = "gridColAddress";
            this.gridColAddress.OptionsColumn.AllowFocus = false;
            this.gridColAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColAddress.Visible = true;
            this.gridColAddress.Width = 220;
            // 
            // gridBandBirthdayAndGender
            // 
            this.gridBandBirthdayAndGender.Caption = "Birthday";
            this.gridBandBirthdayAndGender.Columns.Add(this.bGridColBirthday);
            this.gridBandBirthdayAndGender.Columns.Add(this.bGridGender);
            this.gridBandBirthdayAndGender.Name = "gridBandBirthdayAndGender";
            this.gridBandBirthdayAndGender.VisibleIndex = 3;
            this.gridBandBirthdayAndGender.Width = 175;
            // 
            // bGridColBirthday
            // 
            this.bGridColBirthday.Caption = "Birthday";
            this.bGridColBirthday.FieldName = "Birthday";
            this.bGridColBirthday.Name = "bGridColBirthday";
            this.bGridColBirthday.OptionsColumn.AllowFocus = false;
            this.bGridColBirthday.Visible = true;
            this.bGridColBirthday.Width = 175;
            // 
            // bGridGender
            // 
            this.bGridGender.Caption = "Gender";
            this.bGridGender.FieldName = "Gender";
            this.bGridGender.Name = "bGridGender";
            this.bGridGender.OptionsColumn.AllowFocus = false;
            this.bGridGender.RowIndex = 1;
            this.bGridGender.Visible = true;
            this.bGridGender.Width = 175;
            // 
            // gridBandPhoneAndEmail
            // 
            this.gridBandPhoneAndEmail.Columns.Add(this.gridColEmail);
            this.gridBandPhoneAndEmail.Columns.Add(this.gridColPhone);
            this.gridBandPhoneAndEmail.Name = "gridBandPhoneAndEmail";
            this.gridBandPhoneAndEmail.VisibleIndex = 4;
            this.gridBandPhoneAndEmail.Width = 215;
            // 
            // gridColEmail
            // 
            this.gridColEmail.Caption = "Email";
            this.gridColEmail.FieldName = "Email";
            this.gridColEmail.Name = "gridColEmail";
            this.gridColEmail.OptionsColumn.AllowFocus = false;
            this.gridColEmail.Visible = true;
            this.gridColEmail.Width = 215;
            // 
            // gridColPhone
            // 
            this.gridColPhone.Caption = "Phone";
            this.gridColPhone.FieldName = "Phone";
            this.gridColPhone.Name = "gridColPhone";
            this.gridColPhone.OptionsColumn.AllowFocus = false;
            this.gridColPhone.RowIndex = 1;
            this.gridColPhone.Visible = true;
            this.gridColPhone.Width = 215;
            // 
            // gridBandUser
            // 
            this.gridBandUser.Caption = "User";
            this.gridBandUser.Columns.Add(this.bGridColComments);
            this.gridBandUser.Name = "gridBandUser";
            this.gridBandUser.VisibleIndex = 5;
            this.gridBandUser.Width = 103;
            // 
            // bGridColComments
            // 
            this.bGridColComments.AutoFillDown = true;
            this.bGridColComments.Caption = "Comments";
            this.bGridColComments.FieldName = "Comments";
            this.bGridColComments.Name = "bGridColComments";
            this.bGridColComments.OptionsColumn.AllowFocus = false;
            this.bGridColComments.Visible = true;
            this.bGridColComments.Width = 103;
            // 
            // bGridColStatus
            // 
            this.bGridColStatus.Caption = "Status";
            this.bGridColStatus.Name = "bGridColStatus";
            this.bGridColStatus.Visible = true;
            // 
            // layoutControlEmployees
            // 
            this.layoutControlEmployees.CustomizationFormText = "layoutControlEmployees";
            this.layoutControlEmployees.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlEmployees.GroupBordersVisible = false;
            this.layoutControlEmployees.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlEmployees.Location = new System.Drawing.Point(0, 0);
            this.layoutControlEmployees.Name = "layoutControlEmployees";
            this.layoutControlEmployees.Size = new System.Drawing.Size(975, 496);
            this.layoutControlEmployees.Text = "layoutControlEmployees";
            this.layoutControlEmployees.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlEmployees;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(955, 453);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkAllEmployees;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(955, 23);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_Employees";
            this.Size = new System.Drawing.Size(975, 496);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAllEmployees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlEmployees;
        private DevExpress.XtraEditors.CheckEdit checkAllEmployees;
        private DevExpress.XtraGrid.GridControl gridControlEmployees;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bGridColPhoto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColFullName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColEmployeeId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bGridColBirthday;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bGridGender;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bGridColComments;
        public DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewEmployees;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandPhoto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandNameAndEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandBirthdayAndGender;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandPhoneAndEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandUser;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bGridColStatus;
    }
}
