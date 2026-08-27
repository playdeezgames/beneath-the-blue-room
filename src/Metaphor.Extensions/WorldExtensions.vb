Imports System.Runtime.CompilerServices
Imports Metaphor.Persistence

Public Module WorldExtensions
#Region "Pier"
    <Extension>
    Private Sub CreatePier(world As IWorld, context As IInitializationContext)
        world.CreateLocation(
            LocationSubtypes.PIER,
            "Pier",
            LocationInitializationExtensions.InitializePier(context.ChosenName))
    End Sub
#End Region
    <Extension>
    Public Sub Initialize(world As IWorld, context As IInitializationContext)
        world.Clear()
        world.CreatePier(context)
        world.AddMessage("Welcome to Beneath the Blue Room")
        world.Avatar.Look()
    End Sub
End Module
