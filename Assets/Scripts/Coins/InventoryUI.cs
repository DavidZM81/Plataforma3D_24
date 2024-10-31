using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public PlayerInventory playerInventory;  // Asigna esta referencia en el Inspector
    public TextMeshProUGUI coinText;

    void UpdateCoinText()
    {
        coinText.text = playerInventory.NumberOfCoins.ToString();
    }
}
