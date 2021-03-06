﻿using UnityEngine;

public class Player_2 : MonoBehaviour
{
    Ray ray;
    RaycastHit2D hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CastRay();
    }

    void CastRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit)
        {
            GameObject animal = hit.collider.gameObject;

            if (animal.GetComponent<Cat_Component>())
                animal.GetComponent<Cat_Component>().Speak();
            else if (animal.GetComponent<Dog_Component>())
                animal.GetComponent<Dog_Component>().Speak();
        }
    }
}
