using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class ResButtonControl : UserControl
    {

        private readonly BindingList<Resbutton> bindingListResButton;

        public BindingList<Resbutton> BindingListResButton
        {
            get { return bindingListResButton; }
        }

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public ResButtonControl(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            InitializeComponent();
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;

        }

        private void ResButtonControl_Load(object sender, EventArgs e)
        {
            //bindingListResButton = new BindingList<Resbutton>(rightManager.GetResButtonList().ToList());
            gridControlResButton.DataSource = bindingListResButton;
        }


        private void CurrentResButtonAction(Action<Resbutton> action)
        {
            Resbutton resbutton = gridViewResButton.GetFocusedRow() as Resbutton;
            if (resbutton == null)
                return;
            action(resbutton);
        }


        private void simpleButtonResButtonDelete_Click(object sender, EventArgs e)
        {
            CurrentResButtonAction(Delete);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="resbuttonCurrent"></param>
        private void Delete(Resbutton resbuttonCurrent)
        {
            if (resbuttonCurrent.Sysid != null)
            {
                if (XtraMessageBox.Show("是否删除当前选中数据?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //rightManager.DeleteResButtonById(resbuttonCurrent.Sysid);
                        bindingListResButton.Remove(resbuttonCurrent);
                    }
                    catch (Exception ex)
                    {
                        ExceptionAction(ex);
                    }
                }
            }
        }

        private void simpleButtonResButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            Resbutton resbutton = new Resbutton();
            resbutton.Buttonname = textEditButtonname.Text.Trim();
            resbutton.Formname = textEditFormname.Text.Trim();
            Save(resbutton);
            ValidateChildren();
        }

        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="resbutton"></param>
        /// <returns></returns>
        private void Save(Resbutton resbutton)
        {
            try
            {
                //resbutton.Sysid = rightManager.CreateResButton(resbutton.Formname, resbutton.Buttonname);
                bindingListResButton.Add(resbutton);
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

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
            }
        }

        public override bool ValidateChildren()
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs() { Cancel = false };
            textEdit_Validating(textEditButtonname, cancelEventArgs);
            textEdit_Validating(textEditFormname, cancelEventArgs);
            return !cancelEventArgs.Cancel;
        }

        private void gridViewResButton_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value as string == string.Empty || e.Value == null)
            {
                e.Valid = false;
                e.ErrorText = "不能为空";
            }
        }

        private void gridViewResButton_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                CurrentResButtonAction(resbuttonCurrent =>
                {
                    if (resbuttonCurrent.Sysid != null)
                    {
                        if (e.Column != null && e.Column.FieldName == "Sysid")
                            return;
                        //rightManager.ModifyResButton(resbuttonCurrent);
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
