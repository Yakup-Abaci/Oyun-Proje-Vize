using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAndCamera_sc : MonoBehaviour
{
   
    // Start is called before the first frame update
    [SerializeField] private GameObject panelMain;
    [SerializeField] private GameObject panelAbout;
    [SerializeField] private GameObject panelPaused;

    public int isStarted=0;
    public int isPaused=0;

    void Start()
    {   
        Time.timeScale=0f;
        panelAbout.transform.gameObject.SetActive(false);
        panelPaused.transform.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        onPauseHandler();
    }

    public void startGame(){
        Time.timeScale=1f;
        isStarted=1;
        panelMain.transform.gameObject.SetActive(false);
        
        
    }

    public void openAbout(){
        panelMain.transform.gameObject.SetActive(false);
        panelAbout.transform.gameObject.SetActive(true);
    }

    public void closeAbout(){
        panelMain.transform.gameObject.SetActive(true);
        panelAbout.transform.gameObject.SetActive(false);
    }

    public void pauseGame(){
        if(isStarted==1){
            isPaused=1;
            Time.timeScale=0f;
            panelPaused.transform.gameObject.SetActive(true);
            
        }
    }

    public void resumGame(){
        if(isStarted==1){
            isPaused=0;
            Time.timeScale=1f;
            panelPaused.transform.gameObject.SetActive(false);
           
        }
    }

   public void onPauseHandler(){
     if (Input.GetKeyDown(KeyCode.Space)){
            resumGame();
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            //pauseGame();
            if(isPaused==1){
            resumGame();
            }
            else if(isPaused==0){
            pauseGame();
            }
        }
   }
}