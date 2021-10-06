using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Apple,
    Pear,
    Orange,
    Blueberry
}
public class ConveyorItem : MonoBehaviour
{

    public ItemType type;
    // Start is called before the first frame update
    void Start()
    {
        Material colourMaterial = this.GetComponent<Renderer>().material;
        if(this.type == ItemType.Apple)
        {
            colourMaterial.color = Color.red;
        }
        else if(this.type == ItemType.Pear)
        {
            colourMaterial.color = Color.green;
        }
        else if(this.type == ItemType.Orange)
        {
            colourMaterial.color = new Color(1, 69.0f / 255.0f, 0);
        }
        else if (this.type == ItemType.Blueberry)
        {
            colourMaterial.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
