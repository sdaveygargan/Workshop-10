using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMachineController : MonoBehaviour
{ 

    public Transform _exit;
    public GameObject _itemToSpawn;
    public Transform _itemParent;

    [SerializeField] private float _spawnInterval;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _spawnInterval = 0.8f;
        _timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= _spawnInterval)
        {
            _timer = 0f;
            GameObject spawnObject = Instantiate(_itemToSpawn, _itemParent);
            ConveyorItem item = spawnObject.GetComponent<ConveyorItem>();

            if (item)
            {
                float randomNumber = Random.Range(0,4);
                if(randomNumber < 1)
                {
                    item.type = ItemType.Apple;
                }
                else if (randomNumber < 2)
                {
                    item.type = ItemType.Orange;
                }
                else if(randomNumber < 3)
                {
                    item.type = ItemType.Pear;
                }
                else
                {
                    item.type = ItemType.Blueberry;
                }
            }
        }
    }
}
