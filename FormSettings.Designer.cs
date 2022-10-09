namespace Bingo_Generator
{
    partial class FormSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.sfdOutput = new System.Windows.Forms.SaveFileDialog();
            this.lsbLogic = new System.Windows.Forms.ListBox();
            this.lblLogic = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLogic = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRaceMode = new System.Windows.Forms.CheckBox();
            this.flpDungeons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDungeons = new System.Windows.Forms.Label();
            this.chkDRC = new System.Windows.Forms.CheckBox();
            this.chkFW = new System.Windows.Forms.CheckBox();
            this.chkTOTG = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.chkET = new System.Windows.Forms.CheckBox();
            this.chkWT = new System.Windows.Forms.CheckBox();
            this.flpMenu.SuspendLayout();
            this.flpLogic.SuspendLayout();
            this.flpDungeons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.AutoSize = true;
            this.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMain.BackColor = System.Drawing.Color.Transparent;
            this.flpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Margin = new System.Windows.Forms.Padding(0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.flpMain.Size = new System.Drawing.Size(800, 562);
            this.flpMain.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(13, 62);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 70);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Grid";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // sfdOutput
            // 
            this.sfdOutput.Filter = "txt files (*.txt)|*.txt";
            // 
            // lsbLogic
            // 
            this.lsbLogic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbLogic.FormattingEnabled = true;
            this.lsbLogic.ItemHeight = 20;
            this.lsbLogic.Items.AddRange(new object[] {
            "Limited",
            "No Limit"});
            this.lsbLogic.Location = new System.Drawing.Point(3, 43);
            this.lsbLogic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbLogic.Name = "lsbLogic";
            this.lsbLogic.Size = new System.Drawing.Size(200, 42);
            this.lsbLogic.Sorted = true;
            this.lsbLogic.TabIndex = 1;
            // 
            // lblLogic
            // 
            this.lblLogic.BackColor = System.Drawing.Color.Transparent;
            this.lblLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogic.Location = new System.Drawing.Point(3, 0);
            this.lblLogic.Name = "lblLogic";
            this.lblLogic.Size = new System.Drawing.Size(200, 39);
            this.lblLogic.TabIndex = 2;
            this.lblLogic.Text = "Logic :";
            this.lblLogic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.AutoSize = true;
            this.flpMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpMenu.Controls.Add(this.btnGenerate);
            this.flpMenu.Controls.Add(this.flpLogic);
            this.flpMenu.Controls.Add(this.flpDungeons);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpMenu.Location = new System.Drawing.Point(0, 402);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.flpMenu.Size = new System.Drawing.Size(800, 160);
            this.flpMenu.TabIndex = 3;
            // 
            // flpLogic
            // 
            this.flpLogic.Controls.Add(this.lblLogic);
            this.flpLogic.Controls.Add(this.lsbLogic);
            this.flpLogic.Controls.Add(this.chkRaceMode);
            this.flpLogic.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLogic.Location = new System.Drawing.Point(149, 4);
            this.flpLogic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpLogic.Name = "flpLogic";
            this.flpLogic.Size = new System.Drawing.Size(205, 128);
            this.flpLogic.TabIndex = 3;
            // 
            // chkRaceMode
            // 
            this.chkRaceMode.AutoSize = true;
            this.chkRaceMode.Location = new System.Drawing.Point(3, 93);
            this.chkRaceMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRaceMode.Name = "chkRaceMode";
            this.chkRaceMode.Size = new System.Drawing.Size(106, 24);
            this.chkRaceMode.TabIndex = 3;
            this.chkRaceMode.Text = "Race Mode";
            this.chkRaceMode.UseVisualStyleBackColor = true;
            this.chkRaceMode.CheckedChanged += new System.EventHandler(this.chkRaceMode_CheckedChanged);
            // 
            // flpDungeons
            // 
            this.flpDungeons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDungeons.Controls.Add(this.lblDungeons);
            this.flpDungeons.Controls.Add(this.chkDRC);
            this.flpDungeons.Controls.Add(this.chkFW);
            this.flpDungeons.Controls.Add(this.chkTOTG);
            this.flpDungeons.Controls.Add(this.chkFF);
            this.flpDungeons.Controls.Add(this.chkET);
            this.flpDungeons.Controls.Add(this.chkWT);
            this.flpDungeons.Location = new System.Drawing.Point(360, 4);
            this.flpDungeons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpDungeons.Name = "flpDungeons";
            this.flpDungeons.Size = new System.Drawing.Size(440, 128);
            this.flpDungeons.TabIndex = 4;
            this.flpDungeons.Visible = false;
            // 
            // lblDungeons
            // 
            this.lblDungeons.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDungeons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDungeons.Location = new System.Drawing.Point(3, 0);
            this.lblDungeons.Name = "lblDungeons";
            this.lblDungeons.Size = new System.Drawing.Size(437, 30);
            this.lblDungeons.TabIndex = 7;
            this.lblDungeons.Text = "Active Dungeons :";
            // 
            // chkDRC
            // 
            this.chkDRC.AutoSize = true;
            this.chkDRC.Location = new System.Drawing.Point(3, 34);
            this.chkDRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDRC.Name = "chkDRC";
            this.chkDRC.Size = new System.Drawing.Size(171, 24);
            this.chkDRC.TabIndex = 1;
            this.chkDRC.Text = "Dragon Roast Cavern";
            this.chkDRC.UseVisualStyleBackColor = true;
            // 
            // chkFW
            // 
            this.chkFW.AutoSize = true;
            this.chkFW.Location = new System.Drawing.Point(180, 34);
            this.chkFW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFW.Name = "chkFW";
            this.chkFW.Size = new System.Drawing.Size(149, 24);
            this.chkFW.TabIndex = 2;
            this.chkFW.Text = "Forbidden Woods";
            this.chkFW.UseVisualStyleBackColor = true;
            // 
            // chkTOTG
            // 
            this.chkTOTG.AutoSize = true;
            this.chkTOTG.Location = new System.Drawing.Point(3, 66);
            this.chkTOTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTOTG.Name = "chkTOTG";
            this.chkTOTG.Size = new System.Drawing.Size(152, 24);
            this.chkTOTG.TabIndex = 3;
            this.chkTOTG.Text = "Tower of the Gods";
            this.chkTOTG.UseVisualStyleBackColor = true;
            // 
            // chkFF
            // 
            this.chkFF.AutoSize = true;
            this.chkFF.Location = new System.Drawing.Point(161, 66);
            this.chkFF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFF.Name = "chkFF";
            this.chkFF.Size = new System.Drawing.Size(144, 24);
            this.chkFF.TabIndex = 4;
            this.chkFF.Text = "Forsaken Fortress";
            this.chkFF.UseVisualStyleBackColor = true;
            // 
            // chkET
            // 
            this.chkET.AutoSize = true;
            this.chkET.Location = new System.Drawing.Point(311, 66);
            this.chkET.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkET.Name = "chkET";
            this.chkET.Size = new System.Drawing.Size(118, 24);
            this.chkET.TabIndex = 5;
            this.chkET.Text = "Earth Temple";
            this.chkET.UseVisualStyleBackColor = true;
            // 
            // chkWT
            // 
            this.chkWT.AutoSize = true;
            this.chkWT.Location = new System.Drawing.Point(3, 98);
            this.chkWT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWT.Name = "chkWT";
            this.chkWT.Size = new System.Drawing.Size(119, 24);
            this.chkWT.TabIndex = 6;
            this.chkWT.Text = "Wind Temple";
            this.chkWT.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.flpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSettings";
            this.Text = "BingoGenerator";
            this.flpMenu.ResumeLayout(false);
            this.flpLogic.ResumeLayout(false);
            this.flpLogic.PerformLayout();
            this.flpDungeons.ResumeLayout(false);
            this.flpDungeons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.SaveFileDialog sfdOutput;
        private System.Windows.Forms.ListBox lsbLogic;
        private System.Windows.Forms.Label lblLogic;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.FlowLayoutPanel flpLogic;
        private System.Windows.Forms.FlowLayoutPanel flpDungeons;
        private System.Windows.Forms.CheckBox chkDRC;
        private System.Windows.Forms.CheckBox chkFW;
        private System.Windows.Forms.CheckBox chkTOTG;
        private System.Windows.Forms.CheckBox chkFF;
        private System.Windows.Forms.CheckBox chkET;
        private System.Windows.Forms.CheckBox chkWT;
        private System.Windows.Forms.CheckBox chkRaceMode;
        private System.Windows.Forms.Label lblDungeons;
    }
}