using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{//здоровье нпс
    public int health = 5;
    //уровень нпс
    public int Level = 1;
    //скорость
    public float speed = 1.2f;

    
    
    void Start()
    {
        print(health);
        
    }

    
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
