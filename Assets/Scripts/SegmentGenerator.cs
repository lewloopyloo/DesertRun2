using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] segment;

    [SerializeField] int zPosition = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;
    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
        
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    
    }

}
