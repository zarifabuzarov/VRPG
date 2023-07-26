using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int healthMax = 10;
    public int coins = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    public int Timer()
    {
        return Time.time.ToInt32();
    }

    // Update is called once per frame
    void TakeDamage(int damage)
    {
        health -= damage;
    }
}
