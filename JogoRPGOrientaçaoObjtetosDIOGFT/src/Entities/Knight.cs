namespace JogoRPGOrientaçãoObjetos.src.Entities
{
    public class Knight : Hero
    {
       public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        } 
       public override string Attack(){
            return this.Name + " Atacou com sua espada";
        }
        public  string attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Atacou golpe de espada super efetivo com bonus de " + Bonus;
            }else{
                return this.Name + " atacou com força fraca com bonus de " + Bonus;
            }
        }
    }
}