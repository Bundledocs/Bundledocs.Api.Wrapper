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
        Me.txtAccessToken = New System.Windows.Forms.TextBox()
        Me.lblAuthenticateHeader = New System.Windows.Forms.Label()
        Me.lblOutputHeader = New System.Windows.Forms.Label()
        Me.pnlBrowserContainer = New System.Windows.Forms.Panel()
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.pnlRight = New System.Windows.Forms.TableLayoutPanel()
        Me.txtApiMe = New System.Windows.Forms.TextBox()
        Me.lstBundles = New System.Windows.Forms.ListBox()
        Me.lstSections = New System.Windows.Forms.ListBox()
        Me.pnlMain.SuspendLayout()
        Me.pnlBrowserContainer.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.ColumnCount = 2
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278.0!))
        Me.pnlMain.Controls.Add(Me.txtAccessToken, 0, 2)
        Me.pnlMain.Controls.Add(Me.lblAuthenticateHeader, 0, 0)
        Me.pnlMain.Controls.Add(Me.lblOutputHeader, 1, 0)
        Me.pnlMain.Controls.Add(Me.pnlBrowserContainer, 0, 1)
        Me.pnlMain.Controls.Add(Me.pnlRight, 1, 1)
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
        'txtAccessToken
        '
        Me.txtAccessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAccessToken.Location = New System.Drawing.Point(3, 579)
        Me.txtAccessToken.Multiline = True
        Me.txtAccessToken.Name = "txtAccessToken"
        Me.txtAccessToken.ReadOnly = True
        Me.txtAccessToken.Size = New System.Drawing.Size(560, 44)
        Me.txtAccessToken.TabIndex = 6
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
        Me.pnlRight.Controls.Add(Me.txtApiMe, 0, 0)
        Me.pnlRight.Controls.Add(Me.lstBundles, 0, 1)
        Me.pnlRight.Controls.Add(Me.lstSections, 0, 2)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(569, 33)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.RowCount = 4
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.pnlRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlRight.Size = New System.Drawing.Size(272, 540)
        Me.pnlRight.TabIndex = 7
        '
        'txtApiMe
        '
        Me.txtApiMe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApiMe.Location = New System.Drawing.Point(3, 3)
        Me.txtApiMe.Multiline = True
        Me.txtApiMe.Name = "txtApiMe"
        Me.txtApiMe.ReadOnly = True
        Me.txtApiMe.Size = New System.Drawing.Size(266, 34)
        Me.txtApiMe.TabIndex = 6
        '
        'lstBundles
        '
        Me.lstBundles.DisplayMember = "Title"
        Me.lstBundles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBundles.FormattingEnabled = True
        Me.lstBundles.ItemHeight = 14
        Me.lstBundles.Location = New System.Drawing.Point(3, 43)
        Me.lstBundles.Name = "lstBundles"
        Me.lstBundles.Size = New System.Drawing.Size(266, 79)
        Me.lstBundles.TabIndex = 7
        '
        'lstSections
        '
        Me.lstSections.DisplayMember = "Description"
        Me.lstSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSections.FormattingEnabled = True
        Me.lstSections.ItemHeight = 14
        Me.lstSections.Location = New System.Drawing.Point(3, 128)
        Me.lstSections.Name = "lstSections"
        Me.lstSections.Size = New System.Drawing.Size(266, 79)
        Me.lstSections.TabIndex = 8
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
        Me.pnlMain.PerformLayout()
        Me.pnlBrowserContainer.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlMain As TableLayoutPanel
    Private WithEvents txtAccessToken As TextBox
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

    Friend WithEvents pnlRight As TableLayoutPanel
    Private WithEvents txtApiMe As TextBox
    Friend WithEvents lstBundles As ListBox
    Friend WithEvents lstSections As ListBox
End Class
