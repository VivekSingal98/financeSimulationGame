using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class dataOfGame
{
    public static float netSavings = 0.00f;
    public static float totCredits = 0.00f;
    public static float totSOF = 0.00f;


    public static List<string> inventory = new List<string>();
    public static Dictionary<string, Dictionary<string,float>> statsOfItems = new Dictionary<string, Dictionary<string,float>>
    {
        { "car_diesal" , new Dictionary<string,float>{{"cost", 100000},{"credit", -50},{ "sol",20},{ "carbon_emission",200} } },
        { "car_petrol" , new Dictionary<string,float>{{"cost", 120000},{"credit", -20},{ "sol",20},{ "carbon_emission",120} } },
        { "car_cng" , new Dictionary<string,float>{{"cost", 140000},{"credit", 200},{ "sol",25},{ "carbon_emission",20} } },
        { "car_electric" , new Dictionary<string,float>{{"cost", 145000},{"credit", 250},{ "sol",30},{ "carbon_emission",0} } },


    };

}
