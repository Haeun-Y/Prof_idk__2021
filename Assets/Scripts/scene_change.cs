using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour
{
    public void load_scene()
    {
        SceneManager.LoadScene("cut_scene");
    }
}
