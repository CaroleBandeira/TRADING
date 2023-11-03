using System;

namespace TRADING.Modeles
{
    public class Action2
    {
        #region Attributs

        public static List<Action2> CollClasse = new List<Action2>();


        private string _isin;
        private string _nom;
        private double _prix;

        private List<CoursAction> _lHistoriqueCours;
        private List<Transaction> _lesTransactions;
        private List<Trader> _lesTradersInteresses;

        #endregion

        #region Constructeurs
        public Action2(string isin, string nom, double prix)
        {
            _isin = isin;
            _nom = nom;
            _prix = prix;
            _lesTransactions = new List<Transaction>();
            _lHistoriqueCours = new List<CoursAction>();
            _lesTradersInteresses = new List<Trader>();

            Action2.CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters


        public string Isin { get => _isin; set => _isin = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public List<CoursAction> LHistoriqueCours { get => _lHistoriqueCours; set => _lHistoriqueCours = value; }
        public List<Transaction> LesTransactions { get => _lesTransactions; set => _lesTransactions = value; }
        public List<Trader> LesTradersInteresses { get => _lesTradersInteresses; set => _lesTradersInteresses = value; }
        #endregion

        #region Methodes

        public List<Trader> _lesTradersInteresses
        
        {
            if (Trader._listeInteret.Contains(Action2 monAction))
            {
            _lesTradersInteresses.Add(Trader) 
            
        }
        

        #endregion
    }
}

