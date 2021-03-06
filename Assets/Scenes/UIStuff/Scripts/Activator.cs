﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}

    public void ToggleActivate(GameObject gameObject)
	{
        gameObject.SetActive(!gameObject.activeSelf);
	}

    public void Activate(GameObject gameObject)
	{
        gameObject.SetActive(true);
	}

    public void Deactivate(GameObject gameObject)
	{
        gameObject.SetActive(false);
	}
}
