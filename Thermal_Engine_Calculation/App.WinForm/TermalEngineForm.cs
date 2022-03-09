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
        Color BackColorMain = Color.FromArgb(0, 102, 204);
        Color BackColorTool = Color.FromArgb(0, 102, 204);
        Color BackColorResetButton = Color.FromArgb(0, 102, 204);
        Color BackColorCalculateButton = Color.FromArgb(0, 102, 204);
        Color ForeColorMain = Color.FromArgb(0, 102, 204);


        public TermalEngineForm()
        {
            InitializeComponent();

            //#region TermalEngineForm
            //ClientSize = new System.Drawing.Size(800, 600);
            //MinimumSize = new System.Drawing.Size(100, 100);
            //#endregion

            //#region panelForButton
            //this.panelForButton.Size = new System.Drawing.Size(350, 450);
            //#endregion

            //#region panelForEnter
            //this.panelForEnter.Size = new System.Drawing.Size(550, 140);
            //this.panelForEnter.MinimumSize = new System.Drawing.Size(500, 120);
            //this.panelForEnter.BackColor = BackColorMain;
            //#endregion

            //#region panelForResetAndCalculate
            //this.panelForResetAndCalculate.Size = new System.Drawing.Size(550, 86);
            //#endregion

            //#region panelForReset
            //this.panelForReset.Size = new System.Drawing.Size(270, 86);
            //#endregion

            //#region panelForCalculate
            //this.panelForCalculate.Size = new System.Drawing.Size(270, 86);
            //#endregion

            //#region panelForListing
            //this.panelForListing.Size = new System.Drawing.Size(550, 328);
            //#endregion

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

        private void TermalEngineForm_Load(object sender, EventArgs e)
        {

        }

        private void panelForListing_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
