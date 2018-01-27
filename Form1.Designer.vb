<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.lblTDate = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Location = New System.Drawing.Point(12, 29)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(25, 13)
        Me.Lable1.TabIndex = 0
        Me.Lable1.Text = "Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "value"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(13, 59)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 20)
        Me.txtKey.TabIndex = 2
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(137, 58)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(37, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(137, 116)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(67, 190)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(100, 20)
        Me.txtShow.TabIndex = 6
        '
        'lblTDate
        '
        Me.lblTDate.AutoSize = True
        Me.lblTDate.Location = New System.Drawing.Point(15, 236)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size(0, 13)
        Me.lblTDate.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblTDate)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lable1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lable1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtShow As TextBox
    Friend WithEvents lblTDate As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
