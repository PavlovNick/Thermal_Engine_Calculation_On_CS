using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Thermal_Engine_Calculation.App.WinForm
{
    class ButtonForVariables:Button
    {
        public int _beacon;
        public string _nameOfButton;
        public object _valueOfButton;
        public ButtonForVariables():base()
        {
            base.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            base.FontHeight = 12;
            base.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            base.Height = 45;
            base.FlatStyle = FlatStyle.Flat;
        }
    }
}
