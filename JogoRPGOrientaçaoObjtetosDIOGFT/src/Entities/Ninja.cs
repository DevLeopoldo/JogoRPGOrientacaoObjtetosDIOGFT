namespace JogoRPGOrientaçãoObjetos.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }  
        public override string Attack(){
            return this.Name + " Atacou suas estrelinhas ninja";
        }
        public  string Attack(int Bonus){
             if (Bonus > 6){
                return this.Name + " Lançou suas Estralas da morte super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou uma Estrelinha ninja com força fraca, com bonus de " + Bonus;
            }
        }
    }
}