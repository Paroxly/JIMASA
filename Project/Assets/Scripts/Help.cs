using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour
{
    public void HelpControls()
    {
        SceneManager.LoadScene("HelpScene");
    }
}
