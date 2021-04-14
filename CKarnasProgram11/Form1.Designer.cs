namespace CKarnasProgram11
{
    partial class Form1
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
            this.grpFillDrain = new System.Windows.Forms.GroupBox();
            this.txtFillDrainPS = new System.Windows.Forms.TextBox();
            this.radDrainWater = new System.Windows.Forms.RadioButton();
            this.radFillWater = new System.Windows.Forms.RadioButton();
            this.nudLitPsec = new System.Windows.Forms.NumericUpDown();
            this.btnFillDrain = new System.Windows.Forms.Button();
            this.lblLitersPerSecond = new System.Windows.Forms.Label();
            this.grpTankDimensions = new System.Windows.Forms.GroupBox();
            this.btnCreateTank = new System.Windows.Forms.Button();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grpTankData = new System.Windows.Forms.GroupBox();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.btnMaxCapacity = new System.Windows.Forms.Button();
            this.btnCurrentWaterLevel = new System.Windows.Forms.Button();
            this.grpAddWithdraw = new System.Windows.Forms.GroupBox();
            this.lblAddWithdrawMessage = new System.Windows.Forms.Label();
            this.btnAddWithdraw = new System.Windows.Forms.Button();
            this.radWithdrawWater = new System.Windows.Forms.RadioButton();
            this.radAddWater = new System.Windows.Forms.RadioButton();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.lblLitersAddWithdraw = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFillDrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitPsec)).BeginInit();
            this.grpTankDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.grpTankData.SuspendLayout();
            this.grpAddWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFillDrain
            // 
            this.grpFillDrain.Controls.Add(this.txtFillDrainPS);
            this.grpFillDrain.Controls.Add(this.radDrainWater);
            this.grpFillDrain.Controls.Add(this.radFillWater);
            this.grpFillDrain.Controls.Add(this.nudLitPsec);
            this.grpFillDrain.Controls.Add(this.btnFillDrain);
            this.grpFillDrain.Controls.Add(this.lblLitersPerSecond);
            this.grpFillDrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFillDrain.Location = new System.Drawing.Point(421, 25);
            this.grpFillDrain.Name = "grpFillDrain";
            this.grpFillDrain.Size = new System.Drawing.Size(395, 545);
            this.grpFillDrain.TabIndex = 0;
            this.grpFillDrain.TabStop = false;
            this.grpFillDrain.Text = "Fill/Drain Water";
            // 
            // txtFillDrainPS
            // 
            this.txtFillDrainPS.AllowDrop = true;
            this.txtFillDrainPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFillDrainPS.Location = new System.Drawing.Point(16, 138);
            this.txtFillDrainPS.Multiline = true;
            this.txtFillDrainPS.Name = "txtFillDrainPS";
            this.txtFillDrainPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFillDrainPS.Size = new System.Drawing.Size(360, 391);
            this.txtFillDrainPS.TabIndex = 13;
            // 
            // radDrainWater
            // 
            this.radDrainWater.AutoSize = true;
            this.radDrainWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDrainWater.Location = new System.Drawing.Point(16, 83);
            this.radDrainWater.Name = "radDrainWater";
            this.radDrainWater.Size = new System.Drawing.Size(72, 28);
            this.radDrainWater.TabIndex = 11;
            this.radDrainWater.TabStop = true;
            this.radDrainWater.Text = "Drain";
            this.radDrainWater.UseVisualStyleBackColor = true;
            // 
            // radFillWater
            // 
            this.radFillWater.AutoSize = true;
            this.radFillWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFillWater.Location = new System.Drawing.Point(16, 42);
            this.radFillWater.Name = "radFillWater";
            this.radFillWater.Size = new System.Drawing.Size(52, 28);
            this.radFillWater.TabIndex = 10;
            this.radFillWater.TabStop = true;
            this.radFillWater.Text = "Fill";
            this.radFillWater.UseVisualStyleBackColor = true;
            // 
            // nudLitPsec
            // 
            this.nudLitPsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLitPsec.Location = new System.Drawing.Point(269, 42);
            this.nudLitPsec.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLitPsec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLitPsec.Name = "nudLitPsec";
            this.nudLitPsec.Size = new System.Drawing.Size(107, 29);
            this.nudLitPsec.TabIndex = 8;
            this.nudLitPsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLitPsec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFillDrain
            // 
            this.btnFillDrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillDrain.Location = new System.Drawing.Point(141, 80);
            this.btnFillDrain.Name = "btnFillDrain";
            this.btnFillDrain.Size = new System.Drawing.Size(235, 34);
            this.btnFillDrain.TabIndex = 9;
            this.btnFillDrain.Text = "Fill/Drain Water";
            this.btnFillDrain.UseVisualStyleBackColor = true;
            this.btnFillDrain.Click += new System.EventHandler(this.btnFillDrain_Click);
            // 
            // lblLitersPerSecond
            // 
            this.lblLitersPerSecond.AutoSize = true;
            this.lblLitersPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitersPerSecond.Location = new System.Drawing.Point(137, 44);
            this.lblLitersPerSecond.Name = "lblLitersPerSecond";
            this.lblLitersPerSecond.Size = new System.Drawing.Size(130, 24);
            this.lblLitersPerSecond.TabIndex = 3;
            this.lblLitersPerSecond.Text = "Liters/Second:";
            // 
            // grpTankDimensions
            // 
            this.grpTankDimensions.Controls.Add(this.btnCreateTank);
            this.grpTankDimensions.Controls.Add(this.nudDepth);
            this.grpTankDimensions.Controls.Add(this.nudRadius);
            this.grpTankDimensions.Controls.Add(this.lblDepth);
            this.grpTankDimensions.Controls.Add(this.lblRadius);
            this.grpTankDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTankDimensions.Location = new System.Drawing.Point(12, 29);
            this.grpTankDimensions.Name = "grpTankDimensions";
            this.grpTankDimensions.Size = new System.Drawing.Size(388, 174);
            this.grpTankDimensions.TabIndex = 1;
            this.grpTankDimensions.TabStop = false;
            this.grpTankDimensions.Text = "Water Tank Dimensions";
            // 
            // btnCreateTank
            // 
            this.btnCreateTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTank.Location = new System.Drawing.Point(30, 124);
            this.btnCreateTank.Name = "btnCreateTank";
            this.btnCreateTank.Size = new System.Drawing.Size(233, 34);
            this.btnCreateTank.TabIndex = 3;
            this.btnCreateTank.Text = "Create Water Tank";
            this.btnCreateTank.UseVisualStyleBackColor = true;
            this.btnCreateTank.Click += new System.EventHandler(this.btnCreateTank_Click);
            // 
            // nudDepth
            // 
            this.nudDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDepth.Location = new System.Drawing.Point(179, 79);
            this.nudDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 29);
            this.nudDepth.TabIndex = 2;
            this.nudDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRadius
            // 
            this.nudRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRadius.Location = new System.Drawing.Point(179, 38);
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 29);
            this.nudRadius.TabIndex = 1;
            this.nudRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(26, 81);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(139, 24);
            this.lblDepth.TabIndex = 1;
            this.lblDepth.Text = "Depth (meters):";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(26, 40);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(147, 24);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius (meters):";
            // 
            // grpTankData
            // 
            this.grpTankData.Controls.Add(this.lblMaxCapacity);
            this.grpTankData.Controls.Add(this.lblCurrentLevel);
            this.grpTankData.Controls.Add(this.btnMaxCapacity);
            this.grpTankData.Controls.Add(this.btnCurrentWaterLevel);
            this.grpTankData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTankData.Location = new System.Drawing.Point(12, 221);
            this.grpTankData.Name = "grpTankData";
            this.grpTankData.Size = new System.Drawing.Size(388, 134);
            this.grpTankData.TabIndex = 2;
            this.grpTankData.TabStop = false;
            this.grpTankData.Text = "Water Tank Data";
            // 
            // lblMaxCapacity
            // 
            this.lblMaxCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCapacity.Location = new System.Drawing.Point(212, 80);
            this.lblMaxCapacity.Name = "lblMaxCapacity";
            this.lblMaxCapacity.Size = new System.Drawing.Size(170, 34);
            this.lblMaxCapacity.TabIndex = 8;
            this.lblMaxCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLevel.Location = new System.Drawing.Point(212, 31);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(170, 34);
            this.lblCurrentLevel.TabIndex = 7;
            this.lblCurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaxCapacity
            // 
            this.btnMaxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxCapacity.Location = new System.Drawing.Point(6, 80);
            this.btnMaxCapacity.Name = "btnMaxCapacity";
            this.btnMaxCapacity.Size = new System.Drawing.Size(191, 34);
            this.btnMaxCapacity.TabIndex = 5;
            this.btnMaxCapacity.Text = "Maximum Capacity";
            this.btnMaxCapacity.UseVisualStyleBackColor = true;
            this.btnMaxCapacity.Click += new System.EventHandler(this.btnMaxCapacity_Click);
            // 
            // btnCurrentWaterLevel
            // 
            this.btnCurrentWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentWaterLevel.Location = new System.Drawing.Point(6, 31);
            this.btnCurrentWaterLevel.Name = "btnCurrentWaterLevel";
            this.btnCurrentWaterLevel.Size = new System.Drawing.Size(191, 34);
            this.btnCurrentWaterLevel.TabIndex = 4;
            this.btnCurrentWaterLevel.Text = "Current Water Level";
            this.btnCurrentWaterLevel.UseVisualStyleBackColor = true;
            this.btnCurrentWaterLevel.Click += new System.EventHandler(this.btnCurrentWaterLevel_Click);
            // 
            // grpAddWithdraw
            // 
            this.grpAddWithdraw.Controls.Add(this.lblAddWithdrawMessage);
            this.grpAddWithdraw.Controls.Add(this.btnAddWithdraw);
            this.grpAddWithdraw.Controls.Add(this.radWithdrawWater);
            this.grpAddWithdraw.Controls.Add(this.radAddWater);
            this.grpAddWithdraw.Controls.Add(this.nudLevel);
            this.grpAddWithdraw.Controls.Add(this.lblLitersAddWithdraw);
            this.grpAddWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddWithdraw.Location = new System.Drawing.Point(12, 374);
            this.grpAddWithdraw.Name = "grpAddWithdraw";
            this.grpAddWithdraw.Size = new System.Drawing.Size(388, 246);
            this.grpAddWithdraw.TabIndex = 3;
            this.grpAddWithdraw.TabStop = false;
            this.grpAddWithdraw.Text = "Add/Withdraw Water";
            // 
            // lblAddWithdrawMessage
            // 
            this.lblAddWithdrawMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddWithdrawMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWithdrawMessage.Location = new System.Drawing.Point(17, 121);
            this.lblAddWithdrawMessage.Name = "lblAddWithdrawMessage";
            this.lblAddWithdrawMessage.Size = new System.Drawing.Size(358, 113);
            this.lblAddWithdrawMessage.TabIndex = 11;
            // 
            // btnAddWithdraw
            // 
            this.btnAddWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWithdraw.Location = new System.Drawing.Point(163, 73);
            this.btnAddWithdraw.Name = "btnAddWithdraw";
            this.btnAddWithdraw.Size = new System.Drawing.Size(212, 34);
            this.btnAddWithdraw.TabIndex = 10;
            this.btnAddWithdraw.Text = "Add/Withdraw Water";
            this.btnAddWithdraw.UseVisualStyleBackColor = true;
            this.btnAddWithdraw.Click += new System.EventHandler(this.btnAddWithdraw_Click);
            // 
            // radWithdrawWater
            // 
            this.radWithdrawWater.AutoSize = true;
            this.radWithdrawWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWithdrawWater.Location = new System.Drawing.Point(24, 73);
            this.radWithdrawWater.Name = "radWithdrawWater";
            this.radWithdrawWater.Size = new System.Drawing.Size(106, 28);
            this.radWithdrawWater.TabIndex = 9;
            this.radWithdrawWater.TabStop = true;
            this.radWithdrawWater.Text = "Withdraw";
            this.radWithdrawWater.UseVisualStyleBackColor = true;
            // 
            // radAddWater
            // 
            this.radAddWater.AutoSize = true;
            this.radAddWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAddWater.Location = new System.Drawing.Point(24, 30);
            this.radAddWater.Name = "radAddWater";
            this.radAddWater.Size = new System.Drawing.Size(63, 28);
            this.radAddWater.TabIndex = 7;
            this.radAddWater.TabStop = true;
            this.radAddWater.Text = "Add";
            this.radAddWater.UseVisualStyleBackColor = true;
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(255, 30);
            this.nudLevel.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(120, 29);
            this.nudLevel.TabIndex = 6;
            this.nudLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLitersAddWithdraw
            // 
            this.lblLitersAddWithdraw.AutoSize = true;
            this.lblLitersAddWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitersAddWithdraw.Location = new System.Drawing.Point(180, 32);
            this.lblLitersAddWithdraw.Name = "lblLitersAddWithdraw";
            this.lblLitersAddWithdraw.Size = new System.Drawing.Size(59, 24);
            this.lblLitersAddWithdraw.TabIndex = 2;
            this.lblLitersAddWithdraw.Text = "Liters:";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(1, 632);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloper.TabIndex = 4;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(421, 586);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(196, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(623, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 654);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.grpAddWithdraw);
            this.Controls.Add(this.grpTankData);
            this.Controls.Add(this.grpTankDimensions);
            this.Controls.Add(this.grpFillDrain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 5 - Water Tank ";
            this.grpFillDrain.ResumeLayout(false);
            this.grpFillDrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitPsec)).EndInit();
            this.grpTankDimensions.ResumeLayout(false);
            this.grpTankDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.grpTankData.ResumeLayout(false);
            this.grpAddWithdraw.ResumeLayout(false);
            this.grpAddWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFillDrain;
        private System.Windows.Forms.GroupBox grpTankDimensions;
        private System.Windows.Forms.GroupBox grpTankData;
        private System.Windows.Forms.GroupBox grpAddWithdraw;
        private System.Windows.Forms.RadioButton radDrainWater;
        private System.Windows.Forms.RadioButton radFillWater;
        private System.Windows.Forms.NumericUpDown nudLitPsec;
        private System.Windows.Forms.Button btnFillDrain;
        private System.Windows.Forms.Label lblLitersPerSecond;
        private System.Windows.Forms.Button btnCreateTank;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblMaxCapacity;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Button btnMaxCapacity;
        private System.Windows.Forms.Button btnCurrentWaterLevel;
        private System.Windows.Forms.RadioButton radWithdrawWater;
        private System.Windows.Forms.RadioButton radAddWater;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label lblLitersAddWithdraw;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddWithdraw;
        private System.Windows.Forms.Label lblAddWithdrawMessage;
        private System.Windows.Forms.TextBox txtFillDrainPS;
    }
}

