using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    string heroName = "فتيات القوة";
    int heroHeight = 170;
    int heroAge = 22;
    int heroSuperPower = 100;

    // شخصية شريرة في كرتون فتيات القوة
    string vililanName = "موجو جوجو";
     int vililanHeight = 150;
     int vililanAge = 60;
     string vililanSuperPower = "None" ;
    
    int ageDifference = 60 - 22;

    // Start is called before the first frame update
    void Start()
    {

        print(heroName + "طولهم" + heroHeight + "عمرهم" + heroAge + "قوتهم الخارقة" +heroSuperPower);
        print(vililanName + "طوله" + vililanHeight + "عمره" + vililanAge + "قوته الخارقة" + vililanSuperPower);

        print(ageDifference);

        print(heroName + "طولهم" + heroHeight * 5 + "عمرهم" + heroAge + "قوتهم الخارقة" + heroSuperPower);
        print(vililanName + "طوله" + vililanHeight / 5 + "عمره" + vililanAge + "قوته الخارقة" + vililanSuperPower);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
