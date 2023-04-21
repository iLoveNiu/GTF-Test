using Unity.CommandStateObserver;
using Unity.GraphToolsFoundation.Editor;
using UnityEngine.UIElements;


internal class ComboOnBoardingProvider : OnboardingProvider
{
    public override VisualElement CreateOnboardingElements(ICommandTarget commandTarget)
    {
        var template = new GraphTemplate<ComboStencil>(ComboStencil.GraphName);
        return AddNewGraphButton<ComboAsset>(commandTarget, template, "promptTitle", "Button Text", "FFFFF");
    }
}