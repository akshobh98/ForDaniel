/* Vikings - Shell Game
 * 
 * Sprint 1
 * 
 * framework for openning patient records and
 * allowing the game to write results to the
 * file as it generates results.
 * 
 */
 using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

//created class used with the search id textfield and button
public class GetInputOnClick : MonoBehaviour
{
    //in game assests to allow user input
    public Button user_click;
    public InputField user_input;

    //runs once a frame to record inputs
    private void Start()
    {
        //if the button is clicked call the function handler
        user_click.onClick.AddListener(GetInputOnClickHandler);
    }
    //handler to execute what happens when a click on the button is made
    public void GetInputOnClickHandler()
    {
        //debug message to imform that the input was recieved
        UnityEngine.Debug.Log("Search ID: " + user_input.text);

        //creating a string that will be used as the files path
        //goes to the directory, adds the user inputted id and adds the csv extension.
        string path = "Assets/Data/" + user_input.text + ".csv";

        //sets up the creathed string as a write path
        StreamWriter writer = new StreamWriter(path, true);

        //write a test line to the file
        writer.WriteLine("Test,TEST,tEST");
        //close the write path
        writer.Close();


    }
}
