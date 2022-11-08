using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    
    public float hp;
    private float speed;
    private Vector3 targetPosition;

    void Start()
    {
        speed = 0.1f;
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height)));
        
    }

    void Update()
    {
        RandomMoveFlower();
    }

    private void RandomMoveFlower()
     {
         transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
     }
private void OnTriggerEnter(Collider other)
    {

        // �p�G�I���쪺�O�l�u
        if (other.tag == "Bullet")
        {
            // �����o�l�u�������O
            Bullet bullet = other.GetComponent<Bullet>();

            // ������
            hp -= bullet.atk;

            // �p�G�S��F�A�N�R���ۤv
            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
