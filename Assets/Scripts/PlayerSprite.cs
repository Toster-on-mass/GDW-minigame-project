using UnityEngine;

public class PlayerSprite : MonoBehaviour
{

    public PlayerControler connectedPlayerControler;
    public NetCapture connectedNetCapture;
    public SpriteRenderer connectedSprite;

    public Sprite[] sprites;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (connectedPlayerControler.currentFacingDirection.x == 1)
        {
            connectedSprite.flipX = false;
        }
        else
        {
            connectedSprite.flipX = true;
        }


        if (connectedNetCapture.active)
        {
            connectedSprite.sprite = sprites[1];
        }
        else
        {
            connectedSprite.sprite = sprites[0];
        }
    }
}
