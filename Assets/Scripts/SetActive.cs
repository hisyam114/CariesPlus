using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    public GameObject kelas1, kelas2, kelas3, kelas4, kelas5, kelas6;
    // Start is called before the first frame update
    void Start()
    {
        if(ChangeScene.choose.ToString().Equals("Kelas 1")){
            kelas1.SetActive(true);
        }else if(ChangeScene.choose.ToString().Equals("Kelas 2")){
            kelas2.SetActive(true);
        }else if(ChangeScene.choose.ToString().Equals("Kelas 3")){
            kelas3.SetActive(true);
        }else if(ChangeScene.choose.ToString().Equals("Kelas 4")){
            kelas4.SetActive(true);
        }else if(ChangeScene.choose.ToString().Equals("Kelas 5")){
            kelas5.SetActive(true);
        }else if(ChangeScene.choose.ToString().Equals("Kelas 6")){
            kelas6.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
