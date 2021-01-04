<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUpdate
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUpdate))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.lblCurrentEmp = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbApp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocalPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUpdateFile = New System.Windows.Forms.Label()
        Me.opnFle = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationIcon = CType(resources.GetObject("RibbonControl1.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(854, 49)
        '
        'lblCurrentEmp
        '
        Me.lblCurrentEmp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentEmp.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.lblCurrentEmp.Appearance.Options.UseFont = True
        Me.lblCurrentEmp.Appearance.Options.UseForeColor = True
        Me.lblCurrentEmp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCurrentEmp.LineColor = System.Drawing.Color.Gold
        Me.lblCurrentEmp.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.lblCurrentEmp.LineVisible = True
        Me.lblCurrentEmp.Location = New System.Drawing.Point(12, 71)
        Me.lblCurrentEmp.Name = "lblCurrentEmp"
        Me.lblCurrentEmp.Size = New System.Drawing.Size(769, 39)
        Me.lblCurrentEmp.TabIndex = 118
        Me.lblCurrentEmp.Text = "Add Application Updates"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(360, 452)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(238, 68)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Add New"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(604, 452)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(238, 68)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Cancel"
        '
        'cmbApp
        '
        Me.cmbApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApp.FormattingEnabled = True
        Me.cmbApp.Items.AddRange(New Object() {"EICA"})
        Me.cmbApp.Location = New System.Drawing.Point(153, 128)
        Me.cmbApp.Name = "cmbApp"
        Me.cmbApp.Size = New System.Drawing.Size(267, 21)
        Me.cmbApp.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Application: "
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(153, 191)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(489, 21)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Name: "
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"System File Overwrite", "Database Structure Update", "EXE Update"})
        Me.cmbType.Location = New System.Drawing.Point(153, 160)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(267, 21)
        Me.cmbType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Type: "
        '
        'txtLocalPath
        '
        Me.txtLocalPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalPath.Location = New System.Drawing.Point(153, 221)
        Me.txtLocalPath.Name = "txtLocalPath"
        Me.txtLocalPath.Size = New System.Drawing.Size(646, 21)
        Me.txtLocalPath.TabIndex = 3
        Me.txtLocalPath.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Local Path: "
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(153, 324)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(168, 41)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Select Update File"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Update File: "
        '
        'lblUpdateFile
        '
        Me.lblUpdateFile.Location = New System.Drawing.Point(150, 261)
        Me.lblUpdateFile.Name = "lblUpdateFile"
        Me.lblUpdateFile.Size = New System.Drawing.Size(649, 46)
        Me.lblUpdateFile.TabIndex = 151
        '
        'opnFle
        '
        Me.opnFle.Filter = "All File Types|*.*"
        '
        'frmAddUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUpdateFile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.txtLocalPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbApp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblCurrentEmp)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddUpdate"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents lblCurrentEmp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbApp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLocalPath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUpdateFile As Label
    Friend WithEvents opnFle As OpenFileDialog
End Class
