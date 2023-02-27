Namespace CustomAlertBoxDemo
	Partial Public Class Form_Alert
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.lblMsg = New System.Windows.Forms.Label()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblMsg
			' 
			Me.lblMsg.AutoSize = True
			Me.lblMsg.ForeColor = System.Drawing.Color.White
			Me.lblMsg.Location = New System.Drawing.Point(65, 22)
			Me.lblMsg.Name = "lblMsg"
			Me.lblMsg.Size = New System.Drawing.Size(116, 21)
			Me.lblMsg.TabIndex = 0
			Me.lblMsg.Text = "Message Text"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = My.Resources.success
			Me.pictureBox1.Location = New System.Drawing.Point(12, 13)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(41, 39)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox1.TabIndex = 2
			Me.pictureBox1.TabStop = False
			' 
			' timer1
			' 
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Image = My.Resources.icons8_cancel_25px
			Me.pictureBox2.Location = New System.Drawing.Point(298, 22)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(26, 30)
			Me.pictureBox2.TabIndex = 3
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.Click += New System.EventHandler(Me.pictureBox2_Click)
			' 
			' Form_Alert
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = System.Drawing.SystemColors.Highlight
			Me.ClientSize = New System.Drawing.Size(347, 74)
			Me.Controls.Add(Me.pictureBox2)
			Me.Controls.Add(Me.pictureBox1)
			Me.Controls.Add(Me.lblMsg)
			Me.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form_Alert"
			Me.Text = "Form_Alert"
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblMsg As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Friend WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
	End Class
End Namespace