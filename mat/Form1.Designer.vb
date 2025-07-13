<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        Label1 = New Label()
        RichTextBox2 = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(21, 52)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(384, 200)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(429, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 29)
        Button1.TabIndex = 2
        Button1.Text = "Analizar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 3
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Enabled = False
        RichTextBox2.Location = New Point(429, 49)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(163, 174)
        RichTextBox2.TabIndex = 4
        RichTextBox2.Text = "Este programa le dirá si la matriz que ingrese es Antisimétrica o Única. Escriba aquí su matriz separando cada elemento por , y cada fila con ; como se muestra en el ejemplo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 278)
        Controls.Add(RichTextBox2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "Analisis de Matrices"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox

End Class
