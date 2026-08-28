Public Class Grid
    Implements IGrid

    Private _rows As New List(Of IGridRow)

    Public ReadOnly Property Rows As IEnumerable(Of IGridRow) Implements IGrid.Rows
        Get
            Return _rows
        End Get
    End Property

    Public Property Size As (Columns As Integer, Rows As Integer) Implements IGrid.Size
        Get
            Dim rows = _rows.Count
            If rows > 0 Then
                Return (_rows(0).Cells.Count, rows)
            Else
                Return (0, rows)
            End If
        End Get
        Set(value As (Columns As Integer, Rows As Integer))
            _rows = Enumerable.Range(0, value.Rows).Select(Function(x) GridRow.Create(value.Columns)).ToList()
        End Set
    End Property
End Class
