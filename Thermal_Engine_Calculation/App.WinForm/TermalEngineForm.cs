using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Thermal_Engine_Calculation.App.WinForm
{
    public partial class TermalEngineForm : Form
    {
        public TermalEngineForm()
        {
            InitializeComponent();

            #region Add button
            for (int i = 0; i < 30; i++)
            {
                panelForButton.Controls.Add(new ButtonForVariables()
                {
                    Text = $"Button {i + 1}",
                    Dock = DockStyle.Top,
                    Width = panelForButton.Width,
                });
            }
            #endregion
        }
    }
}
