using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceUI.Controls
{
    [ToolboxItem(true)]
    public class MyLookUpEdit:LookUpEdit
    {
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Properties.NullText = "";
        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
