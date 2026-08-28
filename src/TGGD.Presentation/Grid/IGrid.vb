Public Interface IGrid
    ReadOnly Property Rows As IEnumerable(Of IGridRow)
    Property Size As (Columns As Integer, Rows As Integer)
End Interface
