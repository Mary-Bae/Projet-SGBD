using Microsoft.IdentityModel.Tokens;

namespace CustomErrors
{
    public enum ErreurCodeEnum
    {
        UK_CHAINE_NOM,
        UK_CINEMA_NOM,
        UK_SALLE_NUMBER,
        FK_SALLE_CINEMA,
        ErreurSQL,
        QuantiteMinimaleDePlaces,
        ChampVide,
        NumeroInvalide,
        ErreurGenerale
    }
    public class CustomError : Exception
    {
        int _codeError;

        public CustomError(ErreurCodeEnum pCodeError) : base(SetBaseMessage(pCodeError))
        {
            _codeError = (int)pCodeError;
        }

        public CustomError(ErreurCodeEnum pCodeError, Exception inner) : base(SetBaseMessage(pCodeError), inner)
        {
            _codeError = (int)pCodeError;
        }
        public int CodeError
        { get { return _codeError; } }

        private static string SetBaseMessage(ErreurCodeEnum pCodeError)
        {
            string _messageToReturn;

            switch (pCodeError)
            {
                case ErreurCodeEnum.UK_CHAINE_NOM:
                    _messageToReturn = "Ajout impossible : La chaine de cinéma doit être unique ";
                    break;
                case ErreurCodeEnum.UK_CINEMA_NOM:
                    _messageToReturn = "Ajout impossible : Le cinéma doit être unique ";
                    break;
                case ErreurCodeEnum.UK_SALLE_NUMBER:
                    _messageToReturn = "Ajout impossible : Il ne peut pas y avoir deux fois le même numero de salle pour un cinéma ";
                    break;
                case ErreurCodeEnum.FK_SALLE_CINEMA:
                    _messageToReturn = "Une salle de cinema doit appartenir à un cinema ";
                    break;
                case ErreurCodeEnum.ErreurSQL:
                    _messageToReturn = "Erreur liée à la base de données SQL.";
                    break;
                case ErreurCodeEnum.ErreurGenerale:
                    _messageToReturn = "Une erreur générale s'est produite.";
                    break;
                case ErreurCodeEnum.QuantiteMinimaleDePlaces:
                    _messageToReturn = "Le nombre de places de cinéma n'est pas correct.";
                    break;
                case ErreurCodeEnum.NumeroInvalide:
                    _messageToReturn = "Veuillez rentrer un numero de salle valide.";
                    break;
                case ErreurCodeEnum.ChampVide:
                    _messageToReturn = "Les champs obligatoires ne peuvent pas être vide.";
                    break;
                default:
                    _messageToReturn = "Erreur non reconnue";
                    break;
            }
            return _messageToReturn;
        }
    }  
}
