Public Class frmPat
    Dim dbCon As New SqlConnection("Server=.\SQLEXPRESS;Database=Skinput;Integrated Security=true")
    Dim dbDA As New SqlDataAdapter
    Dim dbDS As New DataSet
    Dim dbUPDATE As New SqlCommandBuilder

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        On Error GoTo X

        dbUPDATE.DataAdapter = dbDA
        dbDA.Update(dbDS, "Pattern")

        MsgBox("Record Updated.")

        Exit Sub
X:
        MsgBox(Err.Description)

    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbDA.SelectCommand = New SqlCommand("SELECT * FROM Pattern", dbCon)
        If dbDS.Tables.Contains("Pattern") Then
            dbDS.Tables.Remove("Pattern")
        End If
        dbDA.Fill(dbDS, "Pattern")
        dg.DataSource = dbDS.Tables("Pattern")
    End Sub

    Private Sub frmGridView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        dg.Width = Me.Width - 40
        dg.Height = Me.Height - 110
        btnUpdate.Width = Me.Width - 40
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class