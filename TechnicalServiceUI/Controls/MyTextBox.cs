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
    public class MyTextBox:TextEdit
    {

        public MyTextBox()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
