Imports Metaphor.Persistence

Friend Module MapInitializationExtensions
#Region "Blue Room"
    Private ReadOnly blueRoom As String() =
        {
            "####################",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#.........@........#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "#..................#",
            "####################"
        }
    Private Const AVATAR_CHARACTER = "@"c
    Private ReadOnly blueRoomDeets As New Dictionary(Of Char, (Subtype As String, Name As String, Initializer As LocationInitializer)) From
        {
            {"#"c, (LocationSubtypes.WALL, "Wall", Nothing)},
            {"."c, (LocationSubtypes.FLOOR, "Floor", Nothing)},
            {AVATAR_CHARACTER, (LocationSubtypes.FLOOR, "Floor", Nothing)}
        }
    Friend Function InitializeBlueRoom(context As IInitializationContext) As MapInitializer
        Return Sub(map)
                   Dim row = 0
                   For Each line In blueRoom
                       Dim column = 0
                       For Each character In line
                           Dim deets = blueRoomDeets(character)
                           Dim location = map.CreateLocation(deets.Subtype, deets.Name, (column, row), deets.Initializer)
                           If character = AVATAR_CHARACTER Then
                               location.CreateCharacter(CharacterSubtypes.N00B, context.ChosenName, AddressOf CharacterInitializationExtensions.InitializeN00b)
                           End If
                           column += 1
                       Next
                       row += 1
                   Next
               End Sub
    End Function
#End Region
End Module
