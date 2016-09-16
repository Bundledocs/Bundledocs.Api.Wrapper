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
        Me.txtApiMe = New System.Windows.Forms.TextBox()
        Me.pnlMain.SuspendLayout
        Me.pnlBrowserContainer.SuspendLayout
        Me.SuspendLayout
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = true
        Me.pnlMain.ColumnCount = 2
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278!))
        Me.pnlMain.Controls.Add(Me.txtAccessToken, 0, 2)
        Me.pnlMain.Controls.Add(Me.lblAuthenticateHeader, 0, 0)
        Me.pnlMain.Controls.Add(Me.lblOutputHeader, 1, 0)
        Me.pnlMain.Controls.Add(Me.pnlBrowserContainer, 0, 1)
        Me.pnlMain.Controls.Add(Me.txtApiMe, 1, 1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.RowCount = 3
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77821!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.221797!))
        Me.pnlMain.Size = New System.Drawing.Size(844, 626)
        Me.pnlMain.TabIndex = 1
        '
        'txtAccessToken
        '
        Me.txtAccessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAccessToken.Location = New System.Drawing.Point(3, 579)
        Me.txtAccessToken.Multiline = true
        Me.txtAccessToken.Name = "txtAccessToken"
        Me.txtAccessToken.ReadOnly = true
        Me.txtAccessToken.Size = New System.Drawing.Size(560, 44)
        Me.txtAccessToken.TabIndex = 6
        '
        'lblAuthenticateHeader
        '
        Me.lblAuthenticateHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAuthenticateHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.lblOutputHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        'txtApiMe
        '
        Me.txtApiMe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApiMe.Location = New System.Drawing.Point(569, 33)
        Me.txtApiMe.Multiline = true
        Me.txtApiMe.Name = "txtApiMe"
        Me.txtApiMe.ReadOnly = true
        Me.txtApiMe.Size = New System.Drawing.Size(272, 540)
        Me.txtApiMe.TabIndex = 5
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 626)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        Me.pnlBrowserContainer.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Private WithEvents pnlMain As TableLayoutPanel
    Private WithEvents txtAccessToken As TextBox
    Private WithEvents lblAuthenticateHeader As Label
    Private WithEvents lblOutputHeader As Label
    Private WithEvents pnlBrowserContainer As Panel
    Private WithEvents txtApiMe As TextBox
    Friend WithEvents wbMain As WebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
