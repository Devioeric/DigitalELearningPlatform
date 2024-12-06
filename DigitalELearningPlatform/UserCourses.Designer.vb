<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserCourses))
        MenuPanel = New Panel()
        MenuIconPanel = New Panel()
        LogOutIcon = New Panel()
        SettingsIcon = New Panel()
        CoursesIcon = New Panel()
        AssessmentIcon = New Panel()
        AchievementsIcon = New Panel()
        DashboardIcon = New Panel()
        UserCoursesPanel = New Panel()
        AddNewCoursesBtn = New Panel()
        RecentlyCompletedLabel4 = New Label()
        RecentlyCompletedLabel3 = New Label()
        RecentlyCompletedLabel2 = New Label()
        RecentlyCompletedLabel1 = New Label()
        Panel3 = New Panel()
        LessonsCompleted = New Label()
        Hours = New Label()
        S = New Panel()
        Panel9 = New Panel()
        Label17 = New Label()
        Panel10 = New Panel()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Panel6 = New Panel()
        Label11 = New Label()
        Panel8 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        Panel5 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel7 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LessonName = New Label()
        CourseName = New Label()
        TextBoxSearch = New TextBox()
        MenuPanel.SuspendLayout()
        MenuIconPanel.SuspendLayout()
        UserCoursesPanel.SuspendLayout()
        S.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel7.SuspendLayout()
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
        MenuPanel.TabIndex = 2
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
        ' UserCoursesPanel
        ' 
        UserCoursesPanel.BackColor = Color.Transparent
        UserCoursesPanel.BackgroundImage = CType(resources.GetObject("UserCoursesPanel.BackgroundImage"), Image)
        UserCoursesPanel.Controls.Add(AddNewCoursesBtn)
        UserCoursesPanel.Controls.Add(RecentlyCompletedLabel4)
        UserCoursesPanel.Controls.Add(RecentlyCompletedLabel3)
        UserCoursesPanel.Controls.Add(RecentlyCompletedLabel2)
        UserCoursesPanel.Controls.Add(RecentlyCompletedLabel1)
        UserCoursesPanel.Controls.Add(Panel3)
        UserCoursesPanel.Controls.Add(LessonsCompleted)
        UserCoursesPanel.Controls.Add(Hours)
        UserCoursesPanel.Controls.Add(S)
        UserCoursesPanel.Controls.Add(TextBoxSearch)
        UserCoursesPanel.Location = New Point(86, 12)
        UserCoursesPanel.Name = "UserCoursesPanel"
        UserCoursesPanel.Size = New Size(1173, 708)
        UserCoursesPanel.TabIndex = 4
        ' 
        ' AddNewCoursesBtn
        ' 
        AddNewCoursesBtn.BackgroundImage = CType(resources.GetObject("AddNewCoursesBtn.BackgroundImage"), Image)
        AddNewCoursesBtn.BackgroundImageLayout = ImageLayout.Center
        AddNewCoursesBtn.Cursor = Cursors.Hand
        AddNewCoursesBtn.Location = New Point(927, 15)
        AddNewCoursesBtn.Name = "AddNewCoursesBtn"
        AddNewCoursesBtn.Size = New Size(234, 59)
        AddNewCoursesBtn.TabIndex = 10
        ' 
        ' RecentlyCompletedLabel4
        ' 
        RecentlyCompletedLabel4.AutoSize = True
        RecentlyCompletedLabel4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecentlyCompletedLabel4.ForeColor = Color.White
        RecentlyCompletedLabel4.Location = New Point(826, 371)
        RecentlyCompletedLabel4.Name = "RecentlyCompletedLabel4"
        RecentlyCompletedLabel4.Size = New Size(171, 15)
        RecentlyCompletedLabel4.TabIndex = 9
        RecentlyCompletedLabel4.Text = "Introduction to Programming"
        ' 
        ' RecentlyCompletedLabel3
        ' 
        RecentlyCompletedLabel3.AutoSize = True
        RecentlyCompletedLabel3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecentlyCompletedLabel3.ForeColor = Color.White
        RecentlyCompletedLabel3.Location = New Point(827, 343)
        RecentlyCompletedLabel3.Name = "RecentlyCompletedLabel3"
        RecentlyCompletedLabel3.Size = New Size(138, 15)
        RecentlyCompletedLabel3.TabIndex = 8
        RecentlyCompletedLabel3.Text = "Cybersecurity Essentials"
        ' 
        ' RecentlyCompletedLabel2
        ' 
        RecentlyCompletedLabel2.AutoSize = True
        RecentlyCompletedLabel2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecentlyCompletedLabel2.ForeColor = Color.White
        RecentlyCompletedLabel2.Location = New Point(827, 315)
        RecentlyCompletedLabel2.Name = "RecentlyCompletedLabel2"
        RecentlyCompletedLabel2.Size = New Size(129, 15)
        RecentlyCompletedLabel2.TabIndex = 7
        RecentlyCompletedLabel2.Text = "Networking Essentials"
        ' 
        ' RecentlyCompletedLabel1
        ' 
        RecentlyCompletedLabel1.AutoSize = True
        RecentlyCompletedLabel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecentlyCompletedLabel1.ForeColor = Color.White
        RecentlyCompletedLabel1.Location = New Point(827, 287)
        RecentlyCompletedLabel1.Name = "RecentlyCompletedLabel1"
        RecentlyCompletedLabel1.Size = New Size(118, 15)
        RecentlyCompletedLabel1.TabIndex = 6
        RecentlyCompletedLabel1.Text = "Adobe After Effects"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(797, 282)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(27, 109)
        Panel3.TabIndex = 5
        ' 
        ' LessonsCompleted
        ' 
        LessonsCompleted.AutoSize = True
        LessonsCompleted.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LessonsCompleted.Location = New Point(942, 159)
        LessonsCompleted.Name = "LessonsCompleted"
        LessonsCompleted.Size = New Size(28, 32)
        LessonsCompleted.TabIndex = 4
        LessonsCompleted.Text = "0"
        ' 
        ' Hours
        ' 
        Hours.AutoSize = True
        Hours.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Hours.Location = New Point(807, 159)
        Hours.Name = "Hours"
        Hours.Size = New Size(28, 32)
        Hours.TabIndex = 3
        Hours.Text = "0"
        ' 
        ' S
        ' 
        S.AutoScroll = True
        S.Controls.Add(Panel9)
        S.Controls.Add(Panel6)
        S.Controls.Add(Panel4)
        S.Controls.Add(Panel2)
        S.Location = New Point(28, 128)
        S.Name = "S"
        S.Size = New Size(740, 566)
        S.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), Image)
        Panel9.BackgroundImageLayout = ImageLayout.Center
        Panel9.Controls.Add(Label17)
        Panel9.Controls.Add(Panel10)
        Panel9.Controls.Add(Label20)
        Panel9.Controls.Add(Label21)
        Panel9.Controls.Add(Label22)
        Panel9.Location = New Point(3, 427)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(730, 136)
        Panel9.TabIndex = 4
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(221, 93)
        Label17.Name = "Label17"
        Label17.Size = New Size(36, 15)
        Label17.TabIndex = 8
        Label17.Text = "12/30"
        ' 
        ' Panel10
        ' 
        Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), Image)
        Panel10.BackgroundImageLayout = ImageLayout.Center
        Panel10.Controls.Add(Label18)
        Panel10.Controls.Add(Label19)
        Panel10.Location = New Point(27, 91)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(194, 19)
        Panel10.TabIndex = 7
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(110, 3)
        Label18.Name = "Label18"
        Label18.Size = New Size(36, 15)
        Label18.TabIndex = 6
        Label18.Text = "12/30"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(23, 3)
        Label19.Name = "Label19"
        Label19.Size = New Size(36, 15)
        Label19.TabIndex = 5
        Label19.Text = "12/30"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 8.4F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.White
        Label20.Location = New Point(638, 89)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 6
        Label20.Text = "Nathan V."
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(24, 44)
        Label21.Name = "Label21"
        Label21.Size = New Size(300, 25)
        Label21.TabIndex = 5
        Label21.Text = "Introduction to Adobe Photoshop"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(25, 18)
        Label22.Name = "Label22"
        Label22.Size = New Size(125, 21)
        Label22.TabIndex = 4
        Label22.Text = "UI/UX Designing"
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.BackgroundImageLayout = ImageLayout.Center
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(Label14)
        Panel6.Controls.Add(Label15)
        Panel6.Controls.Add(Label16)
        Panel6.Location = New Point(3, 287)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(730, 136)
        Panel6.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(221, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 15)
        Label11.TabIndex = 8
        Label11.Text = "12/30"
        ' 
        ' Panel8
        ' 
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Center
        Panel8.Controls.Add(Label12)
        Panel8.Controls.Add(Label13)
        Panel8.Location = New Point(27, 91)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(194, 19)
        Panel8.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(110, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(36, 15)
        Label12.TabIndex = 6
        Label12.Text = "12/30"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(23, 3)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 15)
        Label13.TabIndex = 5
        Label13.Text = "12/30"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 8.4F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(638, 89)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 6
        Label14.Text = "Nathan V."
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(24, 44)
        Label15.Name = "Label15"
        Label15.Size = New Size(300, 25)
        Label15.TabIndex = 5
        Label15.Text = "Introduction to Adobe Photoshop"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(25, 18)
        Label16.Name = "Label16"
        Label16.Size = New Size(125, 21)
        Label16.TabIndex = 4
        Label16.Text = "UI/UX Designing"
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Center
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(3, 145)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(730, 136)
        Panel4.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(221, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 8
        Label5.Text = "12/30"
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Center
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(27, 91)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(194, 19)
        Panel5.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(110, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 6
        Label6.Text = "12/30"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(23, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 5
        Label7.Text = "12/30"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 8.4F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(638, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 6
        Label8.Text = "Nathan V."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(24, 44)
        Label9.Name = "Label9"
        Label9.Size = New Size(300, 25)
        Label9.TabIndex = 5
        Label9.Text = "Introduction to Adobe Photoshop"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(25, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 21)
        Label10.TabIndex = 4
        Label10.Text = "UI/UX Designing"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(LessonName)
        Panel2.Controls.Add(CourseName)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(730, 136)
        Panel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(221, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "12/30"
        ' 
        ' Panel7
        ' 
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.BackgroundImageLayout = ImageLayout.Center
        Panel7.Controls.Add(Label3)
        Panel7.Controls.Add(Label2)
        Panel7.Location = New Point(27, 91)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(194, 19)
        Panel7.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(110, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 6
        Label3.Text = "12/30"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 5
        Label2.Text = "12/30"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 8.4F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(638, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nathan V."
        ' 
        ' LessonName
        ' 
        LessonName.AutoSize = True
        LessonName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LessonName.Location = New Point(24, 44)
        LessonName.Name = "LessonName"
        LessonName.Size = New Size(300, 25)
        LessonName.TabIndex = 5
        LessonName.Text = "Introduction to Adobe Photoshop"
        ' 
        ' CourseName
        ' 
        CourseName.AutoSize = True
        CourseName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CourseName.Location = New Point(25, 18)
        CourseName.Name = "CourseName"
        CourseName.Size = New Size(125, 21)
        CourseName.TabIndex = 4
        CourseName.Text = "UI/UX Designing"
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BackColor = Color.WhiteSmoke
        TextBoxSearch.BorderStyle = BorderStyle.None
        TextBoxSearch.Location = New Point(39, 35)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(317, 16)
        TextBoxSearch.TabIndex = 0
        ' 
        ' UserCourses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(UserCoursesPanel)
        Controls.Add(MenuPanel)
        Name = "UserCourses"
        StartPosition = FormStartPosition.CenterParent
        Text = "UserCourses"
        MenuPanel.ResumeLayout(False)
        MenuIconPanel.ResumeLayout(False)
        UserCoursesPanel.ResumeLayout(False)
        UserCoursesPanel.PerformLayout()
        S.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
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
    Friend WithEvents UserCoursesPanel As Panel
    Friend WithEvents AddNewCoursesBtn As Panel
    Friend WithEvents RecentlyCompletedLabel4 As Label
    Friend WithEvents RecentlyCompletedLabel3 As Label
    Friend WithEvents RecentlyCompletedLabel2 As Label
    Friend WithEvents RecentlyCompletedLabel1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LessonsCompleted As Label
    Friend WithEvents Hours As Label
    Friend WithEvents S As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LessonName As Label
    Friend WithEvents CourseName As Label
    Friend WithEvents TextBoxSearch As TextBox
End Class
