<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Searching
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgSearch = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVisitor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFlatNo = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboVisitor = New System.Windows.Forms.ComboBox()
        Me.cboBuildingNo = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboBuildingNo)
        Me.Panel1.Controls.Add(Me.cboVisitor)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.cboFlatNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtVisitor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 254)
        Me.Panel2.TabIndex = 1
        '
        'dgSearch
        '
        Me.dgSearch.AllowUserToAddRows = False
        Me.dgSearch.AllowUserToDeleteRows = False
        Me.dgSearch.AllowUserToOrderColumns = True
        Me.dgSearch.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgSearch.Name = "dgSearch"
        Me.dgSearch.ReadOnly = True
        Me.dgSearch.Size = New System.Drawing.Size(781, 254)
        Me.dgSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visitor"
        '
        'txtVisitor
        '
        Me.txtVisitor.Location = New System.Drawing.Point(151, 13)
        Me.txtVisitor.Name = "txtVisitor"
        Me.txtVisitor.Size = New System.Drawing.Size(99, 20)
        Me.txtVisitor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room No"
        '
        'cboFlatNo
        '
        Me.cboFlatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlatNo.FormattingEnabled = True
        Me.cboFlatNo.Location = New System.Drawing.Point(470, 13)
        Me.cboFlatNo.Name = "cboFlatNo"
        Me.cboFlatNo.Size = New System.Drawing.Size(121, 21)
        Me.cboFlatNo.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(662, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboVisitor
        '
        Me.cboVisitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVisitor.FormattingEnabled = True
        Me.cboVisitor.Location = New System.Drawing.Point(52, 12)
        Me.cboVisitor.Name = "cboVisitor"
        Me.cboVisitor.Size = New System.Drawing.Size(93, 21)
        Me.cboVisitor.TabIndex = 5
        '
        'cboBuildingNo
        '
        Me.cboBuildingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuildingNo.FormattingEnabled = True
        Me.cboBuildingNo.Location = New System.Drawing.Point(367, 13)
        Me.cboBuildingNo.Name = "cboBuildingNo"
        Me.cboBuildingNo.Size = New System.Drawing.Size(97, 21)
        Me.cboBuildingNo.TabIndex = 7
        '
        'Searching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 296)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Searching"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Searching"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgSearch As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboFlatNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVisitor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboVisitor As System.Windows.Forms.ComboBox
    Friend WithEvents cboBuildingNo As System.Windows.Forms.ComboBox
End Class
