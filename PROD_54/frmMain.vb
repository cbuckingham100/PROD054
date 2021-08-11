
Imports System.Configuration
Imports LinxLib.DataLib


Public Class mainForm

    Public sExeVersion As String = "1.00"


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub




    Private Sub LoadMainFormDisplay(sOrderNum As String)
        Dim tDatafetch(0) As DataIn
        Dim bResult As Boolean
        bResult = False

        Dim xDataAccess As New DataAccess


        Try

            xDataAccess.Initialise()

            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "vw_oracle_tij_label_data"
            xDataAccess.SetOrder = "unique_id"
            If (Trim(sOrderNum) = "") Then
                xDataAccess.SetDBWhere = "1=1"
            Else
                xDataAccess.SetDBWhere = "unique_id like '%" & Trim(sOrderNum) & "%'"
            End If


            ReDim Preserve tDatafetch(9)
            tDatafetch(0).ColName = "Unique_ID"
            tDatafetch(1).ColName = "Due_Date"
            tDatafetch(2).ColName = "Product"
            tDatafetch(3).ColName = "Qty"
            tDatafetch(4).ColName = "Product_description"
            tDatafetch(5).ColName = "Customer"
            tDatafetch(6).ColName = "Cust_Code"
            tDatafetch(7).ColName = "Country"
            tDatafetch(8).ColName = "Cust_Order_No"
            tDatafetch(9).ColName = "Country_Label"


            DataGridView1.DataSource = xDataAccess.GetRecordsDataByID(tDatafetch)

            lblRecords.Text = "Records: " & DataGridView1.Rows.Count

        Catch



        End Try




    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadMainFormDisplay("")


    End Sub



    Private Sub mainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If (Me.Height < 400) Then Me.Height = 400
        If (Me.Width < 670) Then Me.Width = 670
        Me.DataGridView1.Width = Me.Width - 40
        Me.DataGridView1.Height = Me.Height - 100
        Me.btnExit.Top = Me.Height - 65
        Me.btnExit.Left = Me.Width - 80
        Me.lblOrderNum.Top = Me.btnExit.Top
        Me.txtOrderNum.Top = Me.btnExit.Top

        '       Me.btnCreateSK.Top = Me.btnExit.Top
        '       Me.lblDistributor.Top = Me.btnExit.Top
        Me.lblRecords.Top = Me.btnExit.Top
        '        Me.lblEmail.Top = Me.btnExit.Top

    End Sub

    Private Sub chkActive_CheckedChanged(sender As Object, e As EventArgs)

        'If chkActive.Checked Then
        '    LoadMainFormDisplay("Y")
        'Else
        '    LoadMainFormDisplay("")
        'End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Try
        '    lblDistributor.Text = Trim(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
        '    lblEmail.Text = Trim(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
        'Catch

        'End Try


    End Sub

    Private Sub btnCreateSK_Click(sender As Object, e As EventArgs)

        'If Trim(lblDistributor.Text) = "" Then
        '    MsgBox("No email for user")
        '    Exit Sub
        'End If

        'If lblDistributor.Text = "Distributor" Then
        '    MsgBox("Please click on distributor in the list above")
        '    Exit Sub
        'End If

        'MsgBox("Create service key routine for " & lblDistributor.Text)

        'CreateTextFile(lblDistributor.Text)









    End Sub

    Private Sub CreateTextFile(sDistributor As String)


        'Dim tDatafetch(0) As DataIn
        'Dim bResult As Boolean
        'bResult = False

        'Dim xDataAccess As New DataAccess

        'Dim sServiceKeyFreq As String = ""
        'Dim sNoOfKeys As String = ""

        'Try

        '    xDataAccess.Initialise()

        '    xDataAccess.SetScheme = "dbo"
        '    xDataAccess.SetTableName = "Users"
        '    xDataAccess.SetOrder = ""
        '    xDataAccess.SetDBWhere = "Distributor='" & sDistributor & "'"

        '    ReDim Preserve tDatafetch(2)
        '    tDatafetch(0).ColName = "Distributor"
        '    tDatafetch(1).ColName = "ServiceKeyFreq"
        '    tDatafetch(2).ColName = "NoOfKeys"

        '    Dim oBindingSource As BindingSource
        '    oBindingSource = xDataAccess.GetRecordsDataByID(tDatafetch)

        '    sServiceKeyFreq = CType(oBindingSource.List(0), DataRowView).Item(1).ToString
        '    sNoOfKeys = CType(oBindingSource.List(0), DataRowView).Item(2).ToString



        'Catch



        'End Try


        'xDataAccess.Dispose()

        'Dim sSKFileName As String = ConfigurationManager.AppSettings("ServicePasswordFileName")
        'Dim sSKPath As String = ConfigurationManager.AppSettings("ServicePasswordPath")

        'If System.IO.File.Exists(sSKPath & "\" & sSKFileName) Then
        '    System.IO.File.Delete(sSKPath & "\" & sSKFileName)
        'End If

        'Dim sTemp As String = sDistributor & "," & sServiceKeyFreq & "," & sNoOfKeys
        'IO.File.WriteAllText(sSKPath & "\" & sSKFileName, sTemp)


    End Sub

    Private Sub txtOrderNum_TextChanged(sender As Object, e As EventArgs) Handles txtOrderNum.TextChanged

        LoadMainFormDisplay(txtOrderNum.Text)


    End Sub
End Class
