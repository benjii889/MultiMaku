﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject bulletOwner;
    void Start()
    {
        Debug.Log("Im alive!");
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
        //Debug.Log("I hit a player :)");
        //var hit = collision.gameObject;
        //var health = hit.GetComponent<Health>();
        //if (health != null)
        //{
        //    if (!health.TakeDamage (10))
        //	{
        //		Destroy(gameObject);
        //	}
        //}
        //Destroy(gameObject);
    //}
}
