using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglesFromPitch : MonoBehaviour
{
    public ChoseNotes choseNotes;

    public float totalIdx;
    public float totalFreq;

    public float rootDegree;
    public float thirdDegree;
    public float fifthDegree;

    public GameObject rotato1;
    public GameObject rotato2;

    public void MakeAngles()
    {
        totalIdx = choseNotes.tonicIdx + choseNotes.thirdIdx + choseNotes.fifthIdx;
        totalFreq = choseNotes.tonicFreq + choseNotes.thirdFreq + choseNotes.fifthFreq;

        rootDegree = choseNotes.tonicFreq / totalFreq * 180;
        thirdDegree = choseNotes.thirdFreq / totalFreq * 180;
        fifthDegree = choseNotes.fifthFreq / totalFreq * 180;

        Debug.Log("Angle 1: " + rootDegree);
        Debug.Log("Angle 2: " + thirdDegree);
        Debug.Log("Angle 3: " + fifthDegree);

        rotato1.transform.Rotate(0, 0, rootDegree);
        rotato2.transform.Rotate(0, 0, -thirdDegree);
    }
    
}
