using Registration.Models;
using System;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();


            //Console.WriteLine(user.ShowInfo());
            //user.PasswordChecker(user.Password);

            //User user1 = new User("Ali", "Quliyev", "neon.n.2002@mail.ru", "ff2002");
            //Console.WriteLine(user1.ShowInfo());
            //user1.PasswordChecker(user1.Password);


        }

        public static void Menu()
        {
            Student student = new Student("", "", 0);
            Group group = new Group("", 0);

            User user = new User("Akif", "Quliyev", "leon.l.2002@mail.ru", "Akif2002");
            Console.WriteLine("\n Enter user name: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("\n Enter user surname: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("\n Enter user email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine("\n Enter user password: ");
            user.Password = Console.ReadLine();

            Console.WriteLine(@"                                                                              
                                                                              
█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝
                                                                              
                                                                              
                                                                              ");
            Console.WriteLine(@" █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████    ▄▄▄█████▓ ▒█████  
▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀    ▓  ██▒ ▓▒▒██▒  ██▒
▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███      ▒ ▓██░ ▒░▒██░  ██▒
░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄    ░ ▓██▓ ░ ▒██   ██░
░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒     ▒██▒ ░ ░ ████▓▒░
░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░     ▒ ░░   ░ ▒░▒░▒░ 
  ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░       ░      ░ ▒ ▒░ 
  ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░        ░      ░ ░ ░ ▒  
    ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                ░ ░  
                        ░                                                        
 ███▄ ▄███▓ ▄▄▄       ██▓ ███▄    █     ███▄ ▄███▓▓█████  ███▄    █  █    ██     
▓██▒▀█▀ ██▒▒████▄    ▓██▒ ██ ▀█   █    ▓██▒▀█▀ ██▒▓█   ▀  ██ ▀█   █  ██  ▓██▒    
▓██    ▓██░▒██  ▀█▄  ▒██▒▓██  ▀█ ██▒   ▓██    ▓██░▒███   ▓██  ▀█ ██▒▓██  ▒██░    
▒██    ▒██ ░██▄▄▄▄██ ░██░▓██▒  ▐▌██▒   ▒██    ▒██ ▒▓█  ▄ ▓██▒  ▐▌██▒▓▓█  ░██░    
▒██▒   ░██▒ ▓█   ▓██▒░██░▒██░   ▓██░   ▒██▒   ░██▒░▒████▒▒██░   ▓██░▒▒█████▓     
░ ▒░   ░  ░ ▒▒   ▓▒█░░▓  ░ ▒░   ▒ ▒    ░ ▒░   ░  ░░░ ▒░ ░░ ▒░   ▒ ▒ ░▒▓▒ ▒ ▒     
░  ░      ░  ▒   ▒▒ ░ ▒ ░░ ░░   ░ ▒░   ░  ░      ░ ░ ░  ░░ ░░   ░ ▒░░░▒░ ░ ░     
░      ░     ░   ▒    ▒ ░   ░   ░ ░    ░      ░      ░      ░   ░ ░  ░░░ ░ ░     
       ░         ░  ░ ░           ░           ░      ░  ░         ░    ░         
                                                                                 ");
            Console.WriteLine(@"                                                                              
                                                                              
█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝
                                                                              
                                                                              
                                                                              ");
            Menu:
            Console.WriteLine("\n Case 1: Show info about user." +
                              "\n Case 2: Create new group." +
                              "\n Case 3: Edit Menu.");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(user.ShowInfo());
                        goto Menu;
                    }
                case 2:
                    {
                        Console.Clear();
                        group.CreateGroup();
                        goto Menu;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                              
                                                                              
█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝
                                                                              
                                                                              
                                                                              ");
                        Console.WriteLine(@" █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████    ▄▄▄█████▓ ▒█████     
▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀    ▓  ██▒ ▓▒▒██▒  ██▒   
▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███      ▒ ▓██░ ▒░▒██░  ██▒   
░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄    ░ ▓██▓ ░ ▒██   ██░   
░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒     ▒██▒ ░ ░ ████▓▒░   
░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░     ▒ ░░   ░ ▒░▒░▒░    
  ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░       ░      ░ ▒ ▒░    
  ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░        ░      ░ ░ ░ ▒     
    ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                ░ ░     
                        ░                                                           
▓█████ ▓█████▄  ██▓▄▄▄█████▓    ███▄ ▄███▓▓█████  ███▄    █  █    ██                
▓█   ▀ ▒██▀ ██▌▓██▒▓  ██▒ ▓▒   ▓██▒▀█▀ ██▒▓█   ▀  ██ ▀█   █  ██  ▓██▒               
▒███   ░██   █▌▒██▒▒ ▓██░ ▒░   ▓██    ▓██░▒███   ▓██  ▀█ ██▒▓██  ▒██░               
▒▓█  ▄ ░▓█▄   ▌░██░░ ▓██▓ ░    ▒██    ▒██ ▒▓█  ▄ ▓██▒  ▐▌██▒▓▓█  ░██░               
░▒████▒░▒████▓ ░██░  ▒██▒ ░    ▒██▒   ░██▒░▒████▒▒██░   ▓██░▒▒█████▓                
░░ ▒░ ░ ▒▒▓  ▒ ░▓    ▒ ░░      ░ ▒░   ░  ░░░ ▒░ ░░ ▒░   ▒ ▒ ░▒▓▒ ▒ ▒                
 ░ ░  ░ ░ ▒  ▒  ▒ ░    ░       ░  ░      ░ ░ ░  ░░ ░░   ░ ▒░░░▒░ ░ ░                
   ░    ░ ░  ░  ▒ ░  ░         ░      ░      ░      ░   ░ ░  ░░░ ░ ░                
   ░  ░   ░     ░                     ░      ░  ░         ░    ░                    
        ░                                                                           ");
                        Console.WriteLine(@"                                                                              
                                                                              
█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝
                                                                              
                                                                              
                                                                              ");
                        EditMenu:
                        Console.WriteLine("\n Case 1: Show all students" +
                                          "\n Case 2: Get student by id" +
                                          "\n Case 3: Add student" +
                                          "\n Case 0: Quit.");

                        int choice1 = Convert.ToInt32(Console.ReadLine());

                        switch (choice1)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    group.GetAllStudents();
                                    goto EditMenu;
                                }
                            case 2:
                                {
                                    Console.Clear();
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    group.GetStudent(id);
                                    goto EditMenu;
                                }
                            case 3:
                                {
                                    Console.Clear();
                                    student.CreateStudent();
                                    group.AddStudent(student);
                                    goto EditMenu;
                                }
                            case 0:
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"  ▄████  ▒█████   ▒█████  ▓█████▄     ▄▄▄▄ ▓██   ██▓▓█████ 
 ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌   ▓█████▄▒██  ██▒▓█   ▀ 
▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░██   █▌   ▒██▒ ▄██▒██ ██░▒███   
░▓█  ██▓▒██   ██░▒██   ██░░▓█▄   ▌   ▒██░█▀  ░ ▐██▓░▒▓█  ▄ 
░▒▓███▀▒░ ████▓▒░░ ████▓▒░░▒████▓    ░▓█  ▀█▓░ ██▒▓░░▒████▒
 ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒    ░▒▓███▀▒ ██▒▒▒ ░░ ▒░ ░
  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒    ▒░▒   ░▓██ ░▒░  ░ ░  ░
░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░     ░    ░▒ ▒ ░░     ░   
      ░     ░ ░      ░ ░     ░        ░     ░ ░        ░  ░
                           ░               ░░ ░            ");
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    goto Menu;
                                }
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n Wrong choice. \n Please try again.");
                                    goto EditMenu;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\n Wrong choice. \n Please try again.");
                        goto Menu;
                    }                                    
            }
        }
    }
}
