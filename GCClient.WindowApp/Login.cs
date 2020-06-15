using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;
using FHEC.GC.RBAC;
using System.Collections.Generic;
using FHEC;
using GCClient.WindowApp;
using GC.Model;

namespace GCClient.WindowApp
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        //private IRightsManageSrv IRightsManageSrv = ServiceFactory.GetService<IRightsManageSrv>();
        //private ISysCommonSrv sysCommonSrvClient = ServiceFactory.GetService<ISysCommonSrv>();
        private string str = Application.StartupPath + "\\Username.ini";

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        private Ice.Communicator communicator;
        public VusermenuDtoPage vusermenuList;
        public EmployeeDto employee;
        public Login()
        {
            InitializeComponent();
        }

        public Login(IRightsUploadServicePrx rightsUploadService, IRightsQueryServicePrx rightsQueryService, Ice.Communicator communicator)
        {
            _rightsUploadService = rightsUploadService;
            _rightsQueryService = rightsQueryService;
            this.communicator = communicator;
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
                       
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.Empty == txtUserName.Text)
                {
                    XtraMessageBox.Show("请输入用户名!");
                    return;
                }
                else
                {
                    txtUserPassWord.SelectAll();
                    txtUserPassWord.Focus();
                }
            }
        }

        private void txtUserPassWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.Empty == txtUserName.Text)
                {
                    XtraMessageBox.Show("请输入用户名!");
                    return;
                }
                if (string.Empty == txtUserPassWord.Text)
                {
                    XtraMessageBox.Show("请输入密码!");
                    return;
                }
                else
                    lblOk_Click(sender,e);
            }
        }

        private string LoadGCClientVersion(string strPath)
        {
            string strResult = string.Empty;
            if (File.Exists(strPath))
            {
                StreamReader sr = new StreamReader(strPath);
                strResult = sr.ReadLine();
                sr.Close();
            }
            return strResult.ToUpper();
        }

        private void KillExeProgram()
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;//是否使用操作系统外壳程序启动进程
            string strUpdatePath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            proc.StartInfo.WorkingDirectory = strUpdatePath;//启动进程的初始目录
            proc.StartInfo.FileName = "GCClient.Update.exe";
            proc.Start();
            Process[] arrPro = Process.GetProcessesByName("GCClient.WindowsApp");
            foreach (Process pro in arrPro)
                pro.Kill();
        }

        private void Login_Load(object sender, EventArgs e)
        {            
            if (File.Exists(str))
            {
                StreamReader sr = new StreamReader(str);
                txtUserName.Text = sr.ReadLine();
                sr.Close();
                if (txtUserName.Text != string.Empty)
                {
                    txtUserPassWord.TabIndex = 0;
                }
                labelControl1.Parent = pictureEdit1;
                labelControl2.Parent = pictureEdit1;
                lblOk.Parent = pictureEdit1;
                lblCancle.Parent = pictureEdit1;
                labelControl5.Parent = pictureEdit1;
            }
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {
            txtUserPassWord.TabIndex = 2;
        }

        private void lblOk_Click(object sender, EventArgs e)
        {
            EmployeeDto employeeDto = new EmployeeDto();
            if (txtUserName.Text == string.Empty)
            {
                XtraMessageBox.Show("用户名不能为空!");
                return;
            }
            if (txtUserPassWord.Text == string.Empty)
            {
                XtraMessageBox.Show("密码不能为空!");
                return;
            }
            try
            {
                employeeDto.Emplcode = txtUserName.Text;
                employeeDto.Userpassword = txtUserPassWord.Text;
                var employee = _rightsQueryService.GetUserByLoginNameAsync(txtUserName.Text.ToString()).GetAwaiter().GetResult(); ;
                if (employee != null)
                {
                    if (_rightsUploadService.LoginAsync(employeeDto).GetAwaiter().GetResult())
                    {
                        var ic = communicator.getImplicitContext();
                        //创建登录用户
                        ic.setContext(new Dictionary<string, string>
                        {
                            { Extensions.LoginUserKey,System.Text.Json.JsonSerializer.Serialize(new LoginUser
                            {
                                Sysid = employee.Sysid,
                                Emplcode = employee.Emplcode,
                                Username = employee.Username
                            })}
                        });
                        this.employee = employee;
                        vusermenuList = _rightsQueryService.getUserMenuByLoginNameAsync(txtUserName.Text.ToString()).GetAwaiter().GetResult();
                        GCClientData.rightManageC = new RightManageC
                        {
                            employee = employee,
                            vusermenuList = vusermenuList.rows
                        };
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    XtraMessageBox.Show("员工工号或者密码错误！");
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }

        private void lblCancle_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";
            this.txtUserPassWord.Text = "";
            this.Close();
        }

        //private void simpleButton1_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        EmployeeDto employeeDto = new EmployeeDto
        //        {
        //            Sysid = "6",
        //            Emplcode = "00042",
        //            Userpassword = "123456",
        //            Username = "测试",
        //            Dr = 0
        //        };
        //        EmployeeDto user = _rightsUploadService.CreateUserAsync(employeeDto).GetAwaiter().GetResult();
        //        if (user != null)
        //        {
        //            XtraMessageBox.Show("添加成功！！！" + user.Emplcode);
        //        }
        //        else
        //        {
        //            XtraMessageBox.Show("添加失败！！！");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show(ex.Message);
        //        return;
        //    }
        //}

        //private void simpleButton2_Click_1(object sender, EventArgs e)
        //{
        //    EmployeeDto employeeDto = new EmployeeDto
        //    {
        //        Sysid = "6",
        //        Emplcode = "00051",
        //        Userpassword = "123456",
        //        Username = "测试2",
        //        Dr = 0
        //    };

        //    EmployeeDto user = _rightsUploadService.ModifyUserAsync(employeeDto).GetAwaiter().GetResult();
        //    if (user != null)
        //    {
        //        XtraMessageBox.Show("修改成功！！！" + user.Emplcode);
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("修改失败！！！");
        //    }
        //}
    }
}