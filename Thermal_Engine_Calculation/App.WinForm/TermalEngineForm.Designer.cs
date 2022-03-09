
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
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.buttonChangeValue = new System.Windows.Forms.Button();
            this.panelForReset = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelForCalculate = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panelForResetAndCalculate = new System.Windows.Forms.Panel();
            this.panelForEnter.SuspendLayout();
            this.panelForReset.SuspendLayout();
            this.panelForCalculate.SuspendLayout();
            this.panelForResetAndCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForButton
            // 
            this.panelForButton.AutoScroll = true;
            this.panelForButton.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.panelForButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForButton.Location = new System.Drawing.Point(0, 0);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(250, 518);
            this.panelForButton.TabIndex = 0;
            // 
            // panelForEnter
            // 
            this.panelForEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForEnter.Controls.Add(this.textBoxEnterValue);
            this.panelForEnter.Controls.Add(this.labelNameValue);
            this.panelForEnter.Controls.Add(this.buttonChangeValue);
            this.panelForEnter.Location = new System.Drawing.Point(250, 0);
            this.panelForEnter.MinimumSize = new System.Drawing.Size(500, 120);
            this.panelForEnter.Name = "panelForEnter";
            this.panelForEnter.Size = new System.Drawing.Size(695, 122);
            this.panelForEnter.TabIndex = 1;
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Location = new System.Drawing.Point(57, 71);
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.PlaceholderText = "Переменная";
            this.textBoxEnterValue.Size = new System.Drawing.Size(262, 27);
            this.textBoxEnterValue.TabIndex = 2;
            // 
            // labelNameValue
            // 
            this.labelNameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(315, 23);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(85, 20);
            this.labelNameValue.TabIndex = 1;
            this.labelNameValue.Text = "NameValue";
            // 
            // buttonChangeValue
            // 
            this.buttonChangeValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChangeValue.Location = new System.Drawing.Point(399, 71);
            this.buttonChangeValue.Name = "buttonChangeValue";
            this.buttonChangeValue.Size = new System.Drawing.Size(94, 29);
            this.buttonChangeValue.TabIndex = 0;
            this.buttonChangeValue.Text = "button1";
            this.buttonChangeValue.UseVisualStyleBackColor = true;
            // 
            // panelForReset
            // 
            this.panelForReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForReset.Controls.Add(this.buttonReset);
            this.panelForReset.Location = new System.Drawing.Point(6, 3);
            this.panelForReset.Name = "panelForReset";
            this.panelForReset.Size = new System.Drawing.Size(313, 72);
            this.panelForReset.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReset.Location = new System.Drawing.Point(107, 24);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(85, 30);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // panelForCalculate
            // 
            this.panelForCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForCalculate.Controls.Add(this.buttonCalculate);
            this.panelForCalculate.Location = new System.Drawing.Point(325, 6);
            this.panelForCalculate.Name = "panelForCalculate";
            this.panelForCalculate.Size = new System.Drawing.Size(367, 69);
            this.panelForCalculate.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalculate.Location = new System.Drawing.Point(108, 21);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(140, 30);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Порахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // panelForResetAndCalculate
            // 
            this.panelForResetAndCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForResetAndCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForResetAndCalculate.Controls.Add(this.panelForCalculate);
            this.panelForResetAndCalculate.Controls.Add(this.panelForReset);
            this.panelForResetAndCalculate.Location = new System.Drawing.Point(250, 128);
            this.panelForResetAndCalculate.Name = "panelForResetAndCalculate";
            this.panelForResetAndCalculate.Size = new System.Drawing.Size(695, 78);
            this.panelForResetAndCalculate.TabIndex = 5;
            // 
            // TermalEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 518);
            this.Controls.Add(this.panelForResetAndCalculate);
            this.Controls.Add(this.panelForEnter);
            this.Controls.Add(this.panelForButton);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "TermalEngineForm";
            this.Text = "TermalEngineForm";
            this.Load += new System.EventHandler(this.TermalEngineForm_Load);
            this.panelForEnter.ResumeLayout(false);
            this.panelForEnter.PerformLayout();
            this.panelForReset.ResumeLayout(false);
            this.panelForCalculate.ResumeLayout(false);
            this.panelForResetAndCalculate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.Panel panelForReset;
        private System.Windows.Forms.Panel panelForEnter;
        private System.Windows.Forms.Panel panelForCalculate;
        private System.Windows.Forms.Panel panelForResetAndCalculate;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.Button buttonChangeValue;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalculate;
    }
}