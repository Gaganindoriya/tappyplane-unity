using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class ShowBanner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        showBannerAd();
       // Debug.Log("Banner Loaded");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void showBannerAd()
    {
        string adID = "ca-app-pub-8990957263632638/2600756506";

        //***For Testing in the Device***
      //  AdRequest request = new AdRequest.Builder()
    //   .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
     //  .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
     //  .Build();

        //***For Production When Submit App***
        AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Top);
        bannerAd.LoadAd(request);
    }
}
