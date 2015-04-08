<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceholderForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceholderForm))
      Me.LogitechKeepAliveIcon = New System.Windows.Forms.NotifyIcon(Me.components)
      Me.AudioTimer = New System.Windows.Forms.Timer(Me.components)
      Me.IconContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.IconContextMenu.SuspendLayout()
      Me.SuspendLayout()
      '
      'LogitechKeepAliveIcon
      '
      Me.LogitechKeepAliveIcon.Icon = CType(resources.GetObject("LogitechKeepAliveIcon.Icon"), System.Drawing.Icon)
      Me.LogitechKeepAliveIcon.Text = "Logitech Headset Keep-Alive"
      Me.LogitechKeepAliveIcon.Visible = True
      '
      'AudioTimer
      '
      Me.AudioTimer.Enabled = True
      Me.AudioTimer.Interval = 300000
      '
      'IconContextMenu
      '
      Me.IconContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.IconContextMenu.Name = "IconContextMenu"
      Me.IconContextMenu.Size = New System.Drawing.Size(133, 52)
      Me.IconContextMenu.Text = "asdf"
      '
      'EnabledToolStripMenuItem
      '
      Me.EnabledToolStripMenuItem.Checked = True
      Me.EnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
      Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
      Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
      Me.EnabledToolStripMenuItem.Text = "Enabled"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
      Me.ExitToolStripMenuItem.Text = "Exit"
      '
      'PlaceholderForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(501, 493)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "PlaceholderForm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
      Me.Text = "Logitech Keep-Alive"
      Me.TopMost = True
      Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
      Me.IconContextMenu.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents LogitechKeepAliveIcon As System.Windows.Forms.NotifyIcon
   Friend WithEvents AudioTimer As System.Windows.Forms.Timer
   Friend WithEvents IconContextMenu As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents EnabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
