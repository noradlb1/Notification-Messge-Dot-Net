Namespace CustomAlertBoxDemo
	Partial Public Class Form1
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.SeaGreen
			Me.button1.FlatAppearance.BorderSize = 0
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(169, 101)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(204, 58)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Success"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.OrangeRed
			Me.button2.FlatAppearance.BorderSize = 0
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(169, 165)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(204, 58)
			Me.button2.TabIndex = 0
			Me.button2.Text = "Warning"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.Color.DarkRed
			Me.button3.FlatAppearance.BorderSize = 0
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button3.ForeColor = System.Drawing.Color.White
			Me.button3.Location = New System.Drawing.Point(169, 229)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(204, 58)
			Me.button3.TabIndex = 0
			Me.button3.Text = "Error"
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.Color.RoyalBlue
			Me.button4.FlatAppearance.BorderSize = 0
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button4.ForeColor = System.Drawing.Color.White
			Me.button4.Location = New System.Drawing.Point(169, 293)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(204, 58)
			Me.button4.TabIndex = 0
			Me.button4.Text = "info"
			Me.button4.UseVisualStyleBackColor = False
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(180, 35)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(174, 25)
			Me.label1.TabIndex = 1
			Me.label1.Text = "C# Ui Academy"
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.ClientSize = New System.Drawing.Size(555, 413)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

