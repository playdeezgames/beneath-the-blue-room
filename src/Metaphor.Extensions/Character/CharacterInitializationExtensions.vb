Imports System.Runtime.CompilerServices
Imports Metaphor.Persistence

Friend Module CharacterInitializationExtensions
#Region "N00b"
    <Extension>
    Friend Sub InitializeN00b(character As ICharacter)
        character.World.Avatar = character
        character.CreateMoveVerb("N", 0, -1)
        character.CreateMoveVerb("E", 1, 0)
        character.CreateMoveVerb("S", 0, 1)
        character.CreateMoveVerb("W", -1, 0)
        character.CreateLookVerb()
        character.CreateStatusVerb()
    End Sub
#End Region
End Module
