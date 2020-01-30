﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float speed = 20f;
	public int damage = 40;
	private Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		// Enemy enemy = hitInfo.GetComponent<Enemy>();
		// if (enemy != null)
		// {
		// 	enemy.TakeDamage(damage);
		// }

        if (impactEffect != null)
        {
    	Instantiate(impactEffect, transform.position, transform.rotation);
        }

		Destroy(gameObject);
	}
	
}