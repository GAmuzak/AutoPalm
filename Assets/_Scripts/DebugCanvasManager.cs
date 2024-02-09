using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugCanvasManager : MonoBehaviour
{
    [Tooltip("Enter from thumb to pinkie in order")] [SerializeField]
    private List<TextMeshProUGUI> leftHandFingersTMP;

    [Tooltip("Enter from thumb to pinkie in order")] [SerializeField]
    private List<TextMeshProUGUI> rightHandFingersTMP;

    public void UpdatePositionData(List<Vector3> leftHandData, List<Vector3> rightHandData)
    {
        
    }
}