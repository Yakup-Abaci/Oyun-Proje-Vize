using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public GameObject hedef;
    public float[] random = new float[2];
    public float a;
    // Start is called before the first frame update
    void Start()
    {

        hedef Hedef = hedef.GetComponent<hedef>(); 
        a=Hedef.randomx;
        Debug.Log(a);
        transform.position = new Vector3(random[0],4.1f,random[1]+5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
