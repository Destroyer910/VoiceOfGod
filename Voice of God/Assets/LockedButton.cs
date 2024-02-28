using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedButton : MonoBehaviour
{
    [SerializeField] private int thingsNeededToUse;
    [SerializeField] private bool canPushButton;
    [SerializeField] private bool buttonIsPushed;

    public Transform movePoint;

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
        Vector3 tempPoint = gameObject.transform.position;
        StartCoroutine(moveButton(tempPoint));
        if(canPushButton)
        {
            buttonIsPushed = true;
        }
    }

    private IEnumerator moveButton(Vector3 startPos)
    {
        gameObject.transform.position = movePoint.position;
        yield return new WaitForSecondsRealtime(1f);
        gameObject.transform.position = startPos;
    }
}
