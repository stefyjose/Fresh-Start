Imports System.Data.SqlClient
Public Class frmreminder
    Dim dbobj As New DBLayer.Connection
    Dim dt As New DataTable
    Dim cmd, cmd1 As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim rid, a

    Private Sub frmreminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim res
        btncreate.Enabled = True
        txtrem.Enabled = False
        dtpdate.Enabled = False
        dbobj.Connect()
        dt.Clear()
        dt.Columns.Clear()
        cmd.CommandText = "select count(rid) from tb_reminder"
        cmd.Connection = dbobj.myconnection
        ad.SelectCommand = cmd
        ad.Fill(dt)
        Dim c = dt.Rows(0).Item(0)
        dt.Clear()
        dt.Columns.Clear()
        cmd.CommandText = "select * from tb_reminder where status=1"
        cmd.Connection = dbobj.myconnection
        ad.SelectCommand = cmd
        ad.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("rdate") = Date.Now.Date() Then
                res = MessageBox.Show(dt.Rows(i).Item("rem"), "Today's Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Dim b = dt.Rows(i).Item("rid")
                If res = 1 Then
                    cmd1.CommandText = "update tb_reminder set status=0 where rid= " & b & ""
                    cmd1.Connection = dbobj.myconnection
                    cmd1.ExecuteNonQuery()
                End If
                If dt.Rows.Count = c Then
                    End
                End If
            End If

        Next
        dt.Clear()
        dt.Columns.Clear()
        cmd.CommandText = "select * from tb_reminder"
        cmd.Connection = dbobj.myconnection
        ad.SelectCommand = cmd
        ad.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            dgrid.Rows.Add()
            dgrid.Rows(i).Cells(0).Value = dt.Rows(i).Item("rid")
            dgrid.Rows(i).Cells(1).Value = dt.Rows(i).Item("rem")
            dgrid.Rows(i).Cells(2).Value = dt.Rows(i).Item("rdate")
            If dt.Rows(i).Item("status") = 1 Then
                dgrid.Rows(i).Cells(3).Value = "Upcoming"
            Else
                dgrid.Rows(i).Cells(3).Value = "Completed"
            End If
        Next

    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        txtrem.Enabled = True
        dtpdate.Enabled = True
        If btncreate.Text = "CREATE" Then
            btncreate.Text = "SAVE"
            txtrem.Select()
            dt.Clear()
            dt.Columns.Clear()
            cmd.CommandText = "select * from tb_reminder"
            cmd.Connection = dbobj.myconnection
            ad.SelectCommand = cmd
            ad.Fill(dt)
            If dt.Rows.Count = 0 Then
                rid = 101
            Else
                rid = Val(dt.Rows(dt.Rows.Count - 1).Item("rid")) + 1
            End If
        ElseIf btncreate.Text = "SAVE" Then
            If txtrem.Text = "" Then
                MessageBox.Show("Fill all the Fields")
                Exit Sub
            End If
            cmd.CommandText = "insert into tb_reminder values(" & rid & ",'" & txtrem.Text & "','" & dtpdate.Value & "',1)"
            cmd.Connection = dbobj.myconnection
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reminder Created")
            btncreate.Text = "CREATE"
            txtrem.Text = ""
            dtpdate.Value = Date.Now.Date()
            dt.Clear()
            dt.Columns.Clear()
            cmd.CommandText = "select * from tb_reminder "
            cmd.Connection = dbobj.myconnection
            ad.SelectCommand = cmd
            ad.Fill(dt)
            dgrid.Rows.Add()
            For i = 0 To dt.Rows.Count - 1

                dgrid.Rows(i).Cells(0).Value = dt.Rows(i).Item("rid")
                dgrid.Rows(i).Cells(1).Value = dt.Rows(i).Item("rem")
                dgrid.Rows(i).Cells(2).Value = dt.Rows(i).Item("rdate")
                If dt.Rows(i).Item("status") = 1 Then
                    dgrid.Rows(i).Cells(3).Value = "Upcoming"
                Else
                    dgrid.Rows(i).Cells(3).Value = "Completed"
                End If

            Next

        ElseIf btncreate.Text = "UPDATE" Then
            If txtrem.Text = "" Then
                MessageBox.Show("Fill all the Fields")
                Exit Sub
            End If
            cmd.CommandText = "update tb_reminder set rem='" & txtrem.Text & "',rdate='" & dtpdate.Value & "',status=1 where rid= " & a & ""
            cmd.Connection = dbobj.myconnection
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated")
            txtrem.Text = ""
            dtpdate.Value = Date.Now.Date()
            dt.Clear()
            dt.Columns.Clear()
            cmd.CommandText = "select * from tb_reminder"
            cmd.Connection = dbobj.myconnection
            ad.SelectCommand = cmd
            ad.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                dgrid.Rows(i).Cells(0).Value = dt.Rows(i).Item("rid")
                dgrid.Rows(i).Cells(1).Value = dt.Rows(i).Item("rem")
                dgrid.Rows(i).Cells(2).Value = dt.Rows(i).Item("rdate")
                If dt.Rows(i).Item("status") = 1 Then
                    dgrid.Rows(i).Cells(3).Value = "Upcoming"
                Else
                    dgrid.Rows(i).Cells(3).Value = "Completed"
                End If
            Next
        End If
    End Sub



    Private Sub dgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid.CellClick
        If e.RowIndex <> -1 Then
            btncreate.Enabled = True
            btncreate.Text = "UPDATE"
            a = dgrid.Rows(e.RowIndex).Cells(0).Value
            txtrem.Text = dgrid.Rows(e.RowIndex).Cells(1).Value
            dtpdate.Value = dgrid.Rows(e.RowIndex).Cells(2).Value
        End If
    End Sub
End Class
