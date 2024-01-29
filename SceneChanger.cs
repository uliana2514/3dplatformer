using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
 
public class SceneChanger : MonoBehaviour
{
    //Имя сцены, которую нужно перезапустить
    public string sceneName;
 

    void OnTriggerEnter( )
    {
         //Перезапуск сцены
        EditorSceneManager.LoadScene(sceneName);
    }
}