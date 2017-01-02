Imports System.Collections.ObjectModel
Imports Microsoft.VisualBasic.FileIO
Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class Form1

    Private Sub Donustur()
        Dim path As String = girdi.Text
        If (path = "" Or path = String.Empty) Then
            Return
        End If
        cikti.Clear()

        Try
            Dim sr As StreamReader = New StreamReader(path)
            Dim satir As String
            Dim yardimciSatir As String = ""
            Dim blokYorumu As Boolean = False
            Dim boslukKontrol As String

            Do While sr.Peek() >= 0
                boslukKontrol = yardimciSatir.Trim
                If boslukKontrol.Length = 0 Then

                Else
                    cikti.AppendText(yardimciSatir + vbNewLine)
                End If

                yardimciSatir = ""
                satir = sr.ReadLine()


                If (satir.Contains("//") Or satir.Contains("/*") Or satir.Contains("*/")) Then
                    While (satir.Contains("//") Or satir.Contains("/*") Or satir.Contains("*/"))
                        If blokYorumu Then
                            If satir.Contains("*/") Then
                                satir = satir.Substring(satir.IndexOf("*/") + 2, satir.Length - (satir.IndexOf("*/") + 2))
                                blokYorumu = False
                            Else
                                Continue Do
                            End If
                        Else
                            If satir.Contains("//") And satir.Contains("/*") Then
                                If satir.IndexOf("//") < satir.IndexOf("/*") Then
                                    yardimciSatir += satir.Substring(0, satir.IndexOf("//"))

                                    blokYorumu = False
                                    Continue Do
                                Else
                                    yardimciSatir += satir.Substring(0, satir.IndexOf("/*"))
                                    satir = satir.Substring(satir.IndexOf("/*") + 2, satir.Length - (satir.IndexOf("/*") + 2))
                                    blokYorumu = True
                                End If
                            ElseIf satir.Contains("//") Then
                                yardimciSatir += satir.Substring(0, satir.IndexOf("//"))
                                Continue Do
                            ElseIf satir.Contains("/*") Then
                                yardimciSatir += satir.Substring(0, satir.IndexOf("/*"))
                                satir = satir.Substring(satir.IndexOf("/*") + 2, satir.Length - (satir.IndexOf("/*") + 2))
                                blokYorumu = True
                            Else


                            End If
                        End If
                    End While
                    If blokYorumu = False Then
                        yardimciSatir += satir
                    End If
                Else
                    If blokYorumu Then
                        Continue Do
                    Else
                        yardimciSatir += satir
                    End If
                End If
            Loop
            cikti.AppendText(yardimciSatir + vbNewLine)
            sr.Close()
        Catch er As Exception
            Console.WriteLine("The process failed: {0}", er.ToString())
        End Try
    End Sub
    Private Sub DonusturToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DonusturToolStripMenuItem1.Click
        Donustur()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object,
   ByVal e As System.EventArgs) Handles Button1.Click
        ' dosya açma diyalog penceresini açar.
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Javascript Dosyaları|*.js"
        openFileDialog1.Title = "Bir Javascript Dosyası Seçin"


        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            girdi.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub CiktiyiKopyalaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CiktiyiKopyalaToolStripMenuItem.Click
        If (cikti.Text = "" Or cikti.Text = String.Empty) Then
            Return
        End If
        My.Computer.Clipboard.SetText(cikti.Text)
    End Sub

    Private Sub ÇıktıyıYazdırToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıktıyıYazdırToolStripMenuItem.Click
        Dim path As String = girdi.Text
        If (path = "" Or path = String.Empty) Then
            Return
        End If
        Donustur()
        My.Computer.Clipboard.SetText(cikti.Text)
        My.Computer.FileSystem.WriteAllText(path, My.Computer.Clipboard.GetText(), False)
    End Sub
End Class
