using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedButton : MonoBehaviour
{
    [SerializeField] private int thingsNeededToUse;
    [SerializeField] private bool canPushButton;
    [SerializeField] private bool buttonIsPushed;

    public GameObject activateUponGoodPush;

    private bool canPushAgain = true;

    public Transform movePoint;
    public LockedButton buttonScript;

    public void tryUnlockButton()
    {
        thingsNeededToUse--;
        if(thingsNeededToUse == 0)
        {
            canPushButton = true;
        }
    }

    public void pushButton()
    {
        if(canPushAgain)
        {
            Debug.Log("Work!!");
            Vector3 tempPoint = gameObject.transform.position;
            canPushAgain = false;
            StartCoroutine(moveButton(tempPoint));
        }
        if(canPushButton)
        {
            canPushButton = false;
            buttonIsPushed = true;
            activateUponGoodPush.SetActive(true);
            if(buttonScript != null)
            {
                buttonScript.tryUnlockButton();
            }
        }
    }

    private IEnumerator moveButton(Vector3 startPos)
    {
        gameObject.transform.position = movePoint.position;
        yield return new WaitForSecondsRealtime(1f);
        gameObject.transform.position = startPos;
        canPushAgain = true;
    }
}
