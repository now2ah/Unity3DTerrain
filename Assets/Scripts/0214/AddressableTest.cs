using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableTest : MonoBehaviour
{
    public AssetReferenceGameObject assetReference;
    GameObject gO;
    IEnumerator InitializeCoroutine()
    {
        var init = Addressables.InitializeAsync(false);
        yield return init;
    }

    public void OnCreateGameObject()
    {
        assetReference.InstantiateAsync().Completed += (obj) =>
        {
            gO = obj.Result;
        };
    }

    public void OnReleaseGameObject()
    {
        Addressables.ReleaseInstance(gO);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(InitializeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            OnCreateGameObject();

        if (Input.GetKeyDown(KeyCode.DownArrow))
            OnReleaseGameObject();

    }
}
