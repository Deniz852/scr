using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        print("�������� NPC: " + health);
        print("������� NPC: " + level);
        print("�������� NPC: " + speed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;
        transform.position = newPos;
    }
}
