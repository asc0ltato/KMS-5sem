using UnityEngine;

public class PereklAnimate : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("hittenOn");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetTrigger("hittenOff");
        }
    }
}