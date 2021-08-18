using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMajorBook : MonoBehaviour
{
    public void to_majorbook()
    {
        SceneManager.LoadScene("page");
    }

    public void to_cybercampus()
    {
        SceneManager.LoadScene("cybercampus");
    }

    public void to_zoom()
    {
        SceneManager.LoadScene("stage3_1");
    }

    public void to_desk()
    {
        SceneManager.LoadScene("Desk");
    }
}
