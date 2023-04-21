using System;
using Unity.GraphToolsFoundation.Editor;

[Serializable]
[LibraryItem(typeof(ComboStencil), SearchContext.Graph, "Combo/Root")]
internal class ComboRootNodeModel : NodeModel
{
    public override string Title => "Combo Root";


    protected override void OnDefineNode()
    {
        this.AddExecutionOutputPort("Next ", orientation: PortOrientation.Vertical);
        this.SetCapability(Unity.GraphToolsFoundation.Editor.Capabilities.Movable, false);
    }
}