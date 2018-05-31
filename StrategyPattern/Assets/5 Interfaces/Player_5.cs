using UnityEngine;

public class Player_5 : MonoBehaviour
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
            Act(hit.collider.gameObject);
    }

    void Act(GameObject animal)
    {
        switch (input)
        {
            case InputType.LMB:
            {
                ISpeak speak = animal.GetComponent<ISpeak>();
                if (speak != null)
                {
                    speak.Speak();
                    speakCount++;
                }
                break;
            }
            case InputType.RMB:
            {
                IWalk walk = animal.GetComponent<IWalk>();
                if (walk != null)
                {
                    walk.Walk();
                    walkCount++;
                }
                break;
            }
            case InputType.Space:
            {
                ISwim swim = animal.GetComponent<ISwim>();
                if (swim != null)
                {
                    swim.Swim();
                    swimCount++;
                }
                break;
            }
            case InputType.I:
            {
                IID id = animal.GetComponent<IID>();

                if (id != null)
                    id.Identify();

                break;
            }
            default: break;
        }
    }

    void GetActionCount()
    {
        Debug.Log("Total speeches: " + speakCount + ", total walks: " + walkCount + ", total laps swam: " + swimCount);
    }
}
