using UnityEngine;

public class Player_8 : MonoBehaviour
{
    enum InputType { LMB, RMB, Space, I, A, T, D }
    InputType input;

    Ray ray;
    RaycastHit2D hit;

    int speakCount, walkCount, swimCount;
    [SerializeField] MoveStyles dance;

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
        /*else if (Input.GetKeyDown(KeyCode.A))
        {
            input = InputType.A;
            GetActionCount();
        }*/
        else if (Input.GetKeyDown(KeyCode.T))
        {
            input = InputType.T;
            CastRay();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            input = InputType.D;
            CastRay();
        }
    }

    void CastRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit)
            Act(hit.collider.gameObject);
    }

    void Act(GameObject hitObj)
    {
        Character_8 character = hitObj.GetComponent<Character_8>();

        switch (input)
        {
            case InputType.LMB: { character.PerformSpeak(); break; }
            case InputType.RMB: { character.PerformMove(); break; }
            case InputType.I: { character.Identify(); break; }
            case InputType.Space: { character.ChangeMoveState(); break; }
            case InputType.T: { character.ChangeSpeakState(); break; }
            case InputType.D: { character.LearnMovement(dance); break; }
            default: break;
        }
    }

    /*void GetActionCount()
    {
        Debug.Log("Total speeches: " + speakCount + ", total walks: " + walkCount + ", total laps swam: " + swimCount);
    }*/
}
