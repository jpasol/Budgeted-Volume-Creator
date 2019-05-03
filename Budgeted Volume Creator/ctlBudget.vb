Imports reports
Public Class ctlBudget
    Public Sub New(Year As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Year = Year
        tabYear.TabPages.Item(0).Text = Year
        BudgetVolume = New BudgetVolume(Year)

        BudgetVolumeData = New BudgetVolumeData
        dgvBudget.AutoGenerateColumns = False
        dgvBudget.DataSource = BudgetVolumeData.MonthlyBudgetVolume

        FormatBudgetVolume()

    End Sub

    Private Sub FormatBudgetVolume()
        Dim volumeYear As Integer = Me.Year
        For monthCount As Integer = 1 To 12
            With BudgetVolume.MonthlyVolume.AsEnumerable
                Dim volumeMonthName As String = MonthName(monthCount)
                Dim importFCL As Double = .Where(Function(vol) vol.Month = monthCount And
                                                     vol.Category = "IMPRT" And
                                                     vol.FreightKind = "FCL").Sum(Function(vol) vol.Volume)
                Dim importMTY As Double = .Where(Function(vol) vol.Month = monthCount And
                                     vol.Category = "IMPRT" And
                                     vol.FreightKind = "MTY").Sum(Function(vol) vol.Volume)
                Dim exportFCL As Double = .Where(Function(vol) vol.Month = monthCount And
                                     vol.Category = "EXPRT" And
                                     vol.FreightKind = "FCL").Sum(Function(vol) vol.Volume)
                Dim exportMTY As Double = .Where(Function(vol) vol.Month = monthCount And
                                     vol.Category = "EXPRT" And
                                     vol.FreightKind = "MTY").Sum(Function(vol) vol.Volume)

                Dim tempRow As DataRow
                tempRow = BudgetVolumeData.MonthlyBudgetVolume.NewMonthlyBudgetVolumeRow

                tempRow("Year") = volumeYear
                tempRow("Month") = volumeMonthName
                tempRow("ImportFull") = importFCL
                tempRow("ImportEmpty") = importMTY
                tempRow("ExportFull") = exportFCL
                tempRow("ExportEmpty") = exportMTY
                tempRow("Total") = importFCL + importMTY + exportFCL + exportMTY

                BudgetVolumeData.MonthlyBudgetVolume.Rows.Add(tempRow)

            End With
        Next
    End Sub

    Friend Sub Save()
        GenerateMonthlyVolumeDataUsingDataGridView()
        BudgetVolume.Save()
    End Sub

    Private Sub GenerateMonthlyVolumeDataUsingDataGridView()
        BudgetVolume.MonthlyVolume.Clear()
        For Each row As BudgetVolumeData.MonthlyBudgetVolumeRow In BudgetVolumeData.MonthlyBudgetVolume.Rows
            Dim volumeYear As Integer = Me.Year
            Dim volumeMonth As Integer = Date.ParseExact(row("Month").ToString,
                                                         "MMMM",
                                                         System.Globalization.CultureInfo.InvariantCulture).
                                                         Month

            Dim importFCLVolume As BudgetVolume.Volume = New BudgetVolume.Volume(volumeYear, volumeMonth,
                                                                           "IMPRT", "FCL",
                                                                           row("ImportFull"))
            Dim importMTYVolume As BudgetVolume.Volume = New BudgetVolume.Volume(volumeYear, volumeMonth,
                                                               "IMPRT", "MTY",
                                                               row("ImportEmpty"))

            Dim exportFCLVolume As BudgetVolume.Volume = New BudgetVolume.Volume(volumeYear, volumeMonth,
                                                                           "EXPRT", "FCL",
                                                                           row("ExportFull"))
            Dim exportMTYVolume As BudgetVolume.Volume = New BudgetVolume.Volume(volumeYear, volumeMonth,
                                                               "EXPRT", "MTY",
                                                               row("ExportEmpty"))

            BudgetVolume.MonthlyVolume.Add(importFCLVolume)
            BudgetVolume.MonthlyVolume.Add(importMTYVolume)
            BudgetVolume.MonthlyVolume.Add(exportFCLVolume)
            BudgetVolume.MonthlyVolume.Add(exportMTYVolume)


        Next
    End Sub

    Public ReadOnly Property VolumeTabPage As TabPage
        Get
            Return tabYear.TabPages.Item(0) 'first tabpage which is volumetabpage
        End Get
    End Property

    Private ReadOnly Property Year As Integer
    Private BudgetVolumeData As BudgetVolumeData
    Public ReadOnly Property BudgetVolume As BudgetVolume


    Private Sub dgvBudget_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBudget.CellEndEdit
        With DirectCast(sender, DataGridView).Rows(e.RowIndex)
            Dim importFCL As Double = (.Cells(1).Value)
            Dim importMTY As Double = (.Cells(2).Value)
            Dim exportFCL As Double = (.Cells(3).Value)
            Dim exportMTY As Double = (.Cells(4).Value)


            .Cells(5).Value = importFCL + importMTY + exportFCL + exportMTY
        End With
    End Sub

End Class
