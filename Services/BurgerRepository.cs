using menukort.model;

namespace menukort.Services
{
    public class BurgerRepository
    {
        // instans felt 
        private List<Burger> _liste;


        // evt property
        public List<Burger> ListeAfBurger
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public BurgerRepository(bool mocData = false)
        {
            _liste = new List<Burger>();


            if (mocData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _liste.Clear();
            _liste.Add(new Burger(1, "Classic Hamburger", "varmt", 20, false));
            _liste.Add(new Burger(2, "Classic Cheeseburger", "kold", 204, false));
            _liste.Add(new Burger(3, "Classic Baconburger", "koldyes", 2322, false));
            _liste.Add(new Burger(4, "Classic Baconcheeseburger", "koldno", 24404, false));
            _liste.Add(new Burger(5, "Big Mamma Burger", "koldsd", 219204, false));
        }

        //Metoder

        public void Tilføj(Burger Burger)
        {
            _liste.Add(Burger);
        }

        public List<Burger> HentAlleBurger()
        {
            return _liste;
        }



        public Burger Slet(Burger Burger)
        {
            if (_liste.Contains(Burger))
            {
                _liste.Remove(Burger);
                return Burger;
            }

            // findes ikke
            return null;
        }
    }
}
