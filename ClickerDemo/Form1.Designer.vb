<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Clicks"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(41, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Interval (ms)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(178, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(76, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Click!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(240, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Timer2
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotkeysToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.InfoToolStripMenuItem.Text = "File"
        '
        'HotkeysToolStripMenuItem
        '
        Me.HotkeysToolStripMenuItem.Name = "HotkeysToolStripMenuItem"
        Me.HotkeysToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HotkeysToolStripMenuItem.Text = "Hotkeys"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 247)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Clicker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotkeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
