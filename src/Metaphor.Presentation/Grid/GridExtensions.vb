Imports System.Runtime.CompilerServices
Imports Metaphor.Extensions
Imports Metaphor.Processing
Imports TGGD.Presentation

Friend Module GridExtensions
    Private ReadOnly characterTypeDeets As New Dictionary(Of String, (Text As Byte, [Class] As Byte)) From
        {
            {CharacterSubtypes.N00B, (2, &HF)}
        }
    Private ReadOnly locationTypeDeets As New Dictionary(Of String, (Text As Byte, [Class] As Byte)) From
        {
            {LocationSubtypes.WALL, (CByte(Asc("#")), &H91)},
            {LocationSubtypes.FLOOR, (CByte(Asc(".")), &H7)}
        }
    <Extension>
    Friend Sub Refresh(grid As IGrid, model As IWorldModel)
        Dim mapModel = model.Avatar.Map
        grid.Size = (mapModel.Columns, mapModel.Rows)
        For Each location In mapModel.Locations
            Dim character = location.Characters.All.FirstOrDefault()
            Dim deets = If(character Is Nothing, locationTypeDeets(location.LocationType), characterTypeDeets(character.CharacterType))
            Dim cell = grid.Rows(location.Row).Cells(location.Column)
            cell.Character = deets.Text
            cell.Attribute = deets.Class
        Next
    End Sub
End Module
