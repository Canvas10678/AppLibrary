using System;
enum Menu { Login = 1, Registeratation } // ใช้ตอนเลือกเมนู

namespace App_for_Digital_Library
{
    class Program
    {
        static PersonList personList;
        static void Main(string[] args)
        {
            PrintHead();
        }
        static void PrintHead() 
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("---------------------------");
            PrintMenuInputMenuFormKeyborad(); //ตัวเมนูกับการเลือกเมนู
        }
        static void PrintMenuInputMenuFormKeyborad()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu); //เงื่อนไขตอนที่เลือกเมนู
        }
        static void PreparePersonListWhenLoading() 
        {
            Program.personList = new PersonList();
        } 

        static void PresentMenu(Menu menu) 
        {
            if (menu == Menu.Login)
            {
                ShowYourInputLogin(); 
            }
            else if (menu == Menu.Registeratation)
            {
                ShowYourInputRegisterScreen();
            }
            else 
            {
                ShowYourInCorrectMassage(); //เมื่อกดผิดจะวนซ้ำจนกว่าจะกรอกถูกตามเมนู
            }
        }
        static void ShowYourInputLogin() 
        {
            Console.Clear();
            PrintLoginScreen();
        }
        static void ShowYourInputRegisterScreen()
        {
            Console.Clear();
            PrintListRegisterMenu();
        }
        static void ShowYourInCorrectMassage()
        {
            Console.Clear();
            Console.WriteLine("Menu is Incorrect Please try again");
            PrintMenuInputMenuFormKeyborad(); //ใช้ในการวนเมนูซ้ำ
        }
        static Student CreateNewStudent() 
        {
            return new Student(InputYourName(),InputYourPassword(),InputyourType(),InputYourStudentID());
        }
        static Employee CreateNewEmployee()
        {
            return new Employee(InputYourName(), InputYourPassword(), InputyourType(), InputEmployeeID());
        }
        static string InputYourName()
        {
            Console.Write("Input Name: ");

            return Console.ReadLine();
        }
        static string InputYourPassword()
        {
            Console.Write("Input Password : ");

            return Console.ReadLine();
        }
        static string InputyourType()
        {
            InputYourName();                       //พิมพ์ชื่อ
            InputYourPassword();                   //พิมพ์รหัสผ่าน
            Console.Write("Input Type : ");        //ระบุว่าเป็น Type Student กับ Type Employee

            int Number_Choose = int.Parse(Console.ReadLine()); //เงื่อนไขในการเลือก
            if (Number_Choose == 1)
            {
                InputYourStudentID();
                Console.Clear();
                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
                Console.Clear();
                PrintHead();
              
            }
            else
            {
                InputEmployeeID();
                Console.Clear();
                Employee employee = CreateNewEmployee();
                Program.personList.AddNewPerson(employee);
                Console.Clear();
                PrintHead();
               
            }
            return Console.ReadLine();
        }
        static string InputYourStudentID()
        {
            Console.Write("Student ID : ");

            return Console.ReadLine();
        }
        static string InputEmployeeID()
        {
            Console.Write("Employee ID : ");

            return Console.ReadLine();
        }
        static void PrintListRegisterMenu() 
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("--------------------");
            InputyourType();
            PrintMenuInputMenuFormKeyborad();
        }
        static void PrintLoginScreen() 
        {
            Console.WriteLine("Login Screen");
            Console.WriteLine("-------------");
            InputYourName();
            InputYourPassword();
        }
        static void CorrectlyFormInformationLogin() 
        {
                      
        }
    }
}
