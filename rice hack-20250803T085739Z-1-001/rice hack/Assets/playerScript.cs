using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public CharacterDatabaseScript characterDB;
    public SpriteRenderer artworkSprite;
    [SerializeField] TextMeshProUGUI nameText;
    private int selectedOption = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("selectedOption") != true)
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }

    private void UpdateCharacter(int selectedOption)
    {
        CharacterScript character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

}
