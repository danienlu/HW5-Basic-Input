//前面設置資料的 String
string Name;
string Gender;
string Birthday;
string StudentID;

//這邊設置的是 CORRECT 是確認資料對不對的部分；WHICHONE 是選擇性修改的部分
//int CORRECT=0;
//int WHICHONE=0;
//原本設置 string 的目的是因為，Console.ReadLine 無法直接讀取輸入的 int
string CORRECT2="";
string WHICHONE2="";

Console.WriteLine("////////////////////////////////////");
Console.WriteLine("Homework5 基本資料輸入系統");
Console.WriteLine("////////////////////////////////////");
Console.WriteLine("                                    ");
Console.WriteLine("你好，這位屌絲；現在需要你輸入你的基本資料");
Console.WriteLine("------------------------------------");
Console.WriteLine("1.姓名");
Console.WriteLine("2.性別");
Console.WriteLine("3.出生年月日");
Console.WriteLine("4.學號");
Console.WriteLine("------------------------------------");

//這裡開始問答
Console.WriteLine("請問姓名是？");
Name = Console.ReadLine();
Console.WriteLine("                                    ");
Console.WriteLine("------------------------------------");
Console.WriteLine("你的名字是：" + Name);
Console.WriteLine("------------------------------------");
Console.WriteLine("                                    ");

Console.WriteLine("請問性別是？(1)男生，(2)女生，(其他)不知名性別");
Gender = Console.ReadLine();
//switch case 的目的就是選擇性的限制。 1 OR 2 OR 不知名性別
switch(Gender)
{
    case"1":    
        Gender = "男";
         break;
    case"2":
        Gender = "女";
         break;
    default:
        Gender = "不知名性別";
         break;
}
Console.WriteLine("                                    ");
Console.WriteLine("------------------------------------");
Console.WriteLine("性別：" + Gender);
Console.WriteLine("------------------------------------");
Console.WriteLine("                                    ");

Console.WriteLine("請問出生年月日？");
Birthday = Console.ReadLine();
Console.WriteLine("                                    ");
Console.WriteLine("------------------------------------");
Console.WriteLine("你的出生年月日是：" + Birthday);
Console.WriteLine("------------------------------------");
Console.WriteLine("                                    ");

Console.WriteLine("學號多少？");
StudentID = Console.ReadLine();
Console.WriteLine("                                    ");
Console.WriteLine("------------------------------------");
Console.WriteLine("你的學號是：" + StudentID);
Console.WriteLine("------------------------------------");
Console.WriteLine("                                    ");

//這裡開始設置迴圈, FOR 的目的就是讓他可以回來，如果 CORRECT 是 0，就回來，一定要設置兩個變數
//為什麼要 CORRECT != 1 ，我參考了柏君的做法；1)一定要兩個變數 FOR 才能成立，2）CORRECT = 1 代表問答結束

/*For(開始前執行；條件；下方code執行後執行)
{
符合條件後執行；
}*/
for(;CORRECT2 != "1";) //前面為什麼會有分號，因為原本是 CORRECT = 0 ,也就是開始前的執行條件，但是上面已經宣告過了，所以可以直接省略並分號帶過
{
    Console.WriteLine("麻煩確認一下資料對不對");
    Console.WriteLine("------------------------------------");
    Console.WriteLine(Name);
    Console.WriteLine(Gender);
    Console.WriteLine(Birthday);
    Console.WriteLine(StudentID);
    Console.WriteLine("------------------------------------");

    Console.WriteLine("////////////////////////////////////");
    Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
    Console.WriteLine("////////////////////////////////////");
    CORRECT2 = Console.ReadLine();           //這個部分是 讀取 String，因為無法讀取 Int
    //CORRECT = Convert.ToInt32(CORRECT2);     //Convert.ToInt 的部分是阿貴教我的，代表 int = 被轉換了的 (String)
    
    if (CORRECT2 == "1")                               //這個部分直接結束
    {
        Console.WriteLine("                                    ");
        Console.WriteLine("您好！( " + Name + " )");
        await Task.Delay(2000);
        Console.WriteLine("我是您的管理員：" + Name + "的老爹");
        await Task.Delay(2000);
        Console.WriteLine("性別是( " + Gender + " )嗎？" );
        await Task.Delay(2500);
        if(Gender == "男")
        {
            Console.WriteLine("真可惜是棒子....");
            await Task.Delay(1000);
            Console.WriteLine("算了吧");
        }
        else if (Gender == "女")
        {
            Console.WriteLine("身為您的老爹我不介意可以一直教你哦");
        }
        else if (Gender == "不知名性別")
        {
            Console.WriteLine("我不知道當初您在填寫的時候在想什麼但是我不會再追問的。");
        }
        await Task.Delay(2000);
        Console.WriteLine("( " + Birthday + " )是你的生日嗎？");
        await Task.Delay(1000);
        Console.WriteLine("我會好好記下來的，以後每年這一天我都不會在.");
        await Task.Delay(1000);
        Console.WriteLine("接下來是.....");
        await Task.Delay(2500);
        Console.WriteLine("學號是這個嗎？( " + StudentID + " )");
        await Task.Delay(1000);
        Console.WriteLine("好，這個是最重要的資料。已經確認完畢了");
        await Task.Delay(2000);
        Console.WriteLine("感謝您的填寫，過幾天就會去把你給賣了");
    }
    //這個部分很沒有必要，但是我覺得很好玩。

    else if (CORRECT2 == "2")                          //這個部分選擇錯誤填寫的部分
    {
        Console.WriteLine("                                    ");
        Console.WriteLine("哪裡填錯了？快快讓你改");
        Console.WriteLine("1.姓名");
        Console.WriteLine("2.性別");
        Console.WriteLine("3.生日");
        Console.WriteLine("4.學號");
        
        WHICHONE2 = Console.ReadLine();                  //一樣的操作，讀取 String, 轉換進去 Int 的庫存
        //WHICHONE = Convert.ToInt32(WHICHONE2);
        Console.WriteLine("                                    ");
        if(WHICHONE2 == "1")
        {
            Console.WriteLine("所以你的名字是什麼？");
            Name = Console.ReadLine();
            Console.WriteLine("                                    ");
            //CORRECT2 = "0";                                //寫完了後，直接回到一開始的 CORRECT = 0，也就是確認資料的部分
        }
        else if(WHICHONE2 == "2")               //WHICHONE 的部分 就是 選擇 1,2,3,4，你要修改哪一個
        {
            Console.WriteLine("性別是？(1)男生，(2)女生，(其他)不知名性別");
            Gender = Console.ReadLine();
            switch(Gender)
            {
                case"1":    
                    Gender = "男";
                    break;
                case"2":
                    Gender = "女";
                    break;
                default:
                    Gender = "不知名性別";
                    break;
            }
            Console.WriteLine("                                    ");
            //CORRECT2 = "0";
        }
        else if(WHICHONE2 == "3")
        {
            Console.WriteLine("所以你的生日是幾號？");
            Birthday = Console.ReadLine();
            Console.WriteLine("                                    ");
            //CORRECT2 = "0";
        }
        else if(WHICHONE2 == "4")
        {
            Console.WriteLine("所以你的生學號是幾號？");
            StudentID = Console.ReadLine();
            Console.WriteLine("                                    ");
            //CORRECT2 = "0";
        }
        else            //這邊放的是一個菜單，就是如果輸入 1 2 3 4 以外的數字，會直接帶回去確認資料，但是如果輸入很多東西就不管用了不知道為啥
        {
            Console.WriteLine("請你不要浪費我的時間");
            await Task.Delay(1000);         //這個是網上找的 delay 的寫法，很好玩。
            Console.WriteLine("                                    ");
            //CORRECT2 = "0";
        }
    }
    else
    {
        Console.WriteLine("請你不要浪費我的時間");      //這邊也是一樣
        await Task.Delay(1000);
        Console.WriteLine("                                    ");
        //CORRECT2 = "0"; 
    }
}

/*Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
CORRECT2 = Console.ReadLine();
CORRECT = Convert.ToInt32(CORRECT2);
if (CORRECT == 1)
{
    Console.WriteLine("好了謝謝填寫，你可以滾了");
}
else if (CORRECT == 2)
{
    Console.WriteLine("哪裡填錯了？快快讓你改");
    Console.WriteLine("1.姓名");
    Console.WriteLine("2.性別");
    Console.WriteLine("3.生日");
    Console.WriteLine("4.學號");
    
    WHICHONE2 = Console.ReadLine();
    WHICHONE = Convert.ToInt32(WHICHONE2);
    if(WHICHONE == 1)
    {
        Console.WriteLine("所以你的名字是什麼？");
        Name = Console.ReadLine();
        Console.WriteLine("好，快確認一下資料都對不對");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("姓名："+Name);
        Console.WriteLine("性別："+Gender);
        Console.WriteLine("生日："+Birthday);
        Console.WriteLine("學號："+StudentID);
        Console.WriteLine("------------------------------------");

        Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
        CORRECT2 = Console.ReadLine();
        CORRECT = Convert.ToInt32(CORRECT2);
    }
    else if(WHICHONE == 2)
    {
        Console.WriteLine("所以你的性別是什麼？");
        Gender = Console.ReadLine();
        Console.WriteLine("好，快確認一下資料都對不對");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("姓名："+Name);
        Console.WriteLine("性別："+Gender);
        Console.WriteLine("生日："+Birthday);
        Console.WriteLine("學號："+StudentID);
        Console.WriteLine("------------------------------------");

        Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
        CORRECT2 = Console.ReadLine();
        CORRECT = Convert.ToInt32(CORRECT2);
    }
    else if(WHICHONE == 3)
    {
        Console.WriteLine("所以你的生日是幾號？");
        Birthday = Console.ReadLine();
        Console.WriteLine("好，快確認一下資料都對不對");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("姓名："+Name);
        Console.WriteLine("性別："+Gender);
        Console.WriteLine("生日："+Birthday);
        Console.WriteLine("學號："+StudentID);
        Console.WriteLine("------------------------------------");

        Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
        CORRECT2 = Console.ReadLine();
        CORRECT = Convert.ToInt32(CORRECT2);
    }
    else if(WHICHONE == 4)
    {
        Console.WriteLine("所以你的生學號是幾號？");
        StudentID = Console.ReadLine();
        Console.WriteLine("好，快確認一下資料都對不對");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("姓名："+Name);
        Console.WriteLine("性別："+Gender);
        Console.WriteLine("生日："+Birthday);
        Console.WriteLine("學號："+StudentID);
        Console.WriteLine("------------------------------------");

        Console.WriteLine("請問資料都正確嗎？(1)正確、(2)再修改");
        CORRECT2 = Console.ReadLine();
        CORRECT = Convert.ToInt32(CORRECT2);
    }
    else
    {
        Console.WriteLine("請你不要浪費我的時間");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("資料都正確嗎？(1)正確、(2)再修改");
        CORRECT2 = Console.ReadLine();
        CORRECT = Convert.ToInt32(CORRECT2);
    }
}
/*{
    case "1":    
        break;
    /*case 2:
        Console.WriteLine("請問要修改哪個部分？");
        Console.WriteLine("(1)姓名、(2)性別、(3)生日、(4)學號");
        if(WHICHONE == 1)
        {
            Name = Console.ReadLine();
        }
        else if(WHICHONE == 2)
        {
            Gender = Console.ReadLine();
        }
        else if(WHICHONE == 3)
        {
            Birthday = Console.ReadLine();
        }
        else if (WHICHONE == 4)
        {
            StudentID = Console.ReadLine();
        }
        else
        {
            break;
        }
        break;
    */
    /*case "2":
        CORRECT = 2;
        break;
    default:
        break;
}
do
{
    Console.WriteLine("請問要修改哪個部分？");
        Console.WriteLine("(1)姓名、(2)性別、(3)生日、(4)學號");
        WHICHONE = Console.ReadLine();
        WHICHONE2= Convert.ToInt32(WHICHONE);
        if(WHICHONE2 == 1)
        {
            Name = Console.ReadLine();
            CORRECT = 0;
        }
        else if(WHICHONE2 == 2)
        {
            Gender = Console.ReadLine();
            CORRECT = 0;
        }
        else if(WHICHONE2 == 3)
        {
            Birthday = Console.ReadLine();
            CORRECT = 0;
        }
        else if (WHICHONE2 == 4)
        {
            StudentID = Console.ReadLine();
            CORRECT = 0;
        }
        else
        {
            break;
        }
}while (CORRECT == 2);*/
