using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSizes : MonoBehaviour
{
    public static float size;
    public Transform shoeTransform;
	Vector3 scale = new Vector3();



    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        size = PlayerPrefs.GetFloat("size");
        float increment = (float) 0.5;
        float newVal;
        
        foreach (Transform child in shoeTransform)
        {
            newVal = (float)(0.6848 * increment * size / 100);
            scale.Set(newVal, newVal, newVal);
            child.localScale = scale;
            increment += (float) 0.1;
            
        }
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
