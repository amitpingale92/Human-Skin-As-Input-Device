<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.lblV1 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.cmbCOM = New System.Windows.Forms.ComboBox
        Me.Port = New AxMSCommLib.AxMSComm
        Me.Chart = New AxMSChart20Lib.AxMSChart
        Me.lblV2 = New System.Windows.Forms.Label
        Me.lblV3 = New System.Windows.Forms.Label
        Me.lblV4 = New System.Windows.Forms.Label
        Me.lblV5 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtCMD = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblV8 = New System.Windows.Forms.Label
        Me.lblV7 = New System.Windows.Forms.Label
        Me.lblV6 = New System.Windows.Forms.Label
        Me.btnRef = New System.Windows.Forms.Button
        Me.lblR8 = New System.Windows.Forms.Label
        Me.lblR7 = New System.Windows.Forms.Label
        Me.lblR6 = New System.Windows.Forms.Label
        Me.lblR5 = New System.Windows.Forms.Label
        Me.lblR4 = New System.Windows.Forms.Label
        Me.lblR3 = New System.Windows.Forms.Label
        Me.lblR2 = New System.Windows.Forms.Label
        Me.lblR1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDelta = New System.Windows.Forms.TextBox
        Me.lblL8 = New System.Windows.Forms.Label
        Me.lblL7 = New System.Windows.Forms.Label
        Me.lblL6 = New System.Windows.Forms.Label
        Me.lblL5 = New System.Windows.Forms.Label
        Me.lblL4 = New System.Windows.Forms.Label
        Me.lblL3 = New System.Windows.Forms.Label
        Me.lblL2 = New System.Windows.Forms.Label
        Me.lblL1 = New System.Windows.Forms.Label
        Me.txtSysMsg = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.chkEnable = New System.Windows.Forms.CheckBox
        Me.txtCMDs = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkLearn = New System.Windows.Forms.CheckBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 661)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(754, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(622, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 51)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Query ALL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(736, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 49)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Bill Pay"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem3.Text = "&Help"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem4.Text = "&About ..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem5.Text = "File"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripMenuItem6.Text = "Exit"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem7.Text = "&Help"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem8.Text = "&About ..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(754, 25)
        Me.ToolStrip.TabIndex = 45
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'lblV1
        '
        Me.lblV1.AutoSize = True
        Me.lblV1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV1.Location = New System.Drawing.Point(6, 59)
        Me.lblV1.Name = "lblV1"
        Me.lblV1.Size = New System.Drawing.Size(62, 31)
        Me.lblV1.TabIndex = 109
        Me.lblV1.Text = "000"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(162, 0)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(386, 49)
        Me.btnConnect.TabIndex = 133
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cmbCOM
        '
        Me.cmbCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCOM.FormattingEnabled = True
        Me.cmbCOM.Location = New System.Drawing.Point(12, 12)
        Me.cmbCOM.Name = "cmbCOM"
        Me.cmbCOM.Size = New System.Drawing.Size(144, 24)
        Me.cmbCOM.TabIndex = 132
        Me.cmbCOM.Text = "Select COM Port"
        '
        'Port
        '
        Me.Port.Enabled = True
        Me.Port.Location = New System.Drawing.Point(101, 3)
        Me.Port.Name = "Port"
        Me.Port.OcxState = CType(resources.GetObject("Port.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Port.Size = New System.Drawing.Size(38, 38)
        Me.Port.TabIndex = 131
        '
        'Chart
        '
        'Me.Chart.DataSource = Nothing
        Me.Chart.Location = New System.Drawing.Point(12, 93)
        Me.Chart.Name = "Chart"
        Me.Chart.OcxState = CType(resources.GetObject("Chart.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Chart.Size = New System.Drawing.Size(536, 387)
        Me.Chart.TabIndex = 137
        '
        'lblV2
        '
        Me.lblV2.AutoSize = True
        Me.lblV2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV2.Location = New System.Drawing.Point(77, 59)
        Me.lblV2.Name = "lblV2"
        Me.lblV2.Size = New System.Drawing.Size(62, 31)
        Me.lblV2.TabIndex = 139
        Me.lblV2.Text = "000"
        '
        'lblV3
        '
        Me.lblV3.AutoSize = True
        Me.lblV3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV3.Location = New System.Drawing.Point(145, 59)
        Me.lblV3.Name = "lblV3"
        Me.lblV3.Size = New System.Drawing.Size(62, 31)
        Me.lblV3.TabIndex = 140
        Me.lblV3.Text = "000"
        '
        'lblV4
        '
        Me.lblV4.AutoSize = True
        Me.lblV4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV4.Location = New System.Drawing.Point(213, 59)
        Me.lblV4.Name = "lblV4"
        Me.lblV4.Size = New System.Drawing.Size(62, 31)
        Me.lblV4.TabIndex = 141
        Me.lblV4.Text = "000"
        '
        'lblV5
        '
        Me.lblV5.AutoSize = True
        Me.lblV5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV5.Location = New System.Drawing.Point(281, 59)
        Me.lblV5.Name = "lblV5"
        Me.lblV5.Size = New System.Drawing.Size(62, 31)
        Me.lblV5.TabIndex = 142
        Me.lblV5.Text = "000"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(554, 586)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 49)
        Me.btnSave.TabIndex = 144
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCMD
        '
        Me.txtCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMD.Location = New System.Drawing.Point(560, 542)
        Me.txtCMD.Name = "txtCMD"
        Me.txtCMD.Size = New System.Drawing.Size(180, 29)
        Me.txtCMD.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(554, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 31)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Name:"
        '
        'lblV8
        '
        Me.lblV8.AutoSize = True
        Me.lblV8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV8.Location = New System.Drawing.Point(486, 59)
        Me.lblV8.Name = "lblV8"
        Me.lblV8.Size = New System.Drawing.Size(62, 31)
        Me.lblV8.TabIndex = 149
        Me.lblV8.Text = "000"
        '
        'lblV7
        '
        Me.lblV7.AutoSize = True
        Me.lblV7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV7.Location = New System.Drawing.Point(418, 59)
        Me.lblV7.Name = "lblV7"
        Me.lblV7.Size = New System.Drawing.Size(62, 31)
        Me.lblV7.TabIndex = 148
        Me.lblV7.Text = "000"
        '
        'lblV6
        '
        Me.lblV6.AutoSize = True
        Me.lblV6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblV6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblV6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblV6.Location = New System.Drawing.Point(350, 59)
        Me.lblV6.Name = "lblV6"
        Me.lblV6.Size = New System.Drawing.Size(62, 31)
        Me.lblV6.TabIndex = 147
        Me.lblV6.Text = "000"
        '
        'btnRef
        '
        Me.btnRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.Location = New System.Drawing.Point(12, 486)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(536, 49)
        Me.btnRef.TabIndex = 151
        Me.btnRef.Text = "Set Reference"
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'lblR8
        '
        Me.lblR8.AutoSize = True
        Me.lblR8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR8.Location = New System.Drawing.Point(486, 538)
        Me.lblR8.Name = "lblR8"
        Me.lblR8.Size = New System.Drawing.Size(62, 31)
        Me.lblR8.TabIndex = 159
        Me.lblR8.Text = "000"
        '
        'lblR7
        '
        Me.lblR7.AutoSize = True
        Me.lblR7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR7.Location = New System.Drawing.Point(418, 538)
        Me.lblR7.Name = "lblR7"
        Me.lblR7.Size = New System.Drawing.Size(62, 31)
        Me.lblR7.TabIndex = 158
        Me.lblR7.Text = "000"
        '
        'lblR6
        '
        Me.lblR6.AutoSize = True
        Me.lblR6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR6.Location = New System.Drawing.Point(350, 538)
        Me.lblR6.Name = "lblR6"
        Me.lblR6.Size = New System.Drawing.Size(62, 31)
        Me.lblR6.TabIndex = 157
        Me.lblR6.Text = "000"
        '
        'lblR5
        '
        Me.lblR5.AutoSize = True
        Me.lblR5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR5.Location = New System.Drawing.Point(281, 538)
        Me.lblR5.Name = "lblR5"
        Me.lblR5.Size = New System.Drawing.Size(62, 31)
        Me.lblR5.TabIndex = 156
        Me.lblR5.Text = "000"
        '
        'lblR4
        '
        Me.lblR4.AutoSize = True
        Me.lblR4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR4.Location = New System.Drawing.Point(213, 538)
        Me.lblR4.Name = "lblR4"
        Me.lblR4.Size = New System.Drawing.Size(62, 31)
        Me.lblR4.TabIndex = 155
        Me.lblR4.Text = "000"
        '
        'lblR3
        '
        Me.lblR3.AutoSize = True
        Me.lblR3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR3.Location = New System.Drawing.Point(145, 538)
        Me.lblR3.Name = "lblR3"
        Me.lblR3.Size = New System.Drawing.Size(62, 31)
        Me.lblR3.TabIndex = 154
        Me.lblR3.Text = "000"
        '
        'lblR2
        '
        Me.lblR2.AutoSize = True
        Me.lblR2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR2.Location = New System.Drawing.Point(77, 538)
        Me.lblR2.Name = "lblR2"
        Me.lblR2.Size = New System.Drawing.Size(62, 31)
        Me.lblR2.TabIndex = 153
        Me.lblR2.Text = "000"
        '
        'lblR1
        '
        Me.lblR1.AutoSize = True
        Me.lblR1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblR1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblR1.Location = New System.Drawing.Point(6, 538)
        Me.lblR1.Name = "lblR1"
        Me.lblR1.Size = New System.Drawing.Size(62, 31)
        Me.lblR1.TabIndex = 152
        Me.lblR1.Text = "000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(7, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Enter Delta Trigger:"
        '
        'txtDelta
        '
        Me.txtDelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelta.Location = New System.Drawing.Point(237, 572)
        Me.txtDelta.Name = "txtDelta"
        Me.txtDelta.Size = New System.Drawing.Size(63, 29)
        Me.txtDelta.TabIndex = 160
        Me.txtDelta.Text = "25"
        '
        'lblL8
        '
        Me.lblL8.AutoSize = True
        Me.lblL8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL8.Location = New System.Drawing.Point(486, 604)
        Me.lblL8.Name = "lblL8"
        Me.lblL8.Size = New System.Drawing.Size(62, 31)
        Me.lblL8.TabIndex = 169
        Me.lblL8.Text = "000"
        '
        'lblL7
        '
        Me.lblL7.AutoSize = True
        Me.lblL7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL7.Location = New System.Drawing.Point(418, 604)
        Me.lblL7.Name = "lblL7"
        Me.lblL7.Size = New System.Drawing.Size(62, 31)
        Me.lblL7.TabIndex = 168
        Me.lblL7.Text = "000"
        '
        'lblL6
        '
        Me.lblL6.AutoSize = True
        Me.lblL6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL6.Location = New System.Drawing.Point(350, 604)
        Me.lblL6.Name = "lblL6"
        Me.lblL6.Size = New System.Drawing.Size(62, 31)
        Me.lblL6.TabIndex = 167
        Me.lblL6.Text = "000"
        '
        'lblL5
        '
        Me.lblL5.AutoSize = True
        Me.lblL5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL5.Location = New System.Drawing.Point(281, 604)
        Me.lblL5.Name = "lblL5"
        Me.lblL5.Size = New System.Drawing.Size(62, 31)
        Me.lblL5.TabIndex = 166
        Me.lblL5.Text = "000"
        '
        'lblL4
        '
        Me.lblL4.AutoSize = True
        Me.lblL4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL4.Location = New System.Drawing.Point(213, 604)
        Me.lblL4.Name = "lblL4"
        Me.lblL4.Size = New System.Drawing.Size(62, 31)
        Me.lblL4.TabIndex = 165
        Me.lblL4.Text = "000"
        '
        'lblL3
        '
        Me.lblL3.AutoSize = True
        Me.lblL3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL3.Location = New System.Drawing.Point(145, 604)
        Me.lblL3.Name = "lblL3"
        Me.lblL3.Size = New System.Drawing.Size(62, 31)
        Me.lblL3.TabIndex = 164
        Me.lblL3.Text = "000"
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL2.Location = New System.Drawing.Point(77, 604)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(62, 31)
        Me.lblL2.TabIndex = 163
        Me.lblL2.Text = "000"
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblL1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblL1.Location = New System.Drawing.Point(6, 604)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(62, 31)
        Me.lblL1.TabIndex = 162
        Me.lblL1.Text = "000"
        '
        'txtSysMsg
        '
        Me.txtSysMsg.BackColor = System.Drawing.Color.DimGray
        Me.txtSysMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysMsg.ForeColor = System.Drawing.SystemColors.Info
        Me.txtSysMsg.Location = New System.Drawing.Point(554, 147)
        Me.txtSysMsg.Multiline = True
        Me.txtSysMsg.Name = "txtSysMsg"
        Me.txtSysMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSysMsg.Size = New System.Drawing.Size(186, 143)
        Me.txtSysMsg.TabIndex = 172
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(554, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "System Messages:"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(554, 1)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(186, 48)
        Me.btnShow.TabIndex = 173
        Me.btnShow.Text = "Show Stored Commands"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'chkEnable
        '
        Me.chkEnable.AutoSize = True
        Me.chkEnable.BackColor = System.Drawing.Color.Transparent
        Me.chkEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnable.Location = New System.Drawing.Point(560, 93)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(95, 28)
        Me.chkEnable.TabIndex = 184
        Me.chkEnable.Text = "Enable"
        Me.chkEnable.UseVisualStyleBackColor = False
        '
        'txtCMDs
        '
        Me.txtCMDs.BackColor = System.Drawing.Color.DimGray
        Me.txtCMDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMDs.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCMDs.Location = New System.Drawing.Point(554, 337)
        Me.txtCMDs.Multiline = True
        Me.txtCMDs.Name = "txtCMDs"
        Me.txtCMDs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCMDs.Size = New System.Drawing.Size(186, 143)
        Me.txtCMDs.TabIndex = 187
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(554, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "CMDs:"
        '
        'Timer1
        '
        '
        'chkLearn
        '
        Me.chkLearn.AutoSize = True
        Me.chkLearn.BackColor = System.Drawing.Color.Transparent
        Me.chkLearn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLearn.Location = New System.Drawing.Point(558, 59)
        Me.chkLearn.Name = "chkLearn"
        Me.chkLearn.Size = New System.Drawing.Size(111, 28)
        Me.chkLearn.TabIndex = 189
        Me.chkLearn.Text = "Learning"
        Me.chkLearn.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 683)
        Me.Controls.Add(Me.chkLearn)
        Me.Controls.Add(Me.txtCMDs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkEnable)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtSysMsg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblL8)
        Me.Controls.Add(Me.lblL7)
        Me.Controls.Add(Me.lblL6)
        Me.Controls.Add(Me.lblL5)
        Me.Controls.Add(Me.lblL4)
        Me.Controls.Add(Me.lblL3)
        Me.Controls.Add(Me.lblL2)
        Me.Controls.Add(Me.lblL1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDelta)
        Me.Controls.Add(Me.lblR8)
        Me.Controls.Add(Me.lblR7)
        Me.Controls.Add(Me.lblR6)
        Me.Controls.Add(Me.lblR5)
        Me.Controls.Add(Me.lblR4)
        Me.Controls.Add(Me.lblR3)
        Me.Controls.Add(Me.lblR2)
        Me.Controls.Add(Me.lblR1)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.lblV8)
        Me.Controls.Add(Me.lblV7)
        Me.Controls.Add(Me.lblV6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCMD)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblV5)
        Me.Controls.Add(Me.lblV4)
        Me.Controls.Add(Me.lblV3)
        Me.Controls.Add(Me.lblV2)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblV1)
        Me.Controls.Add(Me.cmbCOM)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Online Realtime Monitoring"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblV1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cmbCOM As System.Windows.Forms.ComboBox
    Public WithEvents Port As AxMSCommLib.AxMSComm
    Public WithEvents Chart As AxMSChart20Lib.AxMSChart
    Friend WithEvents lblV2 As System.Windows.Forms.Label
    Friend WithEvents lblV3 As System.Windows.Forms.Label
    Friend WithEvents lblV4 As System.Windows.Forms.Label
    Friend WithEvents lblV5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCMD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblV8 As System.Windows.Forms.Label
    Friend WithEvents lblV7 As System.Windows.Forms.Label
    Friend WithEvents lblV6 As System.Windows.Forms.Label
    Friend WithEvents btnRef As System.Windows.Forms.Button
    Friend WithEvents lblR8 As System.Windows.Forms.Label
    Friend WithEvents lblR7 As System.Windows.Forms.Label
    Friend WithEvents lblR6 As System.Windows.Forms.Label
    Friend WithEvents lblR5 As System.Windows.Forms.Label
    Friend WithEvents lblR4 As System.Windows.Forms.Label
    Friend WithEvents lblR3 As System.Windows.Forms.Label
    Friend WithEvents lblR2 As System.Windows.Forms.Label
    Friend WithEvents lblR1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDelta As System.Windows.Forms.TextBox
    Friend WithEvents lblL8 As System.Windows.Forms.Label
    Friend WithEvents lblL7 As System.Windows.Forms.Label
    Friend WithEvents lblL6 As System.Windows.Forms.Label
    Friend WithEvents lblL5 As System.Windows.Forms.Label
    Friend WithEvents lblL4 As System.Windows.Forms.Label
    Friend WithEvents lblL3 As System.Windows.Forms.Label
    Friend WithEvents lblL2 As System.Windows.Forms.Label
    Friend WithEvents lblL1 As System.Windows.Forms.Label
    Friend WithEvents txtSysMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents chkEnable As System.Windows.Forms.CheckBox
    Friend WithEvents txtCMDs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkLearn As System.Windows.Forms.CheckBox

End Class
