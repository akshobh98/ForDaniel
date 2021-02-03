using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class CupsMove : MonoBehaviour
{
    public Transform prefab;
    public Transform cup1;
    public Transform cup2;
    public Transform cup3;
    public Transform cup4;
    public Button user_click;
    public float speed = 1;
    int numberofcups;

    // Start is called before the first frame update
    void Start()
    {
        numberofcups = PlayerPrefs.GetInt("cups");
        user_click.onClick.AddListener(GetInputOnClickHandler);  
    }

    public void GetInputOnClickHandler(){
        if(numberofcups == 2){
            cup2.transform.Translate(speed * Vector3.right * -10 * Time.deltaTime , Space.World);
            if(cup2.transform.position.x <= 50 && cup2.transform.position.x > 0){
                cup2.transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
            }
            if(cup2.transform.position.x <= 0){
                cup2.transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
            }
            if(cup2.transform.position.x <= -50){
                speed = 0;
            }
            cup1.transform.Translate(speed * Vector3.right * 10 * Time.deltaTime, Space.World);
            if(cup1.transform.position.x >= -50 && cup1.transform.position.x < 0){
                cup1.transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x >= 0){
                cup1.transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x >= 50){
                speed = 0;
            }
        }
        if(numberofcups == 3){
            cup2.transform.Translate(speed * Vector3.right * 10 * Time.deltaTime, Space.World);
            if(cup2.transform.position.x >= -76 && cup2.transform.position.x > -38){
                cup2.transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
            }
            if(cup2.transform.position.x <= -38){
                cup2.transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
            }
            if(cup2.transform.position.x >= 0){
                speed = 0;
            }
            cup1.transform.Translate(speed * Vector3.right * -10 * Time.deltaTime, Space.World);
            if(cup1.transform.position.x <= 0 && cup1.transform.position.x < -38){
                cup1.transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x >= -38){
                cup1.transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x <= -76){
                speed = 0;
            }
        }
        if(numberofcups == 4){
            cup3.transform.Translate(speed * Vector3.right * 10 * Time.deltaTime, Space.World);
            if(cup3.transform.position.x >= -75 && cup3.transform.position.x > -50){
                cup3.transform.Translate(speed * Vector3.forward * -10 * Time.deltaTime , Space.World);
            }
            if(cup3.transform.position.x <= -50){
                cup3.transform.Translate(speed * Vector3.forward * 10 * Time.deltaTime , Space.World);
            }
            if(cup3.transform.position.x >= -25){
                speed = 0;
            }
            cup1.transform.Translate(speed * Vector3.right * -10 * Time.deltaTime, Space.World);
            if(cup1.transform.position.x <= -25 && cup1.transform.position.x < -50){
                cup1.transform.Translate(speed * Vector3.forward * 10 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x >= -50){
                cup1.transform.Translate(speed * Vector3.forward * -10 * Time.deltaTime , Space.World);
            }
            if(cup1.transform.position.x <= -75){
                speed = 0;
            }
            
        }    
        
    }
    
}
