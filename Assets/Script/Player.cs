using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool[] is_Having = {false,false,false,true};
    public static int equipment = 3;

    public static void set_having(int i){
        is_Having[i] = true;  
    }

    public static bool check_having(int i){
        return is_Having[i];
    }

    public static void set_equipment(int i){
        equipment = i;
    }
    
    public static int get_equipment(){
        return Player.equipment;
    }

}