using System.IO;
using UnityEngine;

/// <summary>
/// The e2e proof component (dslp-e2e-unityproof). On the first frame the
/// player writes a fixed marker to a file in its working directory, logs it,
/// and quits — so a headless run of the built player leaves evidence that a
/// real, working player came out of the build (P-22).
/// </summary>
public class DslpBuildProof : MonoBehaviour
{
    public const string Marker = "dslp unityproof ok";
    public const string MarkerFile = "dslp_unityproof.txt";

    private void Start()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), MarkerFile);
        File.WriteAllText(path, Marker + "\n");
        Debug.Log(Marker);
        Application.Quit(0);
    }
}
// webhook-build push
// webhook-build push
// webhook-build push
// webhook-build push
// webhook-build push
// webhook-build push
