<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblRootFolder = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblOracleOrder = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(776, 363)
        Me.DataGridView1.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(725, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 22)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Location = New System.Drawing.Point(722, 512)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(47, 13)
        Me.lblRecords.TabIndex = 31
        Me.lblRecords.Text = "Records"
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Location = New System.Drawing.Point(88, 417)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.Size = New System.Drawing.Size(141, 20)
        Me.txtOrderNum.TabIndex = 32
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Location = New System.Drawing.Point(9, 420)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(73, 13)
        Me.lblOrderNum.TabIndex = 33
        Me.lblOrderNum.Text = "Order Number"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(238, 415)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 22)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(144, 389)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(118, 18)
        Me.lblSelected.TabIndex = 35
        Me.lblSelected.Text = "None Selected"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(502, 415)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(120, 22)
        Me.btnDisplay.TabIndex = 36
        Me.btnDisplay.Text = "Display in Excel"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblRootFolder
        '
        Me.lblRootFolder.AutoSize = True
        Me.lblRootFolder.Location = New System.Drawing.Point(48, 512)
        Me.lblRootFolder.Name = "lblRootFolder"
        Me.lblRootFolder.Size = New System.Drawing.Size(44, 13)
        Me.lblRootFolder.TabIndex = 37
        Me.lblRootFolder.Text = "location"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(1, 512)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(41, 13)
        Me.lblVersion.TabIndex = 38
        Me.lblVersion.Text = "version"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(343, 415)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(120, 22)
        Me.btnSelect.TabIndex = 39
        Me.btnSelect.Text = "Select Order"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblOracleOrder
        '
        Me.lblOracleOrder.AutoSize = True
        Me.lblOracleOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOracleOrder.Location = New System.Drawing.Point(9, 389)
        Me.lblOracleOrder.Name = "lblOracleOrder"
        Me.lblOracleOrder.Size = New System.Drawing.Size(83, 18)
        Me.lblOracleOrder.TabIndex = 40
        Me.lblOracleOrder.Text = "Order No."
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 525)
        Me.Controls.Add(Me.lblOracleOrder)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblRootFolder)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblOrderNum)
        Me.Controls.Add(Me.txtOrderNum)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "mainForm"
        Me.Text = "PROD054 - Spares Cell TIJ Cartridge"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents lblRecords As Label
    Friend WithEvents txtOrderNum As TextBox
    Friend WithEvents lblOrderNum As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSelected As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblRootFolder As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblOracleOrder As Label
End Class
