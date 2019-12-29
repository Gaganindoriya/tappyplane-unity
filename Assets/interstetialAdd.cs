using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class interstetialAdd : MonoBehaviour
{

    bool hasShownAdOneTime;

    // Use this for initialization
    void Start()
    {
        //Request Ad
        RequestInterstitialAds();
    }

    void Update()
    {
        if (Player.isGameOverThreeTime)
       {
            if (!hasShownAdOneTime)
            {
                hasShownAdOneTime = true;
                Invoke("showInterstitialAd", 3.0f);
            }
        }
    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD Interstetial");
        }

    }

    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        string adID = "ca-app-pub-8990957263632638/4077489708";

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test***
       // AdRequest request = new AdRequest.Builder()
       //.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       //.AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       //.Build();

        //***Production***
        AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        interstitial.OnAdClosed += Interstitial_OnAdClosed;
     //   interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED interstetial");

    }

    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        Player.isGameOverThreeTime = false;
        //Resume Play Sound
        //Application.LoadLevel("level2");
        SceneManager.LoadScene(1);
    }
    //public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    //{
    //  // Handle the ad failed to load event.
    //    Player.isGameOverThreeTime = false;
    //    //Resume Play Sound
    //    //Application.LoadLevel("level2");
    //    SceneManager.LoadScene(1);
    //}
}
