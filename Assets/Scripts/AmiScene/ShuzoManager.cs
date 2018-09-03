﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuzoManager : MonoBehaviour {
    [SerializeField] GameObject frameImage;

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnFrameMode()
    {
        animator.speed = 2.0f;
        frameImage.SetActive(true);
    }

    public void OffFrameMode()
    {
        animator.speed = 1.0f;
        frameImage.SetActive(false);
    }
}