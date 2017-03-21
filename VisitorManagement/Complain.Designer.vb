<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Complain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboFlatNo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboBuildingNo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSubmit = New System.Windows.Forms.Button()
        Me.chkIssue = New System.Windows.Forms.CheckBox()
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComplain = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboFlatNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboBuildingNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 60)
        Me.Panel1.TabIndex = 0
        '
        'cboFlatNo
        '
        Me.cboFlatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlatNo.FormattingEnabled = True
        Me.cboFlatNo.Location = New System.Drawing.Point(354, 15)
        Me.cboFlatNo.Name = "cboFlatNo"
        Me.cboFlatNo.Size = New System.Drawing.Size(319, 21)
        Me.cboFlatNo.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Flat No"
        '
        'cboBuildingNo
        '
        Me.cboBuildingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuildingNo.FormattingEnabled = True
        Me.cboBuildingNo.Location = New System.Drawing.Point(99, 12)
        Me.cboBuildingNo.Name = "cboBuildingNo"
        Me.cboBuildingNo.Size = New System.Drawing.Size(121, 21)
        Me.cboBuildingNo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Building No"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.txtSubmit)
        Me.Panel2.Controls.Add(Me.chkIssue)
        Me.Panel2.Controls.Add(Me.txtResolution)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtComplain)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 201)
        Me.Panel2.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(736, 122)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 7
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(598, 141)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtSubmit
        '
        Me.txtSubmit.Location = New System.Drawing.Point(509, 141)
        Me.txtSubmit.Name = "txtSubmit"
        Me.txtSubmit.Size = New System.Drawing.Size(75, 23)
        Me.txtSubmit.TabIndex = 5
        Me.txtSubmit.Text = "Submit"
        Me.txtSubmit.UseVisualStyleBackColor = True
        '
        'chkIssue
        '
        Me.chkIssue.AutoSize = True
        Me.chkIssue.Location = New System.Drawing.Point(509, 19)
        Me.chkIssue.Name = "chkIssue"
        Me.chkIssue.Size = New System.Drawing.Size(99, 17)
        Me.chkIssue.TabIndex = 4
        Me.chkIssue.Text = "Issue Resolved"
        Me.chkIssue.UseVisualStyleBackColor = True
        '
        'txtResolution
        '
        Me.txtResolution.Location = New System.Drawing.Point(99, 104)
        Me.txtResolution.Multiline = True
        Me.txtResolution.Name = "txtResolution"
        Me.txtResolution.Size = New System.Drawing.Size(362, 63)
        Me.txtResolution.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solution"
        '
        'txtComplain
        '
        Me.txtComplain.Location = New System.Drawing.Point(99, 19)
        Me.txtComplain.Multiline = True
        Me.txtComplain.Name = "txtComplain"
        Me.txtComplain.Size = New System.Drawing.Size(362, 63)
        Me.txtComplain.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Complain"
        '
        'Complain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Complain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboFlatNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboBuildingNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSubmit As System.Windows.Forms.Button
    Friend WithEvents chkIssue As System.Windows.Forms.CheckBox
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComplain As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
