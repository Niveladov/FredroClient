using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinkleClient.ExtraClasses
{
    internal static class TwinkleMessageBox
    {
        public static DialogResult ShowSucces(string message)
        {
            XtraMessageBox.SmartTextWrap = true;
            return XtraMessageBox.Show(message, "Успешно",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowError(string message)
        {
            XtraMessageBox.SmartTextWrap = true;
            return XtraMessageBox.Show(message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestionYesNo (string message)
        {
            XtraMessageBox.SmartTextWrap = true;
            return XtraMessageBox.Show(message, "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
