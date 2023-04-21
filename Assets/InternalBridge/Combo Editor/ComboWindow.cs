using System.Collections.Generic;
using Unity.GraphToolsFoundation.Editor;
using UnityEditor;

internal class ComboWindow : GraphViewEditorWindow
{
    [MenuItem("GTF/Samples/Combo Editor")]
    public static void ShowWindow() => GetWindow<ComboWindow>();

    [InitializeOnLoadMethod]
    static void RegisterTool()
    {
        ShortcutHelper.RegisterDefaultShortcuts<ComboWindow>(ComboStencil.GraphName);
    }


    protected override bool CanHandleAssetType(GraphAsset asset)
    {
        return asset is ComboAsset;
    }

    protected override BlankPage CreateBlankPage()
    {
        var onboardingProviders = new List<OnboardingProvider>();
        onboardingProviders.Add(new ComboOnBoardingProvider());
        return new BlankPage(this.GraphTool, new[] { new ComboOnBoardingProvider() });
    }

    protected override GraphView CreateGraphView()
    {
        return new ComboGraphView(this, GraphTool, "ComboView");
    }
}