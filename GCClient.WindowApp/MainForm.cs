using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

using System.IO;
using System.Threading;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraTab;
using System.Diagnostics;
using FHEC.GC.RBAC;
using Microsoft.Extensions.DependencyInjection;
using GC.Client.Base;
//

namespace GCClient.WindowApp
{
    public partial class MainForm : RibbonForm
    {
        private RibbonControl ribbonControl;
        private RibbonStatusBar ribbonStatusBar;

        private ImageCollection navbarLargeImageCollection;
        private ImageCollection navbarSmallImageCollection;
        private ImageCollection ribbonSmallImageCollection;
        private ImageCollection ribbonLargeImageCollection;

        private DockManager dockManager;
        private DockPanel dockPanelObj;
        private DockPanel dockPanelWork;
        private NavBarControl navBarControl;

        private RibbonGalleryBarItem rgbiSkins;

        private XtraTabbedMdiManager xtraTabbedMdiManager;
        private BarStaticItem timestaticitem;
        private BarStaticItem storinfostaticitem;
        private System.Threading.Thread mainThread;

        private System.Timers.Timer GCClientTimer;

        private string strCurrentPath;
        private string strClientVersion;

        private IEnumerable<VusermenuDto> topMenus;
        private VusermenuDtoPage vusermenuList;
        private ServiceProvider serviceProvider;
        //private ISysCommonSrv sysCommonSrvClient = ServiceFactory.GetService<ISysCommonSrv>();

        Assembly[] assemblies = null;

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(VusermenuDtoPage vusermenuList, ServiceProvider serviceProvider)
        {
            InitializeComponent();
            strCurrentPath = Application.StartupPath;
            this.vusermenuList = vusermenuList;
            this.serviceProvider = serviceProvider;
            strClientVersion = LoadGCClientVersion(Application.StartupPath + "\\Version.ini");
            topMenus = from Vusermenu in vusermenuList.rows
                       where Vusermenu.Parentid == null || Vusermenu.Parentid == ""
                       orderby Vusermenu.Menuindex
                       select Vusermenu;
            assemblies = new Assembly[]
            {
                Assembly.GetAssembly(this.GetType()),
                 //Assembly.LoadFile(Application.StartupPath + @"\Enterprise.dll")
            };
        }

        void InitImageCollection()
        {
            //初始化ImageCollection
            navbarSmallImageCollection = new ImageCollection();
            if (null != navbarSmallImageCollection)
                navbarSmallImageCollection.ImageSize = new Size(16, 16);
            navbarLargeImageCollection = new ImageCollection();
            if (null != navbarLargeImageCollection)
                navbarLargeImageCollection.ImageSize = new Size(64, 64);
            ribbonSmallImageCollection = new ImageCollection();
            if (null != ribbonSmallImageCollection)
                ribbonSmallImageCollection.ImageSize = new Size(16, 16);
            ribbonLargeImageCollection = new ImageCollection();
            if (null != ribbonLargeImageCollection)
                ribbonLargeImageCollection.ImageSize = new Size(32, 32);

            foreach (VusermenuDto vusermenu in vusermenuList.rows)
            {
                if (null == vusermenu.Menuimage)
                    continue;
                if (File.Exists(strCurrentPath + "\\image\\" + vusermenu.Menuimage))
                {
                    Image image = Image.FromFile(strCurrentPath + "\\image\\" + vusermenu.Menuimage);
                    if (null == image)
                        continue;
                    navbarSmallImageCollection.Images.Add(image, vusermenu.Menuname);
                    navbarLargeImageCollection.Images.Add(image, vusermenu.Menuname);
                    ribbonSmallImageCollection.Images.Add(image, vusermenu.Menuname);
                    ribbonLargeImageCollection.Images.Add(image, vusermenu.Menuname);
                }
            }
        }

        void InitRibbonControl()
        {
            //初始化RibbonControl
            ribbonControl = new RibbonControl();
            if (null == ribbonControl)
                return;
            this.Controls.Add(ribbonControl);
            ribbonControl.ApplicationCaption = "报价管理系统";
            //ribbonControl.ApplicationIcon = global::GCClient.WindowsApp.Properties.Resources.RibbonLogo;
            ribbonControl.LargeImages = ribbonLargeImageCollection;
            ribbonControl.Images = ribbonSmallImageCollection;
            //初始化RibbonStatusBar
            ribbonStatusBar = new RibbonStatusBar();
            if (null == ribbonStatusBar)
                return;
            BarStaticItem userstaticitem = new BarStaticItem();
            //userstaticitem.Caption = "用户名:" +GCClientData.rightManageC.employee.Username ;            
            ribbonStatusBar.ItemLinks.Add(userstaticitem, true);

            BarStaticItem versionitem = new BarStaticItem();
            versionitem.Caption = "版本号:" + strClientVersion;
            versionitem.Alignment = BarItemLinkAlignment.Right;
            ribbonStatusBar.ItemLinks.Add(versionitem, true);

            timestaticitem = new BarStaticItem();
            timestaticitem.Caption = DateTime.Now.ToString("当前时间:yyyy-MM-dd HH:mm:ss");
            timestaticitem.Alignment = BarItemLinkAlignment.Right;
            ribbonStatusBar.ItemLinks.Add(timestaticitem, true);

            //storinfostaticitem = new BarStaticItem();
            //storinfostaticitem.Caption = string.Format("仓库:{0}","未选择");
            //storinfostaticitem.Alignment = BarItemLinkAlignment.Right;
            //ribbonStatusBar.ItemLinks.Add(storinfostaticitem, true);

            ribbonStatusBar.Ribbon = ribbonControl;
            this.Controls.Add(ribbonStatusBar);
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

        private int GetImageIndex(string strname)
        {
            for (int i = 0; i < ribbonLargeImageCollection.Images.Keys.Count; i++)
            {
                if (strname == ribbonLargeImageCollection.Images.Keys[i])
                {
                    return i;
                }
            }
            return 0;
        }

        [Obsolete]
        void InitRibbonPage()
        {
            foreach (var vusermenu in topMenus)
            {
                var PageMenus = GetChildMenus(vusermenu.Sysid);
                foreach (var pageMenu in PageMenus)
                {
                    if ("Page" != pageMenu.Menumark)
                        continue;
                    RibbonPage ribbonPage = new RibbonPage(pageMenu.Menudesc);
                    if (null == ribbonPage)
                        return;
                    ribbonPage.Name = pageMenu.Menuname;
                    var groupMenus = GetChildMenus(pageMenu.Sysid);
                    foreach (var groupMenu in groupMenus)
                    {
                        if ("Group" != groupMenu.Menumark)
                            continue;
                        RibbonPageGroup ribbonPageGroup = new RibbonPageGroup(groupMenu.Menudesc);
                        if (null == ribbonPageGroup)
                            return;
                        ribbonPageGroup.Name = groupMenu.Menuname;
                        var buttonMenus = GetChildMenus(groupMenu.Sysid);
                        foreach (var buttonMenu in buttonMenus)
                        {
                            if (buttonMenu.Menumark.Contains("Button") == false)
                                continue;
                            if (buttonMenu.Menudesc.Contains("主题") == true)
                            {
                                rgbiSkins = new RibbonGalleryBarItem();
                                if (null == rgbiSkins)
                                    return;
                                rgbiSkins.Caption = buttonMenu.Menudesc;
                                rgbiSkins.Gallery.AllowHoverImages = true;
                                rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseFont = true;
                                rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseTextOptions = true;
                                rgbiSkins.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                rgbiSkins.Gallery.ColumnCount = 4;
                                rgbiSkins.Gallery.FixedHoverImageSize = false;
                                rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
                                rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
                                rgbiSkins.Gallery.RowCount = 4;
                                rgbiSkins.Id = 60;
                                rgbiSkins.Name = buttonMenu.Menuname;
                                ribbonPageGroup.ItemLinks.Add(rgbiSkins);
                                ribbonControl.Items.Add(rgbiSkins);
                                SkinHelper.InitSkinGallery(rgbiSkins, true);
                            }
                            else
                            {
                                BarButtonItem barButtonItem = ribbonControl.Items.CreateButton(buttonMenu.Menudesc);
                                if (null == barButtonItem)
                                    return;
                                barButtonItem.Name = buttonMenu.Menuname;
                                if (buttonMenu.Menumark == "LargeButton")
                                {
                                    barButtonItem.LargeImageIndex = GetImageIndex(buttonMenu.Menuname);
                                    barButtonItem.RibbonStyle = RibbonItemStyles.Large;
                                }
                                else
                                {
                                    barButtonItem.ImageIndex = GetImageIndex(buttonMenu.Menuname);
                                    barButtonItem.RibbonStyle = RibbonItemStyles.SmallWithText;
                                }
                                barButtonItem.ItemClick += new ItemClickEventHandler(barButtonItem_ItemClick);
                                ribbonPageGroup.ItemLinks.Add(barButtonItem);
                            }
                        }
                        ribbonPage.Groups.Add(ribbonPageGroup);
                    }
                    ribbonControl.Pages.Add(ribbonPage);
                }
            }
        }

        private List<VusermenuDto> GetChildMenus(string sysid)
        {
            return vusermenuList.rows.Where(p => p.Parentid == sysid).OrderBy(usermenu => usermenu.Menuindex).ToList();
        }

        void InitDockManager()
        {
            dockManager = new DockManager(this);
            if (null == dockManager)
                return;
            dockPanelObj = dockManager.AddPanel(DockingStyle.Left);
            dockPanelObj.Text = "业务对象";
            dockPanelObj.Width = 140;
            //dockPanelWork = dockManager.AddPanel(DockingStyle.Left);
            //dockPanelWork.Text = "工作平台";
            //dockPanelWork.Width = 140;
            //dockPanelWork.DockAsTab(dockPanelObj,1);
            dockPanelObj.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            dockManager.DockingOptions.ShowCloseButton = false;
        }

        void InitNavBarControl()
        {
            navBarControl = new NavBarControl();
            if (null == navBarControl)
                return;
            navBarControl.Dock = DockStyle.Fill;
            navBarControl.SmallImages = navbarSmallImageCollection;
            navBarControl.LargeImages = navbarLargeImageCollection;
            navBarControl.PaintStyleName = "XP2View";
            navBarControl.LookAndFeel.UseDefaultLookAndFeel = true;
            foreach (var vusermenu in topMenus)
            {
                NavBarGroup navBarGroup = navBarControl.Groups.Add();
                navBarGroup.Caption = vusermenu.Menudesc;
                navBarGroup.Name = vusermenu.Menuname;
                navBarGroup.GroupStyle = NavBarGroupStyle.LargeIconsText;
                navBarGroup.SmallImageIndex = GetImageIndex(vusermenu.Menuname);
                var childMenus = vusermenuList.rows.Where(p => p.Parentid == vusermenu.Sysid).OrderBy(p => p.Menuindex);
                foreach (var childMenu in childMenus)
                {
                    NavBarItem navBarItem = navBarControl.Items.Add();
                    navBarItem.Caption = childMenu.Menudesc;
                    navBarItem.Name = childMenu.Menuname;
                    navBarItem.LargeImageIndex = GetImageIndex(childMenu.Menuname);
                    navBarItem.Name = childMenu.Menuname;
                    navBarItem.LinkClicked += new NavBarLinkEventHandler(navBarItem_LinkClicked);
                    navBarGroup.ItemLinks.Add(navBarItem);
                }
            }
            dockPanelObj.Controls.Add(navBarControl);
        }

        void InitXtraTabbledMidManager()
        {
            xtraTabbedMdiManager = new XtraTabbedMdiManager();
            if (null == xtraTabbedMdiManager)
                return;
            xtraTabbedMdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.InActiveTabPageHeader;
            xtraTabbedMdiManager.MdiParent = this;
        }

        [Obsolete]
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitImageCollection();
            InitRibbonControl();
            InitRibbonPage();
            InitDockManager();
            InitNavBarControl();
            InitXtraTabbledMidManager();
            this.WindowState = FormWindowState.Maximized;
            System.Timers.Timer maintimer = new System.Timers.Timer(1000);
            maintimer.Elapsed += new System.Timers.ElapsedEventHandler(maintimer_Elapsed);
            maintimer.Enabled = true;

            GCClientTimer = new System.Timers.Timer(1000 * 60 );
            GCClientTimer.Elapsed += new System.Timers.ElapsedEventHandler(GCClientTimer_Elapsed);
            GCClientTimer.Enabled = true;
        }

        void maintimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timestaticitem.Caption = DateTime.Now.ToString("当前时间:yyyy-MM-dd HH:mm:ss");
            //Storinfo storinfo = GCClientData.GetStorinfo();
            //storinfostaticitem.Caption = storinfo == null ? "未选择" : storinfo.Fullname;
            //ribbonStatusBar.Refresh();
        }

        void GCClientTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //string strSerVersion = sysCommonSrvClient.GetGCClientLastVersion();
            //if (strClientVersion != strSerVersion)
            //{
            //    GCClientTimer.Enabled = false;
            //    //XtraMessageBox.Show("客户端版本有更新，请关闭程序更新！！！");
            //    //DialogResult dr = XtraMessageBox.Show("客户端版本有更新，请关闭程序更新？", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //if (dr == DialogResult.OK)
            //    //{                    
            //    //  KillExeProgram();
            //    //}
            //}
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

        VusermenuDto GetMenuFromMenus(string menuname)
        {
            foreach (VusermenuDto menu in vusermenuList.rows)
            {
                if (menuname == menu.Menuname)
                    return menu;
            }
            return null;
        }

        Form GetMdiForm(string formname)
        {
            return Application.OpenForms[formname];
        }

        private void ActiveRibbonPage(string pagename)
        {
            RibbonPage ribbonpage = this.ribbonControl.Pages.GetPageByName(pagename);
            ribbonControl.SelectedPage = ribbonpage;
        }

        void navBarItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            VusermenuDto barItemMenu = GetMenuFromMenus(e.Link.Item.Name);
            if (barItemMenu == null)
                return;
            if (barItemMenu.Menurule == null)
                return;
            foreach (var item in assemblies)
            {
                Type formType = item.GetType(barItemMenu.Menurule);
                if (formType != null)
                {
                    if (typeof(Form).IsAssignableFrom(formType))
                    {
                        int inx = (barItemMenu.Menurule).LastIndexOf(".") + 1;
                        string formname = (barItemMenu.Menurule).Substring(inx);
                        Form frm = GetMdiForm(formname);
                        if (frm == null)
                        {
                            frm = (Form)Activator.CreateInstance(formType);
                            frm.MdiParent = this;
                        }
                        frm.Activate();
                        ActiveRibbonPage(e.Link.Item.Name);
                        frm.Show();
                    }
                    else
                        XtraMessageBox.Show("指定的类型不能是从Form类型继承", "温馨提示");
                    return;
                }

            }
            XtraMessageBox.Show("指定的类型不存在", "温馨提示");
        }

       /// <summary>
       /// main界面按钮跳转
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                VusermenuDto barItemMenu = GetMenuFromMenus(e.Item.Name);
                if (barItemMenu == null)
                    return;
                if (barItemMenu.Menurule == null)
                    return;
                Form form = this.MdiChildren.FirstOrDefault(f => f.GetType().FullName == barItemMenu.Menurule);
                if (form == null) 
                {
                    form = ServiceProviderManager.GetForm(barItemMenu.Menurule);
                }
                form.MdiParent = this;
                form.Show();
                form.Activate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("数据是否保存，是否退出？选确定,退出窗体！", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Dispose();
            else
                e.Cancel = true;
        }
        //private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        //{

        //}

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //}
    }
}