namespace Components
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.buttonArrowBot = new System.Windows.Forms.Button();
            this.buttonArrowRight = new System.Windows.Forms.Button();
            this.buttonArrowLeft = new System.Windows.Forms.Button();
            this.buttonArrowTop = new System.Windows.Forms.Button();
            this.buttonCenterTarget = new System.Windows.Forms.Button();
            this.buttonEnabled = new System.Windows.Forms.Button();
            this.buttonVisible = new System.Windows.Forms.Button();
            this.comboBoxBorder = new System.Windows.Forms.ComboBox();
            this.labelBorderStyle = new System.Windows.Forms.Label();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.Text = "Target X = 0\r\n\r\nTarget Y = 0";
            this.targetButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRight.Controls.Add(this.buttonArrowBot);
            this.groupBoxRight.Controls.Add(this.buttonArrowRight);
            this.groupBoxRight.Controls.Add(this.buttonArrowLeft);
            this.groupBoxRight.Controls.Add(this.buttonArrowTop);
            this.groupBoxRight.Controls.Add(this.buttonCenterTarget);
            this.groupBoxRight.Controls.Add(this.buttonEnabled);
            this.groupBoxRight.Controls.Add(this.buttonVisible);
            this.groupBoxRight.Controls.Add(this.comboBoxBorder);
            this.groupBoxRight.Controls.Add(this.labelBorderStyle);
            this.groupBoxRight.Location = new System.Drawing.Point(570, 15);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(200, 500);
            this.groupBoxRight.TabIndex = 1;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "Controls";
            // 
            // buttonArrowBot
            // 
            this.buttonArrowBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArrowBot.Location = new System.Drawing.Point(74, 384);
            this.buttonArrowBot.Name = "buttonArrowBot";
            this.buttonArrowBot.Size = new System.Drawing.Size(50, 40);
            this.buttonArrowBot.TabIndex = 8;
            this.buttonArrowBot.Text = "⮟";
            this.buttonArrowBot.UseVisualStyleBackColor = true;
            // 
            // buttonArrowRight
            // 
            this.buttonArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArrowRight.Location = new System.Drawing.Point(121, 346);
            this.buttonArrowRight.Name = "buttonArrowRight";
            this.buttonArrowRight.Size = new System.Drawing.Size(50, 40);
            this.buttonArrowRight.TabIndex = 7;
            this.buttonArrowRight.Text = "⮞";
            this.buttonArrowRight.UseVisualStyleBackColor = true;
            // 
            // buttonArrowLeft
            // 
            this.buttonArrowLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArrowLeft.Location = new System.Drawing.Point(27, 346);
            this.buttonArrowLeft.Name = "buttonArrowLeft";
            this.buttonArrowLeft.Size = new System.Drawing.Size(50, 40);
            this.buttonArrowLeft.TabIndex = 6;
            this.buttonArrowLeft.Text = "⮜ ";
            this.buttonArrowLeft.UseVisualStyleBackColor = true;
            // 
            // buttonArrowTop
            // 
            this.buttonArrowTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArrowTop.Location = new System.Drawing.Point(74, 308);
            this.buttonArrowTop.Name = "buttonArrowTop";
            this.buttonArrowTop.Size = new System.Drawing.Size(50, 40);
            this.buttonArrowTop.TabIndex = 5;
            this.buttonArrowTop.Text = "⮝";
            this.buttonArrowTop.UseVisualStyleBackColor = true;
            // 
            // buttonCenterTarget
            // 
            this.buttonCenterTarget.Location = new System.Drawing.Point(37, 182);
            this.buttonCenterTarget.Name = "buttonCenterTarget";
            this.buttonCenterTarget.Size = new System.Drawing.Size(135, 22);
            this.buttonCenterTarget.TabIndex = 4;
            this.buttonCenterTarget.Text = "Center Target";
            this.buttonCenterTarget.UseVisualStyleBackColor = true;
            // 
            // buttonEnabled
            // 
            this.buttonEnabled.Location = new System.Drawing.Point(37, 140);
            this.buttonEnabled.Name = "buttonEnabled";
            this.buttonEnabled.Size = new System.Drawing.Size(135, 22);
            this.buttonEnabled.TabIndex = 3;
            this.buttonEnabled.Text = "Enabled = True";
            this.buttonEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonVisible
            // 
            this.buttonVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVisible.Location = new System.Drawing.Point(37, 99);
            this.buttonVisible.Name = "buttonVisible";
            this.buttonVisible.Size = new System.Drawing.Size(135, 22);
            this.buttonVisible.TabIndex = 2;
            this.buttonVisible.Text = "Visible = True";
            this.buttonVisible.UseVisualStyleBackColor = true;
            // 
            // comboBoxBorder
            // 
            this.comboBoxBorder.FormattingEnabled = true;
            this.comboBoxBorder.Items.AddRange(new object[] {
            "None",
            "",
            "FixedSingle",
            "",
            "Fixed3D",
            "",
            "FixedDialog",
            "",
            "Sizable",
            "",
            "FixedToolWindow",
            "",
            "SizableToolWindow"});
            this.comboBoxBorder.Location = new System.Drawing.Point(31, 45);
            this.comboBoxBorder.Name = "comboBoxBorder";
            this.comboBoxBorder.Size = new System.Drawing.Size(141, 21);
            this.comboBoxBorder.TabIndex = 1;
            // 
            // labelBorderStyle
            // 
            this.labelBorderStyle.AutoSize = true;
            this.labelBorderStyle.Location = new System.Drawing.Point(28, 29);
            this.labelBorderStyle.Name = "labelBorderStyle";
            this.labelBorderStyle.Size = new System.Drawing.Size(84, 13);
            this.labelBorderStyle.TabIndex = 0;
            this.labelBorderStyle.Text = "FormBorderStyle";
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "Form Size: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.LocationChanged += new System.EventHandler(this.mainForm_LocationChanged);
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.Button buttonArrowBot;
        private System.Windows.Forms.Button buttonArrowRight;
        private System.Windows.Forms.Button buttonArrowLeft;
        private System.Windows.Forms.Button buttonArrowTop;
        private System.Windows.Forms.Button buttonCenterTarget;
        private System.Windows.Forms.Button buttonEnabled;
        private System.Windows.Forms.Button buttonVisible;
        private System.Windows.Forms.ComboBox comboBoxBorder;
        private System.Windows.Forms.Label labelBorderStyle;
        private System.Windows.Forms.Label formSizeLabel;
    }
}

