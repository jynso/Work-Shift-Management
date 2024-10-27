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
        PictureBoxqcu = New PictureBox()
        Labelwelcome = New Label()
        Labelback = New Label()
        Labellogin = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        CType(PictureBoxqcu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxqcu
        ' 
        PictureBoxqcu.Image = CType(resources.GetObject("PictureBoxqcu.Image"), Image)
        PictureBoxqcu.Location = New Point(0, 0)
        PictureBoxqcu.Margin = New Padding(2)
        PictureBoxqcu.Name = "PictureBoxqcu"
        PictureBoxqcu.Size = New Size(626, 680)
        PictureBoxqcu.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxqcu.TabIndex = 0
        PictureBoxqcu.TabStop = False
        ' 
        ' Labelwelcome
        ' 
        Labelwelcome.AutoSize = True
        Labelwelcome.BackColor = Color.Transparent
        Labelwelcome.Font = New Font("Montserrat", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelwelcome.ForeColor = Color.FromArgb(CByte(255), CByte(223), CByte(0))
        Labelwelcome.Location = New Point(46, 31)
        Labelwelcome.Margin = New Padding(2, 0, 2, 0)
        Labelwelcome.Name = "Labelwelcome"
        Labelwelcome.Size = New Size(333, 83)
        Labelwelcome.TabIndex = 1
        Labelwelcome.Text = "Welcome"
        ' 
        ' Labelback
        ' 
        Labelback.AutoSize = True
        Labelback.BackColor = Color.Transparent
        Labelback.Font = New Font("Montserrat", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelback.ForeColor = Color.White
        Labelback.Location = New Point(46, 122)
        Labelback.Margin = New Padding(2, 0, 2, 0)
        Labelback.Name = "Labelback"
        Labelback.Size = New Size(193, 83)
        Labelback.TabIndex = 2
        Labelback.Text = "Back"
        ' 
        ' Labellogin
        ' 
        Labellogin.AutoSize = True
        Labellogin.BackColor = Color.Transparent
        Labellogin.Font = New Font("Montserrat", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labellogin.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Labellogin.Location = New Point(705, 122)
        Labellogin.Margin = New Padding(2, 0, 2, 0)
        Labellogin.Name = "Labellogin"
        Labellogin.Size = New Size(211, 83)
        Labellogin.TabIndex = 3
        Labellogin.Text = "Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(721, 286)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(308, 36)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        Label1.Location = New Point(713, 220)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 47)
        Label1.TabIndex = 5
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        Label2.Location = New Point(713, 354)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 47)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(721, 438)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(308, 36)
        TextBox2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Montserrat", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(969, 518)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 55)
        Label3.TabIndex = 8
        Label3.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(1262, 673)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Labellogin)
        Controls.Add(Labelback)
        Controls.Add(Labelwelcome)
        Controls.Add(PictureBoxqcu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBoxqcu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxqcu As PictureBox
    Friend WithEvents Labelwelcome As Label
    Friend WithEvents Labelback As Label
    Friend WithEvents Labellogin As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label

End Class
