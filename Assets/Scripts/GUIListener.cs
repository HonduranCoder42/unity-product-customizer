using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GUIListener : MonoBehaviour
{
    // Vehicle variables
    private int currentVehicle = 0;
    private float scaleValue;


    [SerializeField]
    private GameObject[] vehicles;

    //Initial Menu Components
    [SerializeField]
    private GameObject bodyPanel;
    //[SerializeField]
    //private GameObject buggyPanel;
    [SerializeField]
    private GameObject[] vehiclePanels;
    [SerializeField]
    private GameObject resetPanel;
    [SerializeField]
    private GameObject purchasePanel;
    [SerializeField]
    private GameObject purchaseSuccessPanel;
    [SerializeField]
    private TMP_Dropdown dropdownCompnent;
    


    // Sets all vehicles to inactive from the start
    void Start()
    {
       foreach (var vehicle in vehicles)
        {
            vehicle.SetActive(false);
        } 

       if (vehicles[currentVehicle] != null)
        {
            vehicles[currentVehicle].SetActive(true);
        }
       else
        {
            Debug.LogWarning("Unexpected null vehicle in GUIListeners");
        }
    }

    void Update()
    {
        if (currentVehicle == 0)
        {
            scaleValue = buggySlider.value;
        }
        else if (currentVehicle == 1)
        {
            scaleValue = coupeSlider.value;
        }
        else if (currentVehicle == 2)
        {
            scaleValue = busSlider.value;
        }
        else
        {
            scaleValue = 0;
        }
    }


    // ********************* Choosing Vehicle Body *********************
    // Sets selected vehicle to active
    public void OnDropdownChange()
    {
        vehicles[currentVehicle].SetActive(false);

        currentVehicle = dropdownCompnent.value;

        vehicles[currentVehicle].SetActive(true);
    }

    // Confirms main vehicle body
    public void OnConfirmBodyPush()
    {
        bodyPanel.SetActive(false);
        vehiclePanels[currentVehicle].SetActive(true);
    }

    // ********************* Customizing Buggy *********************
    // Buggy variables
    private int currentBuggyTire = 0;
    private int currentBuggyWeapon = 0;

    [SerializeField]
    private GameObject[] buggyTires;
    [SerializeField]
    private GameObject[] buggyWeapon;
    [SerializeField]
    private TMP_Dropdown buggyTireDropdown;
    [SerializeField]
    private TMP_Dropdown buggyWeaponDropdown;
    [SerializeField]
    private Slider buggySlider;
    [SerializeField]
    private GameObject buggySliderObj;
    [SerializeField]
    private Toggle buggyLockSize;

    
    // Sets selected tire type to active
    public void OnBuggyDropdownTireChange()
    {
        buggyTires[currentBuggyTire].SetActive(false);

        currentBuggyTire = buggyTireDropdown.value;

        buggyTires[currentBuggyTire].SetActive(true);
    }
    // Sets selected weapon type to active
    public void OnBuggyDropdownWeaponChange()
    {
        buggyWeapon[currentBuggyWeapon].SetActive(false);

        currentBuggyWeapon = buggyWeaponDropdown.value;

        buggyWeapon[currentBuggyWeapon].SetActive(true);
    }
    // Sets scale of Buggy
    public void OnBuggyScaleSliderValueChanged()
    {
        vehicles[currentVehicle].transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }
    // Locks/Unlocks scale slider
    public void OnBuggyLockSizeClick()
    {
        if(buggyLockSize.isOn)
        {
            buggySliderObj.SetActive(false);
        }
        else
        {
            buggySliderObj.SetActive(true);
        }
    }

    // ********************* Customizing Coupe *********************
    // Coupe variables
    private int currentCoupeTire = 0;
    private int currentCoupeRoof = 0;

    [SerializeField]
    private GameObject[] coupeTires;
    [SerializeField]
    private GameObject[] coupeRoofs;
    [SerializeField]
    private TMP_Dropdown coupeTireDropdown;
    [SerializeField]
    private TMP_Dropdown coupeRoofDropdown;
    [SerializeField]
    private Slider coupeSlider;
    [SerializeField]
    private GameObject coupeSliderObj;
    [SerializeField]
    private Toggle coupeLockSize;


    // Sets selected tire type to active
    public void OnCoupeDropdownTireChange()
    {
        coupeTires[currentCoupeTire].SetActive(false);

        currentCoupeTire = coupeTireDropdown.value;

        coupeTires[currentCoupeTire].SetActive(true);
    }
    // Sets selected roof type to active
    public void OnCoupeDropdownRoofChange()
    {
        coupeRoofs[currentCoupeRoof].SetActive(false);

        currentCoupeRoof = coupeRoofDropdown.value;

        coupeRoofs[currentCoupeRoof].SetActive(true);
    }
    // Sets scale of Coupe
    public void OnCoupeScaleSliderValueChanged()
    {
        vehicles[currentVehicle].transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }
    // Locks/Unlocks scale slider
    public void OnCoupeLockSizeClick()
    {
        if (coupeLockSize.isOn)
        {
            coupeSliderObj.SetActive(false);
        }
        else
        {
            coupeSliderObj.SetActive(true);
        }
    }

    // ********************* Customizing Bus *********************
    // Coupe variables
    private int currentBusTire = 0;
    private int currentBusBullbar = 0;

    [SerializeField]
    private GameObject[] busTires;
    [SerializeField]
    private GameObject[] busBullbars;
    [SerializeField]
    private TMP_Dropdown busTireDropdown;
    [SerializeField]
    private TMP_Dropdown busBullbarDropdown;
    [SerializeField]
    private Slider busSlider;
    [SerializeField]
    private GameObject busSliderObj;
    [SerializeField]
    private Toggle busLockSize;


    // Sets selected tire type to active
    public void OnBusDropdownTireChange()
    {
        busTires[currentBusTire].SetActive(false);

        currentBusTire = busTireDropdown.value;

        busTires[currentBusTire].SetActive(true);
    }
    // Sets selected roof type to active
    public void OnBusDropdownBullbarChange()
    {
        busBullbars[currentBusBullbar].SetActive(false);

        currentBusBullbar = busBullbarDropdown.value;

        busBullbars[currentBusBullbar].SetActive(true);
    }
    // Sets scale of Coupe
    public void OnBusScaleSliderValueChanged()
    {
        vehicles[currentVehicle].transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }
    // Locks/Unlocks scale slider
    public void OnBusLockSizeClick()
    {
        if (busLockSize.isOn)
        {
            busSliderObj.SetActive(false);
        }
        else
        {
            busSliderObj.SetActive(true);
        }
    }

    // ********************* Functions For All Vehicles *********************
    public void OnResetButtonPress()
    {
        vehiclePanels[currentVehicle].SetActive(false);
        resetPanel.SetActive(true);
    }
    public void OnResetConfirm()
    {
        if(currentVehicle == 0)
        {
            buggyTires[currentBuggyTire].SetActive(false);
            buggyTires[0].SetActive(true);
            buggyTireDropdown.value = 0;

            buggyWeapon[currentBuggyWeapon].SetActive(false);
            buggyWeapon[0].SetActive(true);
            buggyWeaponDropdown.value = 0;

            buggySlider.value = 1;
            buggyLockSize.isOn = true;
        }
        else if(currentVehicle == 1)
        {
            coupeTires[currentCoupeTire].SetActive(false);
            coupeTires[0].SetActive(true);
            coupeTireDropdown.value = 0;

            coupeRoofs[currentCoupeRoof].SetActive(false);
            coupeRoofs[0].SetActive(true);
            coupeRoofDropdown.value = 0;

            coupeSlider.value = 1;
            coupeLockSize.isOn = true;
        }
        else
        {
            busTires[currentBusTire].SetActive(false);
            busTires[0].SetActive(true);
            busTireDropdown.value = 0;

            busBullbars[currentBusBullbar].SetActive(false);
            busBullbars[0].SetActive(true);
            busBullbarDropdown.value = 0;

            busSlider.value = 1;
            busLockSize.isOn = true;
        }

        vehicles[currentVehicle].transform.localScale = new Vector3(1, 1, 1);
        resetPanel.SetActive(false);
        vehiclePanels[currentVehicle].SetActive(true);
    }
    public void OnResetDecline()
    {
        resetPanel.SetActive(false);
        vehiclePanels[currentVehicle].SetActive(true);
    }

    public void OnPurchaseButtonPress()
    {
        vehiclePanels[currentVehicle].SetActive(false);
        purchasePanel.SetActive(true);
    }
    public void OnPurchaseConfirm()
    {
        purchasePanel.SetActive(false);
        purchaseSuccessPanel.SetActive(true);
    }
    public void OnPurchaseDecline()
    {
        purchasePanel.SetActive(false);
        vehiclePanels[currentVehicle].SetActive(true);
    }



}
