﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsDeviceSupported : MonoBehaviour {

    [SerializeField] private Text _text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private static readonly List<string> DeviceList = new List<string>
        {
            "samsung SM-N920V",
            "samsung SM-N920S",
            "samsung SM-N9208",
            "samsung SM-N920K",
            "samsung SM-N920L",
            "samsung SM-N920C",
            "samsung SM-N920I",
            "samsung SM-N9200",
            "samsung SM-N920T",
            "samsung SM-N920P",
            "samsung SM-N920G",
            "samsung SAMSUNG-SM-N920A",
            "samsung SM-N920W8",
            "samsung SM-G920F",
            "samsung SM-G920S",
            "samsung SM-G920I",
            "samsung SM-G920K",
            "samsung SM-G920L",
            "samsung SM-G9200",
            "samsung SM-G920P",
            "samsung SM-G920V",
            "samsung SM-G9209",
            "samsung SM-G920W8",
            "samsung SM-G9208",
            "samsung SAMSUNG-SM-G920A",
            "samsung SM-G920T",
            "samsung SM-G920R4",
            "samsung SM-G920R7",
            "samsung SM-G920X",
            "samsung SM-G925I",
            "samsung SM-G925S",
            "samsung SM-G9250",
            "samsung SM-G925K",
            "samsung SM-G925F",
            "samsung SM-G925L",
            "samsung SM-G925V",
            "samsung SM-G925W8",
            "samsung SM-G925T",
            "samsung SM-G925P",
            "samsung SAMSUNG-SM-G925A",
            "samsung SM-G925X",
            "samsung SM-G930F",
            "samsung SM-G930K",
            "samsung SM-G930L",
            "samsung SM-G930S",
            "samsung SM-G930W8",
            "samsung SAMSUNG-SM-G930A",
            "samsung SM-G930P",
            "samsung SM-G930V",
            "samsung SM-G9300",
            "samsung SM-G930T",
            "samsung SM-G930R4",
            "samsung SM-G9308",
            "samsung SM-G930U",
            "samsung SM-G930T1",
            "samsung SAMSUNG-SM-G930AZ",
            "samsung SM-G930VL",
            "samsung SM-G930R7",
            "samsung SM-G930R6",
            "samsung SM-G935F",
            "samsung SM-G935S",
            "samsung SM-G935K",
            "samsung SM-G935X",
            "samsung SM-G935L",
            "samsung SM-G935W8",
            "samsung SM-G935U",
            "samsung SM-G935V",
            "samsung SM-G935T",
            "samsung SM-G935P",
            "samsung SM-G9350",
            "samsung SAMSUNG-SM-G935A",
            "samsung SM-G935R4",
            "samsung SM-N950F",
            "samsung SM-N950XN",
            "samsung SM-N950N",
            "samsung SM-N950U",
            "samsung SM-N9500",
            "samsung SM-G950F",
            "samsung SM-G950N",
            "samsung SM-G950X",
            "samsung SM-G950XN",
            "samsung SM-G950U",
            "samsung SM-G9500",
            "samsung SM-G950U1",
            "samsung SM-G950W",
            "samsung SM-G9508",
            "samsung SM-G950K",
            "samsung SM-G950XC",
            "samsung SM-G955F",
            "samsung SM-G955N",
            "samsung SM-G955X",
            "samsung SM-G955XN",
            "samsung SM-G955U",
            "samsung SM-G9550",
            "samsung SM-G955U1",
            "samsung SM-G955W",
            "samsung SM-G955XC",
            "Xiaomi Redmi 3S",
            "OPPO OPPO R9sk",
            "OPPO OPPO R9st",
            "OPPO OPPO R9s",
            "OPPO OPPO R9s Plus",
            "OPPO OPPO R11",
            "OPPO OPPO R11t",
            "Google Pixel",
            "Google Pixel 2",
            "Google Pixel 2 XL",
            "Huawei Nexus 6P",
            "motorola Moto G (4)",
            "iPad 6,11",
            "iPad 6,12",
            "iPad4,1",
            "iPad4,2",
            "iPad4,3",
            "iPad5,3",
            "iPad5,4",
            "iPad4,4",
            "iPad4,5",
            "iPad4,6",
            "iPad4,7",
            "iPad4,8",
            "iPad4,9",
            "iPad5,1",
            "iPad5,2",
            "iPhone6,1",
            "iPhone6,2",
            "iPhone8,4",
            "iPhone7,2",
            "iPhone7,1",
            "iPhone8,1",
            "iPhone8,2",
            "iPhone9,1",
            "iPhone9,3",
            "iPhone9,2",
            "iPhone9,4",
            "iPhone10,1",
            "iPhone10,4",
            "iPhone10,2",
            "iPhone10,5",
            "iPhone10,3",
            "iPhone10,6",
            "iPad6,7",
            "iPad6,8",
            "iPad7,3",
            "iPad7,4",
            "iPad7,1",
            "iPad7,2",
            "iPad6,3",
            "iPad6,4"
        };

    public static bool IsGroundPlaneSupported()
    {
        var currentDevice = SystemInfo.deviceModel;


        if (DeviceList.Contains(currentDevice, StringComparer.OrdinalIgnoreCase))
        {
            _text.text = "true";
            return true;
        }

        Debug.LogWarning(string.Format("Device Model '{0} is not currently supported by Vuforia Ground Plane", currentDevice));

        _text.text = "false";
        return false;

    }
}
