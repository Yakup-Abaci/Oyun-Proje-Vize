using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{

    public float yon_x;
    public GameObject silah;
    public GameObject Hedef;
    public float dönme_açısı;
    public float hedef=0;
    public float sınır=0;
    public float falso=0f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,4.1f,0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        oyuncu oyun = silah.GetComponent<oyuncu>();
        transform.rotation = Quaternion.Euler(90,dönme_açısı,0);

        //transform.Translate(new Vector3(0,1,0)*0.01f);
        //transform.Translate(new Vector3(1,0,0)*artış);
        hedef=yon_x;
        if(yon_x>0){

            transform.Translate(falso,1f,0);
            if(yon_x<1.0f){
                hedef=1f;
            }
            else if(1f<=yon_x && yon_x<2f){
                hedef=3f;
            }
            else if(2f<=yon_x && yon_x<3f){
                hedef=5f;
            }
            else if(3f<=yon_x && yon_x<4f){
                hedef=7f;
            }
            else if(4f<=yon_x && yon_x<5f){
                hedef=9f;
            }
            else if(5f<=yon_x && yon_x<6f){
                hedef=11f;
            }
            else if(6f<=yon_x && yon_x<7f){
                hedef=13f;
            }
            else if(7f<=yon_x && yon_x<8f){
                hedef=15f;
            }
            else if(8f<=yon_x && yon_x<9f){
                hedef=17f;
            }
            else if(9f<=yon_x && yon_x<10f){
                hedef=19f;
            }
            else{
                hedef=24f;
            }
            if(transform.position.x<=hedef && sınır ==0 ){
                falso +=0.05f;
            }
            else {
                sınır=1;
                falso -=0.01f;
            }

    }
    
    else if(yon_x<0) {
    transform.Translate(falso,1f,0);
    
        if(-1.0f<yon_x){
                hedef=-1f;
            }
            else if(yon_x<=-1f && -2f<yon_x){
                hedef=-3f;
            }
            else if(yon_x<=-2f && -3f<yon_x){
                hedef=-5f;
            }
            else if(yon_x<=-3f && -4f<yon_x){
                hedef=-7f;
            }
            else if(yon_x<=-4f && -5f<yon_x){
                hedef=-9f;
            }
            else if(yon_x<=-5f && -6f<yon_x){
                hedef=-11f;
            }
            else if(yon_x<=-6f && -7f<yon_x){
                hedef=-13f;
            }
            else if(yon_x<=-7f && -8f<yon_x){
                hedef=-15f;
            }
            else if(yon_x<=-8f && -9f<yon_x){
                hedef=-17f;
            }
            else if(yon_x<=-9f && -10f<yon_x){
                hedef=-19f;
            }
            else{
                hedef=-12f;
            }
            if(transform.position.x>=hedef && sınır ==0 ){
                falso -=0.05f;
            }
            else {
                sınır=1;
                falso +=0.01f;
            }

    }
    else{
        Destroy(gameObject);
    }
    if(transform.position.z>1000f || transform.position.z<-1000f){
        Destroy(this.gameObject);
    }
     
    }
    public void hareket(Quaternion yon,float yon2){
        //atışhakkı();
        dönme_açısı=yon[1]*100;
        yon_x=yon2;
        
    }
    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Vurdu "+ other.transform.name);
        if(other.tag == "hedef"){
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            hedef hedef_tahtası = Hedef.GetComponent<hedef>();
            hedef_tahtası.yeni_hedef();
        }
        
    }

 
 
}

