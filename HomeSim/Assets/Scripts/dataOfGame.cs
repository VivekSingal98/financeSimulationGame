using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelTarget
{
    public float levelNo;
    public float credits ;
    public float assets;
    public float sol;
    public float salary;
    public float monthEndExpenses;
    public Dictionary<string, float> damages;
    public levelTarget(float f, float a, float b, float c, float d,float e)
    {
        levelNo = f;
        credits = a;
        assets = b;
        sol = c;
        monthEndExpenses = d;
        salary = e;
        damages = new Dictionary<string, float>();
    }
}
public static class dataOfGame
{
    public static float netSavings = 600000f;
    public static float totCredits = 0.00f;
    public static float totSOL = 0.00f;
    public static int currLevel = 1;
    public static float totInvest = 0;


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
        {"fridge_5Star",new Dictionary<string, float>{ { "cost",20000},{"credit",70 },{"sol",7}, {"cfc",500},{"energy",1f}}},


        {"light_incandescent",new Dictionary<string, float>{ { "cost",30},{"credit",-5 },{"sol",0},{"energy",2f }}},
        {"light_cfl",new Dictionary<string, float>{ { "cost",80},{"credit",0.5f },{"sol",0.1f},{"energy",1.5f}}},
        {"light_led",new Dictionary<string, float>{ { "cost",100},{"credit",1 },{"sol",0.1f},{"energy",1f}}},

        {"furniture_plastic",new Dictionary<string, float>{ { "cost",1500},{"credit",0 },{"sol",0.5f}}},
        {"furniture_wood",new Dictionary<string, float>{ { "cost",2500},{"credit",10 },{"sol",0.8f}}},
        {"furniture_steel",new Dictionary<string, float>{ { "cost",2700},{"credit",15 },{"sol",1}}},

        {"insurance_health",new Dictionary<string, float>{ { "cost",2000},{"credit",20 },{"claim",200000 },{"sol",3}}},
        {"insurance_home",new Dictionary<string, float>{ { "cost",3000},{"credit",20 }, { "claim", 300000 }, { "sol",3}}},
        {"insurance_car",new Dictionary<string, float>{ { "cost",2000},{"credit",20 }, { "claim", 100000 }, { "sol",3}}},

        {"fan_fan",new Dictionary<string, float>{ { "cost",1500},{"credit",0 },{"sol",0.5f}}},

        {"clothes_foreign",new Dictionary<string, float>{ { "cost",5000},{"credit",0 },{"sol",1.5f}}},
        {"clothes_indian",new Dictionary<string, float>{ { "cost",3000},{"credit",30 },{"sol",1}}},

        {"electronics_laptop",new Dictionary<string, float>{ { "cost",20000},{"credit",100 },{"sol",5}}},
        {"electronics_ps4",new Dictionary<string, float>{ { "cost",20000},{"credit",0 },{"sol",5}}},

        {"decor_paint",new Dictionary<string, float>{ { "cost",10000},{"credit",0 },{"sol",3}}},

        {"plants_plants",new Dictionary<string, float>{ { "cost",2000},{"credit",10 },{"sol",1}}},
    };

    public static Dictionary<string, Dictionary<string, float>> statsOfInvest = new Dictionary<string, Dictionary<string, float>>
    {
        {"realestate_house1",new Dictionary<string, float>{ { "cost",400000},{"credit",600 },{"sol",50}}},
        {"realestate_house2",new Dictionary<string, float>{ { "cost",500000},{"credit",800 },{"sol",55}}},
        {"realestate_house3",new Dictionary<string, float>{ { "cost",600000},{"credit",1000 },{"sol",60}}},

        {"stocks_stocka",new Dictionary<string, float>{ { "cost",200},{"credit",0.5f },{"sol",0.1f}}},
        {"stocks_stockb",new Dictionary<string, float>{ { "cost",500},{"credit",1 },{"sol",0.1f}}},
        {"stocks_stockc",new Dictionary<string, float>{ { "cost",2000},{"credit",2 },{"sol",0.1f}}},

        {"banks_saving",new Dictionary<string, float>{ { "min_amount",1000},{"interest",4 },{ "min_withdrawal_tenure",0},{"credit",0.005f },{"sol",0.0003f}}},
        {"banks_fd",new Dictionary<string, float>{ { "min_amount",20000},{"interest",8},{ "min_withdrawal_tenure",2},{"credit",0.00375f },{"sol",0.00015f}}},


    };

    public static Dictionary<string, Dictionary<string, float>> statsOfLoan = new Dictionary<string, Dictionary<string, float>>
    {

        {"loan_home",new Dictionary<string, float>{ { "duration",6},{"min_assets",50000 },{ "interest",9.25f},{"credit",-100 },{"sol",-10}}},
        {"loan_health",new Dictionary<string, float>{ { "duration",4},{"min_assets",20000 },{ "interest",8.75f},{"credit",-100 },{"sol",-5}}},


    };

    public static List<levelTarget> levelInfo = new List<levelTarget>
    {
        { new levelTarget(1,200,15000,10,5000,60000) },
    };



}
