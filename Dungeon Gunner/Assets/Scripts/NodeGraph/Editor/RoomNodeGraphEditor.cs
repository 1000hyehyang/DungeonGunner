using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RoomNodeGraphEditor : EditorWindow
{
    [MenuItem("Room Node Graph Ediotr", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]

    private static void GraphWindow()
    {
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
    }
}
