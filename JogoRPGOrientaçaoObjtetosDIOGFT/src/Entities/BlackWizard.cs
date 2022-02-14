namespace JogoRPGOrientaçãoObjetos.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lançou Magia Negra";
        }
        public string Attack(int Bonus){
            if (Bonus > 4){
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou uma magio com força fraca com bonus de " + Bonus;
            }
            
        }


    }
}