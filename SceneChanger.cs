using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
 
public class SceneChanger : MonoBehaviour
{
    //��� �����, ������� ����� �������������
    public string sceneName;
 

    void OnTriggerEnter( )
    {
         //���������� �����
        EditorSceneManager.LoadScene(sceneName);
    }
}