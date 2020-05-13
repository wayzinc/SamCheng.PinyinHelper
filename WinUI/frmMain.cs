/*!
 * Sam.Cheng Pinyin Helper
 * http://300830.com
 *
 * Copyright 2020 Sam.Cheng
 * Released under the MIT license
 *
 * Date: 2020-04-24
 */
namespace SamCheng.PinyinHelper
{
    #region _Spaces
    using Core;
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    #endregion

    [ComVisible(true)]
    public partial class frmMain : Form
    {
        #region _Init
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region _Variables
        #endregion

        #region _Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitWebBrowser();
            webViewContent.DocumentCompleted += webViewContent_DocumentCompleted;
        }
        #endregion

        #region Pinyin
        /// <summary>
        /// 注音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZhuyin_Click(object sender, EventArgs e)
        {
            var _ResultData = PinyinUntil.GetCNPinyin(txtContent.Text);

            InvokeWebBrowser("setTitle", txtTitle.Text.Trim());
            InvokeWebBrowser("setAuthor", txtAuthor.Text.Trim());
            InvokeWebBrowser("setContent", PinyinUntil.ToWebJsArray(_ResultData));
            InvokeWebBrowser("showViewData", "");
        }
        #endregion

        #region WebBrowser     
        /// <summary>
        /// 执行JavaScript方法
        /// </summary>
        /// <param name="FunName"></param>
        /// <param name="SetData"></param>
        private void InvokeWebBrowser(string FunName, object SetData)
        {
            webViewContent.Document.InvokeScript(FunName, new object[] { SetData });
        }

        /// <summary>
        /// 初始化浏览器
        /// </summary>
        private void InitWebBrowser()
        {
            webViewContent.Navigate("about:blank");
            webViewContent.Navigate(Application.StartupPath + @"\App_Data\template.html");

            // 防止 WebBrowser 控件打开拖放到其上的文件。
            webViewContent.AllowWebBrowserDrop = false;

            // 防止 WebBrowser 控件在用户右击它时显示其快捷菜单.
            //webViewContent.IsWebBrowserContextMenuEnabled = false;

            // 以防止 WebBrowser 控件响应快捷键。
            webViewContent.WebBrowserShortcutsEnabled = false;

            // 以防止 WebBrowser 控件显示脚本代码问题的错误信息。    
            webViewContent.ScriptErrorsSuppressed = false;

            // 这个属性比较重要，可以通过这个属性，把后台代码中的数据，传递到JS中，供内嵌的网页使用
            webViewContent.ObjectForScripting = this;
        }

        private void webViewContent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            // Ignore the error and suppress the error dialog box. 
            e.Handled = true;
        }
        #endregion
    }
}