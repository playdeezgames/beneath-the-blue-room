Friend Class GridCell
    Implements IGridCell

    Private Sub New()
        Text = 64
        [Class] = 15
    End Sub

    Public Property Text As Byte Implements IGridCell.Text

    Public Property [Class] As Byte Implements IGridCell.Class

    Friend Shared Function Create() As IGridCell
        Return New GridCell
    End Function
End Class
