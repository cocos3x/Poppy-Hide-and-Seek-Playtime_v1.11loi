using UnityEngine;
public class StartView : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI textLevel;
    public TMPro.TextMeshProUGUI textCoin;
    public UnityEngine.GameObject inactiveOnPlayGame;
    public UnityEngine.GameObject[] boosterButtons;
    public ShopView shopView;
    
    // Methods
    private void Awake()
    {
        this.shopView.OnCashUpdated = new System.Action<System.Int32>(object:  this, method:  System.Void StartView::<Awake>b__5_0(int cash));
    }
    public void SetLevel(int level)
    {
        this.textLevel.text = "LEVEL " + level.ToString();
    }
    public void SetCoin(int coin)
    {
        this.textCoin.text = coin.ToString();
    }
    public void Open()
    {
        this.inactiveOnPlayGame.SetActive(value:  true);
        var val_4 = 0;
        do
        {
            if(val_4 >= this.boosterButtons.Length)
        {
                return;
        }
        
            this.boosterButtons[val_4].SetActive(value:  ((UnityEngine.Random.Range(min:  0, max:  3)) == val_4) ? 1 : 0);
            val_4 = val_4 + 1;
        }
        while(this.boosterButtons != null);
        
        throw new NullReferenceException();
    }
    public void Close()
    {
        if(this.inactiveOnPlayGame != null)
        {
                this.inactiveOnPlayGame.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }
    public StartView()
    {
    
    }
    private void <Awake>b__5_0(int cash)
    {
        this.SetCoin(coin:  cash);
    }

}
