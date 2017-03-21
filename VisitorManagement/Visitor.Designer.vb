<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visitor
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
        Me.header = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtGovtIdName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnVisitorSearch = New System.Windows.Forms.Button()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFlatNo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboBuildingNo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdoFGender = New System.Windows.Forms.RadioButton()
        Me.rdoMGender = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGovtNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoneNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Controls.Add(Me.btnReset)
        Me.header.Controls.Add(Me.btnUpdate)
        Me.header.Controls.Add(Me.btnDelete)
        Me.header.Controls.Add(Me.btnSave)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(843, 48)
        Me.header.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(19, 13)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset "
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(656, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(751, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(575, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 383)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 44)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtGovtIdName)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblMsg)
        Me.Panel2.Controls.Add(Me.btnVisitorSearch)
        Me.Panel2.Controls.Add(Me.txtReason)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cboFlatNo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cboBuildingNo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rdoFGender)
        Me.Panel2.Controls.Add(Me.rdoMGender)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtFrom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtGovtNo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtPoneNo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 335)
        Me.Panel2.TabIndex = 2
        '
        'txtGovtIdName
        '
        Me.txtGovtIdName.Location = New System.Drawing.Point(93, 11)
        Me.txtGovtIdName.Name = "txtGovtIdName"
        Me.txtGovtIdName.Size = New System.Drawing.Size(253, 20)
        Me.txtGovtIdName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Govn Id Name"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(414, 43)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg.TabIndex = 19
        '
        'btnVisitorSearch
        '
        Me.btnVisitorSearch.Location = New System.Drawing.Point(353, 34)
        Me.btnVisitorSearch.Name = "btnVisitorSearch"
        Me.btnVisitorSearch.Size = New System.Drawing.Size(54, 23)
        Me.btnVisitorSearch.TabIndex = 18
        Me.btnVisitorSearch.Text = "Search"
        Me.btnVisitorSearch.UseVisualStyleBackColor = True
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(93, 278)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(253, 20)
        Me.txtReason.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Reason"
        '
        'cboFlatNo
        '
        Me.cboFlatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlatNo.FormattingEnabled = True
        Me.cboFlatNo.Location = New System.Drawing.Point(348, 230)
        Me.cboFlatNo.Name = "cboFlatNo"
        Me.cboFlatNo.Size = New System.Drawing.Size(383, 21)
        Me.cboFlatNo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Flat No"
        '
        'cboBuildingNo
        '
        Me.cboBuildingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuildingNo.FormattingEnabled = True
        Me.cboBuildingNo.Location = New System.Drawing.Point(93, 227)
        Me.cboBuildingNo.Name = "cboBuildingNo"
        Me.cboBuildingNo.Size = New System.Drawing.Size(121, 21)
        Me.cboBuildingNo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Building No"
        '
        'rdoFGender
        '
        Me.rdoFGender.AutoSize = True
        Me.rdoFGender.Location = New System.Drawing.Point(198, 149)
        Me.rdoFGender.Name = "rdoFGender"
        Me.rdoFGender.Size = New System.Drawing.Size(59, 17)
        Me.rdoFGender.TabIndex = 10
        Me.rdoFGender.TabStop = True
        Me.rdoFGender.Text = "Female"
        Me.rdoFGender.UseVisualStyleBackColor = True
        '
        'rdoMGender
        '
        Me.rdoMGender.AutoSize = True
        Me.rdoMGender.Checked = True
        Me.rdoMGender.Location = New System.Drawing.Point(93, 149)
        Me.rdoMGender.Name = "rdoMGender"
        Me.rdoMGender.Size = New System.Drawing.Size(48, 17)
        Me.rdoMGender.TabIndex = 9
        Me.rdoMGender.TabStop = True
        Me.rdoMGender.Text = "Male"
        Me.rdoMGender.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(93, 182)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(253, 20)
        Me.txtFrom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From"
        '
        'txtGovtNo
        '
        Me.txtGovtNo.Location = New System.Drawing.Point(93, 37)
        Me.txtGovtNo.Name = "txtGovtNo"
        Me.txtGovtNo.Size = New System.Drawing.Size(253, 20)
        Me.txtGovtNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Id"
        '
        'txtPoneNo
        '
        Me.txtPoneNo.Location = New System.Drawing.Point(93, 106)
        Me.txtPoneNo.Name = "txtPoneNo"
        Me.txtPoneNo.Size = New System.Drawing.Size(253, 20)
        Me.txtPoneNo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Phone No"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(253, 20)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 427)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.header)
        Me.Name = "Visitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitor Info"
        Me.header.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtGovtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents rdoFGender As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMGender As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFlatNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboBuildingNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnVisitorSearch As System.Windows.Forms.Button
    Friend WithEvents txtGovtIdName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
