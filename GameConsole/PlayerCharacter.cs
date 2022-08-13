namespace GameConsole
{
    public class PlayerCharacter
    {
        private readonly ISpecialDefence _specialDefence;
        public string Name { get; set; }
        public int Health { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNew { get; set; }

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
            //DateOfBirth = null;
            //DaysSinceLastLogin = null;
        }

        public void Hit(int damage)
        {
            int damageReduction = 0;
            //if (_specialDefence != null)
            //{
                damageReduction = _specialDefence.CalculateDamageReduction();
            //}

            int totalDamageTaken = Math.Abs(damage - damageReduction);
            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");

        }
    }
}
