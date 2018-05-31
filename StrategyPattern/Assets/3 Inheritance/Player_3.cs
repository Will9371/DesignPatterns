using UnityEngine;

public class Player_3 : MonoBehaviour
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
            hit.collider.gameObject.GetComponent<Animal>().Speak();
    }
}
