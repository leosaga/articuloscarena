Public Class ArticulosGrid

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click

        ArticuloForm.operacion = "alta"
        ArticuloForm.Text = "alta de articulo"
        ArticuloForm.Show()
    End Sub



    Private Sub eleminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eleminar.Click
        If lst.Count = 0 Then
            Exit Sub

        End If
        ArticuloForm.operacion = "elimina"
        ArticuloForm.Text = "elimina articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ArticuloForm.Show()

    End Sub






    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        If lst.Count = 0 Then
            Exit Sub

        End If
        ArticuloForm.operacion = "modifica"
        ArticuloForm.Text = "modificar articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ArticuloForm.Show()
    End Sub




    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()

    End Sub
    Private Sub llenarform()
        ArticuloForm.codigo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ArticuloForm.descripcion1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ArticuloForm.stock1.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        ArticuloForm.costo1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ArticuloForm.utilidad1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

        ' ArticuloForm.venta1.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString

    End Sub

    Private Sub ArticulosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

  
    
End Class