Public Class Form1

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' 1. Validasi & Parsing Input
        Dim nT1, nT2, nT3, nT4, nT5, nUTS, nUAS As Double

        If Not (Double.TryParse(txtTugas1.Text, nT1) AndAlso
                Double.TryParse(txtTugas2.Text, nT2) AndAlso
                Double.TryParse(txtTugas3.Text, nT3) AndAlso
                Double.TryParse(txtTugas4.Text, nT4) AndAlso
                Double.TryParse(txtTugas5.Text, nT5) AndAlso
                Double.TryParse(txtUTS.Text, nUTS) AndAlso
                Double.TryParse(txtUAS.Text, nUAS)) Then

            MessageBox.Show("Harap masukkan nilai berupa angka yang valid!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Hitung Rata-Rata Tugas
        Dim avgTugas As Double = (nT1 + nT2 + nT3 + nT4 + nT5) / 5.0

        ' 3. Hitung Hasil Pembobotan Nilai Akhir
        ' Tugas: 50%, UTS: 20%, UAS: 30%
        Dim nilaiAkhir As Double = (avgTugas * 0.5) + (nUTS * 0.2) + (nUAS * 0.3)

        ' 4. Evaluasi Logika Fuzzy
        Dim kategori As String = EvaluasiFuzzyKategori(nilaiAkhir)

        ' 5. Tampilkan Hasil Ke Interface
        lblRataTugas.Text = $"Rata-rata Tugas: {avgTugas:F2}"
        lblNilaiAkhir.Text = $"Nilai Akhir (Weighted): {nilaiAkhir:F2}"
        lblKategoriFuzzy.Text = $"Kategori Fuzzy: {kategori}"

        ' 6. Kategorisasikan setiap nilai tugas menurut batas numerik yang diminta
        Dim tugasValues = New Double() {nT1, nT2, nT3, nT4, nT5}
        Dim counts As New Dictionary(Of String, Integer) From {
            {"A", 0}, {"B", 0}, {"C", 0}
        }

        For Each v In tugasValues
            Dim k = NumericKategori(v)
            counts(k) += 1
        Next

        Dim total = tugasValues.Length
        Dim pctA = counts("A") / total * 100.0
        Dim pctB = counts("B") / total * 100.0
        Dim pctC = counts("C") / total * 100.0

        lblPctA.Text = $"A: {pctA:F1} %"
        lblPctB.Text = $"B: {pctB:F1} %"
        lblPctC.Text = $"C: {pctC:F1} %"

        ' Draw a simple bar-style chart inside pnlChart to show percentages
        Try
            pnlChart.Refresh()
            Using g As Graphics = pnlChart.CreateGraphics()
                g.Clear(pnlChart.BackColor)
                Dim margin = 10
                Dim barHeight = 30
                Dim spacing = 10
                Dim maxWidth = pnlChart.Width - margin * 2

                ' A
                Dim wA = CInt(maxWidth * (pctA / 100.0))
                g.FillRectangle(Brushes.Green, margin, margin, wA, barHeight)
                g.DrawString($"A: {pctA:F1}%", Me.Font, Brushes.Black, margin + 4, margin + 4)

                ' B
                Dim yB = margin + barHeight + spacing
                Dim wB = CInt(maxWidth * (pctB / 100.0))
                g.FillRectangle(Brushes.Orange, margin, yB, wB, barHeight)
                g.DrawString($"B: {pctB:F1}%", Me.Font, Brushes.Black, margin + 4, yB + 4)

                ' C
                Dim yC = yB + barHeight + spacing
                Dim wC = CInt(maxWidth * (pctC / 100.0))
                g.FillRectangle(Brushes.Red, margin, yC, wC, barHeight)
                g.DrawString($"C: {pctC:F1}%", Me.Font, Brushes.Black, margin + 4, yC + 4)
            End Using
        Catch ex As Exception
            ' ignore drawing errors
        End Try

        ' 7. Kesimpulan akhir berdasarkan kategori numerik nilai akhir (bukan fuzzy)
        Dim kesimpulanAkhir = NumericKategori(nilaiAkhir)
        lblKesimpulan.Text = $"Kesimpulan Akhir: Kategori {kesimpulanAkhir} (nilai akhir {nilaiAkhir:F2})"
    End Sub

    ''' <summary>
    ''' Klasifikasi numerik langsung berdasarkan batas yang diminta:
    ''' C: 0-75 (nilai &lt;=75), B: 75-90 (nilai &gt;75 and &lt;=90), A: 90-100 (nilai &gt;90)
    ''' Note: Perbatasan 75 dipetakan ke C, 90 dipetakan ke B per deskripsi awal.
    ''' </summary>
    Private Function NumericKategori(ByVal nilai As Double) As String
        If nilai > 90.0 Then
            Return "A"
        ElseIf nilai > 75.0 AndAlso nilai <= 90.0 Then
            Return "B"
        Else
            Return "C"
        End If
    End Function

    ''' <summary>
    ''' Fungsi Analogi Logika Fuzzy untuk Penentuan Kategori Nilai
    ''' </summary>
    Private Function EvaluasiFuzzyKategori(ByVal nilai As Double) As String
        Dim uCukup As Double = DerajatCukup(nilai)
        Dim uSedang As Double = DerajatSedang(nilai)
        Dim uTinggi As Double = DerajatTinggi(nilai)

        If uTinggi >= uSedang AndAlso uTinggi >= uCukup Then
            Return "A (Tinggi)"
        ElseIf uSedang >= uCukup Then
            Return "B (Sedang)"
        Else
            Return "C (Cukup)"
        End If
    End Function

    ' --- Fungsi Keanggotaan (Membership Functions) ---

    Private Function DerajatCukup(x As Double) As Double
        If x <= 60 Then
            Return 1.0
        ElseIf x > 60 AndAlso x < 70 Then
            Return (70.0 - x) / 10.0
        Else
            Return 0.0
        End If
    End Function

    Private Function DerajatSedang(x As Double) As Double
        If x <= 60 OrElse x >= 85 Then
            Return 0.0
        ElseIf x > 60 AndAlso x <= 72.5 Then
            Return (x - 60.0) / 12.5
        Else
            Return (85.0 - x) / 12.5
        End If
    End Function

    Private Function DerajatTinggi(x As Double) As Double
        If x <= 75 Then
            Return 0.0
        ElseIf x > 75 AndAlso x < 85 Then
            Return (x - 75.0) / 10.0
        Else
            Return 1.0
        End If
    End Function

    Private Sub lblRataTugas_Click(sender As Object, e As EventArgs) Handles lblRataTugas.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class