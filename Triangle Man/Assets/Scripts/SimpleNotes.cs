using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SimpleNotes : MonoBehaviour
{
    public float tuning;
    public List<float> frequencies = new List<float>();
    public List<string> noteNamesFreqs = new List<string>();
    public List<string> noteNames = new List<string>();
    public string[] twelveTones;


    [ContextMenu("Gimme notes")]
    public void MakeNotes()
    {
        frequencies.Clear();

        float rootOf12 = Mathf.Pow(2f, (1f / 12f));
        for (int i = 0; i < 28; i++)
        {
            if (i == 0)
                frequencies.Add(tuning);
            else
            {
                frequencies.Add(frequencies[i - 1] * rootOf12);
            }
        }

        for (int i = 0; i < 33; i++)
        {
            frequencies.Insert(0, frequencies[0] / rootOf12);
        }
    }

    [ContextMenu("Label Notes")]
    public void MidiNumbers()
    {
        noteNamesFreqs.Clear();
        noteNames.Clear();

        for (int i = 0; i < 60; i++)
        {
            if (i < 12)
            {
                noteNamesFreqs.Add(twelveTones[i] + 2 + " " + frequencies[i]);
                noteNames.Add(twelveTones[i] + 2);
            }

            else if (i > 11 && i < 24)
            {
                noteNamesFreqs.Add(twelveTones[i % 12] + 3 + " " + frequencies[i]);
                noteNames.Add(twelveTones[i % 12] + 3);
            }

            else if (i > 23 && i < 36)
            {
                noteNamesFreqs.Add(twelveTones[i % 12] + 4 + " " + frequencies[i]);
                noteNames.Add(twelveTones[i % 12] + 4);
            }

            else if (i > 35 && i < 48)
            { 
                noteNamesFreqs.Add(twelveTones[i % 12] + 5 + " " + frequencies[i]);
                noteNames.Add(twelveTones[i % 12] + 5);
            }

            else if (i > 47 && i < 60)
            {
                noteNamesFreqs.Add(twelveTones[i % 12] + 6 + " " + frequencies[i]);
                noteNames.Add(twelveTones[i % 12] + 6);
            }
        } 
    }
}
