using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    public Color col;
    public float r;
    public float g;
    public float b;
    public float alpha;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    { 
        rend = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Starting Conditions
        if (b == 0.0f)
        {
            r += 0.01f;
        }

        if (r > 5.0f)
        {
            g += 0.01f;
        }

        if (g > 5.0f)
        {
            b += 0.01f;

            r = 0.0f;
        }

        col = new Color(r, g, b);
        rend.material.color = col;

    }
}
