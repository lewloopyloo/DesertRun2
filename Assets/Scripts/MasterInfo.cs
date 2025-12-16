using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    public static int distanceRun;
    [SerializeField] int internalDistance;
    [SerializeField] GameObject runDisplay;
   
    // Update is called once per frame
    void Update()
    {
        internalDistance = distanceRun;

        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + coinCount;
        runDisplay.GetComponent<TMPro.TMP_Text>().text = "" + distanceRun;
    }
}
