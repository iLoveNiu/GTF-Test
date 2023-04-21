using Unity.GraphToolsFoundation.Editor;

internal class ComboStencil : Stencil
{
    public const string GraphName = "Combo Graph Name";


    public override bool CanPasteNode(AbstractNodeModel originalModel, GraphModel graph)
    {
        return true;
    }

    public override bool CanPasteVariable(VariableDeclarationModel originalModel, GraphModel graph)
    {
        return true;
    }
}