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
        Panel1 = New Panel()
        Loginbtn = New Button()
        Panel2 = New Panel()
        RememberCheckButton = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.LoginWhiteBG
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Loginbtn)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(715, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(564, 723)
        Panel1.TabIndex = 0
        ' 
        ' Loginbtn
        ' 
        Loginbtn.BackgroundImage = My.Resources.Resources.LoginBtn
        Loginbtn.BackgroundImageLayout = ImageLayout.Center
        Loginbtn.Cursor = Cursors.Hand
        Loginbtn.Location = New Point(320, 522)
        Loginbtn.Name = "Loginbtn"
        Loginbtn.Size = New Size(166, 41)
        Loginbtn.TabIndex = 1
        Loginbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.LoginLabel
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(RememberCheckButton)
        Panel2.Location = New Point(78, 160)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(408, 317)
        Panel2.TabIndex = 0
        ' 
        ' RememberCheckButton
        ' 
        RememberCheckButton.AutoSize = True
        RememberCheckButton.Location = New Point(24, 282)
        RememberCheckButton.Name = "RememberCheckButton"
        RememberCheckButton.Size = New Size(15, 14)
        RememberCheckButton.TabIndex = 0
        RememberCheckButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.LoginBg
        ClientSize = New Size(1279, 722)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "The Why, See I"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RememberCheckButton As CheckBox
    Friend WithEvents Loginbtn As Button

End Class
