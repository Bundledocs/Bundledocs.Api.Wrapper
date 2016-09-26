<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.pnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAuthenticateHeader = New System.Windows.Forms.Label()
        Me.lblOutputHeader = New System.Windows.Forms.Label()
        Me.pnlBrowserContainer = New System.Windows.Forms.Panel()
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.pnlRight = New System.Windows.Forms.TableLayoutPanel()
        Me.grpReceipts = New System.Windows.Forms.GroupBox()
        Me.lstReceipts = New System.Windows.Forms.ListBox()
        Me.grpEventsGenerate = New System.Windows.Forms.GroupBox()
        Me.lstEventsGenerate = New System.Windows.Forms.ListBox()
        Me.grpChooseDocuments = New System.Windows.Forms.GroupBox()
        Me.btnChooseFiles = New System.Windows.Forms.Button()
        Me.grpUploadDocuments = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.grpChooseBundle = New System.Windows.Forms.GroupBox()
        Me.lstBundles = New System.Windows.Forms.ListBox()
        Me.grpChooseSection = New System.Windows.Forms.GroupBox()
        Me.lstSections = New System.Windows.Forms.ListBox()
        Me.grpMe = New System.Windows.Forms.GroupBox()
        Me.txtApiMe = New System.Windows.Forms.TextBox()
        Me.grpGenerate = New System.Windows.Forms.GroupBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.grpDocuments = New System.Windows.Forms.GroupBox()
        Me.lstDocuments = New System.Windows.Forms.ListBox()
        Me.grpEventsUpload = New System.Windows.Forms.GroupBox()
        Me.lstEventsUpload = New System.Windows.Forms.ListBox()
        Me.grpDownload = New System.Windows.Forms.GroupBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.grpAccessToken = New System.Windows.Forms.GroupBox()
        Me.txtAccessToken = New System.Windows.Forms.TextBox()
        Me.dlgOpenFiles = New System.Windows.Forms.OpenFileDialog()
        Me.pnlMain.SuspendLayout()
        Me.pnlBrowserContainer.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.grpReceipts.SuspendLayout()
        Me.grpEventsGenerate.SuspendLayout()
        Me.grpChooseDocuments.SuspendLayout()
        Me.grpUploadDocuments.SuspendLayout()
        Me.grpChooseBundle.SuspendLayout()
        Me.grpChooseSection.SuspendLayout()
        Me.grpMe.SuspendLayout()
        Me.grpGenerate.SuspendLayout()
        Me.grpDocuments.SuspendLayout()
        Me.grpEventsUpload.SuspendLayout()
        Me.grpDownload.SuspendLayout()
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
        Me.pnlMain.Size = New System.Drawing.Size(844, 639)
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
        Me.pnlBrowserContainer.Size = New System.Drawing.Size(560, 552)
        Me.pnlBrowserContainer.TabIndex = 3
        '
        'wbMain
        '
        Me.wbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMain.Location = New System.Drawing.Point(0, 0)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(560, 552)
        Me.wbMain.TabIndex = 0
        '
        'pnlRight
        '
        Me.pnlRight.ColumnCount = 1
        Me.pnlRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlRight.Controls.Add(Me.grpReceipts, 0, 9)
        Me.pnlRight.Controls.Add(Me.grpEventsGenerate, 0, 8)
        Me.pnlRight.Controls.Add(Me.grpChooseDocuments, 0, 3)
        Me.pnlRight.Controls.Add(Me.grpUploadDocuments, 0, 5)
        Me.pnlRight.Controls.Add(Me.grpChooseBundle, 0, 1)
        Me.pnlRight.Controls.Add(Me.grpChooseSection, 0, 2)
        Me.pnlRight.Controls.Add(Me.grpMe, 0, 0)
        Me.pnlRight.Controls.Add(Me.grpGenerate, 0, 7)
        Me.pnlRight.Controls.Add(Me.grpDocuments, 0, 4)
        Me.pnlRight.Controls.Add(Me.grpEventsUpload, 0, 6)
        Me.pnlRight.Controls.Add(Me.grpDownload, 0, 10)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(569, 33)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.RowCount = 11
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlRight.Size = New System.Drawing.Size(272, 552)
        Me.pnlRight.TabIndex = 7
        '
        'grpReceipts
        '
        Me.grpReceipts.Controls.Add(Me.lstReceipts)
        Me.grpReceipts.Location = New System.Drawing.Point(3, 453)
        Me.grpReceipts.Name = "grpReceipts"
        Me.grpReceipts.Size = New System.Drawing.Size(266, 44)
        Me.grpReceipts.TabIndex = 22
        Me.grpReceipts.TabStop = False
        Me.grpReceipts.Text = "Bundle Receipts"
        '
        'lstReceipts
        '
        Me.lstReceipts.DisplayMember = "Description"
        Me.lstReceipts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstReceipts.FormattingEnabled = True
        Me.lstReceipts.ItemHeight = 14
        Me.lstReceipts.Location = New System.Drawing.Point(3, 16)
        Me.lstReceipts.Name = "lstReceipts"
        Me.lstReceipts.Size = New System.Drawing.Size(260, 25)
        Me.lstReceipts.TabIndex = 17
        '
        'grpEventsGenerate
        '
        Me.grpEventsGenerate.Controls.Add(Me.lstEventsGenerate)
        Me.grpEventsGenerate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpEventsGenerate.Location = New System.Drawing.Point(3, 403)
        Me.grpEventsGenerate.Name = "grpEventsGenerate"
        Me.grpEventsGenerate.Size = New System.Drawing.Size(266, 44)
        Me.grpEventsGenerate.TabIndex = 21
        Me.grpEventsGenerate.TabStop = False
        Me.grpEventsGenerate.Text = "Upload Events"
        '
        'lstEventsGenerate
        '
        Me.lstEventsGenerate.DisplayMember = "Name"
        Me.lstEventsGenerate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEventsGenerate.FormattingEnabled = True
        Me.lstEventsGenerate.ItemHeight = 14
        Me.lstEventsGenerate.Location = New System.Drawing.Point(3, 16)
        Me.lstEventsGenerate.Name = "lstEventsGenerate"
        Me.lstEventsGenerate.Size = New System.Drawing.Size(260, 25)
        Me.lstEventsGenerate.TabIndex = 17
        '
        'grpChooseDocuments
        '
        Me.grpChooseDocuments.Controls.Add(Me.btnChooseFiles)
        Me.grpChooseDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChooseDocuments.Location = New System.Drawing.Point(3, 153)
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
        'grpUploadDocuments
        '
        Me.grpUploadDocuments.Controls.Add(Me.btnUpload)
        Me.grpUploadDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUploadDocuments.Location = New System.Drawing.Point(3, 253)
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
        Me.grpChooseBundle.Size = New System.Drawing.Size(266, 44)
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
        Me.lstBundles.Size = New System.Drawing.Size(260, 25)
        Me.lstBundles.TabIndex = 8
        '
        'grpChooseSection
        '
        Me.grpChooseSection.Controls.Add(Me.lstSections)
        Me.grpChooseSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChooseSection.Location = New System.Drawing.Point(3, 103)
        Me.grpChooseSection.Name = "grpChooseSection"
        Me.grpChooseSection.Size = New System.Drawing.Size(266, 44)
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
        Me.lstSections.Size = New System.Drawing.Size(260, 25)
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
        'grpGenerate
        '
        Me.grpGenerate.Controls.Add(Me.btnGenerate)
        Me.grpGenerate.Location = New System.Drawing.Point(3, 353)
        Me.grpGenerate.Name = "grpGenerate"
        Me.grpGenerate.Size = New System.Drawing.Size(266, 44)
        Me.grpGenerate.TabIndex = 17
        Me.grpGenerate.TabStop = False
        Me.grpGenerate.Text = "Generate Bundle"
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGenerate.Location = New System.Drawing.Point(3, 16)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(260, 25)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'grpDocuments
        '
        Me.grpDocuments.Controls.Add(Me.lstDocuments)
        Me.grpDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDocuments.Location = New System.Drawing.Point(3, 203)
        Me.grpDocuments.Name = "grpDocuments"
        Me.grpDocuments.Size = New System.Drawing.Size(266, 44)
        Me.grpDocuments.TabIndex = 18
        Me.grpDocuments.TabStop = False
        Me.grpDocuments.Text = "Documents"
        '
        'lstDocuments
        '
        Me.lstDocuments.DisplayMember = "Description"
        Me.lstDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDocuments.FormattingEnabled = True
        Me.lstDocuments.ItemHeight = 14
        Me.lstDocuments.Location = New System.Drawing.Point(3, 16)
        Me.lstDocuments.Name = "lstDocuments"
        Me.lstDocuments.Size = New System.Drawing.Size(260, 25)
        Me.lstDocuments.TabIndex = 11
        '
        'grpEventsUpload
        '
        Me.grpEventsUpload.Controls.Add(Me.lstEventsUpload)
        Me.grpEventsUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpEventsUpload.Location = New System.Drawing.Point(3, 303)
        Me.grpEventsUpload.Name = "grpEventsUpload"
        Me.grpEventsUpload.Size = New System.Drawing.Size(266, 44)
        Me.grpEventsUpload.TabIndex = 19
        Me.grpEventsUpload.TabStop = False
        Me.grpEventsUpload.Text = "Upload Events"
        '
        'lstEventsUpload
        '
        Me.lstEventsUpload.DisplayMember = "Name"
        Me.lstEventsUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEventsUpload.FormattingEnabled = True
        Me.lstEventsUpload.ItemHeight = 14
        Me.lstEventsUpload.Location = New System.Drawing.Point(3, 16)
        Me.lstEventsUpload.Name = "lstEventsUpload"
        Me.lstEventsUpload.Size = New System.Drawing.Size(260, 25)
        Me.lstEventsUpload.TabIndex = 17
        '
        'grpDownload
        '
        Me.grpDownload.Controls.Add(Me.btnDownload)
        Me.grpDownload.Location = New System.Drawing.Point(3, 503)
        Me.grpDownload.Name = "grpDownload"
        Me.grpDownload.Size = New System.Drawing.Size(266, 44)
        Me.grpDownload.TabIndex = 23
        Me.grpDownload.TabStop = False
        Me.grpDownload.Text = "Download Bundle"
        '
        'btnDownload
        '
        Me.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDownload.Location = New System.Drawing.Point(3, 16)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(260, 25)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'grpAccessToken
        '
        Me.grpAccessToken.Controls.Add(Me.txtAccessToken)
        Me.grpAccessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAccessToken.Location = New System.Drawing.Point(3, 591)
        Me.grpAccessToken.Name = "grpAccessToken"
        Me.grpAccessToken.Size = New System.Drawing.Size(560, 45)
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
        Me.txtAccessToken.Size = New System.Drawing.Size(554, 26)
        Me.txtAccessToken.TabIndex = 7
        '
        'dlgOpenFiles
        '
        Me.dlgOpenFiles.FileName = "OpenFileDialog"
        Me.dlgOpenFiles.Multiselect = True
        Me.dlgOpenFiles.RestoreDirectory = True
        Me.dlgOpenFiles.Title = "Choose Documents"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 639)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMain.ResumeLayout(False)
        Me.pnlBrowserContainer.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.grpReceipts.ResumeLayout(False)
        Me.grpEventsGenerate.ResumeLayout(False)
        Me.grpChooseDocuments.ResumeLayout(False)
        Me.grpUploadDocuments.ResumeLayout(False)
        Me.grpChooseBundle.ResumeLayout(False)
        Me.grpChooseSection.ResumeLayout(False)
        Me.grpMe.ResumeLayout(False)
        Me.grpMe.PerformLayout()
        Me.grpGenerate.ResumeLayout(False)
        Me.grpDocuments.ResumeLayout(False)
        Me.grpEventsUpload.ResumeLayout(False)
        Me.grpDownload.ResumeLayout(False)
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
    Friend WithEvents grpGenerate As GroupBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents grpDocuments As GroupBox
    Friend WithEvents lstDocuments As ListBox
    Friend WithEvents grpEventsUpload As GroupBox
    Friend WithEvents lstEventsUpload As ListBox
    Friend WithEvents grpEventsGenerate As GroupBox
    Friend WithEvents lstEventsGenerate As ListBox
    Friend WithEvents grpDownload As GroupBox
    Friend WithEvents btnDownload As Button
    Friend WithEvents grpReceipts As GroupBox
    Friend WithEvents lstReceipts As ListBox
End Class
