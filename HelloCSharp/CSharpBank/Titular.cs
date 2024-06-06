namespace HelloCSharp.CSharpBank
{
    public class Titular
    {
        public Titular(String nomeCompleto, String cpf)
        {    
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
        }

        private String nomeCompleto;
        private String cpf;

        public String getNome()
        {
            return nomeCompleto;
        }

        public String getCpf()
        {
            return cpf;
        }

        public void setNome(String nome)
        {
            this.nomeCompleto = nome;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }
    }
}