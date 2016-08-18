namespace Bundledocs.Api.Wrapper.Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblAuthenticateHeader = new System.Windows.Forms.Label();
            this.lblOutputHeader = new System.Windows.Forms.Label();
            this.pnlBrowserContainer = new System.Windows.Forms.Panel();
            this.txtApiMe = new System.Windows.Forms.TextBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.pnlMain.Controls.Add(this.txtAccessToken, 0, 2);
            this.pnlMain.Controls.Add(this.lblAuthenticateHeader, 0, 0);
            this.pnlMain.Controls.Add(this.lblOutputHeader, 1, 0);
            this.pnlMain.Controls.Add(this.pnlBrowserContainer, 0, 1);
            this.pnlMain.Controls.Add(this.txtApiMe, 1, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77821F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.221797F));
            this.pnlMain.Size = new System.Drawing.Size(860, 553);
            this.pnlMain.TabIndex = 0;
            // 
            // lblAuthenticateHeader
            // 
            this.lblAuthenticateHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthenticateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthenticateHeader.Location = new System.Drawing.Point(3, 0);
            this.lblAuthenticateHeader.Name = "lblAuthenticateHeader";
            this.lblAuthenticateHeader.Size = new System.Drawing.Size(612, 30);
            this.lblAuthenticateHeader.TabIndex = 0;
            this.lblAuthenticateHeader.Text = "Bundledocs Api Client";
            this.lblAuthenticateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputHeader
            // 
            this.lblOutputHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutputHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputHeader.Location = new System.Drawing.Point(621, 0);
            this.lblOutputHeader.Name = "lblOutputHeader";
            this.lblOutputHeader.Size = new System.Drawing.Size(236, 30);
            this.lblOutputHeader.TabIndex = 1;
            this.lblOutputHeader.Text = "Api.Me";
            this.lblOutputHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBrowserContainer
            // 
            this.pnlBrowserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowserContainer.Location = new System.Drawing.Point(3, 33);
            this.pnlBrowserContainer.Name = "pnlBrowserContainer";
            this.pnlBrowserContainer.Size = new System.Drawing.Size(612, 474);
            this.pnlBrowserContainer.TabIndex = 3;
            // 
            // txtApiMe
            // 
            this.txtApiMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApiMe.Location = new System.Drawing.Point(621, 33);
            this.txtApiMe.Multiline = true;
            this.txtApiMe.Name = "txtApiMe";
            this.txtApiMe.ReadOnly = true;
            this.txtApiMe.Size = new System.Drawing.Size(236, 474);
            this.txtApiMe.TabIndex = 5;
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAccessToken.Location = new System.Drawing.Point(3, 513);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.ReadOnly = true;
            this.txtAccessToken.Size = new System.Drawing.Size(612, 37);
            this.txtAccessToken.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 553);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblAuthenticateHeader;
        private System.Windows.Forms.Label lblOutputHeader;
        private System.Windows.Forms.Panel pnlBrowserContainer;
        private System.Windows.Forms.TextBox txtApiMe;
        private System.Windows.Forms.TextBox txtAccessToken;
    }
}

