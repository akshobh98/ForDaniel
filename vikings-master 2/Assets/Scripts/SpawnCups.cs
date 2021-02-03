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

public class SpawnCups : MonoBehaviour
{   
    public Move reference;
    public Transform prefab;
    public Transform[] cupsArray = new Transform[4];
    //public Button user_click;
    int numberofcups = PlayerPrefs.GetInt("cups");
    void Start(){
        //user_click.onClick.AddListener(SpawnCupsboi);
        SpawnCupsboi();
    }

    public void SpawnCupsboi()
    { 
            if(numberofcups == 2){
                cupsArray[0] = Instantiate(prefab, new Vector3(-50, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[0].name = "cup1";
                cupsArray[1] = Instantiate(prefab, new Vector3(50, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[1].name = "cup2";
            } else if(numberofcups == 3){
                cupsArray[0] = Instantiate(prefab, new Vector3(0, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[0].name = "cup1";
                cupsArray[1] = Instantiate(prefab, new Vector3(-76, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[1].name = "cup2";
                cupsArray[2] = Instantiate(prefab, new Vector3(76, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[2].name = "cup3";
            } else if(numberofcups == 4){
                cupsArray[0] = Instantiate(prefab, new Vector3(-25, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[0].name = "cup1";
                cupsArray[1] = Instantiate(prefab, new Vector3(25, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[1].name = "cup2";
                cupsArray[2] = Instantiate(prefab, new Vector3(-75, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[2].name = "cup3";
                cupsArray[3] = Instantiate(prefab, new Vector3(75, 140, -270), Quaternion.Euler(new Vector3(0, 0, 180)));
                cupsArray[3].name = "cup4";
            }   
            reference.fuckUnity(cupsArray);
    }  

}

    

