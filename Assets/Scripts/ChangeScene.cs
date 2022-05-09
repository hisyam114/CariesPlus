using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static string choose;

     public void btn_change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
        
    }

    public void LoadCanvas(string input){
        ChangeScene.choose = input;
        SceneManager.LoadScene("Definition Class");
    }
    
    public void LoadCanvasAR(string input){
        ChangeScene.choose = input;
        SceneManager.LoadScene("AR");
    }

    public void exit(){
         Application.Quit();
    }
}
