import java.util.Scanner;
public class StudentManager {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter student name: ");
        String name = sc.nextLine();
        System.out.println("Student name is: " + name);
    }
}
