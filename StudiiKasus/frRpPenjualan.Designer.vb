﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frRpPenjualan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rpPenjualan1 = New StudiiKasus.rpPenjualan()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Keuangan Dari Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sampai Dengan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "label4"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 83)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.rpPenjualan1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1222, 513)
        Me.CrystalReportViewer1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(832, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frRpPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 636)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frRpPenjualan"
        Me.Text = "Laporan Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpPenjualan1 As rpPenjualan
    Friend WithEvents Button1 As Button
End Class
