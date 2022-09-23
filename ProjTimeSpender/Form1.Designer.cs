
namespace ProjTimeSpender
{
    partial class frmMainStationDahe
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
            this.btnStartWorkDahe = new System.Windows.Forms.Button();
            this.niyShowIconDahe = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbChooseWorkDahe = new System.Windows.Forms.ComboBox();
            this.txbCustomWorkDahe = new System.Windows.Forms.TextBox();
            this.btnShowWorkDahe = new System.Windows.Forms.Button();
            this.tmrScreenDiscoDahe = new System.Windows.Forms.Timer(this.components);
            this.btnSettingsDahe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartWorkDahe
            // 
            this.btnStartWorkDahe.Location = new System.Drawing.Point(12, 17);
            this.btnStartWorkDahe.Name = "btnStartWorkDahe";
            this.btnStartWorkDahe.Size = new System.Drawing.Size(94, 30);
            this.btnStartWorkDahe.TabIndex = 0;
            this.btnStartWorkDahe.Text = "Work";
            this.btnStartWorkDahe.UseVisualStyleBackColor = true;
            this.btnStartWorkDahe.Click += new System.EventHandler(this.btnStartWorkDahe_Click);
            // 
            // niyShowIconDahe
            // 
            this.niyShowIconDahe.Text = "showIcon";
            this.niyShowIconDahe.Visible = true;
            this.niyShowIconDahe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HideIconDahe_MouseDoubleClick);
            // 
            // cmbChooseWorkDahe
            // 
            this.cmbChooseWorkDahe.FormattingEnabled = true;
            this.cmbChooseWorkDahe.Location = new System.Drawing.Point(12, 63);
            this.cmbChooseWorkDahe.Name = "cmbChooseWorkDahe";
            this.cmbChooseWorkDahe.Size = new System.Drawing.Size(195, 24);
            this.cmbChooseWorkDahe.TabIndex = 1;
            // 
            // txbCustomWorkDahe
            // 
            this.txbCustomWorkDahe.Location = new System.Drawing.Point(12, 104);
            this.txbCustomWorkDahe.Name = "txbCustomWorkDahe";
            this.txbCustomWorkDahe.Size = new System.Drawing.Size(195, 22);
            this.txbCustomWorkDahe.TabIndex = 2;
            // 
            // btnShowWorkDahe
            // 
            this.btnShowWorkDahe.Location = new System.Drawing.Point(114, 17);
            this.btnShowWorkDahe.Name = "btnShowWorkDahe";
            this.btnShowWorkDahe.Size = new System.Drawing.Size(93, 30);
            this.btnShowWorkDahe.TabIndex = 4;
            this.btnShowWorkDahe.Text = "show";
            this.btnShowWorkDahe.UseVisualStyleBackColor = true;
            // 
            // tmrScreenDiscoDahe
            // 
            this.tmrScreenDiscoDahe.Enabled = true;
            this.tmrScreenDiscoDahe.Interval = 1500;
            this.tmrScreenDiscoDahe.Tick += new System.EventHandler(this.tmrScreenDiscoDahe_Tick);
            // 
            // btnSettingsDahe
            // 
            this.btnSettingsDahe.Location = new System.Drawing.Point(221, 17);
            this.btnSettingsDahe.Name = "btnSettingsDahe";
            this.btnSettingsDahe.Size = new System.Drawing.Size(93, 30);
            this.btnSettingsDahe.TabIndex = 5;
            this.btnSettingsDahe.Text = "settings";
            this.btnSettingsDahe.UseVisualStyleBackColor = true;
            // 
            // frmMainStationDahe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 165);
            this.Controls.Add(this.btnSettingsDahe);
            this.Controls.Add(this.btnShowWorkDahe);
            this.Controls.Add(this.txbCustomWorkDahe);
            this.Controls.Add(this.cmbChooseWorkDahe);
            this.Controls.Add(this.btnStartWorkDahe);
            this.Name = "frmMainStationDahe";
            this.Load += new System.EventHandler(this.frmMainStationDahe_Load);
            this.Resize += new System.EventHandler(this.frmMainStationDahe_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartWorkDahe;
        private System.Windows.Forms.NotifyIcon niyShowIconDahe;
        private System.Windows.Forms.ComboBox cmbChooseWorkDahe;
        private System.Windows.Forms.TextBox txbCustomWorkDahe;
        private System.Windows.Forms.Button btnShowWorkDahe;
        private System.Windows.Forms.Timer tmrScreenDiscoDahe;
        private System.Windows.Forms.Button btnSettingsDahe;
    }
}

