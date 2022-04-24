﻿using DevExpress.Utils;
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
    public class MyIdentityNumberTextEdit:MyTextBox
    {
        public MyIdentityNumberTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaskSettings.Configure<MaskSettings.Regular>();
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
        }

    }
}
