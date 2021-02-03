using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class Move : MonoBehaviour
{
    public Transform[] notCupsArray = new Transform[4];
    public float speed = 1;
    public Button user_click;
    //public SpawnCups cups;
    int numberofcups = PlayerPrefs.GetInt("cups");
    /*void discoverCups(){
        cups = GameObject.FindObjectOfType<SpawnCups>();
    }*/
    void Start()
    {
        user_click.onClick.AddListener(Update);
    }

    public void fuckUnity(Transform[] cupsArray){
        for(int i = 0; i < numberofcups; i++){
            notCupsArray[i] = cupsArray[i];
        }
    }

    public void Update(){
       // SpawnCups.SpawnCupsboi(notCupsArray);
            if(numberofcups == 2){
                notCupsArray[1].transform.Translate(speed * Vector3.right * -20 * Time.deltaTime , Space.World);
                if(notCupsArray[1].transform.position.x <= 50 && notCupsArray[1].transform.position.x > 0){
                    notCupsArray[1].transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[1].transform.position.x <= 0){
                    notCupsArray[1].transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[1].transform.position.x <= -50){
                    speed = 0;
                }
                notCupsArray[0].transform.Translate(speed * Vector3.right * 20 * Time.deltaTime, Space.World);
                if(notCupsArray[0].transform.position.x >= -50 && notCupsArray[0].transform.position.x < 0){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x >= 0){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x >= 50){
                    speed = 0;
                }
            }
            if(numberofcups == 3){
                notCupsArray[1].transform.Translate(speed * Vector3.right * 20 * Time.deltaTime, Space.World);
                if(notCupsArray[1].transform.position.x >= -76 && notCupsArray[1].transform.position.x > -38){
                    notCupsArray[1].transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[1].transform.position.x <= -38){
                    notCupsArray[1].transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[1].transform.position.x >= 0){
                    speed = 0;
                }
                notCupsArray[0].transform.Translate(speed * Vector3.right * -20 * Time.deltaTime, Space.World);
                if(notCupsArray[0].transform.position.x <= 0 && notCupsArray[0].transform.position.x < -38){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * 6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x >= -38){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * -6 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x <= -76){
                    speed = 0;
                }
            }
            if(numberofcups == 4){
                notCupsArray[2].transform.Translate(speed * Vector3.right * 20 * Time.deltaTime, Space.World);
                if(notCupsArray[2].transform.position.x >= -75 && notCupsArray[2].transform.position.x > -50){
                    notCupsArray[2].transform.Translate(speed * Vector3.forward * -20 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[2].transform.position.x <= -50){
                    notCupsArray[2].transform.Translate(speed * Vector3.forward * 20 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[2].transform.position.x >= -25){
                    speed = 0;
                }
                notCupsArray[0].transform.Translate(speed * Vector3.right * -20 * Time.deltaTime, Space.World);
                if(notCupsArray[0].transform.position.x <= -25 && notCupsArray[0].transform.position.x < -50){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * 10 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x >= -50){
                    notCupsArray[0].transform.Translate(speed * Vector3.forward * -10 * Time.deltaTime , Space.World);
                }
                if(notCupsArray[0].transform.position.x <= -75){
                    speed = 0;
                }
                
            }  
    }
}
