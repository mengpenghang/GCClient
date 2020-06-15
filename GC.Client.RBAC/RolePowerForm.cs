using FHEC.GC.RBAC;
using GC.Client.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace GC.Client.RBAC
{
    public partial class RolePowerForm : DevExpress.XtraEditors.XtraForm, IAppForm
    {
        private MenuInfoControl menuInfoControl = null;
        private ResButtonControl resButtonControl = null;
        private ResPermScopeControl resPermScopeControl = null;
        private ResTableColumnControl resTableColumnControl = null;

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public RolePowerForm()
        {
            InitializeComponent();
        }

        public RolePowerForm(IRightsUploadServicePrx rightsUploadService, IRightsQueryServicePrx rightsQueryService)
        {
            InitializeComponent();
            _rightsUploadService = rightsUploadService;
            _rightsQueryService = rightsQueryService;
        }

        private void RolePowerForm_Load(object sender, EventArgs e)
        {
            InitMenuInfoControl();
            InitResButtonControl();
            InitResPermScopeControl();
            InitResTableColumnControl();
        }

        private void InitMenuInfoControl()
        {
            if (menuInfoControl == null)
            {
                menuInfoControl = new MenuInfoControl(_rightsUploadService, _rightsQueryService);
                menuInfoControl.Dock = DockStyle.Fill;
                xtraTabPageMenuinfo.Controls.Add(menuInfoControl);
            }
        }

        private void InitResButtonControl()
        {
            if (resButtonControl == null)
            {
                resButtonControl = new ResButtonControl(_rightsUploadService, _rightsQueryService);
                resButtonControl.Dock = DockStyle.Fill;
                xtraTabPageResButton.Controls.Add(resButtonControl);
            }
        }

        private void InitResPermScopeControl()
        {
            if (resPermScopeControl == null)
            {
                resPermScopeControl = new ResPermScopeControl(_rightsUploadService, _rightsQueryService);
                resPermScopeControl.Dock = DockStyle.Fill;
                xtraTabPageResPermScope.Controls.Add(resPermScopeControl);
            }
        }

        private void InitResTableColumnControl()
        {
            if (resTableColumnControl == null)
            {
                resTableColumnControl = new ResTableColumnControl(_rightsUploadService, _rightsQueryService);
                resTableColumnControl.Dock = DockStyle.Fill;
                xtraTabPageResTableColumn.Controls.Add(resTableColumnControl);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            base.OnClosing(e);
        }

    }
}
