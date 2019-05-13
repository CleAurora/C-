namespace ex40pqnaorodaaqui.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidacaoEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }
            return false;
        }

        public static bool ValidacaoSenha(string s, string cs){
            if(s.Equals(cs)){
                return true;
            }
            return false;
        }
    }
}