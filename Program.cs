using System;
namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int size = 4;
            IExecutable[] prints = new IExecutable[size];
            Person person = new Person(26, "Bisho", true);
            Student student = new Student(102, 0, -22, "Makarious", true, "SW");
            Employee employee = new Employee(101, 2500, 27, "Marina", false);
            Teacher teacher = new Teacher(102, 3500, 24, "Verina", false, "CS", 4);
            prints[0] = teacher;
            prints[1] = student;
            prints[2] = employee;
            prints[3] = person;

            Console.WriteLine(" Array elements Interface IPrint");
            for (int i = 0; i < prints.Length; i++)
            {
                prints[i].Print();
                Console.WriteLine("-------------------------------");
            }

            Person[] persons = new Person[size];
            for (int i = 0; i < size; i++)
                persons[i] = (Person)prints[i];


            Array.Sort(persons);
            Console.WriteLine(" After sorted array elements by Interface Icomparable");
            foreach (Person pers in persons)
                Console.WriteLine(" Name : {0}  Age : {1}  Gender :  {2}", pers.Name, pers.Age, pers.GenderMale);

            for (int i = 0; i < size; i++)
                persons[i] = (Person)prints[i];

            Console.WriteLine(" After sorted array elements by Interface ICompare)");
            Array.Sort(persons, new Sort_By_Name());
            foreach (Person pers in persons)
                Console.WriteLine(" Name : {0}  Age : {1}  Gender :  {2}", pers.Name, pers.Age, pers.GenderMale);

            Console.WriteLine(" index of element person");
            int index = Array.IndexOf(persons, person);
            Console.WriteLine(" Index : " + index);
           
         
            Person person1 = new Person(26, "Ivan", true);
            Console.WriteLine(" Print element name befor assignment");
            Console.WriteLine(" " + person1.Name);
            Person person2 = person1;
            person2.Name = "Danil";
            Console.WriteLine(" Print element name after assignment");
            Console.WriteLine(" " + person1.Name);

           
            Person person3 = new Person(26, "Nikita", true);
            Console.WriteLine(" Print element name befor used Interface IClonable");
            Console.WriteLine(" " + person3.Name);
            Person person4 = (Person)person3.Clone();
            person4.Name = "Artur";
            Console.WriteLine(" Print element name when used Interface IClonable");
            Console.WriteLine(" " + person4.Name);
            //Print number of stutent by section
            Student[] studentArray = new Student[10];
            studentArray[0] = new Student(101, 0, 26, "Maged", true, "SW");
            studentArray[1] = new Student(101, 0, 26, "David", true, "CS");
            studentArray[2] = new Student(101, 0, 26, "Ikrama", false, "SW");
            studentArray[3] = new Student(101, 0, 26, "Nastya", false, "CS");
            studentArray[4] = new Student(101, 0, 26, "Amer", true, "SW");
            studentArray[5] = new Student(101, 0, 26, "Mary", false, "CS");
            studentArray[6] = new Student(101, 0, 26, "Jhon", true, "SW");
            studentArray[7] = new Student(101, 0, 26, "Karma", false, "CS");
            studentArray[8] = new Student(101, 0, 26, "Pauls", true, "SW");
            studentArray[9] = new Student(101, 0, 26, "Fawzya", false, "CS");

            studentArray[0].Count_number_student_by_section(studentArray, "SW") ;
            IExecutable[] IPrintArray = new IExecutable[18];        
            #region assignments
            Person person1p = person1;
            Person person2p = person1p;
            Person person3p = person3;
            Person person4p = (Person)person3p.Clone();
            IPrintArray[0] = teacher;
            IPrintArray[1] = student;
            IPrintArray[2] = employee;
            IPrintArray[3] = person;
            IPrintArray[4] = person1p;
            IPrintArray[5] = person2p;
            IPrintArray[6] = person3p;
            IPrintArray[7] = person4p;
            IPrintArray[8] = studentArray[0];
            IPrintArray[9] = studentArray[1];
            IPrintArray[10] = studentArray[2]; 
            IPrintArray[11] = studentArray[3];
            IPrintArray[12] = studentArray[4];
            IPrintArray[13] = studentArray[5];
            IPrintArray[14] = studentArray[6];
            IPrintArray[15] = studentArray[7];
            IPrintArray[16] = studentArray[8];
            IPrintArray[17] = studentArray[9];
            #endregion
            Console.WriteLine(" Number of Males : " + Person.countMale);
            Console.WriteLine(" Number of Females : " + Person.countFemale);

            //Print names all Males and all Females
            Console.WriteLine(" Names all Males..........!");
            for (int i = 0; i < IPrintArray.Length; i++)
            {
                IPrintArray[i].Print_Names_Males();
            }
            Console.WriteLine(" Names all Females.........!");
            for (int i = 0; i < IPrintArray.Length; i++)
            {
                IPrintArray[i].Print_Names_Females();
            }

           
            Console.ReadKey();
        }
    }
}