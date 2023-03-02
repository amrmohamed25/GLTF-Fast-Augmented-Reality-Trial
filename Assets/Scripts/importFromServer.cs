using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importFromServer : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        var gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        gltf.Url = "https://firebasestorage.googleapis.com/v0/b/ar-furniture-7fb69.appspot.com/o/victorian_chair.glb?alt=media&token=5d19e19d-1e8c-4865-9b5c-03e54fc7e49e";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
