using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingMachineController : MonoBehaviour
{
    public Transform _leftExit;
    public Transform _rightExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Conveyor"))
        {
            return;
        }

        if (other.gameObject.GetComponent<ConveyorItem>())
        {
            ItemType type = other.gameObject.GetComponent<ConveyorItem>().type;
            if(type == ItemType.Apple || type == ItemType.Pear)
            {
                other.transform.position = _rightExit.transform.position;
                other.transform.rotation = _rightExit.transform.rotation;
            }
            else
            {
                other.transform.position = _leftExit.transform.position;
                other.transform.rotation = _leftExit.transform.rotation;
            }
        }
    }
}
