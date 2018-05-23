Module ModuloPrincipal
    Public lst As ArticulosCollection
    Public listaiva_() As String = {"21,00%", "10,50%"}

    Sub main()
        lst = New ArticulosCollection
        Application.Run(ArticulosGrid)
    End Sub
End Module
