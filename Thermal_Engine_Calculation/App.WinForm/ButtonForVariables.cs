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
            base.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            base.FontHeight = 23;
            base.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            base.Height = 57;
            base.FlatStyle = FlatStyle.Flat;
            base.FlatAppearance.BorderSize = 1;
            base.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(233, 233, 233);
            base.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            base.Padding = new Padding(28, 0, 0, 0);
        }
    }
}
