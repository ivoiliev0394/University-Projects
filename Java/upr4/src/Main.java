import java.util.Scanner;

/*
string - immutable
**metodi za analiz:
1).equals(String)
2).indexOf(string s)
3).indexOf(string s, int start)
4).length()
5).toLowerCase() and .toUpperCase()
6).charAt(int index)
7).compareTo(string s)
8).concat(string s)
9).contains(string s)
10).beginwith(string) and endwith(string)
11).replace(char c1,char c2)
12)replaceAll(string s1,string s1)
-------------------------------------------------------------------------------
!!!!!! StringBuffer(thead safe - sinhroniziran -> po baven)/StringBuilder(thread unsafe - nesinhroniziran -> po burz ) -mutable !!!!!!
-------------------------------------------------------------------------------

* */
public class Main
{
    public static void main(String[] args)
    {
        /*
        //zad 1
        String username="admin";
        String password="local@#";
        int attempts=3;
        boolean LoginOk=false;
        while (attempts!=0)
        {
            Scanner scan = new Scanner(System.in);
            System.out.println("You have " + attempts + " attempts");
            System.out.print("Enter username:");
            String userName = scan.nextLine();
            System.out.print("Enter password:");
            String passWord = scan.nextLine();
            if(userName.equals(username)&&password.equals(passWord)){ LoginOk=true; break;}
            attempts--;
        }
        if(LoginOk) System.out.println("You have entered your account");
        else System.out.println("You have run out of attempts!\nYou are blocked!");*/

    /*    //zad 2
        String[] username={"admin","root","user"};
        String[] password={"local@#","root@local","qwerty"};
        int attempts=3;
        boolean LoginOk=false;
        while (attempts>0)
        {
            Scanner scan = new Scanner(System.in);
            System.out.println("You have " + attempts + " attempts");
            System.out.print("Enter username:");
            String userName = scan.nextLine();
            System.out.print("Enter password:");
            String passWord = scan.nextLine();
            for (int i = 0; i < username.length; i++)
            {
                    if (userName.equals(username[i]) && passWord.equals(password[i]))
                    {
                        LoginOk = true;
                        break;
                    }
            }
            if(LoginOk)break ;
            attempts--;
        }
        if(LoginOk) System.out.println("You have entered your account");
        else System.out.println("You have run out of attempts!\nYou are blocked!");*/
        String input;
        input="Java is object oriented language. Java has bytecode. Java runs on YUM";
        Scanner scan = new Scanner(System.in);
        int count=0;
        System.out.print("Enter word:");
        String word = scan.nextLine();
        //input.
        System.out.println(count);
    }
}