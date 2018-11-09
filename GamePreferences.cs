using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple helper class for saving game data, to use this, just copy the file 
// to project asset folder/subfolder
// Usage: GamePreferences.SaveStringValue("PlayerName", "Jane");
public static class GamePreferences {


    public static void SaveStringValue(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public static string LoadStringValue(string key)
    {
        VerifyKey(key);
        return PlayerPrefs.GetString(key);
    }

    public static float LoadFloatValue(string key)
    {
        VerifyKey(key);
        return PlayerPrefs.GetFloat(key);
    }

    public static float LoadIntValue(string key)
    {
        VerifyKey(key);
        return PlayerPrefs.GetInt(key);
    }

    public static void SaveFloatValue(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
    }

    public static void SaveIntValue(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }


    static void VerifyKey(string key)
    {
        if (!PlayerPrefs.HasKey(key))
        {
            Debug.LogError("Trying to load game preference with a key that does not exist!");
        }
    }
}
