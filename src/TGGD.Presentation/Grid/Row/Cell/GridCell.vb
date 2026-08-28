Friend Class GridCell
    Implements IGridCell

    Private Sub New()
        Text = "@"
        [Class] = "fg15 bg0"
    End Sub

    Public Property Text As String Implements IGridCell.Text

    Public Property [Class] As String Implements IGridCell.Class

    Friend Shared Function Create() As IGridCell
        Return New GridCell
    End Function
End Class
