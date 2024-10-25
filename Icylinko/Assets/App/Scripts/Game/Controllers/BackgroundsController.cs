using UnityEngine;
using UnityEngine.UI;

public class BackgroundsController : MonoBehaviour
{
    public static BackgroundsController Instance { get; private set; }

    [SerializeField] private Image backgroundImage;
    [SerializeField] private Sprite[] availableBackgrounds;

    private void Awake() 
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        ApplyBackground(PlayerPrefsController.GetCurrentBackground("Background 1"));
    }

    public void ApplyBackground(string backgroundName)
    {
        for (int i = 0; i < availableBackgrounds.Length; i++)
        {
            if (availableBackgrounds[i].name == backgroundName)
            {
                backgroundImage.sprite = availableBackgrounds[i];
                break;
            }
        }
    }
}