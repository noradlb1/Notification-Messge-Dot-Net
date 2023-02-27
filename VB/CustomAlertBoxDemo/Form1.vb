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
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub Alert(ByVal msg As String, ByVal type As Form_Alert.enmType)
			Dim frm As New Form_Alert()
			frm.showAlert(msg,type)
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Me.Alert("Success Alert",Form_Alert.enmType.Success)
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Me.Alert("Warning Alert", Form_Alert.enmType.Warning)
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Me.Alert("Error Alert", Form_Alert.enmType.Error)
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Me.Alert("Info Alert", Form_Alert.enmType.Info)
		End Sub
	End Class
End Namespace
