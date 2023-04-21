using System;
using Unity.GraphToolsFoundation.Editor;

[Serializable]
[LibraryItem(typeof(ComboStencil), SearchContext.Graph, "Combo/Condition")]
internal class ConditionNodeModel : NodeModel
{
    public override string Title => "Condition Check";

    protected override void OnDefineNode()
    {
        this.AddExecutionInputPort("Input ", orientation: PortOrientation.Vertical);
        this.AddExecutionOutputPort("Output ", orientation: PortOrientation.Vertical);

        this.AddDataInputPort<bool>("Precondition");
        this.AddDataOutputPort<bool>("Result");
    }
}