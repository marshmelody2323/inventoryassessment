using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    private Image SourceImage;

    void Start()
    {
        SourceImage = gameObject.GetComponent<Image>(); //get sprite renderer & store it
    }

    public void change(Sprite differentSprite)
    {
        //spriteRenderer.sprite = differentSprite; //sets sprite renderers sprite
        SourceImage.sprite = differentSprite;
    }
}
