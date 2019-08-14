using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TX.Framework.WindowUI.Forms
{

    /// <summary>
    /// MessageBox的扩展类
    /// </summary>
    /// User:Ryan  CreateTime:2011-08-10 10:56.
    public class TXMessageBoxExtensions
    {
        #region MessageBox

        public static DialogResult Info(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Info);
        }

        public static DialogResult Info(string message)
        {
            return Info("提示信息", message);
        }

        //错误信息
        public static DialogResult Error(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Error);
        }

        public static DialogResult Error(string message)
        {
            return Error("错误信息", message);
        }

        //正确信息
        public static DialogResult Succeed(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Success);
        }

        public static DialogResult Succeed(string message)
        {
            return Succeed("正确信息", message);
        }

        //询问
        public static DialogResult Question(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Question);
        }

        public static DialogResult Question(string message)
        {
            return Question("询问信息", message);
        }

        //警告
        public static DialogResult Warning(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Warning);
        }

        public static DialogResult Warning(string message)
        {
            return Warning("警告信息", message);
        }

        //各个项目中的最后弹窗
        private static DialogResult ShowMessageBox(string captionText, string message, EnumMessageBox infoType)
        {
            TXMessageBox frm = new TXMessageBox(captionText, message, infoType);
            DialogResult result = frm.ShowDialog();
            frm.Dispose();
            return result;
        }
        #endregion
    }
}
