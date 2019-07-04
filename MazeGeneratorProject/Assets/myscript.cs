using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour
{
    Renderer renderer;
    Texture texture1;
    Color color1;
    float size = 1.0f;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        texture1 = (Texture)Resources.Load("QS-Grass2-Pack-6.1");
        color1 = renderer.material.color;
        renderer.material.mainTexture = texture1;
        renderer.material.color = Color.white;
    }

    void Update()
    {
        transform.Rotate(1f, 1f, 0.1f);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            size += 0.01f;
            renderer.material.mainTextureScale =
                    new Vector2(size, size);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            size -= 0.01f;
            if (size < 0) { size = 0f; }
            renderer.material.SetTextureScale("_MainTex",
                    new Vector2(size, size));
        }
    }
}
