using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    private bool sprite1 = false;
    private bool sprite2 = false;
    private Image SourceImage;
    public Sprite sprite1Sprite;
    [UnityEngine.Serialization.FormerlySerializedAs("sprite2")]public Sprite sprite2Sprite;
    public Sprite sprite3Sprite;

    private bool setSprite1 = false;
    private bool setSprite2 = false;

    void Start()
    {
        SourceImage = gameObject.GetComponent<Image>(); //get sprite renderer & store it
    }

    public void ChangeToSprite1()
    {
        if(sprite1 == false && sprite2 == false)
        {
            SourceImage.sprite = sprite1Sprite;
        }
        else 
        {
            SourceImage.sprite = sprite3Sprite;
        }

        sprite1 = true;
    }

    public void ChangeToSprite2()
    {
        if (sprite1 == false && sprite2 == false)
        {
            SourceImage.sprite = sprite2Sprite;
        }
        else
        {
            SourceImage.sprite = sprite3Sprite;
        }

        sprite2 = true;
    }

    //public void change(Sprite differentSprite)
    //{
    //    if (sprite1 == false)
    //    {
    //        sprite1 = differentSprite == sprite1Sprite;
    //    }

    //    if (sprite2 == false)
    //    {
    //        sprite2 = differentSprite == sprite2Sprite;
    //    }
    //    //spriteRenderer.sprite = differentSprite; //sets sprite renderers sprite

    //    if (sprite1 == true && setSprite1 == false)
    //    {
    //        // Sprite 1
    //        SourceImage.sprite = sprite1Sprite;
    //        setSprite1 = true;
    //    }
    //    else if(sprite2 == true && setSprite2 == false)
    //    {
    //        // Sprite 2
    //        SourceImage.sprite = sprite2Sprite;
    //        setSprite2 = true;
    //    }
    //    else if(sprite1 == true && sprite2 == true)
    //    {
    //        // Sprite 3 - Combined
    //        SourceImage.sprite = sprite3Sprite;
    //    }
    //    //SourceImage.sprite = differentSprite;
    //}
}
