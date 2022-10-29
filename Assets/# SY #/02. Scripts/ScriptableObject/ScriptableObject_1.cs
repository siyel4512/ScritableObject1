using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Player", fileName = "Player_")]
public class ScriptableObject_1 : ScriptableObject
{
    [SerializeField]
    private string nickName;

    [SerializeField]
    [TextArea]
    private string description;

    [SerializeField]
    private int level;

    [SerializeField]
    private ScriptableObject_2 scriptable;

    public string NickName => nickName;
    public string Description => description;
    public int Level => level;
    public ScriptableObject_2 Scriptable => scriptable;
}