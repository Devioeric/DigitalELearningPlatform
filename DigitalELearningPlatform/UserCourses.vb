Public Class UserCourses
    Private AddNewCoursesOriginalImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\NormalIcon\AddNewCourseBtn.png")
    Private AddNewCoursesHoverImage As Image = Image.FromFile("C:\Users\User\source\repos\DigitalELearningPlatform\DigitalELearningPlatform\Resources\HoveredIcon\AddNewCourseBtn-Hovered.png")

    Private Sub AddNewCoursesBtn_MouseEnter(sender As Object, e As EventArgs) Handles AddNewCoursesBtn.MouseEnter
        AddNewCoursesBtn.BackgroundImage = AddNewCoursesHoverImage
    End Sub

    Private Sub AddNewCoursesBtn_MouseLeave(sender As Object, e As EventArgs) Handles AddNewCoursesBtn.MouseLeave
        AddNewCoursesBtn.BackgroundImage = AddNewCoursesOriginalImage
    End Sub

    Private Sub AddNewCoursesBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles AddNewCoursesBtn.MouseClick
        Me.Hide()
        UserCoursesCatalog.Show()
    End Sub

    ' --- User Courses Function --------------------------------------------------------------------------------------------------------------------------
    ' --- User Courses Hover Function ----------------------------------------------------------------------------------------------------------------------




    ' --- User Courses Event Function ----------------------------------------------------------------------------------------------------------------------

End Class