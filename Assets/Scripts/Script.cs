using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    // public GameObject cube;
    // public int x, y, z
    
    public GameObject scene1, scene2, scene3;
    public GameObject stats;
    public TextMeshProUGUI hpValue;
    public int hpPoints;

    // Start is called before the first frame update
    void Start()
    {
        // for scale
        // cube.transform.localScale = new Vector3(x, y, z);

        // for position
        // cube.transform.localPosition = new Vector3(x, y, z);

        scene1.SetActive(true);
        stats.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        hpValue.text = hpPoints.ToString();
    }

    public void StartButton() {
        scene1.SetActive(false);
        scene2.SetActive(true);
        stats.SetActive(true);
    }

    public void WakeUpButton() {
        scene2.SetActive(false);
        scene3.SetActive(true);

        hpPoints += 5;
    }

}
