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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstBIOS = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lstComputer = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lstProcessor = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdService = New System.Windows.Forms.Button()
        Me.CBService = New System.Windows.Forms.ComboBox()
        Me.lstService = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdShare = New System.Windows.Forms.Button()
        Me.CBShare = New System.Windows.Forms.ComboBox()
        Me.lstShare = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lstOS = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(706, 450)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(698, 421)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(692, 415)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'cmdRead
        '
        Me.cmdRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRead.Location = New System.Drawing.Point(510, 364)
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
        Me.CBModel.Size = New System.Drawing.Size(672, 24)
        Me.CBModel.TabIndex = 3
        '
        'lstDrive
        '
        Me.lstDrive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHAName, Me.CHADesc})
        Me.lstDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDrive.Location = New System.Drawing.Point(10, 43)
        Me.lstDrive.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstDrive.Name = "lstDrive"
        Me.lstDrive.Size = New System.Drawing.Size(672, 309)
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
        Me.TabPage2.Size = New System.Drawing.Size(698, 421)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(692, 415)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lstPartition
        '
        Me.lstPartition.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstPartition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPartition.Location = New System.Drawing.Point(10, 43)
        Me.lstPartition.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstPartition.Name = "lstPartition"
        Me.lstPartition.Size = New System.Drawing.Size(672, 309)
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
        Me.CMPName.Size = New System.Drawing.Size(672, 24)
        Me.CMPName.TabIndex = 6
        '
        'cmdPRead
        '
        Me.cmdPRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPRead.Location = New System.Drawing.Point(510, 364)
        Me.cmdPRead.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.cmdPRead.Name = "cmdPRead"
        Me.cmdPRead.Size = New System.Drawing.Size(172, 41)
        Me.cmdPRead.TabIndex = 5
        Me.cmdPRead.Text = "Partitionen einlesen"
        Me.cmdPRead.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstBIOS)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(698, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BIOS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstBIOS
        '
        Me.lstBIOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstBIOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBIOS.Location = New System.Drawing.Point(3, 3)
        Me.lstBIOS.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstBIOS.Name = "lstBIOS"
        Me.lstBIOS.Size = New System.Drawing.Size(692, 415)
        Me.lstBIOS.TabIndex = 8
        Me.lstBIOS.UseCompatibleStateImageBehavior = False
        Me.lstBIOS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attr. Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Attr. Value"
        Me.ColumnHeader4.Width = 400
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstComputer)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(698, 421)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ComputerSystem"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lstComputer
        '
        Me.lstComputer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstComputer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstComputer.Location = New System.Drawing.Point(3, 3)
        Me.lstComputer.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstComputer.Name = "lstComputer"
        Me.lstComputer.Size = New System.Drawing.Size(692, 415)
        Me.lstComputer.TabIndex = 9
        Me.lstComputer.UseCompatibleStateImageBehavior = False
        Me.lstComputer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Attr. Name"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Attr. Value"
        Me.ColumnHeader6.Width = 400
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lstProcessor)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(698, 421)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Processor"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lstProcessor
        '
        Me.lstProcessor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstProcessor.Location = New System.Drawing.Point(3, 3)
        Me.lstProcessor.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstProcessor.Name = "lstProcessor"
        Me.lstProcessor.Size = New System.Drawing.Size(692, 415)
        Me.lstProcessor.TabIndex = 10
        Me.lstProcessor.UseCompatibleStateImageBehavior = False
        Me.lstProcessor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Attr. Name"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Attr. Value"
        Me.ColumnHeader8.Width = 400
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(698, 421)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Service"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cmdService, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.CBService, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lstService, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(692, 415)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'cmdService
        '
        Me.cmdService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdService.Location = New System.Drawing.Point(510, 364)
        Me.cmdService.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.cmdService.Name = "cmdService"
        Me.cmdService.Size = New System.Drawing.Size(172, 41)
        Me.cmdService.TabIndex = 4
        Me.cmdService.Text = "Dienste einlesen"
        Me.cmdService.UseVisualStyleBackColor = True
        '
        'CBService
        '
        Me.CBService.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBService.FormattingEnabled = True
        Me.CBService.Location = New System.Drawing.Point(10, 10)
        Me.CBService.Margin = New System.Windows.Forms.Padding(10)
        Me.CBService.Name = "CBService"
        Me.CBService.Size = New System.Drawing.Size(672, 24)
        Me.CBService.TabIndex = 3
        '
        'lstService
        '
        Me.lstService.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstService.Location = New System.Drawing.Point(10, 43)
        Me.lstService.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstService.Name = "lstService"
        Me.lstService.Size = New System.Drawing.Size(672, 309)
        Me.lstService.TabIndex = 5
        Me.lstService.UseCompatibleStateImageBehavior = False
        Me.lstService.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Attr. Name"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Attr. Value"
        Me.ColumnHeader10.Width = 400
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(698, 421)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Share"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cmdShare, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.CBShare, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lstShare, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(692, 415)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'cmdShare
        '
        Me.cmdShare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShare.Location = New System.Drawing.Point(510, 364)
        Me.cmdShare.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.cmdShare.Name = "cmdShare"
        Me.cmdShare.Size = New System.Drawing.Size(172, 41)
        Me.cmdShare.TabIndex = 4
        Me.cmdShare.Text = "Freigaben einlesen"
        Me.cmdShare.UseVisualStyleBackColor = True
        '
        'CBShare
        '
        Me.CBShare.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBShare.FormattingEnabled = True
        Me.CBShare.Location = New System.Drawing.Point(10, 10)
        Me.CBShare.Margin = New System.Windows.Forms.Padding(10)
        Me.CBShare.Name = "CBShare"
        Me.CBShare.Size = New System.Drawing.Size(672, 24)
        Me.CBShare.TabIndex = 3
        '
        'lstShare
        '
        Me.lstShare.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lstShare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstShare.Location = New System.Drawing.Point(10, 43)
        Me.lstShare.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstShare.Name = "lstShare"
        Me.lstShare.Size = New System.Drawing.Size(672, 309)
        Me.lstShare.TabIndex = 5
        Me.lstShare.UseCompatibleStateImageBehavior = False
        Me.lstShare.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Attr. Name"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Attr. Value"
        Me.ColumnHeader12.Width = 400
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.lstOS)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(698, 421)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "OperatingSystem"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'lstOS
        '
        Me.lstOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lstOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOS.Location = New System.Drawing.Point(3, 3)
        Me.lstOS.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.lstOS.Name = "lstOS"
        Me.lstOS.Size = New System.Drawing.Size(692, 415)
        Me.lstOS.TabIndex = 9
        Me.lstOS.UseCompatibleStateImageBehavior = False
        Me.lstOS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Attr. Name"
        Me.ColumnHeader13.Width = 200
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Attr. Value"
        Me.ColumnHeader14.Width = 400
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Test Classes in CSObjekte"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lstBIOS As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lstComputer As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lstProcessor As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cmdService As Button
    Friend WithEvents CBService As ComboBox
    Friend WithEvents lstService As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cmdShare As Button
    Friend WithEvents CBShare As ComboBox
    Friend WithEvents lstShare As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents lstOS As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
End Class
