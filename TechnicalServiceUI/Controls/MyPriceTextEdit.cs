using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceUI.Controls
{
    [ToolboxItem(true)]
    public class MyPriceTextEdit:TextEdit
    {
        public MyPriceTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.MaskSettings.Configure<MaskSettings.Numeric>();
            Properties.Mask.EditMask = "c";

        }

    }
}
