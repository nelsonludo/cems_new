
Public Class adminProfilePanelUserControl

    Dim profileupdatepanelusercontrol As New profileupdatepanelusercontrol

    'update buttons 
    'profile updates
    Private Sub updateProfileShowBtn_Click(sender As Object, e As EventArgs) Handles updateProfileShowBtn.Click
        profileupdatepanelusercontrol.Visible = True

        profileupdatepanelusercontrol.userNameProfileInput.Text = adminNameProfile.Text
        profileupdatepanelusercontrol.userPhoneNumberProfileInput.Text = adminPhoneNumberProfile.Text
        profileupdatepanelusercontrol.userEmailProfileInput.Text = adminEmailProfile.Text


        profileupdatepanelusercontrol.userPwdProfileInput.Text = ""
        profileupdatepanelusercontrol.userConfirmPwdProfileInput.Text = ""


    End Sub


End Class
