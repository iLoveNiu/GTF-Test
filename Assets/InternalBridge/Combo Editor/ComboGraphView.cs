using Unity.GraphToolsFoundation.Editor;
using UnityEngine.UIElements;

internal class ComboGraphView : GraphView
{
    public ComboGraphView(GraphViewEditorWindow window, BaseGraphTool graphTool, string graphViewName,
        GraphViewDisplayMode displayMode = GraphViewDisplayMode.Interactive) : base(window, graphTool, graphViewName,
        displayMode)
    {
    }

    protected override void BuildContextualMenu(ContextualMenuPopulateEvent evt)
    {
        base.BuildContextualMenu(evt);
        evt.menu.AppendAction("Create Test", menuAction => { });
    }
}