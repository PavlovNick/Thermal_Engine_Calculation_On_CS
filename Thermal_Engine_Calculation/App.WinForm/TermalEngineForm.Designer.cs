
namespace Thermal_Engine_Calculation.App.WinForm
{
    partial class TermalEngineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelForButton = new System.Windows.Forms.Panel();
            this.panelForEnter = new System.Windows.Forms.Panel();
            this.buttonChangeValue = new System.Windows.Forms.Button();
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.panelForResetAndCalculate = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelForListing = new System.Windows.Forms.Panel();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.panelForEnter.SuspendLayout();
            this.panelForResetAndCalculate.SuspendLayout();
            this.panelForListing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForButton
            // 
            this.panelForButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelForButton.AutoScroll = true;
            this.panelForButton.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.panelForButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelForButton.Location = new System.Drawing.Point(0, 0);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(400, 456);
            this.panelForButton.TabIndex = 0;
            // 
            // panelForEnter
            // 
            this.panelForEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelForEnter.Controls.Add(this.buttonChangeValue);
            this.panelForEnter.Controls.Add(this.textBoxEnterValue);
            this.panelForEnter.Controls.Add(this.labelNameValue);
            this.panelForEnter.Location = new System.Drawing.Point(400, 0);
            this.panelForEnter.Name = "panelForEnter";
            this.panelForEnter.Size = new System.Drawing.Size(632, 100);
            this.panelForEnter.TabIndex = 1;
            // 
            // buttonChangeValue
            // 
            this.buttonChangeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeValue.Location = new System.Drawing.Point(401, 50);
            this.buttonChangeValue.Name = "buttonChangeValue";
            this.buttonChangeValue.Size = new System.Drawing.Size(94, 29);
            this.buttonChangeValue.TabIndex = 2;
            this.buttonChangeValue.Text = "Змінити";
            this.buttonChangeValue.UseVisualStyleBackColor = true;
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnterValue.Location = new System.Drawing.Point(35, 52);
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.PlaceholderText = "Значення змінної";
            this.textBoxEnterValue.Size = new System.Drawing.Size(283, 27);
            this.textBoxEnterValue.TabIndex = 1;
            // 
            // labelNameValue
            // 
            this.labelNameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(35, 9);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(97, 20);
            this.labelNameValue.TabIndex = 0;
            this.labelNameValue.Text = "Давай падла";
            // 
            // panelForResetAndCalculate
            // 
            this.panelForResetAndCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForResetAndCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelForResetAndCalculate.Controls.Add(this.buttonCalculate);
            this.panelForResetAndCalculate.Controls.Add(this.buttonReset);
            this.panelForResetAndCalculate.Location = new System.Drawing.Point(400, 100);
            this.panelForResetAndCalculate.Name = "panelForResetAndCalculate";
            this.panelForResetAndCalculate.Size = new System.Drawing.Size(632, 100);
            this.panelForResetAndCalculate.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCalculate.AutoEllipsis = true;
            this.buttonCalculate.Location = new System.Drawing.Point(317, 41);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(178, 29);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReset.AutoEllipsis = true;
            this.buttonReset.Location = new System.Drawing.Point(80, 41);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(203, 29);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // panelForListing
            // 
            this.panelForListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForListing.BackColor = System.Drawing.SystemColors.Info;
            this.panelForListing.Controls.Add(this.richTextBoxOutput);
            this.panelForListing.Location = new System.Drawing.Point(400, 200);
            this.panelForListing.Name = "panelForListing";
            this.panelForListing.Size = new System.Drawing.Size(632, 256);
            this.panelForListing.TabIndex = 3;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(514, 235);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.ReadOnly = true;
            // 
            // TermalEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.panelForListing);
            this.Controls.Add(this.panelForResetAndCalculate);
            this.Controls.Add(this.panelForEnter);
            this.Controls.Add(this.panelForButton);
            this.Name = "TermalEngineForm";
            this.Text = "TermalEngineForm";
            this.panelForEnter.ResumeLayout(false);
            this.panelForEnter.PerformLayout();
            this.panelForResetAndCalculate.ResumeLayout(false);
            this.panelForListing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.Panel panelForEnter;
        private System.Windows.Forms.Panel panelForResetAndCalculate;
        private System.Windows.Forms.Panel panelForListing;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Button buttonChangeValue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
    }
}