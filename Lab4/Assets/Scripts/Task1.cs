using UnityEngine;
using UnityEngine.UI;

public class Task1 : MonoBehaviour
{
    public Animator anim1; 
    public Animator anim2; 
    public Button nextButton;
    public Button nextButton2;

    private bool isFirstKeyTriggered = false;
    private bool isSecondKeyTriggered = false;

    void Start()
    {
        nextButton.interactable = false; 
        nextButton2.interactable = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !isFirstKeyTriggered)
        {
            anim1.SetTrigger("hittenOn");
            isFirstKeyTriggered = true;
        }

        if (Input.GetKeyDown(KeyCode.R) && !isSecondKeyTriggered)
        {
            anim2.SetTrigger("hittenOn");
            isSecondKeyTriggered = true;
        }

        if (isFirstKeyTriggered && isSecondKeyTriggered)
        {
            nextButton.interactable = true;
        }
    }
}