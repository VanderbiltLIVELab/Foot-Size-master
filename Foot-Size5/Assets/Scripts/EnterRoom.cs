using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterRoom : MonoBehaviour
{
	
    public InputField footSize;
    public static float size;

    public void ChangeScene(string scene)
    {   
        size = float.Parse(footSize.text);
        PlayerPrefs.SetFloat("size", size);
        PlayerPrefs.Save();
		SceneManager.LoadScene(scene);
    }
  
}
