using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;

public class AdMobAdManager : MonoBehaviour
{
    private BannerView bannerView;
    AdSize adSize = new AdSize(320, 50);
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        MobileAds.Initialize(initStatus => { LoadBanner(); });

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";

        bannerView = new BannerView(adUnitId, adSize, AdPosition.Top);

    }
    public void LoadBanner()
    {
        if (bannerView == null)
        {
            RequestBanner();
        }

        AdRequest request = new AdRequest();

        bannerView.LoadAd(request);
    }
}

