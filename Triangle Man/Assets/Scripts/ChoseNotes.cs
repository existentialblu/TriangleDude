using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoseNotes : MonoBehaviour
{
    // Inputs
    [SerializeField]
    protected InputField root;
    [SerializeField]
    protected InputField third;
    [SerializeField]
    protected InputField fifth;

    public int tonicIdx;
    public int thirdIdx;
    public int fifthIdx;
    public float tonicFreq;
    public float thirdFreq;
    public float fifthFreq;

    public SimpleNotes simpleNotes;
    
    public void Root()
    {
        if (simpleNotes.noteNames.Contains(root.text))
        {
            tonicIdx = simpleNotes.noteNames.IndexOf(root.text);
            Debug.Log(tonicIdx);
            tonicFreq = simpleNotes.frequencies[tonicIdx];
        }
    }

    public void Third()
    {
        if (simpleNotes.noteNames.Contains(third.text))
        {
            thirdIdx = simpleNotes.noteNames.IndexOf(third.text);
            Debug.Log(thirdIdx);
            thirdFreq = simpleNotes.frequencies[thirdIdx];
        }
    }

    public void Fifth()
    {
        if (simpleNotes.noteNames.Contains(fifth.text))
        {
            fifthIdx = simpleNotes.noteNames.IndexOf(fifth.text);
            Debug.Log(fifthIdx);
            fifthFreq = simpleNotes.frequencies[fifthIdx];
        }
    }
}
