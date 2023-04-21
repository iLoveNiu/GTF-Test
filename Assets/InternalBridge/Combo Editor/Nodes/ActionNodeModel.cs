using System;
using Unity.GraphToolsFoundation;
using Unity.GraphToolsFoundation.Editor;
using UnityEngine;

[Serializable]
[LibraryItem(typeof(ComboStencil), SearchContext.Graph, "Combo/Action/Action")]
internal class ActionNodeModel : NodeModel
{
    public override string Title => "Action Node";

    [SerializeField] public string m_ActionName;


    public override bool HasProgress => true;

    protected override void OnDefineNode()
    {
        AddInputPort("Input", PortType.Data, TypeHandle.Unknown, null, PortOrientation.Horizontal,
            PortModelOptions.NoEmbeddedConstant);
    }
}