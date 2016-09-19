<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.pnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAuthenticateHeader = New System.Windows.Forms.Label()
        Me.lblOutputHeader = New System.Windows.Forms.Label()
        Me.pnlBrowserContainer = New System.Windows.Forms.Panel()
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.pnlRight = New System.Windows.Forms.TableLayoutPanel()
        Me.grpChooseDocuments = New System.Windows.Forms.GroupBox()
        Me.btnChooseFiles = New System.Windows.Forms.Button()
        Me.lstDocuments = New System.Windows.Forms.ListBox()
        Me.grpUploadDocuments = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.grpChooseBundle = New System.Windows.Forms.GroupBox()
        Me.lstBundles = New System.Windows.Forms.ListBox()
        Me.grpChooseSection = New System.Windows.Forms.GroupBox()
        Me.lstSections = New System.Windows.Forms.ListBox()
        Me.grpMe = New System.Windows.Forms.GroupBox()
        Me.dlgOpenFiles = New System.Windows.Forms.OpenFileDialog()
        Me.txtApiMe = New System.Windows.Forms.TextBox()
        Me.grpAccessToken = New System.Windows.Forms.GroupBox()
        Me.txtAccessToken = New System.Windows.Forms.TextBox()
        Me.pnlMain.SuspendLayout()
        Me.pnlBrowserContainer.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.grpChooseDocuments.SuspendLayout()
        Me.grpUploadDocuments.SuspendLayout()
        Me.grpChooseBundle.SuspendLayout()
        Me.grpChooseSection.SuspendLayout()
        Me.grpMe.SuspendLayout()
        Me.grpAccessToken.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.ColumnCount = 2
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278.0!))
        Me.pnlMain.Controls.Add(Me.lblAuthenticateHeader, 0, 0)
        Me.pnlMain.Controls.Add(Me.lblOutputHeader, 1, 0)
        Me.pnlMain.Controls.Add(Me.pnlBrowserContainer, 0, 1)
        Me.pnlMain.Controls.Add(Me.pnlRight, 1, 1)
        Me.pnlMain.Controls.Add(Me.grpAccessToken, 0, 2)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.RowCount = 3
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77821!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.221797!))
        Me.pnlMain.Size = New System.Drawing.Size(844, 626)
        Me.pnlMain.TabIndex = 1
        '
        'lblAuthenticateHeader
        '
        Me.lblAuthenticateHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAuthenticateHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthenticateHeader.Location = New System.Drawing.Point(3, 0)
        Me.lblAuthenticateHeader.Name = "lblAuthenticateHeader"
        Me.lblAuthenticateHeader.Size = New System.Drawing.Size(560, 30)
        Me.lblAuthenticateHeader.TabIndex = 0
        Me.lblAuthenticateHeader.Text = "Bundledocs Api Client"
        Me.lblAuthenticateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputHeader
        '
        Me.lblOutputHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOutputHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputHeader.Location = New System.Drawing.Point(569, 0)
        Me.lblOutputHeader.Name = "lblOutputHeader"
        Me.lblOutputHeader.Size = New System.Drawing.Size(272, 30)
        Me.lblOutputHeader.TabIndex = 1
        Me.lblOutputHeader.Text = "Api.Me"
        Me.lblOutputHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBrowserContainer
        '
        Me.pnlBrowserContainer.Controls.Add(Me.wbMain)
        Me.pnlBrowserContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBrowserContainer.Location = New System.Drawing.Point(3, 33)
        Me.pnlBrowserContainer.Name = "pnlBrowserContainer"
        Me.pnlBrowserContainer.Size = New System.Drawing.Size(560, 540)
        Me.pnlBrowserContainer.TabIndex = 3
        '
        'wbMain
        '
        Me.wbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMain.Location = New System.Drawing.Point(0, 0)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(560, 540)
        Me.wbMain.TabIndex = 0
        '
        'pnlRight
        '
        Me.pnlRight.ColumnCount = 1
        Me.pnlRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlRight.Controls.Add(Me.grpChooseDocuments, 0, 3)
        Me.pnlRight.Controls.Add(Me.lstDocuments, 0, 4)
        Me.pnlRight.Controls.Add(Me.grpUploadDocuments, 0, 5)
        Me.pnlRight.Controls.Add(Me.grpChooseBundle, 0, 1)
        Me.pnlRight.Controls.Add(Me.grpChooseSection, 0, 2)
        Me.pnlRight.Controls.Add(Me.grpMe, 0, 0)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(569, 33)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.RowCount = 7
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlRight.Size = New System.Drawing.Size(272, 540)
        Me.pnlRight.TabIndex = 7
        '
        'grpChooseDocuments
        '
        Me.grpChooseDocuments.Controls.Add(Me.btnChooseFiles)
        Me.grpChooseDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChooseDocuments.Location = New System.Drawing.Point(3, 223)
        Me.grpChooseDocuments.Name = "grpChooseDocuments"
        Me.grpChooseDocuments.Size = New System.Drawing.Size(266, 44)
        Me.grpChooseDocuments.TabIndex = 9
        Me.grpChooseDocuments.TabStop = False
        Me.grpChooseDocuments.Text = "Choose Documents"
        '
        'btnChooseFiles
        '
        Me.btnChooseFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChooseFiles.Location = New System.Drawing.Point(3, 16)
        Me.btnChooseFiles.Name = "btnChooseFiles"
        Me.btnChooseFiles.Size = New System.Drawing.Size(260, 25)
        Me.btnChooseFiles.TabIndex = 10
        Me.btnChooseFiles.Text = "Browse..."
        Me.btnChooseFiles.UseVisualStyleBackColor = True
        '
        'lstDocuments
        '
        Me.lstDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDocuments.FormattingEnabled = True
        Me.lstDocuments.ItemHeight = 14
        Me.lstDocuments.Location = New System.Drawing.Point(3, 273)
        Me.lstDocuments.Name = "lstDocuments"
        Me.lstDocuments.Size = New System.Drawing.Size(266, 79)
        Me.lstDocuments.TabIndex = 10
        '
        'grpUploadDocuments
        '
        Me.grpUploadDocuments.Controls.Add(Me.btnUpload)
        Me.grpUploadDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUploadDocuments.Location = New System.Drawing.Point(3, 358)
        Me.grpUploadDocuments.Name = "grpUploadDocuments"
        Me.grpUploadDocuments.Size = New System.Drawing.Size(266, 44)
        Me.grpUploadDocuments.TabIndex = 11
        Me.grpUploadDocuments.TabStop = False
        Me.grpUploadDocuments.Text = "Upload Documents"
        '
        'btnUpload
        '
        Me.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpload.Location = New System.Drawing.Point(3, 16)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(260, 25)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'grpChooseBundle
        '
        Me.grpChooseBundle.Controls.Add(Me.lstBundles)
        Me.grpChooseBundle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChooseBundle.Location = New System.Drawing.Point(3, 53)
        Me.grpChooseBundle.Name = "grpChooseBundle"
        Me.grpChooseBundle.Size = New System.Drawing.Size(266, 79)
        Me.grpChooseBundle.TabIndex = 12
        Me.grpChooseBundle.TabStop = False
        Me.grpChooseBundle.Text = "Choose Bundle"
        '
        'lstBundles
        '
        Me.lstBundles.DisplayMember = "Title"
        Me.lstBundles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBundles.FormattingEnabled = True
        Me.lstBundles.ItemHeight = 14
        Me.lstBundles.Location = New System.Drawing.Point(3, 16)
        Me.lstBundles.Name = "lstBundles"
        Me.lstBundles.Size = New System.Drawing.Size(260, 60)
        Me.lstBundles.TabIndex = 8
        '
        'grpChooseSection
        '
        Me.grpChooseSection.Controls.Add(Me.lstSections)
        Me.grpChooseSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChooseSection.Location = New System.Drawing.Point(3, 138)
        Me.grpChooseSection.Name = "grpChooseSection"
        Me.grpChooseSection.Size = New System.Drawing.Size(266, 79)
        Me.grpChooseSection.TabIndex = 13
        Me.grpChooseSection.TabStop = False
        Me.grpChooseSection.Text = "Choose Section"
        '
        'lstSections
        '
        Me.lstSections.DisplayMember = "Description"
        Me.lstSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSections.FormattingEnabled = True
        Me.lstSections.ItemHeight = 14
        Me.lstSections.Location = New System.Drawing.Point(3, 16)
        Me.lstSections.Name = "lstSections"
        Me.lstSections.Size = New System.Drawing.Size(260, 60)
        Me.lstSections.TabIndex = 9
        '
        'grpMe
        '
        Me.grpMe.Controls.Add(Me.txtApiMe)
        Me.grpMe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMe.Location = New System.Drawing.Point(3, 3)
        Me.grpMe.Name = "grpMe"
        Me.grpMe.Size = New System.Drawing.Size(266, 44)
        Me.grpMe.TabIndex = 14
        Me.grpMe.TabStop = False
        Me.grpMe.Text = "Account"
        '
        'dlgOpenFiles
        '
        Me.dlgOpenFiles.FileName = "OpenFileDialog"
        Me.dlgOpenFiles.Multiselect = True
        Me.dlgOpenFiles.RestoreDirectory = True
        Me.dlgOpenFiles.Title = "Choose Documents"
        '
        'txtApiMe
        '
        Me.txtApiMe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApiMe.Location = New System.Drawing.Point(3, 16)
        Me.txtApiMe.Multiline = True
        Me.txtApiMe.Name = "txtApiMe"
        Me.txtApiMe.ReadOnly = True
        Me.txtApiMe.Size = New System.Drawing.Size(260, 25)
        Me.txtApiMe.TabIndex = 7
        Me.txtApiMe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpAccessToken
        '
        Me.grpAccessToken.Controls.Add(Me.txtAccessToken)
        Me.grpAccessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAccessToken.Location = New System.Drawing.Point(3, 579)
        Me.grpAccessToken.Name = "grpAccessToken"
        Me.grpAccessToken.Size = New System.Drawing.Size(560, 44)
        Me.grpAccessToken.TabIndex = 8
        Me.grpAccessToken.TabStop = False
        Me.grpAccessToken.Text = "AccessToken"
        '
        'txtAccessToken
        '
        Me.txtAccessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAccessToken.Location = New System.Drawing.Point(3, 16)
        Me.txtAccessToken.Multiline = True
        Me.txtAccessToken.Name = "txtAccessToken"
        Me.txtAccessToken.ReadOnly = True
        Me.txtAccessToken.Size = New System.Drawing.Size(554, 25)
        Me.txtAccessToken.TabIndex = 7
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 626)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMain.ResumeLayout(False)
        Me.pnlBrowserContainer.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.grpChooseDocuments.ResumeLayout(False)
        Me.grpUploadDocuments.ResumeLayout(False)
        Me.grpChooseBundle.ResumeLayout(False)
        Me.grpChooseSection.ResumeLayout(False)
        Me.grpMe.ResumeLayout(False)
        Me.grpMe.PerformLayout()
        Me.grpAccessToken.ResumeLayout(False)
        Me.grpAccessToken.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlMain As TableLayoutPanel
    Private WithEvents lblAuthenticateHeader As Label
    Private WithEvents lblOutputHeader As Label
    Private WithEvents pnlBrowserContainer As Panel
    Friend WithEvents wbMain As WebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents dlgOpenFiles As OpenFileDialog
    Friend WithEvents pnlRight As TableLayoutPanel
    Friend WithEvents grpChooseDocuments As GroupBox
    Friend WithEvents btnChooseFiles As Button
    Friend WithEvents lstDocuments As ListBox
    Friend WithEvents grpUploadDocuments As GroupBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents grpChooseBundle As GroupBox
    Friend WithEvents lstBundles As ListBox
    Friend WithEvents grpChooseSection As GroupBox
    Friend WithEvents lstSections As ListBox
    Friend WithEvents grpMe As GroupBox
    Private WithEvents txtApiMe As TextBox
    Friend WithEvents grpAccessToken As GroupBox
    Private WithEvents txtAccessToken As TextBox
End Class
