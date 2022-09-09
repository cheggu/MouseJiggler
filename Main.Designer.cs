
namespace MouseJiggler
{
    partial class Main
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkJiggleConstant = new System.Windows.Forms.CheckBox();
            this.chkJiggleEveryX = new System.Windows.Forms.CheckBox();
            this.chkJiggleRandom = new System.Windows.Forms.CheckBox();
            this.chkJiggleUntil = new System.Windows.Forms.CheckBox();
            this.lblSettingsJiggle = new System.Windows.Forms.Label();
            this.lblSettingsClick = new System.Windows.Forms.Label();
            this.lblSettingsUtils = new System.Windows.Forms.Label();
            this.chkClick = new System.Windows.Forms.CheckBox();
            this.chkClickEvery = new System.Windows.Forms.CheckBox();
            this.chkClickRandom = new System.Windows.Forms.CheckBox();
            this.chkUtilHide = new System.Windows.Forms.CheckBox();
            this.chkUtilHideKeybind = new System.Windows.Forms.CheckBox();
            this.chkUtilPauseKeybind = new System.Windows.Forms.CheckBox();
            this.chkUtilUsableMode = new System.Windows.Forms.CheckBox();
            this.chkJiggle = new System.Windows.Forms.CheckBox();
            this.chkClickPassthrough = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(195, 422);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkJiggleConstant
            // 
            this.chkJiggleConstant.AutoSize = true;
            this.chkJiggleConstant.Location = new System.Drawing.Point(48, 60);
            this.chkJiggleConstant.Name = "chkJiggleConstant";
            this.chkJiggleConstant.Size = new System.Drawing.Size(98, 17);
            this.chkJiggleConstant.TabIndex = 2;
            this.chkJiggleConstant.Text = "Constant Jiggle";
            this.chkJiggleConstant.UseVisualStyleBackColor = true;
            this.chkJiggleConstant.CheckedChanged += new System.EventHandler(this.chkJiggleConstant_CheckedChanged);
            // 
            // chkJiggleEveryX
            // 
            this.chkJiggleEveryX.AutoSize = true;
            this.chkJiggleEveryX.Location = new System.Drawing.Point(48, 83);
            this.chkJiggleEveryX.Name = "chkJiggleEveryX";
            this.chkJiggleEveryX.Size = new System.Drawing.Size(131, 17);
            this.chkJiggleEveryX.TabIndex = 3;
            this.chkJiggleEveryX.Text = "Jiggle every X minutes";
            this.chkJiggleEveryX.UseVisualStyleBackColor = true;
            this.chkJiggleEveryX.CheckedChanged += new System.EventHandler(this.chkJiggleEveryX_CheckedChanged);
            // 
            // chkJiggleRandom
            // 
            this.chkJiggleRandom.AutoSize = true;
            this.chkJiggleRandom.Location = new System.Drawing.Point(48, 106);
            this.chkJiggleRandom.Name = "chkJiggleRandom";
            this.chkJiggleRandom.Size = new System.Drawing.Size(96, 17);
            this.chkJiggleRandom.TabIndex = 4;
            this.chkJiggleRandom.Text = "Random Jiggle";
            this.chkJiggleRandom.UseVisualStyleBackColor = true;
            this.chkJiggleRandom.CheckedChanged += new System.EventHandler(this.chkJiggleRandom_CheckedChanged);
            // 
            // chkJiggleUntil
            // 
            this.chkJiggleUntil.AutoSize = true;
            this.chkJiggleUntil.Location = new System.Drawing.Point(48, 129);
            this.chkJiggleUntil.Name = "chkJiggleUntil";
            this.chkJiggleUntil.Size = new System.Drawing.Size(77, 17);
            this.chkJiggleUntil.TabIndex = 5;
            this.chkJiggleUntil.Text = "Jiggle Until";
            this.chkJiggleUntil.UseVisualStyleBackColor = true;
            this.chkJiggleUntil.CheckedChanged += new System.EventHandler(this.chkJiggleUntil_CheckedChanged);
            // 
            // lblSettingsJiggle
            // 
            this.lblSettingsJiggle.AutoSize = true;
            this.lblSettingsJiggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsJiggle.Location = new System.Drawing.Point(12, 9);
            this.lblSettingsJiggle.Name = "lblSettingsJiggle";
            this.lblSettingsJiggle.Size = new System.Drawing.Size(87, 15);
            this.lblSettingsJiggle.TabIndex = 6;
            this.lblSettingsJiggle.Text = "Jiggle Settings";
            // 
            // lblSettingsClick
            // 
            this.lblSettingsClick.AutoSize = true;
            this.lblSettingsClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsClick.Location = new System.Drawing.Point(12, 157);
            this.lblSettingsClick.Name = "lblSettingsClick";
            this.lblSettingsClick.Size = new System.Drawing.Size(80, 15);
            this.lblSettingsClick.TabIndex = 7;
            this.lblSettingsClick.Text = "Click Settings";
            // 
            // lblSettingsUtils
            // 
            this.lblSettingsUtils.AutoSize = true;
            this.lblSettingsUtils.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsUtils.Location = new System.Drawing.Point(12, 261);
            this.lblSettingsUtils.Name = "lblSettingsUtils";
            this.lblSettingsUtils.Size = new System.Drawing.Size(72, 15);
            this.lblSettingsUtils.TabIndex = 8;
            this.lblSettingsUtils.Text = "Util Settings";
            // 
            // chkClick
            // 
            this.chkClick.AutoSize = true;
            this.chkClick.Location = new System.Drawing.Point(15, 184);
            this.chkClick.Name = "chkClick";
            this.chkClick.Size = new System.Drawing.Size(49, 17);
            this.chkClick.TabIndex = 9;
            this.chkClick.Text = "Click";
            this.chkClick.UseVisualStyleBackColor = true;
            this.chkClick.CheckedChanged += new System.EventHandler(this.chkClick_CheckedChanged);
            // 
            // chkClickEvery
            // 
            this.chkClickEvery.AutoSize = true;
            this.chkClickEvery.Location = new System.Drawing.Point(48, 207);
            this.chkClickEvery.Name = "chkClickEvery";
            this.chkClickEvery.Size = new System.Drawing.Size(127, 17);
            this.chkClickEvery.TabIndex = 10;
            this.chkClickEvery.Text = "Click every X minutes";
            this.chkClickEvery.UseVisualStyleBackColor = true;
            this.chkClickEvery.CheckedChanged += new System.EventHandler(this.chkClickEvery_CheckedChanged);
            // 
            // chkClickRandom
            // 
            this.chkClickRandom.AutoSize = true;
            this.chkClickRandom.Location = new System.Drawing.Point(48, 230);
            this.chkClickRandom.Name = "chkClickRandom";
            this.chkClickRandom.Size = new System.Drawing.Size(92, 17);
            this.chkClickRandom.TabIndex = 11;
            this.chkClickRandom.Text = "Random Click";
            this.chkClickRandom.UseVisualStyleBackColor = true;
            this.chkClickRandom.CheckedChanged += new System.EventHandler(this.chkClickRandom_CheckedChanged);
            // 
            // chkUtilHide
            // 
            this.chkUtilHide.AutoSize = true;
            this.chkUtilHide.Location = new System.Drawing.Point(15, 288);
            this.chkUtilHide.Name = "chkUtilHide";
            this.chkUtilHide.Size = new System.Drawing.Size(169, 17);
            this.chkUtilHide.TabIndex = 12;
            this.chkUtilHide.Text = "Hide this Window while Active";
            this.chkUtilHide.UseVisualStyleBackColor = true;
            // 
            // chkUtilHideKeybind
            // 
            this.chkUtilHideKeybind.AutoSize = true;
            this.chkUtilHideKeybind.Location = new System.Drawing.Point(15, 311);
            this.chkUtilHideKeybind.Name = "chkUtilHideKeybind";
            this.chkUtilHideKeybind.Size = new System.Drawing.Size(159, 17);
            this.chkUtilHideKeybind.TabIndex = 13;
            this.chkUtilHideKeybind.Text = "Custom Show/Hide Keybind";
            this.chkUtilHideKeybind.UseVisualStyleBackColor = true;
            // 
            // chkUtilPauseKeybind
            // 
            this.chkUtilPauseKeybind.AutoSize = true;
            this.chkUtilPauseKeybind.Location = new System.Drawing.Point(15, 334);
            this.chkUtilPauseKeybind.Name = "chkUtilPauseKeybind";
            this.chkUtilPauseKeybind.Size = new System.Drawing.Size(179, 17);
            this.chkUtilPauseKeybind.TabIndex = 14;
            this.chkUtilPauseKeybind.Text = "Custom Pause/Resume Keybind";
            this.chkUtilPauseKeybind.UseVisualStyleBackColor = true;
            // 
            // chkUtilUsableMode
            // 
            this.chkUtilUsableMode.AutoSize = true;
            this.chkUtilUsableMode.Location = new System.Drawing.Point(15, 380);
            this.chkUtilUsableMode.Name = "chkUtilUsableMode";
            this.chkUtilUsableMode.Size = new System.Drawing.Size(152, 17);
            this.chkUtilUsableMode.TabIndex = 15;
            this.chkUtilUsableMode.Text = "Usable While Active Mode";
            this.chkUtilUsableMode.UseVisualStyleBackColor = true;
            // 
            // chkJiggle
            // 
            this.chkJiggle.AutoSize = true;
            this.chkJiggle.Location = new System.Drawing.Point(15, 37);
            this.chkJiggle.Name = "chkJiggle";
            this.chkJiggle.Size = new System.Drawing.Size(53, 17);
            this.chkJiggle.TabIndex = 17;
            this.chkJiggle.Text = "Jiggle";
            this.chkJiggle.UseVisualStyleBackColor = true;
            this.chkJiggle.CheckedChanged += new System.EventHandler(this.chkJiggle_CheckedChanged);
            // 
            // chkClickPassthrough
            // 
            this.chkClickPassthrough.AutoSize = true;
            this.chkClickPassthrough.Location = new System.Drawing.Point(15, 357);
            this.chkClickPassthrough.Name = "chkClickPassthrough";
            this.chkClickPassthrough.Size = new System.Drawing.Size(111, 17);
            this.chkClickPassthrough.TabIndex = 18;
            this.chkClickPassthrough.Text = "Click Passthrough";
            this.chkClickPassthrough.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 463);
            this.Controls.Add(this.chkClickPassthrough);
            this.Controls.Add(this.chkJiggle);
            this.Controls.Add(this.chkUtilUsableMode);
            this.Controls.Add(this.chkUtilPauseKeybind);
            this.Controls.Add(this.chkUtilHideKeybind);
            this.Controls.Add(this.chkUtilHide);
            this.Controls.Add(this.chkClickRandom);
            this.Controls.Add(this.chkClickEvery);
            this.Controls.Add(this.chkClick);
            this.Controls.Add(this.lblSettingsUtils);
            this.Controls.Add(this.lblSettingsClick);
            this.Controls.Add(this.lblSettingsJiggle);
            this.Controls.Add(this.chkJiggleUntil);
            this.Controls.Add(this.chkJiggleRandom);
            this.Controls.Add(this.chkJiggleEveryX);
            this.Controls.Add(this.chkJiggleConstant);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Name = "Main";
            this.Text = "Mouse Jiggler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkJiggleConstant;
        private System.Windows.Forms.CheckBox chkJiggleEveryX;
        private System.Windows.Forms.CheckBox chkJiggleRandom;
        private System.Windows.Forms.CheckBox chkJiggleUntil;
        private System.Windows.Forms.Label lblSettingsJiggle;
        private System.Windows.Forms.Label lblSettingsClick;
        private System.Windows.Forms.Label lblSettingsUtils;
        private System.Windows.Forms.CheckBox chkClick;
        private System.Windows.Forms.CheckBox chkClickEvery;
        private System.Windows.Forms.CheckBox chkClickRandom;
        private System.Windows.Forms.CheckBox chkUtilHide;
        private System.Windows.Forms.CheckBox chkUtilHideKeybind;
        private System.Windows.Forms.CheckBox chkUtilPauseKeybind;
        private System.Windows.Forms.CheckBox chkUtilUsableMode;
        private System.Windows.Forms.CheckBox chkJiggle;
        private System.Windows.Forms.CheckBox chkClickPassthrough;
    }
}

