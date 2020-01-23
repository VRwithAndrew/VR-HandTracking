using UnityEngine;

public class ForwardTester : MonoBehaviour
{
    public GameObject transformRenderer = null;
    public GameObject poseRenderer = null;

    private OVRHand hand = null;

    private void Awake()
    {
        hand = GetComponent<OVRHand>();
    }

    private void Update()
    {
        Vector3 transformForward = transform.position + (transform.forward * 0.5f);
        transformRenderer.transform.position = transformForward;

        Vector3 poseForward = hand.PointerPose.position + (hand.PointerPose.forward * 0.5f);
        poseRenderer.transform.position = poseForward;
    }
}
