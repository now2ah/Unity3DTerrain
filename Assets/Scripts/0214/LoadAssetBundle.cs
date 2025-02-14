using System.Collections;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadAssetBundle : MonoBehaviour
{
    public Image image;
    string path = "./Bundle/assetbundle01";
    string webPath = "https://drive.usercontent.google.com/u/0/uc?id=1p0-Osjx6nmGI5lw-kOQNNr2iO4ZQuJDk&export=download";

    IEnumerator LoadAssetBundleCoroutine(string path)
    {
        //AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(path));
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(path);
        yield return request;

        AssetBundle bundle = request.assetBundle;

        //Object[] objs = bundle.LoadAllAssets();

        GameObject[] prefabs = bundle.LoadAllAssets<GameObject>();

        foreach(var gameObj in prefabs)
        {
            Instantiate(gameObj);
        }
    }

    IEnumerator LoadAssetBundleWebCoroutine(string webPath)
    {
        UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(webPath);
        yield return uwr.SendWebRequest();

        DownloadHandlerTexture handler = (DownloadHandlerTexture)uwr.downloadHandler;

        Texture2D texture = handler.texture;

        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero, 1.0f);
        image.sprite = sprite;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine(LoadAssetBundleCoroutine(path));
        StartCoroutine(LoadAssetBundleWebCoroutine(webPath));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
