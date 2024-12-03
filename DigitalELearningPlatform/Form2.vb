Public Class UserDashboard

    Private DashBoardOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\DashBoardIcon.png")
    Private DashboardHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\DashboardIcon-Hovered.png")
    Private CoursesOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\CoursesIcon.png")
    Private CoursesHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\CoursesIcon-Hovered.png")
    Private AssessmentOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\AssessmentIcon.png")
    Private AssessmentHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\AssessmentIcon-Hovered.png")
    Private AchivevementsOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\AchievementsIconPng.png")
    Private AchievementsHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\AchievementsIcon-Hovered.png")
    Private SettingsOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\SettingsIcon.png")
    Private SettingsHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\SettingsIcon-Hovered.png")
    Private LogOutOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\LogOutIcon.png")
    Private LogOutHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\LogOutIcon-Hovered.png")
    Private Sub DashboardIcon_MouseEnter(sender As Object, e As EventArgs) Handles DashboardIcon.MouseEnter
        DashboardIcon.BackgroundImage = DashboardHoverImage
    End Sub

    Private Sub DashboardIcon_MouseLeave(sender As Object, e As EventArgs) Handles DashboardIcon.MouseLeave
        DashboardIcon.BackgroundImage = DashBoardOriginalImage
    End Sub

    Private Sub CoursesIcon_MouseEnter(sender As Object, e As EventArgs) Handles CoursesIcon.MouseEnter
        CoursesIcon.BackgroundImage = CoursesHoverImage
    End Sub
    Private Sub CoursesIcon_MouseLeave(sender As Object, e As EventArgs) Handles CoursesIcon.MouseLeave
        CoursesIcon.BackgroundImage = CoursesOriginalImage
    End Sub

    Private Sub AssessmentIcon_MouseEnter(sender As Object, e As EventArgs) Handles AssessmentIcon.MouseEnter
        AssessmentIcon.BackgroundImage = AssessmentHoverImage
    End Sub
    Private Sub AssessmentIcon_MouseLeave(sender As Object, e As EventArgs) Handles AssessmentIcon.MouseLeave
        AssessmentIcon.BackgroundImage = AssessmentOriginalImage
    End Sub

    Private Sub AchievementsIcon_MouseEnter(sender As Object, e As EventArgs) Handles AchievementsIcon.MouseEnter
        AchievementsIcon.BackgroundImage = AchievementsHoverImage
    End Sub
    Private Sub AchievementsIcon_MouseLeave(sender As Object, e As EventArgs) Handles AchievementsIcon.MouseLeave
        AchievementsIcon.BackgroundImage = AchivevementsOriginalImage
    End Sub

    Private Sub SettingsIcon_MouseEnter(sender As Object, e As EventArgs) Handles SettingsIcon.MouseEnter
        SettingsIcon.BackgroundImage = SettingsHoverImage
    End Sub
    Private Sub SettingsIcon_MouseLeave(sender As Object, e As EventArgs) Handles SettingsIcon.MouseLeave
        SettingsIcon.BackgroundImage = SettingsOriginalImage
    End Sub

    Private Sub LogOutIcon_MouseEnter(sender As Object, e As EventArgs) Handles LogOutIcon.MouseEnter
        LogOutIcon.BackgroundImage = LogOutHoverImage
    End Sub

    Private Sub LogOutIcon_MouseLeave(sender As Object, e As EventArgs) Handles LogOutIcon.MouseLeave
        LogOutIcon.BackgroundImage = LogOutOriginalImage
    End Sub

    Private Sub CoursesIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles CoursesIcon.MouseClick
        DashboardPanel.Hide()
        UserCoursesPanel.Show()
    End Sub

    Private Sub DashboardIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles DashboardIcon.MouseClick
        DashboardPanel.Show()
        UserCoursesPanel.Hide()
    End Sub

    Private Sub AssessmentIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles AssessmentIcon.MouseClick
        DashboardPanel.Hide()
        UserCoursesPanel.Hide()
    End Sub

    Private Sub AchievementsIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles AchievementsIcon.MouseClick
        DashboardPanel.Hide()
        UserCoursesPanel.Hide()
    End Sub

    Private Sub SettingsIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingsIcon.MouseClick
        DashboardPanel.Hide()
        UserCoursesPanel.Hide()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserCoursesPanel.Hide()
    End Sub

    Private Sub UserCoursesPanel_Paint(sender As Object, e As PaintEventArgs) Handles UserCoursesPanel.Paint

    End Sub
End Class