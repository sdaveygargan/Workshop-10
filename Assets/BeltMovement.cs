using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour
{
    public Material _beltMaterial;
    [SerializeField] private float _beltSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        _beltMaterial = this.GetComponent<Renderer>().material;
        _beltSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionStay(Collision collision)
    {
        //collision.rigidbody.position += transform.forward * _beltSpeed * Time.deltaTime;
        collision.rigidbody.MovePosition(collision.rigidbody.position + transform.forward * _beltSpeed *
            Time.deltaTime);
    }
}
