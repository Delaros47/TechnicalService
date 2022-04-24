using DevExpress.Utils;
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
    public class MyToogleSwitch : ToggleSwitch
    {
        public MyToogleSwitch()
        {
            Name = "tglState";
            Properties.OffText = "Passive";
            Properties.OnText = "Active";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;

        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}