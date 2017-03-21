<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockVisitor
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
        Me.chkBlock = New System.Windows.Forms.CheckBox()
        Me.txtGovtIdName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnVisitorSearch = New System.Windows.Forms.Button()
        Me.rdoFGender = New System.Windows.Forms.RadioButton()
        Me.rdoMGender = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGovtNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoneNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkBlock
        '
        Me.chkBlock.AutoSize = True
        Me.chkBlock.Location = New System.Drawing.Point(29, 206)
        Me.chkBlock.Name = "chkBlock"
        Me.chkBlock.Size = New System.Drawing.Size(56, 17)
        Me.chkBlock.TabIndex = 0
        Me.chkBlock.Text = "Block "
        Me.chkBlock.UseVisualStyleBackColor = True
        '
        'txtGovtIdName
        '
        Me.txtGovtIdName.Location = New System.Drawing.Point(106, 32)
        Me.txtGovtIdName.Name = "txtGovtIdName"
        Me.txtGovtIdName.Size = New System.Drawing.Size(253, 20)
        Me.txtGovtIdName.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Govn Id Name"
        '
        'btnVisitorSearch
        '
        Me.btnVisitorSearch.Location = New System.Drawing.Point(366, 55)
        Me.btnVisitorSearch.Name = "btnVisitorSearch"
        Me.btnVisitorSearch.Size = New System.Drawing.Size(54, 23)
        Me.btnVisitorSearch.TabIndex = 31
        Me.btnVisitorSearch.Text = "Search"
        Me.btnVisitorSearch.UseVisualStyleBackColor = True
        '
        'rdoFGender
        '
        Me.rdoFGender.AutoSize = True
        Me.rdoFGender.Location = New System.Drawing.Point(211, 170)
        Me.rdoFGender.Name = "rdoFGender"
        Me.rdoFGender.Size = New System.Drawing.Size(59, 17)
        Me.rdoFGender.TabIndex = 30
        Me.rdoFGender.TabStop = True
        Me.rdoFGender.Text = "Female"
        Me.rdoFGender.UseVisualStyleBackColor = True
        '
        'rdoMGender
        '
        Me.rdoMGender.AutoSize = True
        Me.rdoMGender.Checked = True
        Me.rdoMGender.Location = New System.Drawing.Point(106, 170)
        Me.rdoMGender.Name = "rdoMGender"
        Me.rdoMGender.Size = New System.Drawing.Size(48, 17)
        Me.rdoMGender.TabIndex = 29
        Me.rdoMGender.TabStop = True
        Me.rdoMGender.Text = "Male"
        Me.rdoMGender.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Gender"
        '
        'txtGovtNo
        '
        Me.txtGovtNo.Location = New System.Drawing.Point(106, 58)
        Me.txtGovtNo.Name = "txtGovtNo"
        Me.txtGovtNo.Size = New System.Drawing.Size(253, 20)
        Me.txtGovtNo.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Id"
        '
        'txtPoneNo
        '
        Me.txtPoneNo.Enabled = False
        Me.txtPoneNo.Location = New System.Drawing.Point(106, 127)
        Me.txtPoneNo.Name = "txtPoneNo"
        Me.txtPoneNo.Size = New System.Drawing.Size(253, 20)
        Me.txtPoneNo.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Phone No"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(106, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(253, 20)
        Me.txtName.TabIndex = 25
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 92)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Name"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(106, 274)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(253, 20)
        Me.txtReason.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Reason"
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(106, 313)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(253, 20)
        Me.txtAction.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Action Taken"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(308, 351)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(71, 23)
        Me.btnOk.TabIndex = 37
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(427, 64)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg.TabIndex = 39
        '
        'BlockVisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 409)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGovtIdName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnVisitorSearch)
        Me.Controls.Add(Me.rdoFGender)
        Me.Controls.Add(Me.rdoMGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGovtNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPoneNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.chkBlock)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BlockVisitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlockVisitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkBlock As System.Windows.Forms.CheckBox
    Friend WithEvents txtGovtIdName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnVisitorSearch As System.Windows.Forms.Button
    Friend WithEvents rdoFGender As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMGender As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGovtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
