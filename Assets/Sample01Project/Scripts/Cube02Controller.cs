﻿using System;
using UnityEngine;

public class Cube02Controller : MonoBehaviour {

    private Renderer rend;

    void Awake() {
        rend = GetComponent<Renderer>();
    }

    public void ChangeScaleHandler(object o, EventArgs e) {
        this.transform.localScale = new Vector3(1.5f, 1.0f, 1.5f);
    }

    public void ResetScaleHandler(object o, EventArgs e) {
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void ChangeColorHandler(object o, EventArgs e) {
        rend.material.color = new Color(0.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f);
    }

    public void ResetColorHandler(object o, EventArgs e) {
        rend.material.color = new Color(0.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
    }
}