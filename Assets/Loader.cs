using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        Caching.ClearCache();
        Load();
    }

    private async void Load()
    {
        Addressables.InstantiateAsync("Assets/Cube.prefab");
    }
}