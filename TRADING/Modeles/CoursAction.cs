using System;

namespace TRADING.Modeles
{
    public class CoursAction
    {
        #region Attributs

        public static List<CoursAction> CollClasse = new List<CoursAction>();

        private int _idCours;
        private DateTime _dateCours;
        private double _prixCours;

        private Action2 _action;

        #endregion

        #region Constructeurs

        public CoursAction(DateTime dateCours, double prixCours, Action2 action)
        {
            _dateCours = dateCours;
            _prixCours = prixCours;
            _action = action;
        }




        #endregion

        #region Getters/Setters

        public int IdCours { get => _idCours; set => _idCours = value; }
        public DateTime DateCours { get => _dateCours; set => _dateCours = value; }
        public double PrixCours { get => _prixCours; set => _prixCours = value; }
        public Action2 Action { get => _action; set => _action = value; }

        #endregion

        #region Methodes

        // Méthodes supplémentaires ici si nécessaire

        #endregion
    }
}