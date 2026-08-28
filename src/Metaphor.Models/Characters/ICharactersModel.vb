Public Interface ICharactersModel
    ReadOnly Property HasOthers As Boolean
    ReadOnly Property Others As IEnumerable(Of ICharacterModel)
    ReadOnly Property All As IEnumerable(Of ICharacterModel)
    Sub ShowList()
End Interface
