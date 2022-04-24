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
    public class MySimpleButton : SimpleButton
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;

        }
    }
}