Imports System.Runtime.CompilerServices
Imports Metaphor.Persistence

Public Module CharacterCombatExtensions
    <Extension>
    Friend Function GetAttack(character As ICharacter) As Integer
        Return character.GetCounter(Counters.ATTACK) + character.GetEquipment().Sum(Function(x) x.GetCounter(Counters.ATTACK))
    End Function
    <Extension>
    Friend Function GetAttackCap(character As ICharacter) As Integer
        Return character.GetCounter(Counters.ATTACK_CAP) + character.GetEquipment().Sum(Function(x) x.GetCounter(Counters.ATTACK_CAP))
    End Function
    <Extension>
    Friend Function GetDefend(character As ICharacter) As Integer
        Return character.GetCounter(Counters.DEFEND) + character.GetEquipment().Sum(Function(x) x.GetCounter(Counters.DEFEND))
    End Function
    <Extension>
    Friend Function GetDefendCap(character As ICharacter) As Integer
        Return character.GetCounter(Counters.DEFEND_CAP) + character.GetEquipment().Sum(Function(x) x.GetCounter(Counters.DEFEND_CAP))
    End Function
#Region "Equipment"
    <Extension>
    Public Function HasEquipment(character As ICharacter) As Boolean
        Return character.GetYokage(Yokages.EQUIPMENT).Any()
    End Function
    <Extension>
    Public Function GetEquipment(character As ICharacter) As IEnumerable(Of IItem)
        Return character.GetYokage(Yokages.EQUIPMENT).Select(Function(x) character.World.GetItem(x))
    End Function
    <Extension>
    Function CanEquip(character As ICharacter, item As IItem) As Boolean
        Return item.HasCounter(Counters.EQUIP_FLAGS) AndAlso
            ((item.GetCounter(Counters.EQUIP_FLAGS) And
                character.GetEquipment().Aggregate(
                    0,
                    Function(x, y) x Or y.GetCounter(Counters.EQUIP_FLAGS))) = 0)
    End Function
    <Extension>
    Function CanUnequip(character As ICharacter, item As IItem) As Boolean
        Return item.HasCounter(Counters.EQUIP_FLAGS) AndAlso character.GetYokage(Yokages.EQUIPMENT).Contains(item.EntityId)
    End Function
    <Extension>
    Sub Equip(character As ICharacter, item As IItem)
        item.Container = Nothing
        character.AddToYokage(Yokages.EQUIPMENT, item.EntityId)
    End Sub
    <Extension>
    Sub Unequip(character As ICharacter, item As IItem)
        character.RemoveFromYokage(Yokages.EQUIPMENT, item.EntityId)
        item.Container = character.Inventory
    End Sub
#End Region
End Module
