using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;
    public Text nameText;
    public string test;
    public SpriteRenderer playerSprite;
    public int chatype;
    // Start is called before the first frame update

    public Sprite cha1;
    public Sprite cha2;

    private void Awake()
    {
        chatype = 2;
        if (test != null)
        nameText.text = test;
        if (chatype == 2)
        {
            //playerSprite.sprite= Resources.Load<Sprite>("new/penguin_atack_01");
            playerSprite.sprite = Resources.Load<Sprite>("new/penguin_idle_02");
            playerSprite.sprite = cha2;
        }
        else
        {
            playerSprite.sprite = cha1;
        }
    }

}
