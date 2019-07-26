using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSizes : MonoBehaviour
{
    float size;
    public Transform shoeTransform;
	Vector3 scale = new Vector3();


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        size = PlayerPrefs.GetFloat("size");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
		
		size = PlayerPrefs.GetFloat("size");
        float newVal = (float)(0.6848 * 0.5 * size / 100);
        foreach (Transform child in shoeTransform)
        {
            scale.Set(newVal, newVal, newVal);
            child.localScale = scale;
            newVal += (float)0.1;
        }
    }
}
