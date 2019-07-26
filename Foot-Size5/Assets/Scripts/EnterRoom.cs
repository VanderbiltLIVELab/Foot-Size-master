using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterRoom : MonoBehaviour
{
	
    public InputField footSize;
    public static float size;
    //public Transform shoeTransform;
    //public List<Transform> childs  = new List<Transform>();


    public void ChangeScene(string scene)
    {
		DontDestroyOnLoad(footSize);
        
        size = float.Parse(footSize.text);
        PlayerPrefs.SetFloat("size", size);
        PlayerPrefs.Save();
		SceneManager.LoadScene(scene);
    }

  
}
