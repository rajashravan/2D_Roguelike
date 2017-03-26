﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour {

    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;

	// Use this for initialization
	protected virtual void Start () {
        boxCollider = GetComponent<BoxCollider2D>;
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / moveTime;

		
	}

    protected IEnumerator SmoothMovement (Vector3 end)
    {
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
