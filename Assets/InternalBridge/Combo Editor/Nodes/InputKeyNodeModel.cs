using System;
using Unity.GraphToolsFoundation.Editor;
using UnityEngine;

[Serializable]
[LibraryItem(typeof(ComboStencil), SearchContext.Graph, "Combo/State/Input Key")]
internal class InputKeyNodeModel : NodeModel
{
    public override string Title => "Input Key";

    [SerializeField] private PlayerInputType m_type = PlayerInputType.Attack1;
    [SerializeField] private PlayerInputState m_state = PlayerInputState.Press;

    protected override void OnDefineNode()
    {
        this.AddDataOutputPort<bool>("Result");
    }

    [Serializable]
    public enum PlayerInputType
    {
        Attack1,
        Attack2
    }

    [Serializable]
    public enum PlayerInputState
    {
        Press,
        Release,
    }
}