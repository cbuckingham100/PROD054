
Imports System.Configuration
Imports LinxLib.DataLib
Imports Excel = Microsoft.Office.Interop.Excel

Public Class mainForm

    Public sExeVersion As String = "v1.00"

    Private Sub LoadMainFormDisplay(sOrderNum As String)
        Dim tDatafetch(0) As DataIn
        Dim bResult As Boolean
        bResult = False

        Dim xDataAccess As New DataAccess
        Dim sWhereList = ConfigurationManager.AppSettings("whereclause")

        lblVersion.Text = sExeVersion

        Try
            xDataAccess.Initialise()

            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "vw_oracle_tij_label_data"
            xDataAccess.SetOrder = "unique_id"
            If (Trim(sOrderNum) = "") Then
                xDataAccess.SetDBWhere = sWhereList
            Else
                xDataAccess.SetDBWhere = "unique_id like '%" & Trim(sOrderNum) & "%' and " & sWhereList
            End If

            ReDim Preserve tDatafetch(8)
            tDatafetch(0).ColName = "Unique_ID"
            tDatafetch(1).ColName = "Due_Date"
            tDatafetch(2).ColName = "Product"
            tDatafetch(3).ColName = "Qty"
            tDatafetch(4).ColName = "Product_description"
            tDatafetch(5).ColName = "Customer"
            tDatafetch(6).ColName = "Country_Label"
            tDatafetch(7).ColName = "Country"
            tDatafetch(8).ColName = "Cust_Order_No"

            DataGridView1.DataSource = xDataAccess.GetRecordsDataByID(tDatafetch)
            lblRecords.Text = "Records: " & DataGridView1.Rows.Count

        Catch

        End Try

        lblRootFolder.Text = ConfigurationManager.AppSettings("rootfolder")


    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadMainFormDisplay("")

    End Sub

    Private Sub mainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If (Me.Height < 400) Then Me.Height = 400
        If (Me.Width < 670) Then Me.Width = 670
        Me.DataGridView1.Width = Me.Width - 40
        Me.DataGridView1.Height = Me.Height - 130
        Me.btnExit.Top = Me.Height - 70
        Me.btnExit.Left = Me.Width - 100

        Me.lblOrderNum.Top = Me.btnExit.Top
        Me.txtOrderNum.Top = Me.btnExit.Top

        Me.btnDisplay.Top = Me.btnExit.Top
        Me.btnSearch.Top = Me.btnExit.Top
        Me.lblSelected.Top = Me.btnExit.Top - 30
        Me.lblOracleOrder.Top = Me.lblSelected.Top
        Me.btnSelect.Top = Me.btnExit.Top

        Me.lblRootFolder.Top = Me.btnExit.Top + 30
        Me.lblVersion.Top = Me.btnExit.Top + 30
        Me.lblRecords.Top = Me.btnExit.Top + 30


    End Sub


    Private Sub FindExcelSheet(ByVal sName As String)

        Dim sFilelabel As String = ConfigurationManager.AppSettings("filelabel")
        Dim sTypes() As String = sFilelabel.Split(",")
        Dim sFileName As String = ""
        Dim sNotFoundFileName As String = ""

        Dim bFoundFile As Boolean = False

        Dim i As Integer = 0

        Try
            For i = 0 To sTypes.Length - 1
                sFileName = lblRootFolder.Text & "\" & sTypes(i) + " (" & sName & ").xls"
                sNotFoundFileName = sTypes(i) + " (" & sName & ").xls"

                If My.Computer.FileSystem.FileExists(sFileName) Then
                    DisplayExcelFile(sFileName)
                    bFoundFile = True
                End If

            Next

            If Not bFoundFile Then
                MsgBox("Unable to find matching Excel file" & vbCrLf & sNotFoundFileName & vbCrLf & "in root folder")
            End If

        Catch ex As Exception
            MsgBox("Error in FindExcelSheet " & ex.ToString)

        End Try


    End Sub

    Private Sub DisplayExcelFile(ByVal sFilename As String)


        Try

            Dim Proceed As Boolean = False
            Dim xlApp As Excel.Application = Nothing
            Dim xlWorkBooks As Excel.Workbooks = Nothing
            Dim xlWorkBook As Excel.Workbook = Nothing
            Dim xlWorkSheet As Excel.Worksheet = Nothing
            Dim xlWorkSheets As Excel.Sheets = Nothing
            Dim xlCells As Excel.Range = Nothing
            xlApp = New Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(sFilename)
            xlApp.Visible = True
            xlWorkSheets = xlWorkBook.Sheets
            For x As Integer = 1 To xlWorkSheets.Count
                xlWorkSheet = CType(xlWorkSheets(x), Excel.Worksheet)
                If x = 2 Then
                    Proceed = True
                    Exit For
                End If
                Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
                xlWorkSheet = Nothing
            Next
            If Proceed Then
                xlWorkSheet.Activate()
                MessageBox.Show("Close message box to close this Excel sheet", "Spares Cell TIJ Cartridges", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            xlWorkBook.Close()
            xlApp.UserControl = True
            xlApp.Quit()
            ReleaseComObject(xlCells)
            ReleaseComObject(xlWorkSheets)
            ReleaseComObject(xlWorkSheet)
            ReleaseComObject(xlWorkBook)
            ReleaseComObject(xlWorkBooks)
            ReleaseComObject(xlApp)

        Catch ex As Exception

            MsgBox("Error in DisplayExcelSheet " & ex.ToString)

        End Try

    End Sub

    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        LoadMainFormDisplay(Trim(txtOrderNum.Text))

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If lblSelected.Text <> "" And lblSelected.Text <> "None Selected" Then
            FindExcelSheet(lblSelected.Text)
        Else
            MsgBox("Please select an order")
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lblSelected.Text = Trim(DataGridView1.Item(2, i).Value.ToString) & " " & Trim(DataGridView1.Item(6, i).Value.ToString)
            lblOracleOrder.Text = Trim(DataGridView1.Item(0, i).Value.ToString)
        Catch


        End Try


    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub



End Class
