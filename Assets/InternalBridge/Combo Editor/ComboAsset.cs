using System;
using Unity.GraphToolsFoundation.Editor;
using UnityEditor;
using UnityEditor.Callbacks;

internal class ComboAsset : GraphAsset
{
    protected override Type GraphModelType => typeof(ComboGraphModel);


    [MenuItem("Assets/Create/Combo")]
    public static void CreateGraph(MenuCommand command)
    {
        const string path = "Assets";
        var template = new GraphTemplate<ComboStencil>(ComboStencil.GraphName);
        CommandDispatcher dispatcher = null;

        if (EditorWindow.HasOpenInstances<ComboWindow>())
        {
            var window = EditorWindow.GetWindow<ComboWindow>();
            if (window != null)
            {
            }
        }

        GraphAssetCreationHelpers.CreateInProjectWindow<ComboAsset>(template, null, path);
    }

    [OnOpenAsset(1)]
    public static bool OpenGraphAsset(int instanceId, int line)
    {
        if (EditorUtility.InstanceIDToObject(instanceId) is ComboAsset graphAssetModel)
        {
            var window = GraphViewEditorWindow.FindOrCreateGraphWindow<ComboWindow>();
            window.SetCurrentSelection(graphAssetModel, GraphViewEditorWindow.OpenMode.OpenAndFocus);
            return window != null;
        }

        return false;
    }
}