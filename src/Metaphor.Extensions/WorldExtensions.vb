Imports System.Runtime.CompilerServices
Imports Metaphor.Persistence

Public Module WorldExtensions
#Region "Blue Room"
    <Extension>
    Private Function CreateBlueRoom(world As IWorld, context As IInitializationContext) As IMap
        Return world.CreateMap(MapSubtypes.BLUE_ROOM, "The Blue Room", (Grimoire.ROOM_COLUMNS, Grimoire.ROOM_ROWS), MapInitializationExtensions.InitializeBlueRoom(context))
    End Function
#End Region
    <Extension>
    Public Sub Initialize(world As IWorld, context As IInitializationContext)
        world.Clear()
        world.CreateBlueRoom(context)
        world.AddMessage("Welcome to Beneath the Blue Room")
        world.Avatar.Look()
    End Sub
End Module
