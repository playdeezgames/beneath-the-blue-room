Imports System.Runtime.CompilerServices
Imports Metaphor.Persistence

Friend Module CharacterInitializationExtensions
#Region "N00b"
    <Extension>
    Friend Sub InitializeN00b(character As ICharacter)
        character.World.Avatar = character
        character.CreateMoveVerb("N", "north", 0, -1)
        character.CreateMoveVerb("E", "east", 1, 0)
        character.CreateMoveVerb("S", "south", 0, 1)
        character.CreateMoveVerb("W", "west", -1, 0)
        character.CreateLookVerb()
        character.CreateStatusVerb()
    End Sub

    Friend Sub InitializeRat(character As ICharacter)
        character.SetTag(Tags.ENEMY)
    End Sub
#End Region
End Module
