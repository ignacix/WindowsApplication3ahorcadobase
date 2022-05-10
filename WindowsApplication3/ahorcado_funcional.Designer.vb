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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pasar = New System.Windows.Forms.Button()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(183, 105)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(91, 16)
        Me.lbl1.TabIndex = 0
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(185, 48)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(107, 23)
        Me.bt1.TabIndex = 1
        Me.bt1.Text = "Cargar palabra"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(66, 51)
        Me.txt1.Name = "txt1"
        Me.txt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(91, 198)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(29, 20)
        Me.txt2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cargar letra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(150, 105)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(27, 16)
        Me.lbl2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce  la palabra"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(51, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad de letras:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(63, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Introduce la letra"
        '
        'imagen
        '
        Me.imagen.Image = CType(resources.GetObject("imagen.Image"), System.Drawing.Image)
        Me.imagen.Location = New System.Drawing.Point(298, -2)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(350, 509)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 5
        Me.imagen.TabStop = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(690, 80)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 13)
        Me.lbl4.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(690, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Letras Incorrectas:"
        '
        'pasar
        '
        Me.pasar.Location = New System.Drawing.Point(692, 294)
        Me.pasar.Name = "pasar"
        Me.pasar.Size = New System.Drawing.Size(75, 23)
        Me.pasar.TabIndex = 8
        Me.pasar.Text = "Button2"
        Me.pasar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 499)
        Me.Controls.Add(Me.pasar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents bt1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents imagen As PictureBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pasar As Button
End Class
