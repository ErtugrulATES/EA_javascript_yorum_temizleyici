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
        Me.girdi = New System.Windows.Forms.TextBox()
        Me.cikti = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DonusturToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiktiyiKopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ÇıktıyıYazdırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'girdi
        '
        Me.girdi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.girdi.Location = New System.Drawing.Point(12, 27)
        Me.girdi.Multiline = True
        Me.girdi.Name = "girdi"
        Me.girdi.Size = New System.Drawing.Size(519, 75)
        Me.girdi.TabIndex = 0
        '
        'cikti
        '
        Me.cikti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cikti.Location = New System.Drawing.Point(12, 110)
        Me.cikti.Multiline = True
        Me.cikti.Name = "cikti"
        Me.cikti.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cikti.Size = New System.Drawing.Size(614, 566)
        Me.cikti.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonusturToolStripMenuItem1, Me.CiktiyiKopyalaToolStripMenuItem, Me.ÇıktıyıYazdırToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(638, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DonusturToolStripMenuItem1
        '
        Me.DonusturToolStripMenuItem1.Name = "DonusturToolStripMenuItem1"
        Me.DonusturToolStripMenuItem1.Size = New System.Drawing.Size(68, 20)
        Me.DonusturToolStripMenuItem1.Text = "Dönüştür"
        '
        'CiktiyiKopyalaToolStripMenuItem
        '
        Me.CiktiyiKopyalaToolStripMenuItem.Name = "CiktiyiKopyalaToolStripMenuItem"
        Me.CiktiyiKopyalaToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CiktiyiKopyalaToolStripMenuItem.Text = "Çıktıyı Kopyala"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(537, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 74)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Dosya Aç"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ÇıktıyıYazdırToolStripMenuItem
        '
        Me.ÇıktıyıYazdırToolStripMenuItem.Name = "ÇıktıyıYazdırToolStripMenuItem"
        Me.ÇıktıyıYazdırToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ÇıktıyıYazdırToolStripMenuItem.Text = "Çıktıyı Yazdır"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 688)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cikti)
        Me.Controls.Add(Me.girdi)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ertuğrul ATEŞ - Javascript Yorum Temizleyici"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents girdi As TextBox
    Friend WithEvents cikti As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DonusturToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents CiktiyiKopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıktıyıYazdırToolStripMenuItem As ToolStripMenuItem
End Class
