using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class DoorAOpen : MonoBehaviour
{
    PickupController pickupController;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        pickupController = other.GetComponent<PickupController>();
        if (pickupController.silverKey && pickupController.goldKey)
        {
            StartCoroutine(OpenDoor());
            
        }
        
    }

    IEnumerator OpenDoor()
    {
        GetComponent<Animator>().SetTrigger("DoorATrigger");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Main Scene");
    }
}