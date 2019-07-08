<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TKaryawan
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
        Me.tbNik = New System.Windows.Forms.TextBox()
        Me.Tbnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PR = New System.Windows.Forms.RadioButton()
        Me.LK = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BJ = New System.Windows.Forms.RadioButton()
        Me.KW = New System.Windows.Forms.RadioButton()
        Me.tbAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAnak = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTunjangan = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNik
        '
        Me.tbNik.Location = New System.Drawing.Point(136, 70)
        Me.tbNik.Name = "tbNik"
        Me.tbNik.Size = New System.Drawing.Size(91, 20)
        Me.tbNik.TabIndex = 1
        '
        'Tbnama
        '
        Me.Tbnama.Location = New System.Drawing.Point(136, 96)
        Me.Tbnama.Name = "Tbnama"
        Me.Tbnama.Size = New System.Drawing.Size(194, 20)
        Me.Tbnama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PR)
        Me.Panel1.Controls.Add(Me.LK)
        Me.Panel1.Location = New System.Drawing.Point(136, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 23)
        Me.Panel1.TabIndex = 4
        '
        'PR
        '
        Me.PR.AutoSize = True
        Me.PR.Location = New System.Drawing.Point(94, 3)
        Me.PR.Name = "PR"
        Me.PR.Size = New System.Drawing.Size(79, 17)
        Me.PR.TabIndex = 1
        Me.PR.TabStop = True
        Me.PR.Text = "Perempuan"
        Me.PR.UseVisualStyleBackColor = True
        '
        'LK
        '
        Me.LK.AutoSize = True
        Me.LK.Location = New System.Drawing.Point(3, 3)
        Me.LK.Name = "LK"
        Me.LK.Size = New System.Drawing.Size(68, 17)
        Me.LK.TabIndex = 0
        Me.LK.TabStop = True
        Me.LK.Text = "Laki-Laki"
        Me.LK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BJ)
        Me.Panel2.Controls.Add(Me.KW)
        Me.Panel2.Location = New System.Drawing.Point(136, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 23)
        Me.Panel2.TabIndex = 7
        '
        'BJ
        '
        Me.BJ.AutoSize = True
        Me.BJ.Location = New System.Drawing.Point(94, 3)
        Me.BJ.Name = "BJ"
        Me.BJ.Size = New System.Drawing.Size(58, 17)
        Me.BJ.TabIndex = 1
        Me.BJ.TabStop = True
        Me.BJ.Text = "Bujang"
        Me.BJ.UseVisualStyleBackColor = True
        '
        'KW
        '
        Me.KW.AutoSize = True
        Me.KW.Location = New System.Drawing.Point(3, 3)
        Me.KW.Name = "KW"
        Me.KW.Size = New System.Drawing.Size(54, 17)
        Me.KW.TabIndex = 0
        Me.KW.TabStop = True
        Me.KW.Text = "Kawin"
        Me.KW.UseVisualStyleBackColor = True
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(136, 180)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(194, 96)
        Me.tbAlamat.TabIndex = 8
        Me.tbAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alamat"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah Anak"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbAnak
        '
        Me.tbAnak.Location = New System.Drawing.Point(136, 282)
        Me.tbAnak.Name = "tbAnak"
        Me.tbAnak.Size = New System.Drawing.Size(57, 20)
        Me.tbAnak.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gaji Pokok"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(136, 308)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tunjangan Jabatan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbTunjangan
        '
        Me.tbTunjangan.Location = New System.Drawing.Point(136, 335)
        Me.tbTunjangan.Name = "tbTunjangan"
        Me.tbTunjangan.Size = New System.Drawing.Size(131, 20)
        Me.tbTunjangan.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(336, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(432, 393)
        Me.DataGridView1.TabIndex = 17
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(12, 382)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 18
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(93, 382)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 19
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(174, 382)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 20
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(255, 382)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 21
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(318, 58)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Data Karyawan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 419)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbTunjangan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbAnak)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tbnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNik)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(796, 457)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(796, 457)
        Me.Name = "TKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNik As System.Windows.Forms.TextBox
    Friend WithEvents Tbnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PR As System.Windows.Forms.RadioButton
    Friend WithEvents LK As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BJ As System.Windows.Forms.RadioButton
    Friend WithEvents KW As System.Windows.Forms.RadioButton
    Friend WithEvents tbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbAnak As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbTunjangan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
