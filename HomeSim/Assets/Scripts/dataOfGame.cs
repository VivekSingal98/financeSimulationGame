using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class dataOfGame
{
    public static float netSavings = 60000f;
    public static float totCredits = 0.00f;
    public static float totSOF = 0.00f;


    public static List<string> inventory = new List<string>();
    public static Dictionary<string, Dictionary<string,float>> statsOfItems = new Dictionary<string, Dictionary<string,float>>
    {
        { "car_diesel" , new Dictionary<string,float>{{"cost", 100000},{"credit", -50},{ "sol",20},{ "carbon_emission",200} } },
        { "car_petrol" , new Dictionary<string,float>{{"cost", 120000},{"credit", -20},{ "sol",20},{ "carbon_emission",120} } },
        { "car_cng" , new Dictionary<string,float>{{"cost", 140000},{"credit", 200},{ "sol",25},{ "carbon_emission",20} } },
        { "car_electric" , new Dictionary<string,float>{{"cost", 145000},{"credit", 250},{ "sol",30},{ "carbon_emission",0} } },

        {"AC_3Star",new Dictionary<string, float>{ { "cost",15000},{"credit",0 },{"sol",3}, {"eer",2.9f},{"energy",1.5f }}},
        {"AC_4Star",new Dictionary<string, float>{ { "cost",18000},{"credit",50 },{"sol",5}, {"eer",3.1f},{"energy",1.2f}}},
        {"AC_5Star",new Dictionary<string, float>{ { "cost",20000},{"credit",70 },{"sol",5}, {"eer",3.3f},{"energy",1f}}},

        {"fridge_3Star",new Dictionary<string, float>{ { "cost",15000},{"credit",0 },{"sol",3}, {"cfc",500},{"energy",1.66f }}},
        {"fridge_4Star",new Dictionary<string, float>{ { "cost",18000},{"credit",50 },{"sol",5}, {"cfc",500},{"energy",1.33f}}},
        {"fridge_5Star",new Dictionary<string, float>{ { "cost",20000},{"credit",70 },{"sol",7}, {"cfc",500},{"energy",1f}}}



    };

}
