using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI txtPuntaje;
    private int mPuntaje = 0;

    public void AumentarPuntaje()
    {
        mPuntaje++;
        txtPuntaje.text = mPuntaje.ToString();
    }
}
