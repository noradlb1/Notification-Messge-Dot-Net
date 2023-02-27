Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomAlertBoxDemo
	Partial Public Class Form_Alert
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Enum enmAction
			wait
			start
			close
		End Enum

		Public Enum enmType
			Success
			Warning
			[Error]
			Info
		End Enum
		Private action As Form_Alert.enmAction

		Private x, y As Integer

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Select Case Me.action
				Case enmAction.wait
					timer1.Interval = 5000
					action = enmAction.close
				Case Form_Alert.enmAction.start
					Me.timer1.Interval = 1
					Me.Opacity += 0.1
					If Me.x < Me.Location.X Then
						Me.Left -= 1
					Else
						If Me.Opacity = 1.0 Then
							action = Form_Alert.enmAction.wait
						End If
					End If
				Case enmAction.close
					timer1.Interval = 1
					Me.Opacity -= 0.1

					Me.Left -= 3
					If MyBase.Opacity = 0.0 Then
						MyBase.Close()
					End If
			End Select
		End Sub

		Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.Click
			timer1.Interval = 1
			action = enmAction.close
		End Sub

		Public Sub showAlert(ByVal msg As String, ByVal type As enmType)
			Me.Opacity = 0.0
			Me.StartPosition = FormStartPosition.Manual
			Dim fname As String

			For i As Integer = 1 To 9
				fname = "alert" & i.ToString()
				Dim frm As Form_Alert = DirectCast(Application.OpenForms(fname), Form_Alert)

				If frm Is Nothing Then
					Me.Name = fname
					Me.x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
					Me.y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
					Me.Location = New Point(Me.x, Me.y)
					Exit For

				End If

			Next i
			Me.x = Screen.PrimaryScreen.WorkingArea.Width - MyBase.Width - 5

			Select Case type
				Case enmType.Success
					Me.pictureBox1.Image = My.Resources.success
					Me.BackColor = Color.SeaGreen
				Case enmType.Error
					Me.pictureBox1.Image = My.Resources.error
					Me.BackColor = Color.DarkRed
				Case enmType.Info
					Me.pictureBox1.Image = My.Resources.info
					Me.BackColor = Color.RoyalBlue
				Case enmType.Warning
					Me.pictureBox1.Image = My.Resources.warning
					Me.BackColor = Color.DarkOrange
			End Select


			Me.lblMsg.Text = msg

			Me.Show()
			Me.action = enmAction.start
			Me.timer1.Interval = 1
			Me.timer1.Start()
		End Sub
	End Class
End Namespace
