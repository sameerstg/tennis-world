using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour
{
    public Renderer lavaRender;
    //public int materialIndex = 0;
    public Vector2 uvAnimationRate = new Vector2(1.0f, 0.0f);
    public string textureName = "_MainTex";

    Vector2 uvOffset = Vector2.zero;
    float time;
    private void Awake()
    {
        if (!lavaRender.enabled)
        {
            this.enabled = false;
        }

    }
    void LateUpdate()
    {
        time += Time.deltaTime;
        uvOffset += (uvAnimationRate * Mathf.Sin(time));
        lavaRender.sharedMaterial.SetTextureOffset(textureName, uvOffset);
    }
}