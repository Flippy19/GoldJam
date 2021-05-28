using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    public int sceneIndex;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 6)
        SceneManager.LoadScene(sceneIndex);
    }
}
