using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SizeController : MonoBehaviour
{
    public GameObject obj;
    private Vector3 scaleChange;
    public GameObject text;
    private bool sword;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.75f, -0.75f, -0.75f);
        obj.transform.localScale += scaleChange;
        text.transform.localScale -= scaleChange*3.5f;
        sword = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
