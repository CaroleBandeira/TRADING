using System;

namespace TRADING.Modeles
{
    public class Action
    {
        #region Attributs

        public static List<Action> CollClasse = new List<Action>();


        private string _isin;
        private string _nom;
        private double _prix;

        private List<CoursAction> _lHistoriqueCours;
        private List<Transaction> _lesTransactions;

        #endregion

        #region Constructeurs
        public Action(string isin, string nom, double prix)
        {
            _isin = isin;
            _nom = nom;
            _prix = prix;
            _lesTransactions = new List<Transaction>();
            _lHistoriqueCours = new List<CoursAction>();

            Action.CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters


        public string Isin { get => _isin; set => _isin = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Prix { get => _prix; set => _prix = value; }
        #endregion

        #region Methodes

        // Méthodes supplémentaires ici si nécessaire

        #endregion
    }
}

