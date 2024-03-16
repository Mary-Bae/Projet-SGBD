using Microsoft.IdentityModel.Tokens;

namespace CustomErrors
{
    public enum ErreurCodeEnum
    {
        UK_CHAINE_NOM,
        UK_CINEMA_NOM,
        ErreurSQL,
        ErreurGenerale
    }
    public class CustomError : Exception
    {
        int _codeError;

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
                case ErreurCodeEnum.ErreurSQL:
                    _messageToReturn = "Erreur liée à la base de données SQL.";
                    break;
                case ErreurCodeEnum.ErreurGenerale:
                    _messageToReturn = "Une erreur générale s'est produite.";
                    break;
                default:
                    _messageToReturn = "Erreur non reconnue";
                    break;
            }
            return _messageToReturn;
        }
    }  
}
