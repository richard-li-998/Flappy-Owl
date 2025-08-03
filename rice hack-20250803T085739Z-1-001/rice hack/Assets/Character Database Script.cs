    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu]
public class CharacterDatabaseScript : ScriptableObject
{
    public CharacterScript[] character;

    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }

    public CharacterScript GetCharacter(int idx)
    {
        return character[idx];
    }
}    
    
