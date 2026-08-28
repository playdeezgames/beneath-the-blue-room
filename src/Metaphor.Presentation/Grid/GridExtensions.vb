Imports System.Runtime.CompilerServices
Imports Metaphor.Processing
Imports TGGD.Presentation

Friend Module GridExtensions
    <Extension>
    Friend Sub Refresh(grid As IGrid, model As IWorldModel)
        Const columns = 20
        Const rows = 15
        grid.Size = (columns, rows)
        grid.Fill((0, 0), (columns, rows), "#", "fg1 bg9")
        grid.Fill((1, 1), (columns - 2, rows - 2), ".", "fg7 bg0")
    End Sub
End Module
