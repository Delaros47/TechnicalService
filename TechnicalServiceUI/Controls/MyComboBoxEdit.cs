using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceUI.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit : ComboBoxEdit
    {
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
