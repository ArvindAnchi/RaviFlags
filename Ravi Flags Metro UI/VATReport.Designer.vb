﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VATReport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VatDGV = New System.Windows.Forms.DataGridView()
        Me.AmmountDetailsLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.VATEDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.VATSDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.IEDateLBL = New System.Windows.Forms.Label()
        Me.ISDateLBL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.VatDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VatDGV
        '
        Me.VatDGV.AllowUserToAddRows = False
        Me.VatDGV.AllowUserToDeleteRows = False
        Me.VatDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        Me.VatDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VatDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VatDGV.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.VatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.VatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VatDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.VatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VatDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.VatDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.VatDGV.EnableHeadersVisualStyles = False
        Me.VatDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.VatDGV.Location = New System.Drawing.Point(0, 35)
        Me.VatDGV.Name = "VatDGV"
        Me.VatDGV.ReadOnly = True
        Me.VatDGV.RowHeadersVisible = False
        Me.VatDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VatDGV.Size = New System.Drawing.Size(1059, 416)
        Me.VatDGV.TabIndex = 7
        '
        'AmmountDetailsLbl
        '
        Me.AmmountDetailsLbl.Name = "AmmountDetailsLbl"
        Me.AmmountDetailsLbl.Size = New System.Drawing.Size(0, 17)
        Me.AmmountDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AmmountDetailsLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1059, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'VATEDateDTP
        '
        Me.VATEDateDTP.Location = New System.Drawing.Point(362, 8)
        Me.VATEDateDTP.Name = "VATEDateDTP"
        Me.VATEDateDTP.Size = New System.Drawing.Size(200, 21)
        Me.VATEDateDTP.TabIndex = 11
        '
        'VATSDateDTP
        '
        Me.VATSDateDTP.Location = New System.Drawing.Point(91, 8)
        Me.VATSDateDTP.Name = "VATSDateDTP"
        Me.VATSDateDTP.Size = New System.Drawing.Size(200, 21)
        Me.VATSDateDTP.TabIndex = 12
        '
        'IEDateLBL
        '
        Me.IEDateLBL.AutoSize = True
        Me.IEDateLBL.Location = New System.Drawing.Point(304, 12)
        Me.IEDateLBL.Name = "IEDateLBL"
        Me.IEDateLBL.Size = New System.Drawing.Size(55, 13)
        Me.IEDateLBL.TabIndex = 9
        Me.IEDateLBL.Text = "End Date:"
        '
        'ISDateLBL
        '
        Me.ISDateLBL.AutoSize = True
        Me.ISDateLBL.Location = New System.Drawing.Point(30, 12)
        Me.ISDateLBL.Name = "ISDateLBL"
        Me.ISDateLBL.Size = New System.Drawing.Size(61, 13)
        Me.ISDateLBL.TabIndex = 10
        Me.ISDateLBL.Text = "Start Date:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(0, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1059, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VATReport
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VATEDateDTP)
        Me.Controls.Add(Me.VATSDateDTP)
        Me.Controls.Add(Me.IEDateLBL)
        Me.Controls.Add(Me.ISDateLBL)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.VatDGV)
        Me.IconOptions.ShowIcon = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(607, 254)
        Me.Name = "VATReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VAT Report"
        CType(Me.VatDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VatDGV As DataGridView
    Friend WithEvents AmmountDetailsLbl As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents VATEDateDTP As DateTimePicker
    Friend WithEvents VATSDateDTP As DateTimePicker
    Friend WithEvents IEDateLBL As Label
    Friend WithEvents ISDateLBL As Label
    Friend WithEvents Button1 As Button
End Class
