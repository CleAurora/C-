namespace ex36PastelariaMVC.Utils
{
    public class ValidacoesUtil
    {   
        /// <summary>Valida o email do Usuário, Verifica se o mesmo possui @ e .  e se contem mais de 6 caracteres </summary>
        /// <param name = "email">Email do usuário</param>
        ///<returns>Retorna True caso o email seja válido. Caso contrário retorna false.false</returns>

        public static bool ValidadorDeEmail(string email){
             if(email.Contains("@") && email.Contains(".")){
                 return true;
             }
             return false;
        }
        
        public static bool ValidadorDeSenha(string senha, string confirmaSenha){
            if(senha.Equals(confirmaSenha) && senha.Length >5){
                return true;
            }
            return false;
        }

        
      
    }
}