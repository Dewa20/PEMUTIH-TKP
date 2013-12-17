<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TSBuka = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenDlg = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBuka, Me.toolStripSeparator})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(400, 25)
        Me.ToolStrip.TabIndex = 9
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'TSBuka
        '
        Me.TSBuka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBuka.Image = CType(resources.GetObject("TSBuka.Image"), System.Drawing.Image)
        Me.TSBuka.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBuka.Name = "TSBuka"
        Me.TSBuka.Size = New System.Drawing.Size(23, 22)
        Me.TSBuka.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'Pic
        '
        Me.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic.Location = New System.Drawing.Point(0, 28)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(400, 400)
        Me.Pic.TabIndex = 7
        Me.Pic.TabStop = False
        '
        'Timer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 452)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.Pic)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Image Viewer"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TSBuka As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents OpenDlg As System.Windows.Forms.OpenFileDialog
End Class
