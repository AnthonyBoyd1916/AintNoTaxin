using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionScript : MonoBehaviour
{
    private int noofmeat = 0;
    [SerializeField] private Text meatScore;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Meat"))
        {
            Destroy(other.gameObject);
            noofmeat++;
            meatScore.text = "MEAT COLLECTED: " + noofmeat;
        }
    }
}
