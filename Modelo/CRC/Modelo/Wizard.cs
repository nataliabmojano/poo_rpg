namespace GFT.Modelo.CRC.Modelo
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack(){
            return this.Name + "Lançou a  magia";
        }

        public string Attack(int Bonus){
            return this.Name + "Lançou a magia com Bonus de ataque de" + Bonus;
         }  
    }   
}