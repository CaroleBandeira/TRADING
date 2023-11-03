using System;
using System.Security.Cryptography;
using System.Transactions;

namespace TRADING.Modeles
{

    public class Trader
    {
        #region Attributs

        public static List<Trader> CollClasse = new List<Trader>();

        private int _id;
        private string _prenom;
        private string _nom;
        private DateTime _dateNaissance;
        private string _sexe;
        private string _email;
        private int _tel;

        private List<Transaction> _lesTransactions;


        #endregion

        #region Constructeurs

        public Trader(string prenom, string nom,DateTime dateNaissance, string sexe, string email, int tel)
        {
            _prenom = prenom;
            _nom = nom;
            _dateNaissance = dateNaissance;
            _sexe = sexe;
            _email = email;
            _tel = tel;
            _lesTransactions = new List<Transaction>();

            Trader.CollClasse.Add(this);

        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string Email { get => _email; set => _email = value; }
        public int Tel { get => _tel; set => _tel = value; }
        public List<Transaction> LesTransactions { get => _lesTransactions; set => _lesTransactions = value; }

        #endregion

        #region Methodes

        // Méthodes supplémentaires ici si nécessaire

        #endregion
    }

}