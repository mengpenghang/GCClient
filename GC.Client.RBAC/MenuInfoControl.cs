using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class MenuInfoControl : UserControl
    {
        private readonly int sysid = -1;
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        private readonly BindingList<Menuinfo> bindingListMenuInfo;

        public BindingList<Menuinfo> BindingListMenuInfo
        {
            get { return bindingListMenuInfo; }
        }

        //IRightsManageSrv rightManagerSrv;

        private readonly Assembly[] assemblies = null;
        public MenuInfoControl(IRightsUploadServicePrx rightsUploadService, IRightsQueryServicePrx rightsQueryService)
        {
            InitializeComponent();
            _rightsUploadService = rightsUploadService;
            _rightsQueryService = rightsQueryService;
            assemblies = new Assembly[]
            {
                Assembly.GetAssembly(this.GetType())
            };
        }

        private void MenuInfoControl_Load(object sender, EventArgs e)
        {
            Reflection();

            InitControl();
        }

        private void InitControl()
        {
            //bindingListMenuInfo = new BindingList<Menuinfo>(rightManagerSrv.GetMenuList().ToList());
            treeListMenuInfo.DataSource = bindingListMenuInfo;
            treeListMenuInfo.BestFitColumns();
            menuinfoLookupEdit.DataBindings.Add("EditValue", bindingListMenuInfo, "Parentid", true, DataSourceUpdateMode.OnValidation);
            menuinfoLookupEdit.Properties.DataSource = bindingListMenuInfo;
        }


        private void CurrentMenuinfoAction(Action<Menuinfo> action)
        {
            Menuinfo menuinfo = treeListMenuInfo.GetDataRecordByNode(treeListMenuInfo.FocusedNode) as Menuinfo;
            if (menuinfo == null)
                return;
            action(menuinfo);
        }

        /// <summary>
        /// 添加同级菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonMenuinfoAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            DevExpress.XtraTreeList.Nodes.TreeListNode node = this.treeListMenuInfo.FocusedNode;
            DevExpress.XtraTreeList.Nodes.TreeListNode parentNode = node.ParentNode;
            string parentid = null;
            if (parentNode != null)
                parentid = parentNode.GetValue("Sysid") as string;
            Menuinfo menuinfo = NewMenuinfo(parentid);
            Save(menuinfo);
            this.bindingListMenuInfo.ResetBindings();
            ValidateChildren();
        }

        private Menuinfo NewMenuinfo(string parentid)
        {
            Menuinfo menuinfo = new Menuinfo();
            menuinfo.Childform = textEditChildform.Text.Trim();
            menuinfo.Formdialog = textEditFormdialog.Text.Trim();
            menuinfo.Menudesc = textEditMenudesc.Text.Trim();
            menuinfo.Menuimage = textEditMenuimage.Text.Trim();
            menuinfo.Menuindex = Convert.ToInt64(textEditMenuindex.EditValue);
            menuinfo.Menumark = textEditMenumark.Text.Trim();
            menuinfo.Menuname = textEditMenuname.Text.Trim();
            menuinfo.Menurule = lookupEditMenurule.Text.Trim();
            menuinfo.Parentid = parentid;
            menuinfo.Remark = textEditRemark.Text.Trim();
            menuinfo.Transparams = CheckEditTransparams.EditValue as string;
            return menuinfo;
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonMenuinfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentMenuinfoAction(Delete);
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// 删除当前的数据,当前项必须没有子节点,否则无法删除
        /// </summary>
        /// <param name="menuinfo"></param>
        private void Delete(Menuinfo menuinfo)
        {
            try
            {
                if (this.treeListMenuInfo.FocusedNode.HasChildren == true)
                {
                    XtraMessageBox.Show("当前数据存在子数据，无法删除", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (XtraMessageBox.Show("是否删除当前选中数据？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //rightManagerSrv.DeleteMenu(menuinfo.Sysid);
                    bindingListMenuInfo.Remove(menuinfo);
                }
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="menuinfo"></param>
        /// <returns></returns>
        private void Save(Menuinfo menuinfo)
        {
            try
            {
                //menuinfo.Sysid = rightManagerSrv.CreateMenu(menuinfo);
                bindingListMenuInfo.Add(menuinfo);
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }


        /// <summary>
        /// 插入子节点

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonMenuinfoInsert_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            CurrentMenuinfoAction(menuinfo =>
            {
                Menuinfo newMenuinfo = NewMenuinfo(menuinfo.Sysid);
                Save(newMenuinfo);
                treeListMenuInfo.RefreshDataSource();
            });
            ValidateChildren();
        }

        /// <summary>
        /// 获取本程序中所有的窗体
        /// </summary>
        private void Reflection()
        {
            List<string> forms = null;
            if (null == forms)
                forms = new List<string>();
            forms.Clear();
            forms.Insert(0, "");
            foreach (var item in assemblies)
            {
                Type[] types = item.GetTypes();
                var pcResult = types.Where(pc => pc.IsClass && pc.IsPublic).ToList();
                var listforms = pcResult.Where(f => f.BaseType.Name == "XtraForm" && f.Name != "Login" && f.Name != "MainForm").ToList().ConvertAll(f => f.FullName);

                foreach (var form in listforms)
                {
                    forms.Add(form);
                }

            }
            lookupEditMenurule.Properties.DataSource = forms;
            MenuruleItemLookUpEdit.DataSource = forms;
            lookupEditMenurule.Properties.ValueMember = "Column";
            lookupEditMenurule.Properties.DisplayMember = "Column";
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdit_Validating(object sender, CancelEventArgs e)
        {
            DevExpress.XtraEditors.TextEdit textEdit = sender as DevExpress.XtraEditors.TextEdit;
            if (textEdit == null)
                return;
            if (textEdit.Text == null || textEdit.Text == string.Empty)
            {
                textEdit.ErrorText = "不能为空";
                textEdit.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                e.Cancel = true;
                textEdit.EditValue = textEdit.OldEditValue;
            }
        }

        public override bool ValidateChildren()
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs() { Cancel = false };
            textEdit_Validating(textEditMenuname, cancelEventArgs);
            textEdit_Validating(textEditMenudesc, cancelEventArgs);
            return !cancelEventArgs.Cancel;
        }

        private void textEditMenuname_Validating(object sender, CancelEventArgs e)
        {
            textEdit_Validating(sender, e);
        }

        private void treeListMenuInfo_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (treeListMenuInfo.FocusedColumn.FieldName == "Menuname" ||
                treeListMenuInfo.FocusedColumn.FieldName == "Menudesc")
            {
                if (e.Value == null || e.Value as string == string.Empty)
                {
                    e.Valid = false;
                    e.ErrorText = "不能为空";
                }
            }

        }

        private void treeListMenuInfo_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

            try
            {
                CurrentMenuinfoAction(menuinfo =>
                {
                    if (menuinfo != null && menuinfo.Sysid != null)
                    {
                        if (e.Column != null && e.Column.FieldName == "Sysid")
                            return;
                        //rightManagerSrv.ModifyMenu(menuinfo);
                    }
                });
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }

        }
    }
}
