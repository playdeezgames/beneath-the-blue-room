Imports Metaphor.Persistence

Friend Class CharactersModel
    Implements ICharactersModel

    Private ReadOnly location As ILocation

    Private Sub New(location As ILocation)
        Me.location = location
    End Sub

    Public ReadOnly Property HasOthers As Boolean Implements ICharactersModel.HasOthers
        Get
            Return location.HasOtherCharacters(location.World.Avatar)
        End Get
    End Property

    Public ReadOnly Property Others As IEnumerable(Of ICharacterModel) Implements ICharactersModel.Others
        Get
            Return location.GetOtherCharacters(location.World.Avatar).Select(AddressOf CharacterModel.Create)
        End Get
    End Property

    Public ReadOnly Property All As IEnumerable(Of ICharacterModel) Implements ICharactersModel.All
        Get
            Return location.Characters.Select(AddressOf CharacterModel.Create)
        End Get
    End Property

    Public Sub ShowList() Implements ICharactersModel.ShowList
        location.World.ClearMessages()
    End Sub

    Friend Shared Function Create(entity As ILocation) As ICharactersModel
        Return New CharactersModel(entity)
    End Function
End Class
