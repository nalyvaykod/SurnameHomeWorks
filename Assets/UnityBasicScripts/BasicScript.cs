//������ �������
using UnityEngine;

//�������� ���� � ���� ������
public class BasicScript : MonoBehaviour
{
    //Default
    /* public float distance;
     private bool isAlive;
     public int Health;
     public string Name;*/

    //Not Default
    /* public GameObject Player;
     public Light MyLight;
      */

    //1
    public GameObject CubeObject;
    public Light MyLight;
    public Camera MyCamera;
    public Vector3 SomeVector;
    //2
    //public Transform CubeTransform;

    //1 ��� �� ������� ���
    void Start()
    {
        //Transform CubeTransform = CubeObject.GetComponent<Transform>();
        
    }

    //1 ��� �� 1 �����
    void Update()
    {
        CubeObject.transform.position = new Vector3(10f, 10f, 10f);
        CubeObject.transform.localScale = new Vector3(3f, 3f, 3f);

        MyLight.intensity = 2f;
        MyLight.color = Color.blue;

        
        

    }
}


