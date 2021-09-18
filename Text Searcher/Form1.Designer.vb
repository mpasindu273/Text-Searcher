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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsearch = New System.Windows.Forms.Button()
        Me.tlocation = New System.Windows.Forms.TextBox()
        Me.tsearchtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bbrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tresult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkbox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(25, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(26, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Text Name"
        '
        'bsearch
        '
        Me.bsearch.BackColor = System.Drawing.Color.MidnightBlue
        Me.bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bsearch.Location = New System.Drawing.Point(121, 337)
        Me.bsearch.Name = "bsearch"
        Me.bsearch.Size = New System.Drawing.Size(198, 29)
        Me.bsearch.TabIndex = 1
        Me.bsearch.Text = "Search"
        Me.bsearch.UseVisualStyleBackColor = False
        '
        'tlocation
        '
        Me.tlocation.BackColor = System.Drawing.SystemColors.Window
        Me.tlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlocation.ForeColor = System.Drawing.Color.Blue
        Me.tlocation.Location = New System.Drawing.Point(154, 134)
        Me.tlocation.Name = "tlocation"
        Me.tlocation.ReadOnly = True
        Me.tlocation.Size = New System.Drawing.Size(236, 24)
        Me.tlocation.TabIndex = 2
        '
        'tsearchtxt
        '
        Me.tsearchtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsearchtxt.ForeColor = System.Drawing.Color.Blue
        Me.tsearchtxt.Location = New System.Drawing.Point(154, 231)
        Me.tsearchtxt.Name = "tsearchtxt"
        Me.tsearchtxt.Size = New System.Drawing.Size(237, 24)
        Me.tsearchtxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(124, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Text Searcher"
        '
        'bbrowse
        '
        Me.bbrowse.BackColor = System.Drawing.Color.MidnightBlue
        Me.bbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bbrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bbrowse.Location = New System.Drawing.Point(315, 173)
        Me.bbrowse.Name = "bbrowse"
        Me.bbrowse.Size = New System.Drawing.Size(75, 25)
        Me.bbrowse.TabIndex = 1
        Me.bbrowse.Text = "Browse"
        Me.bbrowse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.RectangleShape2, Me.RectangleShape1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(423, 489)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Navy
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -3
        Me.LineShape2.X2 = 427
        Me.LineShape2.Y1 = 308
        Me.LineShape2.Y2 = 309
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(-3, 30)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(428, 359)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkBlue
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RectangleShape1.Location = New System.Drawing.Point(-9, -14)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(446, 57)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Indigo
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -8
        Me.LineShape1.X2 = 439
        Me.LineShape1.Y1 = 327
        Me.LineShape1.Y2 = 325
        '
        'tresult
        '
        Me.tresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tresult.ForeColor = System.Drawing.Color.DarkBlue
        Me.tresult.Location = New System.Drawing.Point(56, 416)
        Me.tresult.Name = "tresult"
        Me.tresult.Size = New System.Drawing.Size(318, 30)
        Me.tresult.TabIndex = 2
        Me.tresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(392, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'checkbox
        '
        Me.checkbox.AutoSize = True
        Me.checkbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox.ForeColor = System.Drawing.Color.DarkBlue
        Me.checkbox.Location = New System.Drawing.Point(278, 271)
        Me.checkbox.Name = "checkbox"
        Me.checkbox.Size = New System.Drawing.Size(112, 21)
        Me.checkbox.TabIndex = 5
        Me.checkbox.Text = "Ignore case"
        Me.checkbox.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(423, 489)
        Me.Controls.Add(Me.checkbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tresult)
        Me.Controls.Add(Me.tsearchtxt)
        Me.Controls.Add(Me.tlocation)
        Me.Controls.Add(Me.bbrowse)
        Me.Controls.Add(Me.bsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bsearch As System.Windows.Forms.Button
    Friend WithEvents tlocation As System.Windows.Forms.TextBox
    Friend WithEvents tsearchtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bbrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tresult As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents checkbox As System.Windows.Forms.CheckBox

End Class
