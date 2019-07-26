using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class PullData : MonoBehaviour
{
    public Text my_text;
    public InputField myInputField;
    string str;
    string str2;
    string data;


    public void WriteString()
    {
        
        str = my_text.GetComponent<Text>().text;
        str2 = myInputField.GetComponent<InputField>().text;
        data = str + ": " + str2;
         string path = Application.dataPath + "/KidsShoeChoices.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(data);

                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(data);

                    sw.Close();
                }
            }
    }
}
