Imports Metaphor.Persistence

Friend Module ItemInitializationExtensions
    Friend Sub InitializeDagger(item As IItem)
        item.SetCounter(Counters.EQUIP_FLAGS, EquipFlags.MAIN_HAND)
        item.CreateVerb(VerbSubtypes.EQUIP, "Equip")
        item.CreateVerb(VerbSubtypes.UNEQUIP, "Unequip")
    End Sub
End Module
