using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu : MonoBehaviour
{
    // Start is called before the first frame update

    public float yon_x;
    public GameObject mermi;
    public Quaternion x_rotation;
    public GameObject hedef;
    void Start()
    {
        transform.position= new Vector3(0,4.1f,0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        yon_x=Input.GetAxis("Mouse X");
        transform.rotation *=Quaternion.Euler(0,yon_x,0);
        x_rotation=transform.rotation*Quaternion.Euler(0,yon_x,0);
        //Debug.Log(y+" "+yon_x);
        if(x_rotation[1]>0.33f){
            transform.rotation = Quaternion.Euler(0,x_rotation[1]*100,0);
        }
        else if(x_rotation[1]<-0.33f){
            transform.rotation = Quaternion.Euler(0,x_rotation[1]*100,0);
        }
        //Debug.Log(y[1]);
        mermi Mermi=mermi.GetComponent<mermi>();
        
        if (Input.GetMouseButtonDown(0)){
            //Debug.Log(yon_x);

            Mermi.hareket(transform.rotation*Quaternion.Euler(0,yon_x,0),yon_x);
            Instantiate(mermi,transform.position + new Vector3(0,0.1f,0),Quaternion.identity);
            

        }

    }
   

}
