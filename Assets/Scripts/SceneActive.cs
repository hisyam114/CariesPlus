using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneActive : MonoBehaviour
{
    // Start is called before the first frame update
 public static string choose;
 public void LoadGame(string input){
     SceneActive.choose = input;

     SceneManager.LoadScene("Definition Class");
 }   
}
