using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    private int countOfObjects;
    public float Interval = 5f;

    //������ ������
    private void Start()
    {
        StartCoroutine(RandomValue());
    }


    //������ ��� ������� ������ ��'����
    private void OnTriggerEnter(Collider other)
    {
        //�� � �������� ������ ��'��� � ����� "Player"?
        if(other.gameObject.tag == "Player")
        {
            //���� ������ �������,�� �������� ���� ������� ��'����,��� ����� ����� countOfObjects
            for(int i = 0; i < countOfObjects; i++)
            {
                //���� ��������� ��'����
                Instantiate(ObjectToSpawn, gameObject.transform.position, gameObject.transform.rotation);
            }

        }
    }

    //������ 5 ������ � ����� countOfObjects ������������ �������� �������� �� 0 �� 5 �������
    IEnumerator RandomValue()
    {
        while (true) { 
            countOfObjects = Random.Range(0, 5 + 1); // 0 - 5 
            Debug.Log(countOfObjects);
            yield return new WaitForSeconds(Interval);
        }
    }

}
