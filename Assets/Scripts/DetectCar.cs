using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCar : MonoBehaviour
{

    public string lightName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "car")
        {
            //invoke increase cars waiting event
            EventManager.IncreaseCarsWaitingEvent(5, lightName);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            //invoke increase cars waiting event
            EventManager.IncreaseCarsWaitingEvent(-5, lightName);
        }
    }
}
