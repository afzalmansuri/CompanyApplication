using CompanyApp.Context;
using CompanyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyApp.Controller
{
    class CompanyController
    {
        int pid;
        int unitid;
        CompanyContext db = new CompanyContext();
        Program program = new Program();
   /*     EmployeeController employeeController = new EmployeeController();*/

        string unitname;

        public void Welcome()
        {
           

            Console.WriteLine("**********   Welcome To Company Handle **************");

            Console.Write(" ENter PINCODE For Use The System  :   ");
            int pincode = Convert.ToInt32(Console.ReadLine());
           

            if (pincode == 1234)
            {
                CompanyMenu();
            }
            else
            {
                Console.WriteLine("****** Invalid PINCODE *****");
                program.Menu();
            }
}

        public void CompanyMenu()
        {
           
                Console.WriteLine("************************************** ");
                Console.WriteLine("1. View BusinessUnit ");
                Console.WriteLine("2. Add Business Unit");
                Console.WriteLine("3. Add Employee ");
                Console.WriteLine("4. View Employee");
                Console.WriteLine("5. Add Project ");
                Console.WriteLine("6. View Projects ");
                Console.WriteLine("7. View Project Team");
                Console.WriteLine("8. Add project Team");
                Console.WriteLine("9. Exit");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        viewBusinessUnit();
                        break;
                    case 2:
                        AddCompanyBusinessUnit();
                        break;

                    case 3:
                       AddEmployee();
                        break;
                    case 4:
                        ViewEmployee();
                        break;
                    case 5:
                        AddProject();
                        break;
                    case 6:
                        ViewProject();
                        break;


                    case 7:
                        ViewProjectTeam();
                        break;
                    case 8:
                        AddProjectTeam();
                        break;
                    case 9:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice  ");
                        Welcome();
                        break;
                }

           
        }


        public void viewBusinessUnit()
        {
           var businessobj= db.BusinessUnits;
            Console.WriteLine(" Business Units Are .......");
            foreach(var single in businessobj)
            {
                Console.WriteLine("BusinessUnit Name : " + single.BusinessUnitName);
            }
            CompanyMenu();
        
        }


        public void AddCompanyBusinessUnit()
        {
            Console.Write("Enter Business Unit Name : ");
            unitname = Console.ReadLine();

            try
            {
                BusinessUnit businessunit = new BusinessUnit(unitname);
                db.BusinessUnits.Add(businessunit);
                db.SaveChanges();
                Console.WriteLine("Business Unit Added Sucessfully....!");
                viewBusinessUnit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something Went Wrong.....");
                CompanyMenu();
            }

        }

        public void AddProject()
        {
            Console.Write("Enter Project Name : ");
            string pname = Console.ReadLine();
            Console.Write("Enter Business Unit Name : ");
            string unitname = Console.ReadLine();

            var unitobj = db.BusinessUnits.Where(t => t.BusinessUnitName == unitname);

            foreach (var single in unitobj)
            {
                unitid = single.BusinessUnitId;
            }

            try
            {
                Project project = new Project(pname,unitid);
                db.Projects.Add(project);
                db.SaveChanges();

                Console.WriteLine(" Project Sucessfully Added ....!!!");
                ViewProject();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something Went Wrong........");
                CompanyMenu();
            
            }

        }


        public void ViewProject()
        {
            var viewproobj = db.vProjects;
            foreach(var single in viewproobj)
            {
                Console.WriteLine("Project Id : "+single.ProjectId +" || Project Name : "+ single.ProjectName +" || Unit Name : "+ single.BusinessUnitName);
                
            }
            CompanyMenu();
        }



        public void AddEmployee()
        {

            Console.Write("Enter Employee Name : ");
            string empname = Console.ReadLine();
            Console.Write("Enter Mobile Number : ");
            string empnumber = Console.ReadLine();
            Console.Write("Enter Email : ");
            string empemail = Console.ReadLine();
            Console.Write(" Enter Gender : ");
            string gender = Console.ReadLine();
            Console.Write("Enter Qualification : ");
            string qualification = Console.ReadLine();
            Console.Write("Enter Experience : ");
            string experience = Console.ReadLine();

            DateTime now = DateTime.Now;

            Console.Write("Enter Status : ");
            string status = Console.ReadLine();

            Console.Write("Enter Business Unit Name : ");
            string unitname = Console.ReadLine();

            var unitobj = db.BusinessUnits.Where(t => t.BusinessUnitName == unitname);

            foreach (var single in unitobj)
            {
                unitid = single.BusinessUnitId;
            }


            if (unitobj.Count() >= 1)
            {
                try
                {
                    Employee employee = new Employee(empname, empnumber, empemail, gender, qualification, experience, now, status, unitid);
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    Console.WriteLine("Employee Added Sucessfully....!!");

                   CompanyMenu();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Something Went Wrong.........");
                }
            }
            else
            {
                Console.WriteLine("Unit Name Not Found ....");
                CompanyMenu();
            }
         }


        public void ViewEmployee()
        {
            Console.Write("Enter Unit Name : ");
            string uname = Console.ReadLine();
            var emprecordobj = db.vEmployees.Where(t=>t.BusinessUnitName==uname);
            if(emprecordobj.Count()>=1)
            {
                Console.WriteLine("Employees Are .......");
                foreach (var single in emprecordobj)
                {
                    Console.WriteLine("Employee Name : " + single.Name + " || Mobile Number : " + single.MobileNumber + " || Employee Email : " + single.Email + " || Employee Gender : " + single.Gender + " || Employee Qualification : " + single.Qualification + " || Employee Experience : " + single.Experience + " || Employee Joining Date : " + single.JoiningDate + " || Employee Work Status : " + single.Status + " || Business Unit : " + single.BusinessUnitName);
                }
                CompanyMenu();
            }
            else
            {
                Console.WriteLine("Invalid Unit Name.....!!!");
                CompanyMenu();
            }

            
        }

       


        public void AddProjectTeam()
        {
            Console.Write("Enter Unit Name : ");
            string uname = Console.ReadLine();

            var dobj = db.BusinessUnits.Where(t => t.BusinessUnitName == uname);
            if(dobj.Count()>=1)
            {
                var probj=db.vProjects.Where(t => t.BusinessUnitName == uname);

                foreach(var single in probj)
                {
                    Console.WriteLine("Project Name : " + single.ProjectName + " || BusinessUnitName : " + single.BusinessUnitName);
                }


                Console.Write("Press 1 To Enter the Team Member ");
                int memberchoice = Convert.ToInt32(Console.ReadLine());
                if(memberchoice==1)
                {
                    Console.Write("Enter Project Name : ");
                    string pname = Console.ReadLine();
                    AddTeamMember(pname);
                }
                else
                {
                    Console.WriteLine("Invalid Number Entered...!!");
                    AddProjectTeam();
                }

               

            }
            else
            {
                Console.WriteLine("DepartMent Not Found");
                CompanyMenu();
            }

        }

        public void AddTeamMember(string pname)
        {
            
            
           
                var pobj = db.Projects.Where(t => t.ProjectName == pname);

                if (pobj.Count() >= 1)
                {
                    foreach (var single in pobj)
                    {
                        pid = single.ProjectId;
                    }


                    Console.Write("Enter Employee Id : ");
                    int eid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Designation : ");
                    string desg = Console.ReadLine();

                    try
                    {
                        ProjectTeam projectTeam = new ProjectTeam(pid, eid, desg);
                        db.ProjectTeams.Add(projectTeam);
                        db.SaveChanges();
                        Console.WriteLine("Team Successfully Created ......!!!");
                        CompanyMenu();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Something Went Wrong....!!!");
                        CompanyMenu();

                    }
                }
                else
                {
                    Console.WriteLine("Project Not Found");
                CompanyMenu();
                }

         }

        public void ViewProjectTeam()
        {
            Console.Write("Enter Project Name : ");
            string projectname = Console.ReadLine();

            var projectteamobj = db.vProjectTeams.Where(t => t.ProjectName == projectname);
            foreach(var single in projectteamobj)
            {
                Console.WriteLine("Project Name : "+single.ProjectName +" || Employee ID : "+ single.EmployeeId+" || Employee Name : "+  single.Name +"|| Employee Mobile Number : "+ single.MobileNumber+ " || Employee Email : " +single.Email +" || Employee Status : "+ single.Status+" || Unit : "+ single.BusinessUnitName);
           
            }
            CompanyMenu();

        }

       
    }
}
