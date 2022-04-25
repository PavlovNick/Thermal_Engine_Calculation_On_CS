
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermalEngineForm));
            this.panelForButton = new System.Windows.Forms.Panel();
            this.panelForEnter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChangeValue = new System.Windows.Forms.Button();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.panelForResetAndCalculate = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelForListing = new System.Windows.Forms.Panel();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.panelForEnter.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelForButton.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelForButton.Location = new System.Drawing.Point(0, 0);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(500, 556);
            this.panelForButton.TabIndex = 0;
            // 
            // panelForEnter
            // 
            this.panelForEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForEnter.BackColor = System.Drawing.Color.White;
            this.panelForEnter.Controls.Add(this.panel2);
            this.panelForEnter.Controls.Add(this.panel1);
            this.panelForEnter.Controls.Add(this.buttonChangeValue);
            this.panelForEnter.Controls.Add(this.labelNameValue);
            this.panelForEnter.Location = new System.Drawing.Point(500, 0);
            this.panelForEnter.Name = "panelForEnter";
            this.panelForEnter.Size = new System.Drawing.Size(882, 140);
            this.panelForEnter.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBoxEnterValue);
            this.panel2.Location = new System.Drawing.Point(33, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 55);
            this.panel2.TabIndex = 4;
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnterValue.BackColor = System.Drawing.Color.White;
            this.textBoxEnterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnterValue.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnterValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxEnterValue.Location = new System.Drawing.Point(1, 18);
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.PlaceholderText = "58,8";
            this.textBoxEnterValue.Size = new System.Drawing.Size(393, 20);
            this.textBoxEnterValue.TabIndex = 1;
            this.textBoxEnterValue.TextChanged += new System.EventHandler(this.textBoxEnterValue_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 57);
            this.panel1.TabIndex = 3;
            // 
            // buttonChangeValue
            // 
            this.buttonChangeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeValue.BackColor = System.Drawing.Color.White;
            this.buttonChangeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeValue.Font = new System.Drawing.Font("SF Pro Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeValue.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeValue.Location = new System.Drawing.Point(463, 71);
            this.buttonChangeValue.Name = "buttonChangeValue";
            this.buttonChangeValue.Size = new System.Drawing.Size(196, 57);
            this.buttonChangeValue.TabIndex = 2;
            this.buttonChangeValue.Text = "Змінити";
            this.buttonChangeValue.UseVisualStyleBackColor = false;
            this.buttonChangeValue.Click += new System.EventHandler(this.buttonChangeValue_Click_1);
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameValue.Location = new System.Drawing.Point(29, 21);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(218, 24);
            this.labelNameValue.TabIndex = 0;
            this.labelNameValue.Text = "Номінальна потужність";
            this.labelNameValue.Click += new System.EventHandler(this.labelNameValue_Click);
            // 
            // panelForResetAndCalculate
            // 
            this.panelForResetAndCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForResetAndCalculate.BackColor = System.Drawing.Color.White;
            this.panelForResetAndCalculate.Controls.Add(this.buttonCalculate);
            this.panelForResetAndCalculate.Controls.Add(this.buttonReset);
            this.panelForResetAndCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelForResetAndCalculate.Location = new System.Drawing.Point(500, 140);
            this.panelForResetAndCalculate.Name = "panelForResetAndCalculate";
            this.panelForResetAndCalculate.Size = new System.Drawing.Size(882, 125);
            this.panelForResetAndCalculate.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCalculate.AutoEllipsis = true;
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(211)))));
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("SF Pro Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(378, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(230, 57);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReset.AutoEllipsis = true;
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("SF Pro Display", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(94, 30);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(203, 57);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // panelForListing
            // 
            this.panelForListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelForListing.Controls.Add(this.richTextBoxOutput);
            this.panelForListing.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelForListing.Location = new System.Drawing.Point(500, 270);
            this.panelForListing.Name = "panelForListing";
            this.panelForListing.Size = new System.Drawing.Size(882, 286);
            this.panelForListing.TabIndex = 3;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutput.Location = new System.Drawing.Point(31, 26);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(642, 245);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.TextChanged += new System.EventHandler(this.richTextBoxOutput_TextChanged);
            // 
            // TermalEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panelForListing);
            this.Controls.Add(this.panelForResetAndCalculate);
            this.Controls.Add(this.panelForEnter);
            this.Controls.Add(this.panelForButton);
            this.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "TermalEngineForm";
            this.Text = "Розрахунок теплового двигуна";
            this.panelForEnter.ResumeLayout(false);
            this.panelForEnter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Button buttonChangeValue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Panel panel2;
    }
}