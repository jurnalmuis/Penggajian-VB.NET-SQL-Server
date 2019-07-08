<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengguna
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idPengguna = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namaPengguna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.leveluser = New System.Windows.Forms.ComboBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pengguna"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idPengguna
        '
        Me.idPengguna.Location = New System.Drawing.Point(110, 57)
        Me.idPengguna.Name = "idPengguna"
        Me.idPengguna.Size = New System.Drawing.Size(63, 20)
        Me.idPengguna.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Pengguna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'namaPengguna
        '
        Me.namaPengguna.Location = New System.Drawing.Point(110, 83)
        Me.namaPengguna.Name = "namaPengguna"
        Me.namaPengguna.Size = New System.Drawing.Size(117, 20)
        Me.namaPengguna.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(110, 136)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(117, 20)
        Me.password.TabIndex = 7
        '
        'leveluser
        '
        Me.leveluser.FormattingEnabled = True
        Me.leveluser.Location = New System.Drawing.Point(110, 109)
        Me.leveluser.Name = "leveluser"
        Me.leveluser.Size = New System.Drawing.Size(117, 21)
        Me.leveluser.TabIndex = 9
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(17, 174)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 10
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(98, 174)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(75, 23)
        Me.btHapus.TabIndex = 11
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Location = New System.Drawing.Point(179, 174)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(75, 23)
        Me.btBatal.TabIndex = 12
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(260, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Pengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 227)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.leveluser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.namaPengguna)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idPengguna)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(385, 265)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(385, 265)
        Me.Name = "Pengguna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Pengguna"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idPengguna As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents namaPengguna As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents leveluser As System.Windows.Forms.ComboBox
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
