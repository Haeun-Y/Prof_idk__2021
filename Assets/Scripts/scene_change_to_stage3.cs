using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change_to_stage3 : MonoBehaviour
{
    public void load_scene()
    {
        SceneManager.LoadScene("stage3_교수님방");
    }

    public void to_stage3()
    {
        SceneManager.LoadScene("stage3-1");
    }

    public void to_stage3_2_cut()
    {
        SceneManager.LoadScene("cut_scene_3-1_3-2");
    }

    public void to_stage3_2()
    {
        SceneManager.LoadScene("stage3-2");
    }

    public void to_stage3_3_cut()
    {
        SceneManager.LoadScene("cut_scene_3-2_3-3");
    }
}
