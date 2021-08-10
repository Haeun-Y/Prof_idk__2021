using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_prof_room : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scenechange()
    {
        SceneManager.LoadScene("prof_room_1");
    }
}
