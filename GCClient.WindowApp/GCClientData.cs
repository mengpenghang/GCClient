using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Xml;
using GC.Model;

namespace GCClient.WindowApp
{
    public class GCClientData
    {
        public static RightManageC rightManageC;

        //private static Storinfo currentStorinfo;

        //public static Storinfo CurrentStorinfo
        //{
        //    get
        //    {
        //        if (currentStorinfo == null)
        //        {
        //            throw new Exception("请先选择仓库");
        //        }
        //        return currentStorinfo;
        //    }
        //    set
        //    {
        //        currentStorinfo = value;
        //    }
        //}

        //public static Storinfo GetStorinfo()
        //{
        //    return currentStorinfo;
        //}
 
        //public static List<Vuserresource> GetResources(string resourcetype)
        //{
        //    return GCClientData.rightManageC.vuserresourceList.Where(p => p.Restype == resourcetype).ToList();
        //}

        public static bool IsChina(string CString)
        {
            bool BoolValue = false;
            for (int i = 0; i < CString.Length; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(CString.Substring(i, 1))) > Convert.ToInt32(Convert.ToChar(128)))
                    return true;
            }
            return BoolValue;
        } 

        public static void GetGridView(GridView gridview, string path)
        {
            try
            {
                string strpath = Application.StartupPath;
                StringBuilder sb = new StringBuilder();
                sb.Append(strpath);
                sb.Append("\\");
                sb.Append(path);
                if (File.Exists(sb.ToString()))
                {
                    gridview.RestoreLayoutFromXml(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void SaveGridView(GridView gridview, string path)
        {
            try
            {
                string strpath = Application.StartupPath;
                StringBuilder sb = new StringBuilder();
                sb.Append(strpath);
                sb.Append("\\");
                sb.Append(path);
                int length = sb.ToString().LastIndexOf("\\");
                if (Directory.Exists(sb.ToString().Substring(0, length)) == false)
                {
                    Directory.CreateDirectory(sb.ToString().Substring(0, length));
                }
                gridview.SaveLayoutToXml(sb.ToString());
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }

        public static string GetSkinStyle(string appkey)
        {
            string splitposition = string.Empty;
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\LayOut\\splitposition.xml");
            XmlNode xmlnode = doc.SelectSingleNode("//userSettings/add[@key='" + appkey + "']");
            if (xmlnode != null)
            {
                splitposition = xmlnode.Attributes[1].InnerText;
            }
            return splitposition;
        }

        public static int GetSplitPosition(string appkey)
        {
            int splitposition = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\LayOut\\splitposition.xml");
            XmlNode xmlnode = doc.SelectSingleNode("//userSettings/add[@key='" + appkey + "']");
            if (xmlnode != null)
            {
                splitposition = Convert.ToInt32(xmlnode.Attributes[1].InnerText);
            }
            return splitposition;
        }
        public static void SaveSplitPosition(string appkey, string appvalue)
        {
            string configfilename = Application.StartupPath + "\\LayOut\\splitposition.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configfilename);
            XmlNode xnode;
            XmlElement xelem1;
            XmlElement xelem2;
            xnode = doc.SelectSingleNode("//userSettings");

            xelem1 = (XmlElement)xnode.SelectSingleNode("//add[@key='" + appkey + "']");
            if (xelem1 != null)
                xelem1.SetAttribute("value", appvalue);
            else
            {
                xelem2 = doc.CreateElement("add");
                xelem2.SetAttribute("key", appkey);
                xelem2.SetAttribute("value", appvalue);
                xnode.AppendChild(xelem2);
            }
            doc.Save(Application.StartupPath + "\\LayOut\\splitposition.xml");

        }

        //add by RC
        public static void ShowGCsage(string msgString)
        {
            XtraMessageBox.Show(msgString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SetComboBox(ComboBoxEdit combox, string resourceType)
        {
            try
            {
                //combox.Properties.Items.Clear();
                //foreach (var item in GCClientData.GetResources(resourceType))
                //{
                //    combox.Properties.Items.Add(item.Resname);
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void ExportToExcel(GridView gridview, string filename)
        {
            if (gridview.RowCount == 0)
            {
                return;
            }
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Excel文挡|.xls";
            savefiledialog.ShowDialog();
            if (savefiledialog.FileName == "")
            {
                return;
            }
            gridview.ExportToXls(savefiledialog.FileName);
            ShowGCsage("数据已导入指定目录！");
        }        
    }
}
