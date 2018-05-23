Imports System.ComponentModel

Public Class ArticulosCollection
    Inherits BindingList(Of ArticuloClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New ArticuloClass()
    End Sub
End Class
