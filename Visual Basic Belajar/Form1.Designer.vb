<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnHitung = New Button()
        txtTugas1 = New TextBox()
        txtTugas2 = New TextBox()
        txtTugas3 = New TextBox()
        txtTugas4 = New TextBox()
        txtTugas5 = New TextBox()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        lblRataTugas = New Label()
        lblNilaiAkhir = New Label()
        lblKategoriFuzzy = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        pnlChart = New Panel()
        lblPctA = New Label()
        lblPctB = New Label()
        lblPctC = New Label()
        lblKesimpulan = New Label()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(20, 172)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(180, 35)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung Nilai & Logika Fuzzy"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtTugas1
        ' 
        txtTugas1.Location = New Point(20, 45)
        txtTugas1.Name = "txtTugas1"
        txtTugas1.Size = New Size(100, 27)
        txtTugas1.TabIndex = 1
        txtTugas1.Text = "0"
        ' 
        ' txtTugas2
        ' 
        txtTugas2.Location = New Point(130, 45)
        txtTugas2.Name = "txtTugas2"
        txtTugas2.Size = New Size(100, 27)
        txtTugas2.TabIndex = 2
        txtTugas2.Text = "0"
        ' 
        ' txtTugas3
        ' 
        txtTugas3.Location = New Point(240, 45)
        txtTugas3.Name = "txtTugas3"
        txtTugas3.Size = New Size(100, 27)
        txtTugas3.TabIndex = 4
        txtTugas3.Text = "0"
        ' 
        ' txtTugas4
        ' 
        txtTugas4.Location = New Point(350, 45)
        txtTugas4.Name = "txtTugas4"
        txtTugas4.Size = New Size(100, 27)
        txtTugas4.TabIndex = 3
        txtTugas4.Text = "0"
        ' 
        ' txtTugas5
        ' 
        txtTugas5.Location = New Point(460, 45)
        txtTugas5.Name = "txtTugas5"
        txtTugas5.Size = New Size(100, 27)
        txtTugas5.TabIndex = 5
        txtTugas5.Text = "0"
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(20, 115)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(120, 27)
        txtUTS.TabIndex = 7
        txtUTS.Text = "0"
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(160, 115)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(120, 27)
        txtUAS.TabIndex = 6
        txtUAS.Text = "0"
        ' 
        ' lblRataTugas
        ' 
        lblRataTugas.AutoSize = True
        lblRataTugas.Location = New Point(20, 260)
        lblRataTugas.Name = "lblRataTugas"
        lblRataTugas.Size = New Size(127, 20)
        lblRataTugas.TabIndex = 8
        lblRataTugas.Text = "Rata-rata Tugas: -"
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(20, 290)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(169, 20)
        lblNilaiAkhir.TabIndex = 9
        lblNilaiAkhir.Text = "Nilai Akhir (Weighted): -"
        ' 
        ' lblKategoriFuzzy
        ' 
        lblKategoriFuzzy.AutoSize = True
        lblKategoriFuzzy.Location = New Point(20, 320)
        lblKategoriFuzzy.Name = "lblKategoriFuzzy"
        lblKategoriFuzzy.Size = New Size(119, 20)
        lblKategoriFuzzy.TabIndex = 10
        lblKategoriFuzzy.Text = "Kategori Fuzzy: -"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 20)
        Label1.TabIndex = 11
        Label1.Text = "Input Nilai Tugas:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 12
        Label2.Text = "Input Nilai UTS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(160, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 13
        Label3.Text = "Input Nilai UAS:"
        ' 
        ' pnlChart
        ' 
        pnlChart.BorderStyle = BorderStyle.FixedSingle
        pnlChart.Location = New Point(450, 100)
        pnlChart.Name = "pnlChart"
        pnlChart.Size = New Size(320, 180)
        pnlChart.TabIndex = 14
        ' 
        ' lblPctA
        ' 
        lblPctA.AutoSize = True
        lblPctA.Location = New Point(450, 290)
        lblPctA.Name = "lblPctA"
        lblPctA.Size = New Size(48, 20)
        lblPctA.TabIndex = 15
        lblPctA.Text = "A: - %"
        ' 
        ' lblPctB
        ' 
        lblPctB.AutoSize = True
        lblPctB.Location = New Point(450, 320)
        lblPctB.Name = "lblPctB"
        lblPctB.Size = New Size(47, 20)
        lblPctB.TabIndex = 16
        lblPctB.Text = "B: - %"
        ' 
        ' lblPctC
        ' 
        lblPctC.AutoSize = True
        lblPctC.Location = New Point(450, 350)
        lblPctC.Name = "lblPctC"
        lblPctC.Size = New Size(47, 20)
        lblPctC.TabIndex = 17
        lblPctC.Text = "C: - %"
        ' 
        ' lblKesimpulan
        ' 
        lblKesimpulan.AutoSize = True
        lblKesimpulan.Location = New Point(25, 410)
        lblKesimpulan.Name = "lblKesimpulan"
        lblKesimpulan.Size = New Size(137, 20)
        lblKesimpulan.TabIndex = 18
        lblKesimpulan.Text = "Kesimpulan Akhir: -"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblKategoriFuzzy)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(lblRataTugas)
        Controls.Add(txtUTS)
        Controls.Add(txtUAS)
        Controls.Add(txtTugas5)
        Controls.Add(txtTugas3)
        Controls.Add(txtTugas4)
        Controls.Add(txtTugas2)
        Controls.Add(txtTugas1)
        Controls.Add(btnHitung)
        Controls.Add(pnlChart)
        Controls.Add(lblPctA)
        Controls.Add(lblPctB)
        Controls.Add(lblPctC)
        Controls.Add(lblKesimpulan)
        Name = "Form1"
        Text = "DSS - Penilaian Logika Fuzzy"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents txtTugas1 As TextBox
    Friend WithEvents txtTugas2 As TextBox
    Friend WithEvents txtTugas3 As TextBox
    Friend WithEvents txtTugas4 As TextBox
    Friend WithEvents txtTugas5 As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents lblRataTugas As Label
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents lblKategoriFuzzy As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend pnlChart As Panel
    Friend lblPctA As Label
    Friend lblPctB As Label
    Friend lblPctC As Label
    Friend lblKesimpulan As Label

End Class