using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{//паблик это публичное оно отвечает за видемость в инспекторе
    //принт отвечает за печать 
    //инт это указание сто в переменой будет лежать целое число
    public int health = 3;
    public int level = 1;
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Здоровье Игрока:" + health);
    }

    // Update is called once per frame
    void Update()
    {//создаём переменую вита вектор3 и сохраняем в неё позицию нпс
        Vector3 newPosition = transform.position;
        //меняем позицыю нпс по оси z согласно скорости нпс и времени между кадроми
        newPosition.z += speed * Time.deltaTime;
        //меняем позицыю нпс на новое значение расщитаное высще
        transform.position = newPosition;


    }
}
