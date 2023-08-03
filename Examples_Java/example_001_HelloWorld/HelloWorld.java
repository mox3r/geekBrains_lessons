package Examples_Java.example_001_HelloWorld;
import java.util.Scanner;

class HelloWorld {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Print something:");
        String str = sc.nextLine();
        System.out.println("You enter: " + str);
        sc.close();
    }
}