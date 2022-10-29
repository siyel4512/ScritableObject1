using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private ScriptableObject_1 scriptable;

    // Start is called before the first frame update
    void Start()
    {
        text.text = scriptable.NickName + " / " + scriptable.Description + " / " + scriptable.Level;

        scriptable.Scriptable.Scriptable();
    }
}
