<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAssessmentTaking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAssessmentTaking))
        MenuPanel = New Panel()
        MenuIconPanel = New Panel()
        LogOutIcon = New Panel()
        SettingsIcon = New Panel()
        CoursesIcon = New Panel()
        AssessmentIcon = New Panel()
        AchievementsIcon = New Panel()
        DashboardIcon = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        CourseName = New Label()
        ModuleNumber = New Label()
        LessonName = New Label()
        Panel2 = New Panel()
        MenuPanel.SuspendLayout()
        MenuIconPanel.SuspendLayout()
        Panel1.SuspendLayout()
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
        MenuPanel.TabIndex = 4
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
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CourseName)
        Panel1.Controls.Add(ModuleNumber)
        Panel1.Controls.Add(LessonName)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(77, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1191, 696)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(503, 479)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 45)
        Label1.TabIndex = 4
        Label1.Text = "50 ITEMS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CourseName
        ' 
        CourseName.AutoSize = True
        CourseName.BackColor = Color.Transparent
        CourseName.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CourseName.Location = New Point(430, 422)
        CourseName.Name = "CourseName"
        CourseName.Size = New Size(302, 45)
        CourseName.TabIndex = 3
        CourseName.Text = "Adobe Masterclass"
        CourseName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ModuleNumber
        ' 
        ModuleNumber.AutoSize = True
        ModuleNumber.BackColor = Color.Transparent
        ModuleNumber.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ModuleNumber.Location = New Point(479, 75)
        ModuleNumber.Name = "ModuleNumber"
        ModuleNumber.Size = New Size(177, 37)
        ModuleNumber.TabIndex = 2
        ModuleNumber.Text = "Module 0.0.0"
        ' 
        ' LessonName
        ' 
        LessonName.AllowDrop = True
        LessonName.AutoEllipsis = True
        LessonName.AutoSize = True
        LessonName.BackColor = Color.Transparent
        LessonName.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LessonName.Location = New Point(213, 139)
        LessonName.MaximumSize = New Size(1000, 0)
        LessonName.MinimumSize = New Size(90, 300)
        LessonName.Name = "LessonName"
        LessonName.Size = New Size(742, 300)
        LessonName.TabIndex = 1
        LessonName.Text = "Introduction to Lesson"
        LessonName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Location = New Point(423, 544)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(315, 96)
        Panel2.TabIndex = 0
        ' 
        ' UserAssessmentTaking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(Panel1)
        Controls.Add(MenuPanel)
        Name = "UserAssessmentTaking"
        Text = "UserAssessmentTaking"
        MenuPanel.ResumeLayout(False)
        MenuIconPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents LessonName As Label
    Friend WithEvents ModuleNumber As Label
    Friend WithEvents CourseName As Label
    Friend WithEvents Label1 As Label
End Class
