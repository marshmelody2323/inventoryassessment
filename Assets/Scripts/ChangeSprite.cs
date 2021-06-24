using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    private bool sprite1 = false;
    private Image SourceImage;
    public Sprite sprite2;

    void Start()
    {
        SourceImage = gameObject.GetComponent<Image>(); //get sprite renderer & store it
    }

    public void Sprite1()
    {
        if(sprite1 == false)
        {
            //hasnt been pressed
        }

        
    }

    public void Sprite2()
    {
        if (sprite1 == false)
        {
            //hasnt been pressed
        }

        
    }

    public void change(Sprite differentSprite)
    {
        sprite1 = true;
        //spriteRenderer.sprite = differentSprite; //sets sprite renderers sprite
        SourceImage.sprite = differentSprite;
    }
}
