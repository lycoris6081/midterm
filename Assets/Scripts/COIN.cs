using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COIN : MonoBehaviour
{
    public string Scenes; // �U�@�����d���W�١]�ݦ^��Unity Inspector����J�^
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // ��I���� tag �� Coin ������
        if (other.gameObject.tag == "Coin")
        {
            // �R������(�]�����ΡB�ò���)
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);


            
        }
    }
}
