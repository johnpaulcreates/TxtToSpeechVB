Imports System.Speech.Synthesis

Public Class Form1

    Dim Speech As New SpeechSynthesizer()

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Text = Application.ProductName & " - " & Application.ProductVersion.ToString
        Me.Show()

        txtText.Focus()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSayIt.Click

        Dim bState As Boolean = False
        btnSayIt.Enabled = bState
        nudSpeed.Enabled = bState
        nudVolume.Enabled = bState
        txtText.Enabled = bState
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Speech.Rate = nudSpeed.Value
        Speech.Volume = nudVolume.Value
        Speech.Speak(txtText.Text)

        bState = True
        btnSayIt.Enabled = bState
        nudSpeed.Enabled = bState
        nudVolume.Enabled = bState
        txtText.Enabled = bState
        Me.Cursor = Cursors.Default
        Application.DoEvents()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(LinkLabel1.Text)
    End Sub
End Class
