<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmp))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUserMail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSqlExpValue = New System.Windows.Forms.Label()
        Me.lblWorkExpValue = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.tbSqlExp = New DevExpress.XtraEditors.TrackBarControl()
        Me.tbWorkExp = New DevExpress.XtraEditors.TrackBarControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAppAssigned = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstGroup = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstStatusID = New System.Windows.Forms.ListBox()
        Me.lstCountID = New System.Windows.Forms.ListBox()
        Me.lstNatID = New System.Windows.Forms.ListBox()
        Me.dteExJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbNat = New System.Windows.Forms.ComboBox()
        Me.txtEduDegree = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrentEmp = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.picEmpImg = New System.Windows.Forms.PictureBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.opnFle = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSqlExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSqlExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbWorkExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbWorkExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmpImg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(887, 54)
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(149, 527)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(267, 21)
        Me.txtUserName.TabIndex = 158
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 529)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 157
        Me.Label16.Text = "* User Name: "
        '
        'txtUserMail
        '
        Me.txtUserMail.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.txtUserMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserMail.Location = New System.Drawing.Point(149, 496)
        Me.txtUserMail.Name = "txtUserMail"
        Me.txtUserMail.Size = New System.Drawing.Size(267, 21)
        Me.txtUserMail.TabIndex = 156
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 498)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "* User Mail: "
        '
        'lblSqlExpValue
        '
        Me.lblSqlExpValue.AutoSize = True
        Me.lblSqlExpValue.Location = New System.Drawing.Point(787, 495)
        Me.lblSqlExpValue.Name = "lblSqlExpValue"
        Me.lblSqlExpValue.Size = New System.Drawing.Size(13, 13)
        Me.lblSqlExpValue.TabIndex = 154
        Me.lblSqlExpValue.Text = "3"
        '
        'lblWorkExpValue
        '
        Me.lblWorkExpValue.AutoSize = True
        Me.lblWorkExpValue.Location = New System.Drawing.Point(787, 439)
        Me.lblWorkExpValue.Name = "lblWorkExpValue"
        Me.lblWorkExpValue.Size = New System.Drawing.Size(13, 13)
        Me.lblWorkExpValue.TabIndex = 153
        Me.lblWorkExpValue.Text = "5"
        '
        'lblPos
        '
        Me.lblPos.Location = New System.Drawing.Point(149, 358)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(453, 15)
        Me.lblPos.TabIndex = 152
        Me.lblPos.Text = "none"
        '
        'tbSqlExp
        '
        Me.tbSqlExp.EditValue = 3
        Me.tbSqlExp.Location = New System.Drawing.Point(563, 480)
        Me.tbSqlExp.MenuManager = Me.RibbonControl1
        Me.tbSqlExp.Name = "tbSqlExp"
        Me.tbSqlExp.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbSqlExp.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbSqlExp.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbSqlExp.Size = New System.Drawing.Size(218, 45)
        Me.tbSqlExp.TabIndex = 151
        Me.tbSqlExp.Value = 3
        '
        'tbWorkExp
        '
        Me.tbWorkExp.EditValue = 5
        Me.tbWorkExp.Location = New System.Drawing.Point(563, 423)
        Me.tbWorkExp.MenuManager = Me.RibbonControl1
        Me.tbWorkExp.Name = "tbWorkExp"
        Me.tbWorkExp.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbWorkExp.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbWorkExp.Properties.ShowLabels = True
        Me.tbWorkExp.Properties.ShowValueToolTip = True
        Me.tbWorkExp.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbWorkExp.Size = New System.Drawing.Size(218, 45)
        Me.tbWorkExp.TabIndex = 150
        Me.tbWorkExp.Value = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(445, 495)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "* Sql Experience: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(445, 436)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "* Work Experience: "
        '
        'txtAppAssigned
        '
        Me.txtAppAssigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppAssigned.Location = New System.Drawing.Point(149, 464)
        Me.txtAppAssigned.Name = "txtAppAssigned"
        Me.txtAppAssigned.Size = New System.Drawing.Size(267, 21)
        Me.txtAppAssigned.TabIndex = 147
        Me.txtAppAssigned.Text = "None"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = " App Assigned: "
        '
        'lstGroup
        '
        Me.lstGroup.FormattingEnabled = True
        Me.lstGroup.Location = New System.Drawing.Point(229, 605)
        Me.lstGroup.Name = "lstGroup"
        Me.lstGroup.Size = New System.Drawing.Size(75, 82)
        Me.lstGroup.TabIndex = 145
        Me.lstGroup.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 434)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "* Group: "
        '
        'lstStatusID
        '
        Me.lstStatusID.FormattingEnabled = True
        Me.lstStatusID.Location = New System.Drawing.Point(179, 604)
        Me.lstStatusID.Name = "lstStatusID"
        Me.lstStatusID.Size = New System.Drawing.Size(75, 82)
        Me.lstStatusID.TabIndex = 143
        Me.lstStatusID.Visible = False
        '
        'lstCountID
        '
        Me.lstCountID.FormattingEnabled = True
        Me.lstCountID.Location = New System.Drawing.Point(98, 604)
        Me.lstCountID.Name = "lstCountID"
        Me.lstCountID.Size = New System.Drawing.Size(75, 82)
        Me.lstCountID.TabIndex = 142
        Me.lstCountID.Visible = False
        '
        'lstNatID
        '
        Me.lstNatID.FormattingEnabled = True
        Me.lstNatID.Location = New System.Drawing.Point(17, 604)
        Me.lstNatID.Name = "lstNatID"
        Me.lstNatID.Size = New System.Drawing.Size(75, 82)
        Me.lstNatID.TabIndex = 141
        Me.lstNatID.Visible = False
        '
        'dteExJoinDate
        '
        Me.dteExJoinDate.Location = New System.Drawing.Point(152, 251)
        Me.dteExJoinDate.Name = "dteExJoinDate"
        Me.dteExJoinDate.Size = New System.Drawing.Size(264, 21)
        Me.dteExJoinDate.TabIndex = 125
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(149, 381)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(168, 41)
        Me.SimpleButton4.TabIndex = 133
        Me.SimpleButton4.Text = "Select Position"
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(149, 431)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(267, 21)
        Me.cmbGroup.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "  Current Position: "
        '
        'cmbCountry
        '
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(149, 216)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(267, 21)
        Me.cmbCountry.TabIndex = 124
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(149, 181)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(267, 21)
        Me.cmbStatus.TabIndex = 122
        '
        'cmbNat
        '
        Me.cmbNat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNat.FormattingEnabled = True
        Me.cmbNat.Location = New System.Drawing.Point(149, 146)
        Me.cmbNat.Name = "cmbNat"
        Me.cmbNat.Size = New System.Drawing.Size(267, 21)
        Me.cmbNat.TabIndex = 120
        '
        'txtEduDegree
        '
        Me.txtEduDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEduDegree.Location = New System.Drawing.Point(149, 319)
        Me.txtEduDegree.Name = "txtEduDegree"
        Me.txtEduDegree.Size = New System.Drawing.Size(267, 21)
        Me.txtEduDegree.TabIndex = 128
        Me.txtEduDegree.Text = "Undefined"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(149, 286)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(267, 21)
        Me.txtPhone.TabIndex = 127
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(149, 111)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(489, 21)
        Me.txtName.TabIndex = 118
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(42, 588)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "* Required Field"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(560, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "  Photo: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "  Education Degree: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "* Phone Number: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "  Expected Join Date: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "* Current Country: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "* Status: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "* Nationality: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "* Full Name: "
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
        Me.lblCurrentEmp.Location = New System.Drawing.Point(12, 60)
        Me.lblCurrentEmp.Name = "lblCurrentEmp"
        Me.lblCurrentEmp.Size = New System.Drawing.Size(769, 39)
        Me.lblCurrentEmp.TabIndex = 117
        Me.lblCurrentEmp.Text = "Current Employee:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(613, 366)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(168, 41)
        Me.SimpleButton3.TabIndex = 130
        Me.SimpleButton3.Text = "Select"
        '
        'picEmpImg
        '
        Me.picEmpImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmpImg.Location = New System.Drawing.Point(613, 178)
        Me.picEmpImg.Name = "picEmpImg"
        Me.picEmpImg.Size = New System.Drawing.Size(168, 182)
        Me.picEmpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmpImg.TabIndex = 139
        Me.picEmpImg.TabStop = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(385, 625)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(238, 68)
        Me.SimpleButton2.TabIndex = 137
        Me.SimpleButton2.Text = "Add New"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(629, 625)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(238, 68)
        Me.SimpleButton1.TabIndex = 138
        Me.SimpleButton1.Text = "Cancel"
        '
        'opnFle
        '
        Me.opnFle.Filter = "JPEG Images|*.jpg"
        '
        'frmAddEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUserMail)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblSqlExpValue)
        Me.Controls.Add(Me.lblWorkExpValue)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.tbSqlExp)
        Me.Controls.Add(Me.tbWorkExp)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAppAssigned)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstGroup)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstStatusID)
        Me.Controls.Add(Me.lstCountID)
        Me.Controls.Add(Me.lstNatID)
        Me.Controls.Add(Me.dteExJoinDate)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbNat)
        Me.Controls.Add(Me.txtEduDegree)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentEmp)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.picEmpImg)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddEmp"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSqlExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSqlExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbWorkExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbWorkExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmpImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtUserMail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSqlExpValue As Label
    Friend WithEvents lblWorkExpValue As Label
    Friend WithEvents lblPos As Label
    Friend WithEvents tbSqlExp As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents tbWorkExp As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAppAssigned As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstGroup As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstStatusID As ListBox
    Friend WithEvents lstCountID As ListBox
    Friend WithEvents lstNatID As ListBox
    Friend WithEvents dteExJoinDate As DateTimePicker
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbNat As ComboBox
    Friend WithEvents txtEduDegree As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrentEmp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picEmpImg As PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents opnFle As OpenFileDialog
End Class
