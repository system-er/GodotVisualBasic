Imports Godot

Public Class GodotVisualBasic

    Private node2d As Node2D

    Public Sub New(n As Node2D)
        node2d = n
    End Sub

    Public Sub _Ready()
        GD.Print("hello world from visualbasic from node ", node2d.Name)
    End Sub

    Public Sub _Process()

    End Sub

End Class
