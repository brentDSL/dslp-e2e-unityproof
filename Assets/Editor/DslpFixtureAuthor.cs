using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// One-shot fixture authoring (run once with -executeMethod DslpFixtureAuthor.Author):
/// creates the single scene carrying the DslpBuildProof component, registers it
/// in the build settings and names the product. The committed fixture is what
/// this produced; it is kept so the fixture's origin is reproducible.
/// </summary>
public static class DslpFixtureAuthor
{
    public static void Author()
    {
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        var proof = new GameObject("DslpBuildProof");
        proof.AddComponent<DslpBuildProof>();
        AssetDatabase.CreateFolder("Assets", "Scenes");
        const string scenePath = "Assets/Scenes/Main.unity";
        EditorSceneManager.SaveScene(scene, scenePath);
        EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(scenePath, true) };
        PlayerSettings.companyName = "DevStreamLabs";
        PlayerSettings.productName = "dslp-e2e-unityproof";
        AssetDatabase.SaveAssets();
        Debug.Log("DslpFixtureAuthor: authored " + scenePath);
    }
}
