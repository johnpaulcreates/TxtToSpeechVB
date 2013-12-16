<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSayIt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudVolume = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.nudVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSayIt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSayIt, 4)
        Me.btnSayIt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSayIt.Location = New System.Drawing.Point(3, 191)
        Me.btnSayIt.Name = "btnSayIt"
        Me.btnSayIt.Size = New System.Drawing.Size(368, 34)
        Me.btnSayIt.TabIndex = 0
        Me.btnSayIt.Text = "Say Text"
        Me.btnSayIt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Volume:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudVolume
        '
        Me.nudVolume.Location = New System.Drawing.Point(63, 166)
        Me.nudVolume.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVolume.Name = "nudVolume"
        Me.nudVolume.Size = New System.Drawing.Size(47, 20)
        Me.nudVolume.TabIndex = 2
        Me.nudVolume.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudSpeed
        '
        Me.nudSpeed.Location = New System.Drawing.Point(177, 166)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSpeed.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.Size = New System.Drawing.Size(47, 20)
        Me.nudSpeed.TabIndex = 4
        Me.nudSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblSpeed
        '
        Me.lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSpeed.Location = New System.Drawing.Point(121, 163)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(50, 25)
        Me.lblSpeed.TabIndex = 3
        Me.lblSpeed.Text = "Speed:"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtText, 4)
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(3, 3)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(368, 157)
        Me.txtText.TabIndex = 0
        Me.txtText.Text = "Welcome to this application." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Simply type what you want converted to text and pre" & _
    "ss enter, or you can click the  the ""Say Text"" button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can also adjust th" & _
    "e volume and speed of the voice."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.btnSayIt, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudSpeed, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudVolume, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSpeed, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtText, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.29442!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.70558!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(374, 249)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LinkLabel1, 4)
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 228)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(204, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://johnpaulsmith.co.uk/text-to-speech"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSayIt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 249)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSayIt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudVolume As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
