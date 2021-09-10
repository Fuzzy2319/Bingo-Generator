
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
            this.flpMenu.SuspendLayout();
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
            this.btnGenerate.Location = new System.Drawing.Point(13, 3);
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
            this.lsbLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbLogic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbLogic.FormattingEnabled = true;
            this.lsbLogic.ItemHeight = 16;
            this.lsbLogic.Items.AddRange(new object[] {
            "No Limit",
            "Normal",
            "Race Mode"});
            this.lsbLogic.Location = new System.Drawing.Point(149, 25);
            this.lsbLogic.Name = "lsbLogic";
            this.lsbLogic.Size = new System.Drawing.Size(115, 34);
            this.lsbLogic.Sorted = true;
            this.lsbLogic.TabIndex = 1;
            // 
            // lblLogic
            // 
            this.lblLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogic.BackColor = System.Drawing.Color.Transparent;
            this.lblLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogic.Location = new System.Drawing.Point(149, 3);
            this.lblLogic.Name = "lblLogic";
            this.lblLogic.Size = new System.Drawing.Size(115, 19);
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
            this.flpMenu.Controls.Add(this.lsbLogic);
            this.flpMenu.Controls.Add(this.lblLogic);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpMenu.Location = new System.Drawing.Point(0, 368);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(800, 82);
            this.flpMenu.TabIndex = 3;
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
    }
}

