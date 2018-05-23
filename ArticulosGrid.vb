Public Class ArticulosGrid

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click

        ArticuloForm.operacion = "alta"
        ArticuloForm.Text = "alta de articulo"
        ArticuloForm.Show()
    End Sub



    Private Sub eleminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eleminar.Click
        ArticuloForm.operacion = "elimina"
        ArticuloForm.Text = "elimina articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        llenarForm()
        ArticuloForm.Show()

    End Sub






    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
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
        ArticuloForm.codigo.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ArticuloForm.descripcion1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ArticuloForm.stock1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ArticuloForm.costo.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        ArticuloForm.utilidad.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ArticuloForm.venta.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub ArticulosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub
End Class