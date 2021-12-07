using lolzin.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolzin.Model
{
  public class Campeoes
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public Conexao con;

        public Campeoes()
        {
            con = new Conexao();
        }

        public void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `campeoes`(`codigo`, `nome`) VALUES (null,'{nome}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar um estabelecimento " + e.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return con.ExecutarConsulta($"SELECT * FROM `campeoes`");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de listar os estabelecimentos " + e.Message);
            }
        }

        public void Editar()
        {
            try
            {
                con.ExecutarComando($"UPDATE `campeoes` SET `nome` = '{nome}' WHERE codigo = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de ediar o estabelecimento " + e.Message);
            }
        }

        public void Deletar(string codigo)
        {
            try
            {
                con.ExecutarComando($"DELETE FROM `campeoes` WHERE `codigo` = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de deletar um estabelecimento " + e.Message);
            }
        }
    }
}
