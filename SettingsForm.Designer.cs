
namespace Bingo_Generator
{
    partial class SettingsForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.sfdOutput = new System.Windows.Forms.SaveFileDialog();
            this.lsbLogic = new System.Windows.Forms.ListBox();
            this.lblLogic = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLogic = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDungeons = new System.Windows.Forms.FlowLayoutPanel();
            this.chkDRC = new System.Windows.Forms.CheckBox();
            this.chkFW = new System.Windows.Forms.CheckBox();
            this.chkTOTG = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.chkET = new System.Windows.Forms.CheckBox();
            this.chkWT = new System.Windows.Forms.CheckBox();
            this.chkRaceMode = new System.Windows.Forms.CheckBox();
            this.lblDungeons = new System.Windows.Forms.Label();
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
            this.flpMain.Padding = new System.Windows.Forms.Padding(10);
            this.flpMain.Size = new System.Drawing.Size(800, 450);
            this.flpMain.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(13, 49);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 56);
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
            this.lsbLogic.ItemHeight = 16;
            this.lsbLogic.Items.AddRange(new object[] {
            "Limited",
            "No Limit"});
            this.lsbLogic.Location = new System.Drawing.Point(3, 34);
            this.lsbLogic.Name = "lsbLogic";
            this.lsbLogic.Size = new System.Drawing.Size(200, 34);
            this.lsbLogic.Sorted = true;
            this.lsbLogic.TabIndex = 1;
            // 
            // lblLogic
            // 
            this.lblLogic.BackColor = System.Drawing.Color.Transparent;
            this.lblLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogic.Location = new System.Drawing.Point(3, 0);
            this.lblLogic.Name = "lblLogic";
            this.lblLogic.Size = new System.Drawing.Size(200, 31);
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
            this.flpMenu.Location = new System.Drawing.Point(0, 322);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(800, 128);
            this.flpMenu.TabIndex = 3;
            // 
            // flpLogic
            // 
            this.flpLogic.Controls.Add(this.lblLogic);
            this.flpLogic.Controls.Add(this.lsbLogic);
            this.flpLogic.Controls.Add(this.chkRaceMode);
            this.flpLogic.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLogic.Location = new System.Drawing.Point(149, 3);
            this.flpLogic.Name = "flpLogic";
            this.flpLogic.Size = new System.Drawing.Size(205, 102);
            this.flpLogic.TabIndex = 3;
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
            this.flpDungeons.Location = new System.Drawing.Point(360, 3);
            this.flpDungeons.Name = "flpDungeons";
            this.flpDungeons.Size = new System.Drawing.Size(440, 102);
            this.flpDungeons.TabIndex = 4;
            this.flpDungeons.Visible = false;
            // 
            // chkDRC
            // 
            this.chkDRC.AutoSize = true;
            this.chkDRC.Location = new System.Drawing.Point(3, 27);
            this.chkDRC.Name = "chkDRC";
            this.chkDRC.Size = new System.Drawing.Size(167, 21);
            this.chkDRC.TabIndex = 1;
            this.chkDRC.Text = "Dragon Roast Cavern";
            this.chkDRC.UseVisualStyleBackColor = true;
            // 
            // chkFW
            // 
            this.chkFW.AutoSize = true;
            this.chkFW.Location = new System.Drawing.Point(176, 27);
            this.chkFW.Name = "chkFW";
            this.chkFW.Size = new System.Drawing.Size(142, 21);
            this.chkFW.TabIndex = 2;
            this.chkFW.Text = "Forbidden Woods";
            this.chkFW.UseVisualStyleBackColor = true;
            // 
            // chkTOTG
            // 
            this.chkTOTG.AutoSize = true;
            this.chkTOTG.Location = new System.Drawing.Point(3, 54);
            this.chkTOTG.Name = "chkTOTG";
            this.chkTOTG.Size = new System.Drawing.Size(147, 21);
            this.chkTOTG.TabIndex = 3;
            this.chkTOTG.Text = "Tower of the Gods";
            this.chkTOTG.UseVisualStyleBackColor = true;
            // 
            // chkFF
            // 
            this.chkFF.AutoSize = true;
            this.chkFF.Location = new System.Drawing.Point(156, 54);
            this.chkFF.Name = "chkFF";
            this.chkFF.Size = new System.Drawing.Size(145, 21);
            this.chkFF.TabIndex = 4;
            this.chkFF.Text = "Forsaken Fortress";
            this.chkFF.UseVisualStyleBackColor = true;
            // 
            // chkET
            // 
            this.chkET.AutoSize = true;
            this.chkET.Location = new System.Drawing.Point(307, 54);
            this.chkET.Name = "chkET";
            this.chkET.Size = new System.Drawing.Size(115, 21);
            this.chkET.TabIndex = 5;
            this.chkET.Text = "Earth Temple";
            this.chkET.UseVisualStyleBackColor = true;
            // 
            // chkWT
            // 
            this.chkWT.AutoSize = true;
            this.chkWT.Location = new System.Drawing.Point(3, 81);
            this.chkWT.Name = "chkWT";
            this.chkWT.Size = new System.Drawing.Size(113, 21);
            this.chkWT.TabIndex = 6;
            this.chkWT.Text = "Wind Temple";
            this.chkWT.UseVisualStyleBackColor = true;
            // 
            // chkRaceMode
            // 
            this.chkRaceMode.AutoSize = true;
            this.chkRaceMode.Location = new System.Drawing.Point(3, 74);
            this.chkRaceMode.Name = "chkRaceMode";
            this.chkRaceMode.Size = new System.Drawing.Size(102, 21);
            this.chkRaceMode.TabIndex = 3;
            this.chkRaceMode.Text = "Race Mode";
            this.chkRaceMode.UseVisualStyleBackColor = true;
            this.chkRaceMode.CheckedChanged += new System.EventHandler(this.chkRaceMode_CheckedChanged);
            // 
            // lblDungeons
            // 
            this.lblDungeons.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDungeons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungeons.Location = new System.Drawing.Point(3, 0);
            this.lblDungeons.Name = "lblDungeons";
            this.lblDungeons.Size = new System.Drawing.Size(437, 24);
            this.lblDungeons.TabIndex = 7;
            this.lblDungeons.Text = "Active Dungeons :";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.flpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
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

