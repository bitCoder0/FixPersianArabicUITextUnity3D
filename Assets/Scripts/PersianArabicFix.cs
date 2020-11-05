using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;

/// <summary>
/// Main class for auto fixing words
/// Assign this script to a canvas that contains persian/arabic text
/// 
/// کلاس اصلی برای رفع مشکل کلمات
/// این اسکریپت رو وصل کنید به یه کانوس که  تکست فارسی/عربی داره
/// </summary>
public class PersianArabicFix : MonoBehaviour
{
    public List<GameObject> ignoreList;

    public bool checkDisabledTexts=true;
    void Start()
    {
        fix();
    }

    /// <summary>
    /// searches in childeren Text gameobjects and fixes the persian/arabic texts
    /// تکست های زیرمجموعه این گیم آبجکت را جستجو و متن فارسی/عربی را ترجمه میکند
    /// </summary>
    void fix()
    {
        foreach (Text text in gameObject.GetComponentsInChildren<Text>(checkDisabledTexts))
        {
            if(!ignoreList.Contains(gameObject))
                text.text = ArabicFixer.Fix(text.text);

        }

    }

}
