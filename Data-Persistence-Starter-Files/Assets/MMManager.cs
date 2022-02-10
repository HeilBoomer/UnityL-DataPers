using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MMManager : MonoBehaviour
{
    public InputField nameField;

    public void NextScene()
    {
        PlayerPrefs.SetString("name",nameField.text);
        SceneManager.LoadScene("main");
    }
}
