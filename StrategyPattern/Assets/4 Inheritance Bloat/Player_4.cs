using UnityEngine;

public class Player_4 : MonoBehaviour
{
    enum InputType { LMB, RMB, Space, I, A }
    InputType input;

    Ray ray;
    RaycastHit2D hit;

    int speakCount, walkCount, swimCount;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            input = InputType.LMB;
            CastRay();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            input = InputType.RMB;
            CastRay();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            input = InputType.Space;
            CastRay();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            input = InputType.I;
            CastRay();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            input = InputType.A;
            GetActionCount();
        }
    }

    void CastRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit)
            Act(hit.collider.gameObject.GetComponent<Animal_1>());
    }

    void Act(Animal_1 animal)
    {
        switch (input)
        {
            case InputType.LMB: speakCount += animal.Speak(); break;
            case InputType.RMB: walkCount += animal.Walk(); break;
            case InputType.Space: swimCount += animal.Swim(); break;
            case InputType.I: animal.Identify(); break;
            default: break;
        }
    }

    void GetActionCount()
    {
        Debug.Log("Total speeches: " + speakCount + ", total walks: " + walkCount + ", total laps swam: " + swimCount);
    }
}
