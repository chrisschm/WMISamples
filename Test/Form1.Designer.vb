<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.lstDrive = New System.Windows.Forms.ListView()
        Me.CHAName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHADesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstPartition = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMPName = New System.Windows.Forms.ComboBox()
        Me.cmdPRead = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 450)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(645, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DiskDrive"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdRead, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CBModel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstDrive, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(639, 415)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'cmdRead
        '
        Me.cmdRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRead.Location = New System.Drawing.Point(457, 364)
        Me.cmdRead.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(172, 41)
        Me.cmdRead.TabIndex = 4
        Me.cmdRead.Text = "Laufwerke einlesen"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'CBModel
        '
        Me.CBModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(10, 10)
        Me.CBModel.Margin = New System.Windows.Forms.Padding(10)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(619, 24)
        Me.CBModel.TabIndex = 3
        '
        'lstDrive
        '
        Me.lstDrive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHAName, Me.CHADesc})
        Me.lstDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDrive.Location = New System.Drawing.Point(10, 43)
        Me.lstDrive.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstDrive.Name = "lstDrive"
        Me.lstDrive.Size = New System.Drawing.Size(619, 309)
        Me.lstDrive.TabIndex = 5
        Me.lstDrive.UseCompatibleStateImageBehavior = False
        Me.lstDrive.View = System.Windows.Forms.View.Details
        '
        'CHAName
        '
        Me.CHAName.Text = "Attr. Name"
        Me.CHAName.Width = 200
        '
        'CHADesc
        '
        Me.CHADesc.Text = "Attr. Value"
        Me.CHADesc.Width = 400
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(645, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DiskPartition"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lstPartition, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CMPName, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdPRead, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(639, 415)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lstPartition
        '
        Me.lstPartition.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstPartition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPartition.Location = New System.Drawing.Point(10, 43)
        Me.lstPartition.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstPartition.Name = "lstPartition"
        Me.lstPartition.Size = New System.Drawing.Size(619, 309)
        Me.lstPartition.TabIndex = 7
        Me.lstPartition.UseCompatibleStateImageBehavior = False
        Me.lstPartition.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Attr. Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Attr. Value"
        Me.ColumnHeader2.Width = 400
        '
        'CMPName
        '
        Me.CMPName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMPName.FormattingEnabled = True
        Me.CMPName.Location = New System.Drawing.Point(10, 10)
        Me.CMPName.Margin = New System.Windows.Forms.Padding(10)
        Me.CMPName.Name = "CMPName"
        Me.CMPName.Size = New System.Drawing.Size(619, 24)
        Me.CMPName.TabIndex = 6
        '
        'cmdPRead
        '
        Me.cmdPRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPRead.Location = New System.Drawing.Point(457, 364)
        Me.cmdPRead.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.cmdPRead.Name = "cmdPRead"
        Me.cmdPRead.Size = New System.Drawing.Size(172, 41)
        Me.cmdPRead.TabIndex = 5
        Me.cmdPRead.Text = "Partitionen einlesen"
        Me.cmdPRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdRead As Button
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstDrive As ListView
    Friend WithEvents CHAName As ColumnHeader
    Friend WithEvents CHADesc As ColumnHeader
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lstPartition As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents CMPName As ComboBox
    Friend WithEvents cmdPRead As Button
End Class
