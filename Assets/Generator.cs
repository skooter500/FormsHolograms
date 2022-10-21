using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int rings = 50;
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Awake()
    {
        for(int ring = 1 ; ring <= rings ; ring ++)
        {              
            int count = (int) Mathf.Round(Mathf.PI * 2.0f * ring);
            float theta = Mathf.PI * 2.0f / (float) count;
    
            for(int i = 0 ; i < count ; i ++)
            {
                Vector3 pos = new Vector3(
                    Mathf.Sin(theta * i) * ring
                    ,Mathf.Cos(theta * i) * ring
                    , 0
                );

                pos = transform.TransformPoint(pos);
                GameObject dod = GameObject.Instantiate(prefab, pos, transform.rotation);
                dod.transform.parent = this.transform;
                //dod.AddComponent<Rigidbody>();
                dod.GetComponent<Renderer>().material.color = Color.HSVToRGB(ring / (float) rings, 1.0f, 1.0f);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
