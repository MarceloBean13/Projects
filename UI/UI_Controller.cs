using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private RawImage _gameOverScreen;
    [SerializeField] private float fadeTime;

    private int _i = 0;
    private Image _healthImg;

    public void Start()
    {
        _healthImg = GetComponent<Image>();
    }
    public void ChangeSprite()
    {
        _healthImg.sprite = _sprites[++_i];
    }
    public void FadeGameOver()
    {
        _gameOverScreen.CrossFadeAlpha(1, fadeTime, false);
    }
}
