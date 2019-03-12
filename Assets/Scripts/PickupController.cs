using UnityEngine;

public class PickupController : MonoBehaviour
{
    public bool silverKey = false;
    public bool goldKey = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SilverKey"))
        {
            this.silverKey = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("GoldKey"))
        {
            this.goldKey = true;
            other.gameObject.SetActive(false);
        }
    }
}
