Random r = new Random();
string[] NamesOfPeople = new string[1000];
string[] FirstName = new string[10] { "Sakon ", "Storm ", "Albert ", "Richard ", "Alicia ", "Martha ", "Brick ", "Apple ", "Hanna ", "Valia " };
string[] MiddleName = new string[10] { "A ", "M ", "D ", "K ", "S ", "F ", "B ", "G ", "O ", "T " };
string[] LastName = new string[10] { "Hadley ", "Smith ", "Mars ", "Keys ", "Stewert ", "Write ", "Stonewall ", "Baker ", "Bard ", "Maker " };
string[] Job = new string[] { ": Material Scientist", ": AreoSpace Engineer", ": Propulsion Specialist", ": SpaceCraft Subsystems Engineer", ": AstroPhysicist" };
double[] Decimal = new double[]{.25,.5,.75};
int Counter = 0;

for (int x = 0; x < FirstName.Length; x++)
{
    for (int y = 0; y < MiddleName.Length; y++)
    {
        for (int z = 0; z < LastName.Length; z++)
        { 
            int randomdecimal = r.Next(0,3);
            int random = r.Next(0, 5);
            int randomWage = r.Next(7,80);
            double Wage = (double)randomWage;
             Wage = Wage + Decimal[randomdecimal];
            NamesOfPeople[x] = FirstName[x] + MiddleName[y] + LastName[z] + Job[random];
            Counter++;
            Console.WriteLine($"{Counter}: {NamesOfPeople[x]}: Hourly wage: ${Wage} Yearly Salary: ${Wage*40*50} ");

        }
    }
}