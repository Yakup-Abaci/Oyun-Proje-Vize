using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedef : MonoBehaviour
{
    public float randomx;
    public float randomy;
    public GameObject Silah;
    


    // Start is called before the first frame update
    void Start()
    {
        randomx=Random.Range(-50f,50f);
        randomy=Random.Range(250f,100f);
        oyuncu oyun = Silah.GetComponent<oyuncu>();
        transform.position=new Vector3(randomx,4.1f,randomy);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Vurdu "+ other.transform.name);
        if(other.tag == "mermi"){
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            
        }
    }
    public void yeni_hedef(){
        transform.position=new Vector3(randomx,4.1f,15);
        Instantiate(this.gameObject , transform.position , Quaternion.identity);
    }
    

}
