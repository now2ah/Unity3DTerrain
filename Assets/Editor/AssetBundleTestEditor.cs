using UnityEditor;
using UnityEngine;
using System.IO;
using Codice.Client.Common.GameUI;

public class AssetBundleTestEditor : Editor
{
    [MenuItem("Asset Bundle/Build")]
    public static void AssetBundleBuild()
    {
        string directory = "./Bundle";

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        BuildPipeline.BuildAssetBundles(directory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        EditorUtility.DisplayDialog("Asset Bundle Build", "Asset Bundle Build completed.", "OK");
    }

}
