Imports System.Runtime.CompilerServices
Imports Metaphor.Processing
Imports TGGD.Presentation

Friend Module GridExtensions
    <Extension>
    Friend Sub Refresh(grid As IGrid, model As IWorldModel)
        grid.Size = (20, 15)
    End Sub
End Module
