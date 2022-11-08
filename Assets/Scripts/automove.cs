using UnityEngine;
using System.Collections;

public class automove : MonoBehaviour
{

    public float speed = 4f;
    private float timer = 0f;
    private float dir_y = 0f;

    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 4)
        {
            dir_y = Random.Range(-1, 1f);
            timer = 0;
            transform.Rotate(new Vector3(0, dir_y, 0));
        }
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
