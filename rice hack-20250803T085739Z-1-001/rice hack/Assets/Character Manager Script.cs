using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterManagerScript : MonoBehaviour
{
    public CharacterDatabaseScript characterDB;

    [SerializeField] TextMeshProUGUI nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption;
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

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--; 

        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
        Save();
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
    
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
