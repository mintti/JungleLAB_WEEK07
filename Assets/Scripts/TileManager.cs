using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    public int cellCount;
    public GameObject cell;
    public GameObject nonoPanel;

    private void Start()
    {
        nonoPanel.GetComponent<GridLayoutGroup>().constraintCount = cellCount;
        for(int i = 0; i < cellCount * cellCount; i++)
        {
            Instantiate(cell, nonoPanel.transform);
        }
    }
}
