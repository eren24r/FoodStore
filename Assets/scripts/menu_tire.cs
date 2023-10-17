using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.UI;

public class menu_tire : MonoBehaviour
{
    public GameObject MenuTire;

    public GameObject home;
    public GameObject home_noAc;
    public GameObject rest;
    public GameObject rest_noAc;
    public GameObject store;
    public GameObject store_noAc;
    public GameObject shop;
    public GameObject shop_noAc;

    public GameObject GlMenu;
    public GameObject RestorPanel;
    public GameObject StorePanel;
    public GameObject ShopPanel;

    public Text NamePanels;

    public void OpenMenu()
    {
        MenuTire.SetActive(true);
    }
    public void CloseMenu()
    {
        StartCoroutine(showTextFuntion());
    }
    IEnumerator showTextFuntion()
    {
        MenuTire.GetComponent<Animator>().Play("menu_3pt_ani_anim_NAO");
        yield return new WaitForSeconds(1f);
        MenuTire.SetActive(false);
    }

    void Update()
    {
        if (home.activeSelf == true)
        {
            rest.SetActive(false);
            store.SetActive(false);
            shop.SetActive(false);
        }
        if (rest.activeSelf == true)
        {
            home.SetActive(false);
            store.SetActive(false);
            shop.SetActive(false);
        }
        if (shop.activeSelf == true)
        {
            home.SetActive(false);
            store.SetActive(false);
            rest.SetActive(false);
        }
    }

    public void OnMoHome()
    {
        home.SetActive(true);
        RestorPanel.SetActive(false);
        StorePanel.SetActive(false);
        ShopPanel.SetActive(false);
        GlMenu.SetActive(true);
        NamePanels.text = "Food Store";
        rest.SetActive(false);
        store.SetActive(false);
        shop.SetActive(false);
    }

    public void OnMoRest()
    {
        rest.SetActive(true);
        GlMenu.SetActive(false);
        StorePanel.SetActive(false);
        ShopPanel.SetActive(false);
        RestorPanel.SetActive(true);
        NamePanels.text = "Рестораны";
        home.SetActive(false);
        store.SetActive(false);
        shop.SetActive(false);
    }

    public void OnMoStore()
    {
        store.SetActive(true);
        GlMenu.SetActive(false);
        RestorPanel.SetActive(false);
        ShopPanel.SetActive(false);
        StorePanel.SetActive(true);
        NamePanels.text = "Магазины";
        home.SetActive(false);
        rest.SetActive(false);
        shop.SetActive(false);
    }
    public void OnMoShop()
    {
        shop.SetActive(true);
        GlMenu.SetActive(false);
        RestorPanel.SetActive(false);
        StorePanel.SetActive(false);
        ShopPanel.SetActive(true);
        NamePanels.text = "Корзина";
        home.SetActive(false);
        rest.SetActive(false);
        store.SetActive(false);
    }
}
