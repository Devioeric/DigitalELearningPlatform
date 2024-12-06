<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAssessmentMultipleChoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAssessmentMultipleChoice))
        MenuPanel = New Panel()
        MenuIconPanel = New Panel()
        LogOutIcon = New Panel()
        SettingsIcon = New Panel()
        CoursesIcon = New Panel()
        AssessmentIcon = New Panel()
        AchievementsIcon = New Panel()
        DashboardIcon = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Choice1 = New Label()
        ModuleNumber = New Label()
        MenuPanel.SuspendLayout()
        MenuIconPanel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuPanel
        ' 
        MenuPanel.BackColor = Color.Transparent
        MenuPanel.BackgroundImage = My.Resources.Resources.MenuBG
        MenuPanel.BackgroundImageLayout = ImageLayout.Center
        MenuPanel.Controls.Add(MenuIconPanel)
        MenuPanel.Location = New Point(-26, -1)
        MenuPanel.Name = "MenuPanel"
        MenuPanel.Size = New Size(97, 724)
        MenuPanel.TabIndex = 5
        ' 
        ' MenuIconPanel
        ' 
        MenuIconPanel.BackgroundImageLayout = ImageLayout.None
        MenuIconPanel.Controls.Add(LogOutIcon)
        MenuIconPanel.Controls.Add(SettingsIcon)
        MenuIconPanel.Controls.Add(CoursesIcon)
        MenuIconPanel.Controls.Add(AssessmentIcon)
        MenuIconPanel.Controls.Add(AchievementsIcon)
        MenuIconPanel.Controls.Add(DashboardIcon)
        MenuIconPanel.Location = New Point(38, 158)
        MenuIconPanel.Name = "MenuIconPanel"
        MenuIconPanel.Size = New Size(45, 551)
        MenuIconPanel.TabIndex = 0
        ' 
        ' LogOutIcon
        ' 
        LogOutIcon.BackgroundImage = CType(resources.GetObject("LogOutIcon.BackgroundImage"), Image)
        LogOutIcon.BackgroundImageLayout = ImageLayout.Center
        LogOutIcon.Cursor = Cursors.Hand
        LogOutIcon.Location = New Point(7, 511)
        LogOutIcon.Name = "LogOutIcon"
        LogOutIcon.Size = New Size(34, 37)
        LogOutIcon.TabIndex = 5
        ' 
        ' SettingsIcon
        ' 
        SettingsIcon.BackgroundImage = CType(resources.GetObject("SettingsIcon.BackgroundImage"), Image)
        SettingsIcon.BackgroundImageLayout = ImageLayout.Center
        SettingsIcon.Cursor = Cursors.Hand
        SettingsIcon.Location = New Point(5, 457)
        SettingsIcon.Name = "SettingsIcon"
        SettingsIcon.Size = New Size(34, 37)
        SettingsIcon.TabIndex = 4
        ' 
        ' CoursesIcon
        ' 
        CoursesIcon.BackgroundImage = CType(resources.GetObject("CoursesIcon.BackgroundImage"), Image)
        CoursesIcon.BackgroundImageLayout = ImageLayout.Center
        CoursesIcon.Cursor = Cursors.Hand
        CoursesIcon.Location = New Point(6, 102)
        CoursesIcon.Name = "CoursesIcon"
        CoursesIcon.Size = New Size(34, 37)
        CoursesIcon.TabIndex = 3
        ' 
        ' AssessmentIcon
        ' 
        AssessmentIcon.BackgroundImage = CType(resources.GetObject("AssessmentIcon.BackgroundImage"), Image)
        AssessmentIcon.BackgroundImageLayout = ImageLayout.Center
        AssessmentIcon.Cursor = Cursors.Hand
        AssessmentIcon.Location = New Point(7, 163)
        AssessmentIcon.Name = "AssessmentIcon"
        AssessmentIcon.Size = New Size(34, 37)
        AssessmentIcon.TabIndex = 2
        ' 
        ' AchievementsIcon
        ' 
        AchievementsIcon.BackgroundImage = CType(resources.GetObject("AchievementsIcon.BackgroundImage"), Image)
        AchievementsIcon.BackgroundImageLayout = ImageLayout.Center
        AchievementsIcon.Cursor = Cursors.Hand
        AchievementsIcon.Location = New Point(5, 223)
        AchievementsIcon.Name = "AchievementsIcon"
        AchievementsIcon.Size = New Size(34, 37)
        AchievementsIcon.TabIndex = 1
        ' 
        ' DashboardIcon
        ' 
        DashboardIcon.BackgroundImage = CType(resources.GetObject("DashboardIcon.BackgroundImage"), Image)
        DashboardIcon.BackgroundImageLayout = ImageLayout.Center
        DashboardIcon.Cursor = Cursors.Hand
        DashboardIcon.Location = New Point(5, 44)
        DashboardIcon.Name = "DashboardIcon"
        DashboardIcon.Size = New Size(34, 35)
        DashboardIcon.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(ModuleNumber)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(78, -22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1190, 774)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(104, 512)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(989, 218)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Controls.Add(Choice1)
        Panel3.Location = New Point(22, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(455, 75)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Center
        Panel4.Location = New Point(506, 19)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(455, 75)
        Panel4.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Center
        Panel5.Location = New Point(506, 112)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(455, 75)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.BackgroundImageLayout = ImageLayout.Center
        Panel6.Location = New Point(22, 112)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(455, 75)
        Panel6.TabIndex = 2
        ' 
        ' Choice1
        ' 
        Choice1.AutoSize = True
        Choice1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Choice1.Location = New Point(196, 28)
        Choice1.Name = "Choice1"
        Choice1.Size = New Size(56, 21)
        Choice1.TabIndex = 0
        Choice1.Text = "Label1"
        ' 
        ' ModuleNumber
        ' 
        ModuleNumber.AutoSize = True
        ModuleNumber.BackColor = Color.Transparent
        ModuleNumber.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ModuleNumber.Location = New Point(502, 45)
        ModuleNumber.Name = "ModuleNumber"
        ModuleNumber.Size = New Size(177, 37)
        ModuleNumber.TabIndex = 3
        ModuleNumber.Text = "Module 0.0.0"
        ' 
        ' UserAssessmentMultipleChoice
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(Panel1)
        Controls.Add(MenuPanel)
        Name = "UserAssessmentMultipleChoice"
        Text = "UserAssessmentMultipleChoice"
        MenuPanel.ResumeLayout(False)
        MenuIconPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents MenuIconPanel As Panel
    Friend WithEvents LogOutIcon As Panel
    Friend WithEvents SettingsIcon As Panel
    Friend WithEvents CoursesIcon As Panel
    Friend WithEvents AssessmentIcon As Panel
    Friend WithEvents AchievementsIcon As Panel
    Friend WithEvents DashboardIcon As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Choice1 As Label
    Friend WithEvents ModuleNumber As Label
End Class
