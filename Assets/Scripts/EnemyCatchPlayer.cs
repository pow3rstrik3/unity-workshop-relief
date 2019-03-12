using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCatchPlayer : MonoBehaviour
{
    public Transform player;
    public float catchDistance;

    public string sceneToLoad;

    void Update()
    {

        if (AbleToCatchPlayer())
        {
            Debug.Log("Caught!");
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private bool AbleToCatchPlayer()
    {
        return (Vector3.Distance(transform.position, player.position) <= catchDistance);
    }
}