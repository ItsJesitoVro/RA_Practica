using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagen : MonoBehaviour
{
    public Texture2D[] frames;
    public int fps = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * fps) % frames.Length;
        //GetComponent<Material>().mainTexture = frames[index];
        GetComponent<Renderer>().material.mainTexture = frames[index];
    }
}
