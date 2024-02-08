using Leap;
using Leap.Unity;
using UnityEngine;

public class HandData : MonoBehaviour
{
    [Tooltip("Make sure to pass the aggregator here")] [SerializeField]
    private LeapProvider leapProvider;

    private void OnEnable()
    {
        leapProvider.OnUpdateFrame += OnUpdateFrame;
    }

    private void OnDisable()
    {
        leapProvider.OnUpdateFrame -= OnUpdateFrame;
    }

    private void OnUpdateFrame(Frame frame)
    {
        Hand leftHand = frame.GetHand(Chirality.Left);
        Hand rightHand = frame.GetHand(Chirality.Right);

        //When we have a valid left hand, we can begin searching for more Hand information
        if(leftHand != null)
        {
            OnUpdateHand(leftHand);
        }

        if (rightHand != null)
        {
            OnUpdateHand(rightHand);
        }
    }

    private void OnUpdateHand(Hand hand)
    {
        Finger thumb = hand.GetThumb();
        Finger index = hand.GetIndex();
        Finger middle = hand.GetMiddle();
        Finger ring = hand.GetRing();
        Finger pinky = hand.GetPinky();
    }
}