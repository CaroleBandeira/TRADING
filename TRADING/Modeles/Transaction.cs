using System;

namespace TRADING.Modeles
{

    public class Transaction
    {
        #region Attributs

        public static List<Transaction> CollClasse = new List<Transaction>();


        private int _id;
        private DateTime _date;
        private int _quantite;
        private string _type;

        private Trader _trader;
        private Action2 _action;

        



        #endregion

        #region Constructeurs
        
        public Transaction(DateTime date, int quantite, string type, Trader trader, Action2 action)
        {
           
            _date = date;
            _quantite = quantite;
            _type = type;
            _trader = trader;
            _action = action;
        }




        #endregion

        #region Getters/Setters

        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public string Type { get => _type; set => _type = value; }
        public Trader Trader { get => _trader; set => _trader = value; }
        public Action2 Action2 { get => _action; set => _action = value; }
        #endregion

        #region Methodes

        // Méthodes supplémentaires ici si nécessaire

        #endregion
    }
}

