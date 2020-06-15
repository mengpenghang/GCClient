using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class ResTableColumnControl : UserControl
    {

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        private readonly BindingList<Restablecolumn> bindingListRestablecolumn = null;

        public BindingList<Restablecolumn> BindingSourceRestablecolumn
        {
            get { return bindingListRestablecolumn; }
        }

        private readonly List<Restablecolumn> restablecolumnAddList = new List<Restablecolumn>();

        public ResTableColumnControl(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            InitializeComponent();
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
        }


        private void ResTableColumnControl_Load(object sender, EventArgs e)
        {
            //bindingListRestablecolumn = new BindingList<Restablecolumn>(rightManager.GetResColumnList().ToList());
            gridControlResTableColumn.DataSource = bindingListRestablecolumn;
        }

        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonRestablecolumnDelete_Click(object sender, EventArgs e)
        {
            CurrentRestablecolumnAction(Delete);
        }

        private void CurrentRestablecolumnAction(Action<Restablecolumn> action)
        {
            Restablecolumn restablecolumn = gridViewResTableColumn.GetFocusedRow() as Restablecolumn;
            if (restablecolumn == null)
                return;
            action(restablecolumn);
        }

        private void Delete(Restablecolumn restablecolumn)
        {
            try
            {
                if (XtraMessageBox.Show("是否删除当前选中的数据?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //rightManager.DeleteResColumn(restablecolumn.Sysid);
                    this.bindingListRestablecolumn.Remove(restablecolumn);
                }
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

        private void simpleButtonRestablecolumnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            Restablecolumn restablecolumn = new Restablecolumn();
            restablecolumn.Objectcolumn = textEditObjectcolumn.Text.Trim();
            restablecolumn.Objectname = textEditObjectname.Text.Trim();
            restablecolumn.Tablecolumn = textEditTablecolumn.Text.Trim();
            restablecolumn.Tablename = textEditTablename.Text.Trim();
            this.Save(restablecolumn);
            this.ValidateChildren();
        }


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="restablecolumn"></param>
        /// <returns></returns>
        private void Save(Restablecolumn restablecolumn)
        {
            try
            {
                //restablecolumn.Sysid = rightManager.CreateResColumn(
                //    restablecolumn.Tablename,
                //    restablecolumn.Tablecolumn,
                //    restablecolumn.Objectname,
                //    restablecolumn.Objectcolumn);
                //bindingListRestablecolumn.Add(restablecolumn);
                gridViewResTableColumn.RefreshData();

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

        private void gridViewResTableColumn_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || e.Value as string == string.Empty)
            {
                e.ErrorText = "不能为空";
                e.Valid = false;
            }
        }


        public override bool ValidateChildren()
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs() { Cancel = false };
            textEdit_Validating(textEditObjectcolumn, cancelEventArgs);
            textEdit_Validating(textEditObjectname, cancelEventArgs);
            textEdit_Validating(textEditTablecolumn, cancelEventArgs);
            textEdit_Validating(textEditTablename, cancelEventArgs);
            return !cancelEventArgs.Cancel;
        }

        private void gridViewResTableColumn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                CurrentRestablecolumnAction(restablecolumn =>
                {
                    if (restablecolumn.Sysid != null)
                    {
                        if (e.Column != null && e.Column.FieldName == "Sysid")
                            return;
                        //rightManager.ModifyResColumn(restablecolumn);
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
