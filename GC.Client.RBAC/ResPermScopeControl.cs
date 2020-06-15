using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class ResPermScopeControl : UserControl
    {

        private readonly BindingList<Respermscope> bindingListRespermscope;

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public ResPermScopeControl(IRightsUploadServicePrx rightsUploadService, IRightsQueryServicePrx rightsQueryService)
        {
            InitializeComponent(); _rightsUploadService = rightsUploadService;
            _rightsQueryService = rightsQueryService;
        }

        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResPermScopeControl_Load(object sender, EventArgs e)
        {
            //bindingListRespermscope = new BindingList<Respermscope>(rightManager.GetResourceList().ToList());
            this.gridControlResPermScope.DataSource = bindingListRespermscope;
        }

        private void CurrentRespermscopeAction(Action<Respermscope> action)
        {
            Respermscope respermscope = gridViewResPermScope.GetFocusedRow() as Respermscope;
            if (respermscope == null)
                return;
            action(respermscope);
        }

        private void simpleButtonRespermscopeDelete_Click(object sender, EventArgs e)
        {
            CurrentRespermscopeAction(Delete);
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            Respermscope respermscope = new Respermscope();
            respermscope.Restype = comboBoxEditRestype.Text.Trim();
            respermscope.Resdesc = textEditResdesc.Text.Trim();
            respermscope.Resname = textEditResname.Text.Trim();
            Save(respermscope);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="respermscope"></param>
        private void Delete(Respermscope respermscope)
        {
            try
            {
                if (respermscope.Sysid != null)
                {
                    if (XtraMessageBox.Show("是否删除当前选中数据？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //rightManager.DeleteResource(respermscope.Sysid);
                        bindingListRespermscope.Remove(respermscope);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }

        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="respermscope"></param>
        /// <returns></returns>
        private void Save(Respermscope respermscope)
        {
            try
            {
                //respermscope.InitSysid(rightManager.CreateResource(respermscope.Resname, respermscope.Restype, respermscope.Resdesc));
                bindingListRespermscope.Add(respermscope);
                this.gridViewResPermScope.RefreshData();
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Validating(object sender, CancelEventArgs e)
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
            Edit_Validating(comboBoxEditRestype, cancelEventArgs);
            Edit_Validating(textEditResdesc, cancelEventArgs);
            Edit_Validating(textEditResname, cancelEventArgs);
            return !cancelEventArgs.Cancel;
        }

        private void gridViewResPermScope_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value as string == string.Empty || e.Value == null)
            {
                e.Valid = false;
                e.ErrorText = "不能为空";
            }
        }

        private void gridViewResPermScope_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                CurrentRespermscopeAction(respermscope =>
                {
                    if (respermscope.Sysid != null)
                    {
                        if (e.Column != null && e.Column.FieldName == "Sysid")
                            return;
                        //rightManager.ModifyResource(respermscope);
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
