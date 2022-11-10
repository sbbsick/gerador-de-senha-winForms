using System.Text;

namespace Content.Services
{
    public class TicketString
    {
        readonly string even = ("==================================================");

        public StringBuilder ResetHeaderString()
        {
            StringBuilder resetString = new();

            resetString.AppendLine("Prezado(a) cliente,\r\n\r\nRealizado o reset de senha conforme solicitação, segue informações de acesso:\r\n");

            return resetString;
        }

        public StringBuilder CreateHeaderString()
        {
            StringBuilder newUserString = new();

            newUserString.AppendLine("Prezado(a) cliente,\r\n\r\nRealizado a criação do usuário conforme solicitação, segue informações de acesso:\r\n");

            return newUserString;
        }

        public StringBuilder MiddleString(string fullUrl, string senha)
        {
            StringBuilder resetString = new();

            resetString.AppendLine($"==================================================\r\nUser: \r\nPass: {fullUrl} - Password: {senha}");

            return resetString;
        }

        public StringBuilder FooterString()
        {
            StringBuilder bottomString = new StringBuilder();

            bottomString.AppendLine($"{even}\r\n\r\nSalve a(s) senha(s) em um local seguro pois o link tem data de expiração.\r\n\r\nPor gentileza validar o acesso.\r\n\r\nPor favor, preencha a pesquisa de satisfação para que possamos melhorar cada vez mais o nosso atendimento.\r\n\r\n\r\nAtenciosamente,\r\n\r\nSeu Nome");

            return bottomString;
        }

        public StringBuilder ResetHeaderStringSpanish()
        {
            StringBuilder resetStringSpanish = new();

            resetStringSpanish.AppendLine("Estimado cliente,\r\n\r\nUna vez restablecida la contraseña solicitada, la información de acceso es la siguiente:\r\n");

            return resetStringSpanish;
        }

        public StringBuilder CreateHeaderStringSpanish()
        {
            StringBuilder createNewUserSpanish = new();

            createNewUserSpanish.AppendLine("Estimado cliente,\r\n\r\nUsuario creado según lo solicitado, la información de acceso es la siguiente:\r\n");

            return createNewUserSpanish;
        }

        public StringBuilder FooterStringSpanish()
        {
            StringBuilder footerStringSpanish = new();

            footerStringSpanish.AppendLine($"{even}\r\n\r\nGuarde la contraseña en un lugar seguro ya que el enlace tiene fecha de caducidad.\r\n\r\nPor favor valide el acceso.\r\n\r\nComplete la encuesta de satisfacción para que podamos mejorar continuamente nuestro servicio.\r\n\r\n\r\nTuyo sinceramente,\r\n\r\nSu nombre");

            return footerStringSpanish;
        }
    }

}
