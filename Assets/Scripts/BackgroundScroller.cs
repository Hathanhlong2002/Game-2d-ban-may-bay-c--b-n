using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrolleSpeed=0.5f;
    private float offset;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat=GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime*scrolleSpeed)/10f;
        mat.SetTextureOffset("_MainTex",new Vector2(0,offset));
    }
}
