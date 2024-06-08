using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    private int countOfObjects;
    public float Interval = 5f;

    //Стартує таймер
    private void Start()
    {
        StartCoroutine(RandomValue());
    }


    //Тригер для запуску спавну об'єктів
    private void OnTriggerEnter(Collider other)
    {
        //Чи в колайдер зайшов об'єкт з тегом "Player"?
        if(other.gameObject.tag == "Player")
        {
            //Якщо зайшов гравець,то спавтити таку кількість об'єктів,яку вказує змінна countOfObjects
            for(int i = 0; i < countOfObjects; i++)
            {
                //Саме створення об'єктів
                Instantiate(ObjectToSpawn, gameObject.transform.position, gameObject.transform.rotation);
            }

        }
    }

    //Кожних 5 секунд в змінну countOfObjects добавляється рандомне значення від 0 до 5 одиниць
    IEnumerator RandomValue()
    {
        while (true) { 
            countOfObjects = Random.Range(0, 5 + 1); // 0 - 5 
            Debug.Log(countOfObjects);
            yield return new WaitForSeconds(Interval);
        }
    }

}
