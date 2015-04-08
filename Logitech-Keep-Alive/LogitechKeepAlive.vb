Imports Microsoft.VisualBasic.Devices.Audio

Public Class PlaceholderForm
   Shared SOUND_FILE As String = "Resources\nothing.wav"

   Private Sub ReactivateHeadset()
      Dim player As NAudio.Wave.WaveOut
      Dim reader As NAudio.Wave.AudioFileReader

      For i = 0 To NAudio.Wave.WaveOut.DeviceCount - 1
         'Console.WriteLine("Reactivating " & i & " at " & DateTime.Now.ToString("hh:mm:ss"))
         player = New NAudio.Wave.WaveOut()
         reader = New NAudio.Wave.AudioFileReader(SOUND_FILE)

         With player
            .DeviceNumber = i
            .Init(reader)
            .Play()
         End With

         Threading.Thread.Sleep(100)

         player.Stop()

         reader.Dispose()
         player.Dispose()
      Next
   End Sub

   Private Sub LogitechKeepAliveIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles LogitechKeepAliveIcon.MouseClick
      If e.Button = Windows.Forms.MouseButtons.Right Then
         Me.Show()
         Me.Activate()
         Me.Width = 1
         Me.Height = 1
         IconContextMenu.Show(Cursor.Position)
         Me.Left = IconContextMenu.Left + 1
         Me.Top = IconContextMenu.Top + 1
      End If
   End Sub

   Private Sub PlaceholderForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
      Me.Hide()
   End Sub

   Private Sub EnabledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem.Click
      EnabledToolStripMenuItem.Checked = Not EnabledToolStripMenuItem.Checked
      AudioTimer.Enabled = EnabledToolStripMenuItem.Checked
      If EnabledToolStripMenuItem.Checked Then
         ReactivateHeadset()
      End If
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
      Me.Close()
   End Sub

   Private Sub AudioTimer_Tick(sender As Object, e As EventArgs) Handles AudioTimer.Tick
      ReactivateHeadset()
   End Sub

   Private Sub PlaceholderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ReactivateHeadset()
   End Sub
End Class
