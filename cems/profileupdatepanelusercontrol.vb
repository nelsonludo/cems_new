Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports cems.users

Imports cems.adminProfilePanelUserControl


Public Class profileupdatepanelusercontrol


    Dim User As New users

    Dim adminProfilePanelUserControl As New adminProfilePanelUserControl


    Private Sub updateProfileCancelBtn_Click(sender As Object, e As EventArgs) Handles updateProfileCancelBtn.Click
        profileSubPanel2.Visible = False
        updateProfileErrorMsg.Visible = False
    End Sub

    Private Sub updateProfileValidateBtn_Click(sender As Object, e As EventArgs) Handles updateProfileValidateBtn.Click

        User.updateUser("admin", "admin", userNameProfileInput.Text, userPhoneNumberProfileInput.Text, userEmailProfileInput.Text, userPwdProfileInput.Text, userConfirmPwdProfileInput.Text, Form1.emailtxt.Text, updateProfileErrorMsg, profileSubPanel2, adminhomePage.Timer2)
        User.updateUserInformation("admin", "admin", Form1.emailtxt, adminProfilePanelUserControl.adminNameProfile, adminProfilePanelUserControl.adminEmailProfile, adminProfilePanelUserControl.adminPhoneNumberProfile, adminProfilePanelUserControl.adminTitleProfile)

        adminhomePage.showUserName()
    End Sub


End Class
