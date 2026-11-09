using UnityEngine;
using UnityEngine.UI;

public class SkinSelectorUI : MonoBehaviour
{
    public Button[] skinButtons; // Inspector mein 10 buttons assign karein

    private void Start()
    {
        for (int i = 0; i < skinButtons.Length; i++)
        {
            int skinIndex = i; // Local variable for lambda
            skinButtons[i].onClick.AddListener(() => SelectSkin(skinIndex));
        }
    }

    public void SelectSkin(int index)
    {
        GameManager.Instance.selectedSkinIndex = index;
        Debug.Log("Skin Selected: " + index);
        // Yahan aap start game ka button enable kar sakte hain
    }
}
