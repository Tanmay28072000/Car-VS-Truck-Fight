using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public List<Player> PlayerData;
}
[System.Serializable]
public class Player
{
    public string name;
    public Sprite player;
    
}
