using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
//Character("namn", hp, dmg, accuracy, armorClass);

Menu();
Console.ReadLine();

static void Menu(){
    string resp;
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a) Play");
    Console.WriteLine("b) Read rules");
    Console.WriteLine("c) Quit");
    resp=Console.ReadLine().ToLower();

    if(resp=="a"){
        Console.Clear();
        Play();
    }
    else if(resp=="c"){
        Console.Clear();
    }
    else if(resp=="b"){
        Console.Clear();
        Rules();
    }
    else{
        Console.Clear();
        Console.WriteLine("Not a valid response, enter one of the given choices respective letter");
        Console.ReadLine();
        Console.Clear();
        Menu();
    }
}

static void Rules(){
    Console.WriteLine("First, you choose a character");
    Console.WriteLine("Each character has different modifiers for damage and accuracy");
    Console.WriteLine("They also have different hp and armor");
    Console.WriteLine("When making an attack you roll a number between 1 and 20 to determine your accuracy");
    Console.WriteLine("Then your accuracy modifier adds to the number you roll, if your combined score exceeds your opponents armor you hit");
    Console.WriteLine("If you hit you then determine your damage");
    Console.WriteLine("You again roll a random number, this time between 1 and 12, and add your damage modifier");
    Console.WriteLine("First one to hit 0 hp loses");
    Console.WriteLine("Good luck!");
    Console.WriteLine("Press ENTER");
    Console.ReadLine();
    Console.Clear();
    Menu();
}

static void Play(){
    string resp;
    int hp1=0;
    int hp2=0;
    int dmg1=0;
    int dmg2=0;
    int accuracy1=0;
    int accuracy2=0;
    int armorClass1=0;
    int armorClass2=0;
    int dice=0;
    Random generator = new Random();
    int cha;

    Console.WriteLine("Choose your character");
    Console.WriteLine("a) Character 1");
    Console.WriteLine("Hp: 45");
    Console.WriteLine("Armor: 16");
    Console.WriteLine("Acc: +2");
    Console.WriteLine("Dmg: +2");

    Console.WriteLine("b) Character 2");
    Console.WriteLine("Hp: 25");
    Console.WriteLine("Armor: 13");
    Console.WriteLine("Acc: +3");
    Console.WriteLine("Dmg: +5");

    Console.WriteLine("c) Character 3");
    Console.WriteLine("Hp: 30");
    Console.WriteLine("Armor: 12");
    Console.WriteLine("Acc: +6");
    Console.WriteLine("Dmg: +3");
    resp=Console.ReadLine().ToLower();

    if(resp=="a"){
        hp1=45;
        armorClass1=16;
        accuracy1=2;
        dmg1=2;
        Console.WriteLine("You choose Character 1");
    }
    else if(resp=="b"){
        hp1=25;
        armorClass1=13;
        accuracy1=3;
        dmg1=5;
        Console.WriteLine("You choose Character 2");
    }
    else if(resp=="c"){
        hp1=30;
        armorClass1=12;
        accuracy1=6;
        dmg1=3;
        Console.WriteLine("You choose Character 3");
    }
    else{
        Console.WriteLine("Not a valid response, enter one of the given choices respective letter");
        Play();
    }
    cha = generator.Next(1,4);

   if(cha==1){
        hp2=45;
        armorClass2=16;
        accuracy2=2;
        dmg2=2;
        Console.WriteLine("Your opponent choose Character 1");
    }
    else if(cha==2){
        hp2=25;
        armorClass2=13;
        accuracy2=3;
        dmg2=5;
        Console.WriteLine("Your opponent choose Character 2");
    }
    else if(cha==3){
        hp2=30;
        armorClass2=12;
        accuracy2=6;
        dmg2=3;
        Console.WriteLine("Your opponent choose Character 3");
    }
    Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Let's get ready!!");
    Console.ReadLine();
    while(hp2>0&&hp1>0){
        Console.WriteLine("Press ENTER to attack");
        Console.ReadLine();
        dice=generator.Next(1,21);
        if(dice+accuracy1>=armorClass2){
            Console.WriteLine("You hit!");
            Console.WriteLine("Press ENTER to do damage");
            Console.ReadLine();
            dice=generator.Next(1,13);
           int dmg=dice+dmg1;
            hp2-=dmg;
            Console.WriteLine("You did "+dmg+" damage");
            if(hp2<0){
                hp2=0;
            }
            Console.WriteLine("Enemy has "+hp2+" health left");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("You missed...");
        }
        Console.WriteLine("Your enemy attacks!");
        dice=generator.Next(1,21);
        if(dice+accuracy2>=armorClass1){
            Console.WriteLine("They hit.");
            dice=generator.Next(1,13);
            hp1-=dice+dmg2;
            if(hp1<0){
                hp1=0;
            }
            Console.WriteLine("You have "+hp1+" health left");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("They missed!");
        }
    }
    if(hp1<=0&&hp2<=0){
        Console.WriteLine("It's a tie!!");
        Console.WriteLine("Not to bad");
        Console.ReadLine();
        Console.Clear();
        Menu();
    }
    else if(hp1<=0){
        Console.WriteLine("You lost...");
        Console.WriteLine("Better luck next time.");
        Console.ReadLine();
        Console.Clear();
        Menu();
    }
    else if(hp2<=0){
        Console.WriteLine("You won!!");
        Console.WriteLine("Good job!!");
        Console.ReadLine();
        Console.Clear();
        Menu();
    }
}  
int x=(int) 0f;