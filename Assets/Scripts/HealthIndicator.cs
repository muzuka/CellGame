using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIndicator : MonoBehaviour {

    Health healthObject;

	// Use this for initialization
	void Start () {
        healthObject = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
        float healthRatio = healthObject.health / healthObject.maxHealth;

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color(renderer.color.r, renderer.color.b * healthRatio, renderer.color.g * healthRatio);
	}
}
