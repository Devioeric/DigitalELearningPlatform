<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCoursesCatalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserCoursesCatalog))
        MenuPanel = New Panel()
        MenuIconPanel = New Panel()
        LogOutIcon = New Panel()
        SettingsIcon = New Panel()
        CoursesIcon = New Panel()
        AssessmentIcon = New Panel()
        AchievementsIcon = New Panel()
        DashboardIcon = New Panel()
        CatalogPanel = New Panel()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CatalogCard = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Catalogs = New Panel()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        courseHour = New Label()
        CourseTitle = New Label()
        Label3 = New Label()
        MenuPanel.SuspendLayout()
        MenuIconPanel.SuspendLayout()
        CatalogPanel.SuspendLayout()
        CatalogCard.SuspendLayout()
        Catalogs.SuspendLayout()
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
        ' CatalogPanel
        ' 
        CatalogPanel.BackColor = Color.Transparent
        CatalogPanel.BackgroundImage = CType(resources.GetObject("CatalogPanel.BackgroundImage"), Image)
        CatalogPanel.BackgroundImageLayout = ImageLayout.Center
        CatalogPanel.Controls.Add(CheckBox8)
        CatalogPanel.Controls.Add(CheckBox7)
        CatalogPanel.Controls.Add(CatalogCard)
        CatalogPanel.Controls.Add(CheckBox6)
        CatalogPanel.Controls.Add(CheckBox5)
        CatalogPanel.Controls.Add(CheckBox4)
        CatalogPanel.Controls.Add(CheckBox3)
        CatalogPanel.Controls.Add(CheckBox2)
        CatalogPanel.Controls.Add(CheckBox1)
        CatalogPanel.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CatalogPanel.Location = New Point(80, 9)
        CatalogPanel.Name = "CatalogPanel"
        CatalogPanel.Size = New Size(1190, 711)
        CatalogPanel.TabIndex = 5
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(28, 344)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(139, 27)
        CheckBox8.TabIndex = 10
        CheckBox8.Text = "Media Literacy"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(28, 311)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(127, 27)
        CheckBox7.TabIndex = 9
        CheckBox7.Text = "Mathematics"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CatalogCard
        ' 
        CatalogCard.Controls.Add(Panel3)
        CatalogCard.Controls.Add(Panel4)
        CatalogCard.Controls.Add(Panel5)
        CatalogCard.Controls.Add(Panel2)
        CatalogCard.Controls.Add(Panel1)
        CatalogCard.Controls.Add(Catalogs)
        CatalogCard.Location = New Point(245, 3)
        CatalogCard.Name = "CatalogCard"
        CatalogCard.Size = New Size(926, 696)
        CatalogCard.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(631, 436)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(292, 321)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Center
        Panel4.Location = New Point(317, 436)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 321)
        Panel4.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Center
        Panel5.Location = New Point(3, 436)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(292, 321)
        Panel5.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Location = New Point(631, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(292, 321)
        Panel2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Location = New Point(317, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(292, 321)
        Panel1.TabIndex = 1
        ' 
        ' Catalogs
        ' 
        Catalogs.BackgroundImage = CType(resources.GetObject("Catalogs.BackgroundImage"), Image)
        Catalogs.BackgroundImageLayout = ImageLayout.Center
        Catalogs.Controls.Add(Label3)
        Catalogs.Controls.Add(CourseTitle)
        Catalogs.Controls.Add(courseHour)
        Catalogs.Controls.Add(Label1)
        Catalogs.Cursor = Cursors.Hand
        Catalogs.Location = New Point(3, 52)
        Catalogs.Name = "Catalogs"
        Catalogs.Size = New Size(292, 321)
        Catalogs.TabIndex = 0
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(28, 278)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(82, 27)
        CheckBox6.TabIndex = 7
        CheckBox6.Text = "History"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(28, 245)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(86, 27)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Science"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(28, 212)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(133, 27)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "CyberSecurity"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(28, 179)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(210, 27)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Information Technology"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(28, 146)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(134, 27)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Programming"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(28, 113)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(169, 27)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Graphic Designing"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 293)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 13)
        Label1.TabIndex = 0
        Label1.Text = "Hours"
        ' 
        ' courseHour
        ' 
        courseHour.AutoSize = True
        courseHour.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        courseHour.Location = New Point(28, 293)
        courseHour.Name = "courseHour"
        courseHour.Size = New Size(19, 13)
        courseHour.TabIndex = 1
        courseHour.Text = "00"
        ' 
        ' CourseTitle
        ' 
        CourseTitle.AutoSize = True
        CourseTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CourseTitle.Location = New Point(9, 179)
        CourseTitle.Name = "CourseTitle"
        CourseTitle.Size = New Size(132, 30)
        CourseTitle.TabIndex = 2
        CourseTitle.Text = "Course Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 219)
        Label3.MinimumSize = New Size(250, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(250, 65)
        Label3.TabIndex = 3
        Label3.Text = "Description Goes Here"
        ' 
        ' UserCoursesCatalog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(CatalogPanel)
        Controls.Add(MenuPanel)
        Name = "UserCoursesCatalog"
        Text = "UserCoursesCatalog"
        MenuPanel.ResumeLayout(False)
        MenuIconPanel.ResumeLayout(False)
        CatalogPanel.ResumeLayout(False)
        CatalogPanel.PerformLayout()
        CatalogCard.ResumeLayout(False)
        Catalogs.ResumeLayout(False)
        Catalogs.PerformLayout()
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
    Friend WithEvents CatalogPanel As Panel
    Friend WithEvents CatalogCard As Panel
    Friend WithEvents Catalogs As Panel
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents courseHour As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CourseTitle As Label
End Class
