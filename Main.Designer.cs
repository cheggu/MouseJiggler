
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
            this.components = new System.ComponentModel.Container();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trkJiggleIntensity = new System.Windows.Forms.TrackBar();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkJiggleIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(260, 519);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 519);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkJiggleConstant
            // 
            this.chkJiggleConstant.AutoSize = true;
            this.chkJiggleConstant.Location = new System.Drawing.Point(64, 74);
            this.chkJiggleConstant.Margin = new System.Windows.Forms.Padding(4);
            this.chkJiggleConstant.Name = "chkJiggleConstant";
            this.chkJiggleConstant.Size = new System.Drawing.Size(127, 21);
            this.chkJiggleConstant.TabIndex = 2;
            this.chkJiggleConstant.Text = "Constant Jiggle";
            this.chkJiggleConstant.UseVisualStyleBackColor = true;
            this.chkJiggleConstant.CheckedChanged += new System.EventHandler(this.chkJiggleConstant_CheckedChanged);
            // 
            // chkJiggleEveryX
            // 
            this.chkJiggleEveryX.AutoSize = true;
            this.chkJiggleEveryX.Location = new System.Drawing.Point(64, 102);
            this.chkJiggleEveryX.Margin = new System.Windows.Forms.Padding(4);
            this.chkJiggleEveryX.Name = "chkJiggleEveryX";
            this.chkJiggleEveryX.Size = new System.Drawing.Size(172, 21);
            this.chkJiggleEveryX.TabIndex = 3;
            this.chkJiggleEveryX.Text = "Jiggle every X minutes";
            this.chkJiggleEveryX.UseVisualStyleBackColor = true;
            this.chkJiggleEveryX.CheckedChanged += new System.EventHandler(this.chkJiggleEveryX_CheckedChanged);
            // 
            // chkJiggleRandom
            // 
            this.chkJiggleRandom.AutoSize = true;
            this.chkJiggleRandom.Location = new System.Drawing.Point(64, 130);
            this.chkJiggleRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkJiggleRandom.Name = "chkJiggleRandom";
            this.chkJiggleRandom.Size = new System.Drawing.Size(124, 21);
            this.chkJiggleRandom.TabIndex = 4;
            this.chkJiggleRandom.Text = "Random Jiggle";
            this.chkJiggleRandom.UseVisualStyleBackColor = true;
            this.chkJiggleRandom.CheckedChanged += new System.EventHandler(this.chkJiggleRandom_CheckedChanged);
            // 
            // chkJiggleUntil
            // 
            this.chkJiggleUntil.AutoSize = true;
            this.chkJiggleUntil.Location = new System.Drawing.Point(64, 159);
            this.chkJiggleUntil.Margin = new System.Windows.Forms.Padding(4);
            this.chkJiggleUntil.Name = "chkJiggleUntil";
            this.chkJiggleUntil.Size = new System.Drawing.Size(99, 21);
            this.chkJiggleUntil.TabIndex = 5;
            this.chkJiggleUntil.Text = "Jiggle Until";
            this.chkJiggleUntil.UseVisualStyleBackColor = true;
            this.chkJiggleUntil.CheckedChanged += new System.EventHandler(this.chkJiggleUntil_CheckedChanged);
            // 
            // lblSettingsJiggle
            // 
            this.lblSettingsJiggle.AutoSize = true;
            this.lblSettingsJiggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsJiggle.Location = new System.Drawing.Point(16, 11);
            this.lblSettingsJiggle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettingsJiggle.Name = "lblSettingsJiggle";
            this.lblSettingsJiggle.Size = new System.Drawing.Size(103, 18);
            this.lblSettingsJiggle.TabIndex = 6;
            this.lblSettingsJiggle.Text = "Jiggle Settings";
            // 
            // lblSettingsClick
            // 
            this.lblSettingsClick.AutoSize = true;
            this.lblSettingsClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsClick.Location = new System.Drawing.Point(16, 193);
            this.lblSettingsClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettingsClick.Name = "lblSettingsClick";
            this.lblSettingsClick.Size = new System.Drawing.Size(98, 18);
            this.lblSettingsClick.TabIndex = 7;
            this.lblSettingsClick.Text = "Click Settings";
            // 
            // lblSettingsUtils
            // 
            this.lblSettingsUtils.AutoSize = true;
            this.lblSettingsUtils.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsUtils.Location = new System.Drawing.Point(16, 321);
            this.lblSettingsUtils.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettingsUtils.Name = "lblSettingsUtils";
            this.lblSettingsUtils.Size = new System.Drawing.Size(86, 18);
            this.lblSettingsUtils.TabIndex = 8;
            this.lblSettingsUtils.Text = "Util Settings";
            // 
            // chkClick
            // 
            this.chkClick.AutoSize = true;
            this.chkClick.Location = new System.Drawing.Point(20, 226);
            this.chkClick.Margin = new System.Windows.Forms.Padding(4);
            this.chkClick.Name = "chkClick";
            this.chkClick.Size = new System.Drawing.Size(59, 21);
            this.chkClick.TabIndex = 9;
            this.chkClick.Text = "Click";
            this.chkClick.UseVisualStyleBackColor = true;
            this.chkClick.CheckedChanged += new System.EventHandler(this.chkClick_CheckedChanged);
            // 
            // chkClickEvery
            // 
            this.chkClickEvery.AutoSize = true;
            this.chkClickEvery.Location = new System.Drawing.Point(64, 255);
            this.chkClickEvery.Margin = new System.Windows.Forms.Padding(4);
            this.chkClickEvery.Name = "chkClickEvery";
            this.chkClickEvery.Size = new System.Drawing.Size(164, 21);
            this.chkClickEvery.TabIndex = 10;
            this.chkClickEvery.Text = "Click every X minutes";
            this.chkClickEvery.UseVisualStyleBackColor = true;
            this.chkClickEvery.CheckedChanged += new System.EventHandler(this.chkClickEvery_CheckedChanged);
            // 
            // chkClickRandom
            // 
            this.chkClickRandom.AutoSize = true;
            this.chkClickRandom.Location = new System.Drawing.Point(64, 283);
            this.chkClickRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkClickRandom.Name = "chkClickRandom";
            this.chkClickRandom.Size = new System.Drawing.Size(116, 21);
            this.chkClickRandom.TabIndex = 11;
            this.chkClickRandom.Text = "Random Click";
            this.chkClickRandom.UseVisualStyleBackColor = true;
            this.chkClickRandom.CheckedChanged += new System.EventHandler(this.chkClickRandom_CheckedChanged);
            // 
            // chkUtilHide
            // 
            this.chkUtilHide.AutoSize = true;
            this.chkUtilHide.Location = new System.Drawing.Point(20, 354);
            this.chkUtilHide.Margin = new System.Windows.Forms.Padding(4);
            this.chkUtilHide.Name = "chkUtilHide";
            this.chkUtilHide.Size = new System.Drawing.Size(215, 21);
            this.chkUtilHide.TabIndex = 12;
            this.chkUtilHide.Text = "Hide this Window while Active";
            this.chkUtilHide.UseVisualStyleBackColor = true;
            // 
            // chkUtilHideKeybind
            // 
            this.chkUtilHideKeybind.AutoSize = true;
            this.chkUtilHideKeybind.Location = new System.Drawing.Point(20, 383);
            this.chkUtilHideKeybind.Margin = new System.Windows.Forms.Padding(4);
            this.chkUtilHideKeybind.Name = "chkUtilHideKeybind";
            this.chkUtilHideKeybind.Size = new System.Drawing.Size(203, 21);
            this.chkUtilHideKeybind.TabIndex = 13;
            this.chkUtilHideKeybind.Text = "Custom Show/Hide Keybind";
            this.chkUtilHideKeybind.UseVisualStyleBackColor = true;
            // 
            // chkUtilPauseKeybind
            // 
            this.chkUtilPauseKeybind.AutoSize = true;
            this.chkUtilPauseKeybind.Location = new System.Drawing.Point(20, 411);
            this.chkUtilPauseKeybind.Margin = new System.Windows.Forms.Padding(4);
            this.chkUtilPauseKeybind.Name = "chkUtilPauseKeybind";
            this.chkUtilPauseKeybind.Size = new System.Drawing.Size(232, 21);
            this.chkUtilPauseKeybind.TabIndex = 14;
            this.chkUtilPauseKeybind.Text = "Custom Pause/Resume Keybind";
            this.chkUtilPauseKeybind.UseVisualStyleBackColor = true;
            // 
            // chkUtilUsableMode
            // 
            this.chkUtilUsableMode.AutoSize = true;
            this.chkUtilUsableMode.Location = new System.Drawing.Point(20, 468);
            this.chkUtilUsableMode.Margin = new System.Windows.Forms.Padding(4);
            this.chkUtilUsableMode.Name = "chkUtilUsableMode";
            this.chkUtilUsableMode.Size = new System.Drawing.Size(194, 21);
            this.chkUtilUsableMode.TabIndex = 15;
            this.chkUtilUsableMode.Text = "Usable While Active Mode";
            this.chkUtilUsableMode.UseVisualStyleBackColor = true;
            // 
            // chkJiggle
            // 
            this.chkJiggle.AutoSize = true;
            this.chkJiggle.Location = new System.Drawing.Point(20, 46);
            this.chkJiggle.Margin = new System.Windows.Forms.Padding(4);
            this.chkJiggle.Name = "chkJiggle";
            this.chkJiggle.Size = new System.Drawing.Size(67, 21);
            this.chkJiggle.TabIndex = 17;
            this.chkJiggle.Text = "Jiggle";
            this.chkJiggle.UseVisualStyleBackColor = true;
            this.chkJiggle.CheckedChanged += new System.EventHandler(this.chkJiggle_CheckedChanged);
            // 
            // chkClickPassthrough
            // 
            this.chkClickPassthrough.AutoSize = true;
            this.chkClickPassthrough.Location = new System.Drawing.Point(20, 439);
            this.chkClickPassthrough.Margin = new System.Windows.Forms.Padding(4);
            this.chkClickPassthrough.Name = "chkClickPassthrough";
            this.chkClickPassthrough.Size = new System.Drawing.Size(143, 21);
            this.chkClickPassthrough.TabIndex = 18;
            this.chkClickPassthrough.Text = "Click Passthrough";
            this.chkClickPassthrough.UseVisualStyleBackColor = true;
            // 
            // trkJiggleIntensity
            // 
            this.trkJiggleIntensity.Location = new System.Drawing.Point(12, 519);
            this.trkJiggleIntensity.Maximum = 100;
            this.trkJiggleIntensity.Name = "trkJiggleIntensity";
            this.trkJiggleIntensity.Size = new System.Drawing.Size(148, 56);
            this.trkJiggleIntensity.TabIndex = 19;
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Location = new System.Drawing.Point(17, 499);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(60, 17);
            this.lblIntensity.TabIndex = 20;
            this.lblIntensity.Text = "Intensity";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 570);
            this.Controls.Add(this.lblIntensity);
            this.Controls.Add(this.trkJiggleIntensity);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Mouse Jiggler";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkJiggleIntensity)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar trkJiggleIntensity;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.Timer timer1;
    }
}

