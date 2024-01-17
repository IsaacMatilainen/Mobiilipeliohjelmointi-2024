using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Tämä script vaihtaa spriten väriä.
    /// </summary>
public class ColorChanger : MonoBehaviour
{
    //Luokan jäsenmuuttajat

    //Kurssin nimeämiskäytännön mukaisesti jäsenmuuttajat merkataan alaviivalla _.
    //Viittaus SpriteRenderer-komponenttiin.
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private Color[] _colours;
    // Start is called before the first frame update
    void Start()
    {
        //Haetaan viittaus SpriteRender-komponenttiin
        //GetComponent palauttaa GameObjectissa olevan SpriteRenderer-komponentin
        _spriteRenderer = GetComponent<SpriteRenderer>();

        //Asettaa listan ensimmäisen värin aloitusväriksi.
        _spriteRenderer.color = _colours[0];
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time % _colours.Length);
        _spriteRenderer.color = _colours[index];
    }
}  
}
