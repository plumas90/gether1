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
    public int chatype=1;
    // Start is called before the first frame update

    public Sprite cha1;
    public Sprite cha2;
    //스타트씬부터 존재해야함

    public void Start()
    {
        nameText.text = start.I.namesave;
    }
    private void Awake()//C# 싱글톤 구현 GET SET 활용
    {
        //nameText.text = start.I.namesave;
        //DontDestroyOnLoad(this.gameObject);
        if (null == I)
        {
            I = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        chatype = start.I.chaType;
        if (chatype == 1)
        {
            //playerSprite.sprite= Resources.Load<Sprite>("new/penguin_atack_01");
            //playerSprite.sprite = Resources.Load<Sprite>("new/penguin_idle_02");
            playerSprite.sprite = cha1;
        }
        else
        {
            //playerSprite.sprite = Resources.Load<Sprite>("new/penguin_atack_01");
            playerSprite.sprite = cha2;
        }
    }
    
}
