<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNotification
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNotification))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstPro = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Pic03 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Pic02 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Pic01 = New System.Windows.Forms.PictureBox()
        Me.txtNoti = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.opnFle = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Pic03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1206, 54)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 54)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstPro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pic03)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pic02)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pic01)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNoti)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtHeader)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1206, 649)
        Me.SplitContainer1.SplitterDistance = 401
        Me.SplitContainer1.TabIndex = 1
        '
        'lstPro
        '
        Me.lstPro.BackColor = System.Drawing.Color.Gray
        Me.lstPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPro.ForeColor = System.Drawing.Color.White
        Me.lstPro.FormattingEnabled = True
        Me.lstPro.Location = New System.Drawing.Point(0, 25)
        Me.lstPro.Name = "lstPro"
        Me.lstPro.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstPro.Size = New System.Drawing.Size(399, 622)
        Me.lstPro.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(399, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton1.Text = "Select Project(s)"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripButton2.Text = "Clear"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(526, 591)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(128, 41)
        Me.SimpleButton8.TabIndex = 27
        Me.SimpleButton8.Text = "Add New"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(660, 591)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(128, 41)
        Me.SimpleButton7.TabIndex = 26
        Me.SimpleButton7.Text = "Cancel"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(373, 558)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton5.TabIndex = 25
        Me.SimpleButton5.Text = "Remove"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(453, 558)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton6.TabIndex = 24
        Me.SimpleButton6.Text = "Select"
        '
        'LabelControl3
        '
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.LineColor = System.Drawing.Color.White
        Me.LabelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(367, 403)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(233, 26)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Footer Picture"
        '
        'Pic03
        '
        Me.Pic03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic03.Location = New System.Drawing.Point(367, 435)
        Me.Pic03.Name = "Pic03"
        Me.Pic03.Size = New System.Drawing.Size(412, 117)
        Me.Pic03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic03.TabIndex = 22
        Me.Pic03.TabStop = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(373, 363)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton3.TabIndex = 21
        Me.SimpleButton3.Text = "Remove"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(453, 363)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton4.TabIndex = 20
        Me.SimpleButton4.Text = "Select"
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.LineColor = System.Drawing.Color.White
        Me.LabelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl4.LineVisible = True
        Me.LabelControl4.Location = New System.Drawing.Point(367, 208)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(233, 26)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Middle Picture"
        '
        'Pic02
        '
        Me.Pic02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic02.Location = New System.Drawing.Point(367, 240)
        Me.Pic02.Name = "Pic02"
        Me.Pic02.Size = New System.Drawing.Size(412, 117)
        Me.Pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic02.TabIndex = 18
        Me.Pic02.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(373, 175)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "Remove"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(453, 175)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(74, 27)
        Me.SimpleButton2.TabIndex = 16
        Me.SimpleButton2.Text = "Select"
        '
        'LabelControl5
        '
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.LineColor = System.Drawing.Color.White
        Me.LabelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl5.LineVisible = True
        Me.LabelControl5.Location = New System.Drawing.Point(367, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(233, 26)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Top Picture"
        '
        'Pic01
        '
        Me.Pic01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic01.Location = New System.Drawing.Point(367, 49)
        Me.Pic01.Name = "Pic01"
        Me.Pic01.Size = New System.Drawing.Size(412, 117)
        Me.Pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic01.TabIndex = 14
        Me.Pic01.TabStop = False
        '
        'txtNoti
        '
        Me.txtNoti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoti.Location = New System.Drawing.Point(78, 54)
        Me.txtNoti.Multiline = True
        Me.txtNoti.Name = "txtNoti"
        Me.txtNoti.Size = New System.Drawing.Size(274, 531)
        Me.txtNoti.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineColor = System.Drawing.Color.White
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.Location = New System.Drawing.Point(13, 49)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 26)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Notification:"
        '
        'txtHeader
        '
        Me.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeader.Location = New System.Drawing.Point(78, 22)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(274, 21)
        Me.txtHeader.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.LineColor = System.Drawing.Color.White
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl2.Location = New System.Drawing.Point(13, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 26)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Header:"
        '
        'opnFle
        '
        Me.opnFle.Filter = "JPEG Images|*.jpg"
        '
        'frmAddNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddNotification"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Notification"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Pic03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents txtNoti As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Pic03 As PictureBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Pic02 As PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Pic01 As PictureBox
    Friend WithEvents opnFle As OpenFileDialog
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstPro As ListBox
End Class
