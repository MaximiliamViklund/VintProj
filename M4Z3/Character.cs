class Character{
        int hp1=0;
        int hp2=0;
        int dmg1=0;
        int dmg2=0;
        int accuracy1=0;
        int accuracy2=0;
        int armorClass1=0;
        int armorClass2=0;
        public Character(int namn, int hp, int dmg, int accuracy, int armorClass){
                namn=this.namn;
                hp=this.hp;
                str=this.str;
        }
        public void statistic(){
                Console.WriteLine(name);
                Console.WriteLine("Hp: "+hp);
                Console.WriteLine("Armor Class: "+armorClass);
                Console.WriteLine("Accuracy modifier: +"+accuracy);
                Console.WriteLine("Damage modifier: +"+dmg);
        }
}