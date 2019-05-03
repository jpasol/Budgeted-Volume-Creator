Public Class BudgetForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        volumeControls = New List(Of ctlBudget)
        Dim budgetForm As New ctlBudget(Date.Now.Year)

        AddTabPage(budgetForm.VolumeTabPage)
        volumeControls.Add(budgetForm)

    End Sub

    Private Sub AddTabPage(volumeTabPage As TabPage)
        On Error Resume Next
        Dim addPage As New TabPage
        addPage.Name = "addPage"
        addPage.Text = "+"

        tabYear.TabPages.Remove(addPage)

        tabYear.TabPages.Add(volumeTabPage)
        tabYear.TabPages.Add(addPage)

    End Sub

    Private volumeControls As List(Of ctlBudget)

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim result As Integer = MsgBox("Would you like to Save?", vbYesNo)

        If result = vbYes Then
            For Each control As ctlBudget In volumeControls
                control.save
            Next
        End If
    End Sub
End Class