using System;
using UnityEngine;
using UnityEngine.Events;

public class CustomHand : MonoBehaviour
{
    public FingerPinch OnIndexPinch = new FingerPinch();
    public FingerPinch OnMiddlePinch = new FingerPinch();

    public OVRHand Hand { get; private set; } = null;

    private void Awake()
    {
        Hand = GetComponent<OVRHand>();
    }

    private void Update()
    {
        if (Hand.IsSystemGestureInProgress)
            return;

        if (Hand.GetFingerIsPinching(OVRHand.HandFinger.Index))
            OnIndexPinch.Invoke(this);

        if (Hand.GetFingerIsPinching(OVRHand.HandFinger.Middle))
            OnMiddlePinch.Invoke(this);
    }

    [Serializable]
    public class FingerPinch : UnityEvent<CustomHand> { }
}
