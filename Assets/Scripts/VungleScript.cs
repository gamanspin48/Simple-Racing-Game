using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VungleScript : MonoBehaviour
{
    string iosAppID = "ios_app_id";
    string androidAppID = "android_app_id";
    string windowsAppID = "5f49e58f3b52010001ce00cd";


    bool adInited = true;
#if UNITY_ANDROID
	string appID = "android_app_id";
#elif UNITY_IPHONE
	string appID = "ios_app_id";
#elif UNITY_WSA_10_0 || UNITY_WINRT_8_1 || UNITY_METRO
    string appID = "5f49e58f3b52010001ce00cd";
#endif

#if UNITY_IPHONE
    string placementID = "ios_placement_id";
#elif UNITY_ANDROID
    string  placementID = "android_placement_id";
#elif UNITY_WSA_10_0 || UNITY_WINRT_8_1 || UNITY_METRO
    string placementID = "BANNER-2563698";
#endif



    void Start(){
        Vungle.init(appID);
        initializeEventHandlers();
    }
    // public static event Action onInitializeEvent;

    void onLoadBanner()
    {
        Vungle.loadBanner(placementID, Vungle.VungleBannerSize.VungleAdSizeBanner, Vungle.VungleBannerPosition.BottomCenter);
    }

    void onPlayBanner()
    {
        Vungle.showBanner(placementID);
    }

    public void onCloseBanner()
    {
        Vungle.closeBanner(placementID);
    }

    public void ShowAd()
    {
        onLoadBanner();
        onPlayBanner();
    }


    void OnApplicationPause(bool pauseStatus) {
        if (pauseStatus) {
            Vungle.onPause();
        }
        else {
            Vungle.onResume();
        }
    }
    

    void initializeEventHandlers()
    {
        Vungle.onAdStartedEvent += (placementID) => {
            Debug.Log ("Ad " + placementID + " is starting!  Pause your game  animation or sound here.");
        };

        Vungle.onAdFinishedEvent += (placementID, args) => {
            Debug.Log ("Ad finished - placementID " + placementID + ", was call to action clicked:" + args.WasCallToActionClicked +  ", is completed view:"
                    + args.IsCompletedView);
        };

        Vungle.adPlayableEvent += (placementID, adPlayable) => {
            Debug.Log ("Ad's playable state has been changed! placementID " + placementID + ". Now: " + adPlayable);
        };

        Vungle.onInitializeEvent += () => {
            adInited = true;
            Debug.Log ("SDK initialized");
        };
    }

}
